using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Signature_Maker
{
    public partial class MainFrm : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr handle, IntPtr baseAddress, [Out] byte[] buffer, int size, out IntPtr numberOfBytesRead);

        Color RedColor = Color.FromArgb(255, 0, 0);
        Color OrangeColor = Color.FromArgb(255, 125, 0);
        Color BlueColor = Color.FromArgb(0, 0, 255);
        Color GreenColor = Color.FromArgb(0, 225, 50);

        bool FirstScan = true;
        string CurrentAddress;
        string CurrentBaseAOB;
        string CurrentCompareAOB;
        string CurrentDifferenceAOB;
        string CurrentHex;

        enum OutputModes : UInt32
        {
            MODE_HEX = 1,
            MODE_HEX_ESCAPED = 2,
            MODE_BYTE_ARRAY = 3,
            MODE_MASK = 4
        };

        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        public byte[] ReadMemory(IntPtr handle, IntPtr address, int size)
        {
            IntPtr intPtr;
            byte[] array = new byte[size];

            if (!ReadProcessMemory(handle, address, array, array.Length, out intPtr))
            {
                return null;
            }

            return array;
        }

        public void LoadProcesses()
        {
            ProcessBox.Items.Clear();

            Process[] processList = Process.GetProcesses();

            foreach (Process process in processList)
            {
                ProcessBox.Items.Add(process.ProcessName + " [" + process.Id.ToString() + "]");
            }
        }

        Process FindProcess(int pid)
        {
            Process[] processList = Process.GetProcesses();

            foreach (Process process in processList)
            {
                if (process.Id == pid)
                {
                    return process;
                }
            }

            return null;
        }

        string CompareBytes(string inputAOB, string compareAOB)
        {
            string result = "";

            char[] baseSplit = inputAOB.ToCharArray();
            char[] compareSplit = compareAOB.ToCharArray();

            for (int i = 0; i < inputAOB.Length; i++)
            {
                if (i < compareAOB.Length)
                {
                    string baseHex = baseSplit[i].ToString();
                    string compareHex = compareSplit[i].ToString();

                    if (baseHex == compareHex)
                    {
                        result += compareHex;
                    }
                    else
                    {
                        result += "?";
                    }
                }
            }

            if (inputAOB.Length < compareAOB.Length)
            {
                for (int i = inputAOB.Length; i < compareAOB.Length; i++)
                {
                    string difference = compareSplit[i].ToString();
                    result += difference;
                }
            }
            else if (inputAOB.Length > compareAOB.Length)
            {
                for (int i = compareAOB.Length; i < inputAOB.Length; i++)
                {
                    string difference = inputAOB[i].ToString();
                    result += difference;
                }
            }

            if ((result.Length & 1) == 1)
            {
                result = result.Remove(result.Length - 1);
            }

            if (compareAOB != result)
            {
                StatusLbl.Text = "Difference detected, it is recommended you repeat multiple times!";
                StatusLbl.ForeColor = RedColor;
            }
            else
            {
                if (FirstScan)
                {
                    StatusLbl.Text = "First scan detected, it is recommended you repeat multiple times!";
                    StatusLbl.ForeColor = OrangeColor;
                    FirstScan = false;
                }
                else
                {
                    StatusLbl.Text = "No difference detected, array of bytes match!";
                    StatusLbl.ForeColor = GreenColor;
                }

                return compareAOB;
            }

            return result;
        }

        string FixSpacing(bool addSpacing, string inputAOB)
        {
            inputAOB = inputAOB.Replace(" ", "");

            if (addSpacing)
            {
                string rebuiltAOB = "";
                char[] aobArray = inputAOB.ToCharArray();

                int index = 0;

                for (int i = 0; i < aobArray.Length; i++)
                {
                    rebuiltAOB += aobArray[i].ToString();

                    if (i == aobArray.Length - 1)
                    {
                        if ((i + 2) <= aobArray.Length)
                        {
                            rebuiltAOB = rebuiltAOB.Insert(i + 2, " ");
                        }
                    }
                    else
                    {
                        if (index == 1)
                        {
                            rebuiltAOB += " ";
                            index = 0;
                        }
                        else
                        {
                            index++;
                        }
                    }
                }

                return rebuiltAOB;
            }

            return inputAOB;
        }

        string CreateHex(string inputAOB)
        {
            string result = "";
            inputAOB = FixSpacing(true, inputAOB);

            string[] inplutSplit = inputAOB.Split(' ');

            for (int i = 0; i < inplutSplit.Length; i++)
            {
                if (inplutSplit[i].Length < 1
                    || inplutSplit[i].Contains("?"))
                {
                    inplutSplit[i] = "00";
                }

                result += inplutSplit[i];
            }

            return result;
        }

        string CreateByteArray(string inputAOB)
        {
            string byteArray = "0x";
            inputAOB = inputAOB.Replace("?", "0");

            int index = 0;

            for (int i = 0; i < inputAOB.Length; i++)
            {
                if (i != inputAOB.Length)
                {
                    if (index == 0)
                    {
                        index = 1;
                        byteArray += inputAOB[i].ToString();
                    }
                    else if (index == 1)
                    {
                        index = 0;
                        byteArray += inputAOB[i].ToString();

                        if (i != (inputAOB.Length - 1) && (i + 2) <= inputAOB.Length)
                        {
                            byteArray += ", 0x";
                        }
                    }
                }
            }

            return byteArray;
        }

        string CreateMask(string inputAOB)
        {
            string result = "";

            char[] splitBytes = inputAOB.ToCharArray();

            for (int i = 0; i < splitBytes.Length; i += 2)
            {
                if (splitBytes[i].ToString() != "?"
                    && (i + 1) < splitBytes.Length
                    && splitBytes[(i + 1)].ToString() != "?")
                {
                    result += "x";
                }
                else if ((i + 1) < splitBytes.Length)
                {
                    result += "?";
                }
            }

            return result;
        }

        private void ProcessBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Regex pidEx = new Regex("\\[(.*?)\\]");
            string pidMatch = pidEx.Match(ProcessBox.Text).Groups[1].ToString();
            PIDBox.Value = UInt32.Parse(pidMatch);
        }


        private void PIDBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Process foundProcess = FindProcess((int)PIDBox.Value);

                if (foundProcess != null)
                {
                    ProcessBox.Text = foundProcess.ProcessName + " [" + foundProcess.Id.ToString() + "]";
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void AddressPasteBtn_Click(object sender, EventArgs e)
        {
            AddressBox.Text = Clipboard.GetText();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AddressBox.Text))
            {
                Process process = FindProcess((int)PIDBox.Value);

                CurrentAddress = AddressBox.Text.Replace("0x", "");

                if (process != null)
                {
                    Int64 addressDecimal = Int64.Parse(CurrentAddress, NumberStyles.HexNumber);
                    IntPtr addressPointer = (IntPtr)addressDecimal;

                    byte[] foundBytes = ReadMemory(process.Handle, addressPointer, (int)LengthBox.Value);

                    CurrentBaseAOB = BitConverter.ToString(foundBytes).Replace("-", "");

                    if (!string.IsNullOrEmpty(BaseBox.Text))
                    {
                        if (!string.IsNullOrEmpty(CompareBox.Text)
                            && !BaseBox.Items.Contains(CompareBox.Text))
                        {
                            BaseBox.Items.Add(CompareBox.Text);
                        }

                        CompareBox.Text = BaseBox.Text;
                        CurrentCompareAOB = CompareBox.Text;
                    }
                    else
                    {
                        CompareBox.Text = FixSpacing(true, CurrentBaseAOB);
                    }

                    BaseBox.Text = FixSpacing(true, CurrentBaseAOB);
                }
                else
                {
                    StatusLbl.Text = "Failed to find selected process, PID invalid!";
                }
            }
        }

        private void BaseCopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BaseBox.Text))
            {
                Clipboard.SetText(BaseBox.Text);
            }
        }

        private void BasePasteBtn_Click(object sender, EventArgs e)
        {
            BaseBox.Text = Clipboard.GetText();
        }

        private void CompareCopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CompareBox.Text))
            {
                Clipboard.SetText(CompareBox.Text);
            }
        }

        private void ComparePasteBtn_Click(object sender, EventArgs e)
        {
            CompareBox.Text = Clipboard.GetText();
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BaseBox.Text) && !string.IsNullOrEmpty(CompareBox.Text))
            {
                CurrentBaseAOB = FixSpacing(false, BaseBox.Text);
                CurrentCompareAOB = FixSpacing(false, CompareBox.Text);
                CurrentDifferenceAOB = CompareBytes(CurrentBaseAOB, CurrentCompareAOB);
                DifferenceBox.Text = FixSpacing(true, CurrentDifferenceAOB);
                CurrentHex = CreateHex(CurrentDifferenceAOB);

                HexBox.Text = FixSpacing(true, CurrentHex);

                HexEscapedBox.Text = "\\x" + HexBox.Text;
                HexEscapedBox.Text = HexEscapedBox.Text.Replace(" ", "\\x");

                ByteArrayBox.Text = CreateByteArray(CurrentHex);

                MaskBox.Text = CreateMask(CurrentDifferenceAOB);
            }
            else
            {
                StatusLbl.Text = "Input fields are empty!";
                StatusLbl.ForeColor = RedColor;
            }
        }

        private void SwapBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BaseBox.Text))
            {
                if (!BaseBox.Items.Contains(BaseBox.Text))
                {
                    BaseBox.Items.Add(BaseBox.Text);
                }
            }

            BaseBox.Text = CompareBox.Text;
            CompareBox.Clear();
        }

        private void DifferenceCopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DifferenceBox.Text))
            {
                Clipboard.SetText(DifferenceBox.Text);
            }
        }

        private void HexCopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(HexBox.Text))
            {
                Clipboard.SetText(HexBox.Text);
            }
        }

        private void HexEcapedCopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(HexEscapedBox.Text))
            {
                Clipboard.SetText(HexEscapedBox.Text);
            }
        }

        private void ByteArrayCopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ByteArrayBox.Text))
            {
                Clipboard.SetText(ByteArrayBox.Text);
            }
        }

        private void MaskCopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaskBox.Text))
            {
                Clipboard.SetText(MaskBox.Text);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BaseBox.Text))
            {
                if (!BaseBox.Items.Contains(BaseBox.Text))
                {
                    BaseBox.Items.Add(BaseBox.Text);
                }
            }

            if (!string.IsNullOrEmpty(CompareBox.Text))
            {
                if (!BaseBox.Items.Contains(BaseBox.Text))
                {
                    BaseBox.Items.Add(CompareBox.Text);
                }
            }

            BaseBox.SelectedText = "";
            CompareBox.Clear();
            DifferenceBox.Clear();
            HexBox.Clear();
            HexEscapedBox.Clear();
            ByteArrayBox.Clear();
            MaskBox.Clear();

            StatusLbl.Text = "Awaiting input...";
            StatusLbl.ForeColor = BlueColor;
            FirstScan = true;
        }
    }
}
