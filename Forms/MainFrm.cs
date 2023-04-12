#define X64BIT
using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Globalization;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SignatureMaker
{
    enum OutputModes : byte
    {
        Hex,
        HexEscaped,
        ByteArray,
        Mask
    }

    enum StatusTypes : byte
    {
        Success,
        Info,
        Warning,
        Error
    }

    public partial class MainFrm : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr handle, IntPtr baseAddress, [Out] byte[] buffer, Int32 size, out IntPtr numberOfBytesRead);

        OutputModes _CurrentMode = OutputModes.HexEscaped; // Current output mode selected by the user.
        string _TestHexArray = ""; // Used for testing if the pattern you created works using "FindPattern".

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

        private byte[] ReadMemory(IntPtr handle, IntPtr address, Int32 size)
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
            if (!string.IsNullOrEmpty(pattern) && !string.IsNullOrEmpty(mask))
            {
                IntPtr baseAddress = process.MainModule.BaseAddress;
                byte[] moduleBytes = new byte[process.MainModule.ModuleMemorySize];
                byte[] patternBytes = ParsePattern(pattern);

                IntPtr bytesRead;
                ReadProcessMemory(process.Handle, baseAddress, moduleBytes, moduleBytes.Length, out bytesRead);

                Int32 currentPos = 0;
                Int32 maskLength = (mask.Length - 1);

                for (Int32 retAddress = 0; retAddress < moduleBytes.Length; retAddress++)
                {
                    if ((moduleBytes[retAddress] == patternBytes[currentPos]) || (mask[currentPos] == '?'))
                    {
                        if (currentPos == maskLength)
                        {
                            return IntPtr.Add(baseAddress, (retAddress - maskLength));
                        }

                        currentPos++;
                    }
                    else
                    {
                        retAddress -= currentPos;
                        currentPos = 0;
                    }
                }
            }

            return IntPtr.Zero;
        }

        private void LoadProcesses()
        {
            ProcessBx.Items.Clear();
            Process[] processList = Process.GetProcesses();
            List<string> processNames = new List<string>();

            foreach (Process process in processList)
            {
                if (process != null)
                {
                    processNames.Add(process.ProcessName + " [" + process.Id.ToString() + "]");
                }
            }

            processNames.Sort();

            foreach (string processName in processNames)
            {
                ProcessBx.Items.Add(processName);
            }
        }

        private Process FindProcess(Int32 pid)
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

        private void SetStatus(string text, StatusTypes type)
        {
            StatusLbl.Text = "Status: " + text;

            switch (type)
            {
                case StatusTypes.Success:
                    StatusLbl.ForeColor = Color.LimeGreen;
                    break;
                case StatusTypes.Info:
                    StatusLbl.ForeColor = Color.DodgerBlue;
                    break;
                case StatusTypes.Warning:
                    StatusLbl.ForeColor = Color.DarkOrange;
                    break;
                case StatusTypes.Error:
                    StatusLbl.ForeColor = Color.Crimson;
                    break;
            }
        }

        private void ProcessBx_SelectedValueChanged(object sender, EventArgs e)
        {
            Int32 pidStart = ProcessBx.Text.IndexOf('[') + 1;
            string pidStr = ProcessBx.Text.Substring(pidStart, (ProcessBx.Text.Length - pidStart) - 1);
            PIDBx.Value = Int32.Parse(pidStr);
        }

        private void PIDBx_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Process foundProcess = FindProcess((Int32)PIDBx.Value);

                if (foundProcess != null)
                {
                    ProcessBx.Text = (foundProcess.ProcessName + " [" + foundProcess.Id.ToString() + "]");
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
            AddressBx.Text = AddressBx.Text.Replace("0x", "");
            AddressBx.Text = AddressBx.Text.Replace("0X", "");
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AddressBx.Text))
            {
                Process process = FindProcess((Int32)PIDBx.Value);
                string addressFormatted = AddressBx.Text.Replace("0x", "").Replace("0X", "");

                if (process != null)
                {
#if X64BIT
                    Int64 addressDecimal = Int64.Parse(addressFormatted, NumberStyles.HexNumber);
#else
                    Int32 addressDecimal = Int32.Parse(addressFormatted, NumberStyles.HexNumber);
#endif
                    IntPtr addressPointer = (IntPtr)addressDecimal;

                    byte[] foundBytes = ReadMemory(process.Handle, addressPointer, (Int32)LengthBx.Value);

                    if (foundBytes != null)
                    {
                        string comparedBytes = BitConverter.ToString(foundBytes).Replace("-", "");

                        if (!string.IsNullOrEmpty(BaseBx.Text))
                        {
                            if (!string.IsNullOrEmpty(CompareBx.Text) && !BaseBx.Items.Contains(CompareBx.Text))
                            {
                                BaseBx.Items.Add(CompareBx.Text);
                            }

                            CompareBx.Text = BaseBx.Text;
                        }
                        else
                        {
                            CompareBx.Text = Format.FormatSpacing(comparedBytes);
                        }

                        BaseBx.Text = Format.FormatSpacing(comparedBytes);
                    }
                    else
                    {
                        SetStatus("Failed to find desired address! Cannot create signature!", StatusTypes.Error);
                    }
                }
                else
                {
                    SetStatus("Failed to find selected process, PID invalid!", StatusTypes.Error);
                }
            }
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BaseBx.Text) && !string.IsNullOrEmpty(CompareBx.Text))
            {
                if (!BaseBx.Items.Contains(BaseBx.Text))
                {
                    BaseBx.Items.Add(BaseBx.Text);
                }

                List<string> baseList = new List<string>();

                foreach (string str in BaseBx.Items)
                {
                    baseList.Add(str);
                }

                string oldBtes = BytesBx.Text;
                string oldMask = MaskBx.Text;
                string comparedBytes = Format.CompareByteList(baseList, CompareBx.Text);
                DifferenceBx.Text = Format.FormatSpacing(comparedBytes);
                MaskBx.Text = Format.CreateHalfMask(comparedBytes);

                switch (_CurrentMode)
                {
                    case OutputModes.Hex:
                        BytesBx.Text = Format.CreateHex(comparedBytes);
                        break;
                    case OutputModes.HexEscaped:
                        BytesBx.Text = Format.CreateHexEscaped(comparedBytes);
                        break;
                    case OutputModes.ByteArray:
                        BytesBx.Text = Format.CreateByteArray(comparedBytes);
                        break;
                }

                if ((oldBtes != BytesBx.Text) || (oldMask != MaskBx.Text))
                {
                    SetStatus("Difference detected, you should repeat multiple times!", StatusTypes.Warning);
                }
                else
                {
                    SetStatus("No difference detected, given array of bytes match!", StatusTypes.Success);
                }

                _TestHexArray = Format.CreateHex(comparedBytes);
            }
            else
            {
                SetStatus("Input fields are empty!", StatusTypes.Error);
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
            BaseBx.Items.Clear();
            CompareBx.Clear();
            DifferenceBx.Clear();
            BytesBx.Clear();
            MaskBx.Clear();
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BytesBx.Text) && !string.IsNullOrEmpty(MaskBx.Text) && !string.IsNullOrEmpty(_TestHexArray))
            {
                Process process = FindProcess((Int32)PIDBx.Value);

                if (process != null)
                {
                    IntPtr foundPointer = FindPattern(process, Format.FormatSpacing(_TestHexArray), MaskBx.Text);

                    if (foundPointer != IntPtr.Zero)
                    {
                        SetStatus("Found pointer at 0x" + foundPointer.ToString("X"), StatusTypes.Success);
                    }
                    else
                    {
                        SetStatus("Failed to find valid pointer with the given signature!", StatusTypes.Warning);
                    }
                }
                else
                {
                    SetStatus("Process no longer active, cannot test signature!", StatusTypes.Warning);
                }
            }
            else
            {
                SetStatus("No signature created, cannot test signature!", StatusTypes.Error);
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
            _CurrentMode = OutputModes.Hex;
            HexMenuItem.Text = "> Hex";
            EscapedMenuItem.Text = "Hex Escaped";
            ByteArrayMenuItem.Text = "Byte Array";
        }

        private void EscapedMenuItem_Click(object sender, EventArgs e)
        {
            _CurrentMode = OutputModes.HexEscaped;
            HexMenuItem.Text = "Hex";
            EscapedMenuItem.Text = "> Hex Escaped";
            ByteArrayMenuItem.Text = "Byte Array";
        }

        private void ByteArrayMenuItem_Click(object sender, EventArgs e)
        {
            _CurrentMode = OutputModes.ByteArray;
            HexMenuItem.Text = "Hex";
            EscapedMenuItem.Text = "Hex Escaped";
            ByteArrayMenuItem.Text = "> Byte Array";
        }

        private void BaseBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
