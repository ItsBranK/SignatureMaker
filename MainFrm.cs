using System;
using System.Drawing;
using System.Windows.Forms;

namespace SigKit
{
    public partial class MainFrm : Form
    {
        Color RedClr = Color.FromArgb(255, 0, 0);
        Color GreenClr = Color.FromArgb(0, 225, 50);
        Color BlueClr = Color.FromArgb(0, 0, 255);

        enum Modes
        {
            Half = 0,
            Full = 1,
            Code = 2,
            Array = 3
        };

        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        string CompareBytes(string Base, string Compare)
        {
            string Result = "";
            char[] BaseSplit = Base.ToCharArray();
            char[] CompareSplit = Compare.ToCharArray();
            for (int i = 0; i < Base.Length; i++) {
                if (i < Compare.Length) {
                    string BaseHex = BaseSplit[i].ToString();
                    string CompareHex = CompareSplit[i].ToString();

                    if (BaseHex == CompareHex) {
                        Result += CompareHex;
                    } else {
                        Result += "?";
                    }
                }
            }

            if (Base.Length < Compare.Length) {
                for (int i = Base.Length; i < Compare.Length; i++) {
                    string DifferenceHex = CompareSplit[i].ToString();
                    Result += DifferenceHex;
                }
            } else if (Base.Length > Compare.Length) {
                for (int i = Compare.Length; i < Base.Length; i++) {
                    string DifferenceHex = Base[i].ToString();
                    Result += DifferenceHex;
                }
            }

            if (Base != Result) {
                StatusLbl.Text = "Difference detected! It is recommended you repeat multiple times until there is no diffrence!";
                StatusLbl.ForeColor = RedClr;
            } else {
                StatusLbl.Text = "No difference detected! Array of bytes match!";
                StatusLbl.ForeColor = GreenClr;
                return Base;
            }

            return Result;
        }

        string GenerateMask(string AOB, Modes Mode)
        {
            string Result = "";
            int AddAmount = 0;

            if (Mode == Modes.Full)
            {
                AddAmount = 1;
            } else if (Mode == Modes.Half) {
                AddAmount = 3;
            }

            char[] SplitBytes = AOB.ToCharArray();
            for (int i = 0; i < SplitBytes.Length; i += AddAmount) {
                if (SplitBytes[i].ToString() == " ")
                    continue;

                if (Mode == Modes.Half)
                {
                    if (SplitBytes[i].ToString() != "?" && SplitBytes[(i + 1)].ToString() != "?")
                    {
                        Result += "x";
                    } else {
                        Result += "?";
                    }                
                } else if (Mode == Modes.Full) {
                    if (SplitBytes[i].ToString() == "?") {
                        Result += "?";
                    } else {
                        Result += "x";
                    }
                }
            }

            return Result;
        }

        string GenerateBytes(string AOB, Modes Mode)
        {
            if (Mode == Modes.Code) {
                AOB = AOB.Insert(0, "\\x");
                AOB = AOB.Replace(" ", "\\x");
                AOB = AOB.Replace("?", "0");
                return AOB;
            } else if (Mode == Modes.Array) {
                string Result = "0x";
                AOB = AOB.Replace("?", "0");

                int Index = 0;
                for (int i = 0; i < AOB.Length; i++) {
                    if (AOB[i].ToString() == " ")
                        continue;

                    if (Index == 0) {
                        Index = 1;
                        Result += AOB[i].ToString();
                    } else if (Index == 1) {
                        Index = 0;
                        Result += AOB[i].ToString();

                        if (i != (AOB.Length - 1))
                            Result += ", 0x";
                    }
                }

                return Result;
            }

            return "NULL";
        }

        private void BaseCpyBtn_Click(object sender, EventArgs e)
        {
            if (BaseBx.Text != "")
                 Clipboard.SetText(BaseBx.Text);
        }

        private void BasePstBtn_Click(object sender, EventArgs e)
        {
            BaseBx.Text = Clipboard.GetText();
        }

        private void CompareCpyBtn_Click(object sender, EventArgs e)
        {
            if (CompareBx.Text != "")
                Clipboard.SetText(CompareBx.Text);
        }

        private void ComparePstBtn_Click(object sender, EventArgs e)
        {
            CompareBx.Text = Clipboard.GetText();
        }

        private void DifferenceCpyBtn_Click(object sender, EventArgs e)
        {
            if (DifferenceBx.Text != "")
                Clipboard.SetText(DifferenceBx.Text);
        }

        private void HalfMaskCpyBtn_Click(object sender, EventArgs e)
        {
            if (HalfMaskBx.Text != "")
                Clipboard.SetText(HalfMaskBx.Text);
        }

        private void FullMaskCpyBtn_Click(object sender, EventArgs e)
        {
            if (FullMaskBx.Text != "")
                Clipboard.SetText(FullMaskBx.Text);
        }

        private void CodeCpyBtn_Click(object sender, EventArgs e)
        {
            if (CodeBx.Text != "")
                Clipboard.SetText(CodeBx.Text);
        }

        private void ArrayCpyBtn_Click(object sender, EventArgs e)
        {
            if (ArrayBx.Text != "")
                Clipboard.SetText(ArrayBx.Text);
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            if (BaseBx.Text.Length > 0 && CompareBx.Text.Length > 0)
            {
                DifferenceBx.Text = CompareBytes(BaseBx.Text, CompareBx.Text);
                HalfMaskBx.Text = GenerateMask(DifferenceBx.Text, Modes.Half);
                FullMaskBx.Text = GenerateMask(DifferenceBx.Text, Modes.Full);
                CodeBx.Text = GenerateBytes(DifferenceBx.Text, Modes.Code);
                ArrayBx.Text = GenerateBytes(DifferenceBx.Text, Modes.Array);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            if (BaseBx.Text != "")
                BaseBx.Items.Add(BaseBx.Text);

            if (CompareBx.Text != "")
                BaseBx.Items.Add(CompareBx.Text);

            BaseBx.Text = "";
            CompareBx.Clear();
            DifferenceBx.Clear();
            HalfMaskBx.Clear();
            FullMaskBx.Clear();
            CodeBx.Clear();
            ArrayBx.Clear();

            StatusLbl.Text = "Awaiting input...";
            StatusLbl.ForeColor = BlueClr;
        }

        private void SwapBtn_Click(object sender, EventArgs e)
        {
            if (BaseBx.Text != "")
                BaseBx.Items.Add(BaseBx.Text);

            BaseBx.Text = CompareBx.Text;
            CompareBx.Clear();
        }
    }
}
