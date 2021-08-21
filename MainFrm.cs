//#define X64BIT
using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Globalization;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace SignatureMaker
{
    enum OutputModes : byte
    {
        MODE_HEX = 1,
        MODE_HEX_ESCAPED = 2,
        MODE_BYTE_ARRAY = 3,
        MODE_MASK = 4
    }

    enum StatusTypes : byte
    {
        TYPE_OK = 0,
        TYPE_INFO = 1,
        TYPE_WARNING = 2,
        TYPE_ERROR = 3
    }

    public partial class MainFrm : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr handle, IntPtr baseAddress, [Out] byte[] buffer, int size, out IntPtr numberOfBytesRead);

        bool FirstScan = true;
        OutputModes OutputMode = OutputModes.MODE_HEX_ESCAPED;
        string CurrentAddress = "";
        string CurrentBaseAOB = "";
        string CurrentCompareAOB = "";
        string CurrentDifferenceAOB = "";
        string CurrentHex = "";

        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            LoadProcesses();
#if X64BIT
            this.Text = "ItsBranK's Signature Maker (x64)";
#else
            this.Text = "ItsBranK's Signature Maker (x32)";
#endif
        }

        private T ConvertByteArray<T>(ref byte[] bytes)
        {
            GCHandle handle = default(GCHandle);
            T result;

            try
            {
                handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                result = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());
            }
            finally
            {
                if (handle.IsAllocated)
                {
                    handle.Free();
                }
            }

            return result;
        }

        private byte[] ParsePattern(string pattern)
        {
            string[] patternArray = pattern.Split(' ');
            List<byte> phrasedBytes = new List<byte>();

            foreach (string text in patternArray)
            {
                phrasedBytes.Add(Convert.ToByte(text, 16));
            }

            return phrasedBytes.ToArray();
        }

        private byte[] ReadMemory(IntPtr handle, IntPtr address, int size)
        {
            IntPtr intPtr;
            byte[] array = new byte[size];

            if (!ReadProcessMemory(handle, address, array, array.Length, out intPtr))
            {
                return null;
            }

            return array;
        }

        private IntPtr FindPattern(Process process, string pattern, string mask)
        {
            IntPtr baseAddress = process.MainModule.BaseAddress;
            byte[] moduleBytes = new byte[process.MainModule.ModuleMemorySize];
            byte[] patternBytes = ParsePattern(pattern);

            IntPtr bytesRead;
            ReadProcessMemory(process.Handle, baseAddress, moduleBytes, moduleBytes.Length, out bytesRead);

            int pos = 0;
            int maskLength = mask.Length - 1;

            for (int modulePos = 0; modulePos < moduleBytes.Length; modulePos++)
            {
                if (moduleBytes[modulePos] == patternBytes[pos] || mask[pos] == '?')
                {
                    if (pos == maskLength)
                    {
                        return IntPtr.Add(baseAddress, modulePos - maskLength);
                    }

                    pos++;
                }
                else
                {
                    modulePos -= pos;
                    pos = 0;
                }
            }

            return IntPtr.Zero;
        }

        private void LoadProcesses()
        {
            ProcessBx.Items.Clear();

            Process[] processList = Process.GetProcesses();

            foreach (Process process in processList)
            {
                ProcessBx.Items.Add(process.ProcessName + " [" + process.Id.ToString() + "]");
            }
        }

        private Process FindProcess(int pid)
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

        private string FixSpacing(string inputAOB, bool bAddSpacing)
        {
            inputAOB = inputAOB.Replace(" ", "");

            if (bAddSpacing)
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

        private string CreateHex(string inputAOB)
        {
            string result = "";
            inputAOB = FixSpacing(inputAOB, true);

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

        private string CreateByteArray(string inputAOB)
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

        private string CreateMask(string inputAOB)
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

        private string CompareBytes(string inputAOB, string compareAOB, out bool bBytesEqual)
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

            if (result != compareAOB)
            {
                bBytesEqual = false;
            }
            else
            {
                bBytesEqual = true;
                return compareAOB;
            }

            return result;
        }

        private void SetStatus(string text, StatusTypes type)
        {
            StatusLbl.Text = "Status: " + text;

            switch (type)
            {
                case StatusTypes.TYPE_OK:
                    StatusLbl.ForeColor = Color.LimeGreen;
                    break;
                case StatusTypes.TYPE_INFO:
                    StatusLbl.ForeColor = Color.DodgerBlue;
                    break;
                case StatusTypes.TYPE_WARNING:
                    StatusLbl.ForeColor = Color.DarkOrange;
                    break;
                case StatusTypes.TYPE_ERROR:
                    StatusLbl.ForeColor = Color.Crimson;
                    break;
            }
        }

        private void ProcessBx_SelectedValueChanged(object sender, EventArgs e)
        {
            int pidStart = ProcessBx.Text.IndexOf('[') + 1;
            string pidStr = ProcessBx.Text.Substring(pidStart, (ProcessBx.Text.Length - pidStart) - 1);
            PIDBx.Value = int.Parse(pidStr);
        }

        private void PIDBx_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Process foundProcess = FindProcess((int)PIDBx.Value);

                if (foundProcess != null)
                {
                    ProcessBx.Text = foundProcess.ProcessName + " [" + foundProcess.Id.ToString() + "]";
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadProcesses();
            PIDBx.Value = 0;
        }

        private void PasteBtn_Click(object sender, EventArgs e)
        {
            AddressBx.Text = Clipboard.GetText();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AddressBx.Text))
            {
                Process process = FindProcess((int)PIDBx.Value);

                CurrentAddress = AddressBx.Text.Replace("0x", "");

                if (process != null)
                {
#if X64BIT
                    Int64 addressDecimal = Int64.Parse(CurrentAddress, NumberStyles.HexNumber);
#else
                    Int32 addressDecimal = Int32.Parse(CurrentAddress, NumberStyles.HexNumber);
#endif
                    IntPtr addressPointer = (IntPtr)addressDecimal;

                    byte[] foundBytes = ReadMemory(process.Handle, addressPointer, (int)LengthBx.Value);

                    if (foundBytes != null)
                    {
                        CurrentBaseAOB = BitConverter.ToString(foundBytes).Replace("-", "");

                        if (!string.IsNullOrEmpty(BaseBx.Text))
                        {
                            if (!string.IsNullOrEmpty(CompareBx.Text)
                                && !BaseBx.Items.Contains(CompareBx.Text))
                            {
                                BaseBx.Items.Add(CompareBx.Text);
                            }

                            CompareBx.Text = BaseBx.Text;
                            CurrentCompareAOB = CompareBx.Text;
                        }
                        else
                        {
                            CompareBx.Text = FixSpacing(CurrentBaseAOB, true);
                        }

                        BaseBx.Text = FixSpacing(CurrentBaseAOB, true);
                    }
                    else
                    {
                        SetStatus("Failed to find desired address! Cannot create signature!", StatusTypes.TYPE_ERROR);
                    }
                }
                else
                {
                    SetStatus("Failed to find selected process, PID invalid!", StatusTypes.TYPE_ERROR);
                }
            }
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BaseBx.Text) && !string.IsNullOrEmpty(CompareBx.Text))
            {
                bool areEqual = false;
                CurrentBaseAOB = FixSpacing(BaseBx.Text, false);
                CurrentCompareAOB = FixSpacing(CompareBx.Text, false);
                CurrentDifferenceAOB = CompareBytes(CurrentBaseAOB, CurrentCompareAOB, out areEqual);

                if (!areEqual)
                {
                    SetStatus("Difference detected, repeat multiple times!", StatusTypes.TYPE_WARNING);
                }
                else
                {
                    if (FirstScan)
                    {
                        FirstScan = false;
                        SetStatus("First scan detected, repeat multiple times!", StatusTypes.TYPE_INFO);
                    }
                    else
                    {
                        SetStatus("No difference detected, array of bytes match!", StatusTypes.TYPE_OK);
                    }
                }

                DifferenceBx.Text = FixSpacing(CurrentDifferenceAOB, true);
                CurrentHex = CreateHex(CurrentDifferenceAOB);
                MaskBx.Text = CreateMask(CurrentDifferenceAOB);

                switch (OutputMode)
                {
                    case OutputModes.MODE_HEX:
                        BytesBx.Text = FixSpacing(CurrentHex, true);
                        break;
                    case OutputModes.MODE_HEX_ESCAPED:
                        BytesBx.Text = "\\x" + FixSpacing(CurrentHex, true);
                        BytesBx.Text = BytesBx.Text.Replace(" ", "\\x");
                        break;
                    case OutputModes.MODE_BYTE_ARRAY:
                        BytesBx.Text = CreateByteArray(CurrentHex);
                        break;
                }
            }
            else
            {
                SetStatus("Input fields are empty!", StatusTypes.TYPE_ERROR);
            }
        }

        private void SwapBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BaseBx.Text))
            {
                if (!BaseBx.Items.Contains(BaseBx.Text))
                {
                    BaseBx.Items.Add(BaseBx.Text);
                }
            }

            BaseBx.Text = CompareBx.Text;
            CompareBx.Clear();
        }

        private void ByteCopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BytesBx.Text))
            {
                Clipboard.SetText(BytesBx.Text);
            }
        }

        private void MaskCopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaskBx.Text))
            {
                Clipboard.SetText(MaskBx.Text);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            AddressBx.Clear();
            LengthBx.Value = 8;
            BaseBx.Text = "";
            CompareBx.Clear();
            DifferenceBx.Clear();
            BytesBx.Clear();
            MaskBx.Clear();
            FirstScan = true;
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BytesBx.Text)
                && !string.IsNullOrEmpty(MaskBx.Text))
            {
                Process process = FindProcess((int)PIDBx.Value);

                if (process != null)
                {
                    IntPtr foundPointer = FindPattern(process, FixSpacing(CurrentHex, true), CreateMask(CurrentDifferenceAOB));

                    if (foundPointer != IntPtr.Zero)
                    {
                        SetStatus("Found pointer at 0x" + foundPointer.ToString("X"), StatusTypes.TYPE_OK);
                    }
                    else
                    {
                        SetStatus("Failed to find valid pointer with the given signature!", StatusTypes.TYPE_WARNING);
                    }
                }
                else
                {
                    SetStatus("Process no longer active, cannot test signature!", StatusTypes.TYPE_WARNING);
                }
            }
            else
            {
                SetStatus("No signature created, cannot test signature!", StatusTypes.TYPE_ERROR);
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutFrm aboutFrm = new AboutFrm();
            aboutFrm.Show();
        }

        private void HexMenuItem_Click(object sender, EventArgs e)
        {
            OutputMode = OutputModes.MODE_HEX;
            HexMenuItem.Text = "√ Hex";
            EscapedMenuItem.Text = "Hex Escaped";
            ByteArrayMenuItem.Text = "Byte Array";
        }

        private void EscapedMenuItem_Click(object sender, EventArgs e)
        {
            OutputMode = OutputModes.MODE_HEX_ESCAPED;
            HexMenuItem.Text = "Hex";
            EscapedMenuItem.Text = "√ Hex Escaped";
            ByteArrayMenuItem.Text = "Byte Array";
        }

        private void ByteArrayMenuItem_Click(object sender, EventArgs e)
        {
            OutputMode = OutputModes.MODE_BYTE_ARRAY;
            HexMenuItem.Text = "Hex";
            EscapedMenuItem.Text = "Hex Escaped";
            ByteArrayMenuItem.Text = "√ Byte Array";
        }
    }
}
