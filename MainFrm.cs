using System;
using System.Drawing;
using System.Windows.Forms;

namespace Signature_Maker {
    public partial class mainFrm : Form {
        Color redClr = Color.FromArgb(255, 0, 0);
        Color greenClr = Color.FromArgb(0, 225, 50);
        Color blueClr = Color.FromArgb(0, 0, 255);

        enum modes {
            half = 0,
            full = 1,
            code = 2,
            array = 3
        };

        public mainFrm() {
            InitializeComponent();
        }
        private void mainFrm_Load(object sender, EventArgs e) {

        }

        string compareBytes(string baseBytes, string compare) {
            string result = "";
            char[] baseSplit = baseBytes.ToCharArray();
            char[] compareSplit = compare.ToCharArray();
            for (int i = 0; i < baseBytes.Length; i++) {
                if (i < compare.Length) {
                    string baseHex = baseSplit[i].ToString();
                    string compareHex = compareSplit[i].ToString();

                    if (baseHex == compareHex) {
                        result += compareHex;
                    } else {
                        result += "?";
                    }
                }
            }

            if (baseBytes.Length < compare.Length) {
                for (int i = baseBytes.Length; i < compare.Length; i++) {
                    string DifferenceHex = compareSplit[i].ToString();
                    result += DifferenceHex;
                }
            } else if (baseBytes.Length > compare.Length) {
                for (int i = compare.Length; i < baseBytes.Length; i++) {
                    string DifferenceHex = baseBytes[i].ToString();
                    result += DifferenceHex;
                }
            }

            if (baseBytes != result) {
                statusLbl.Text = "Difference detected! It is recommended you repeat multiple times until there is no diffrence!";
                statusLbl.ForeColor = redClr;
            } else {
                statusLbl.Text = "No difference detected! Array of bytes match!";
                statusLbl.ForeColor = greenClr;
                return baseBytes;
            }

            return result;
        }

        string generateMask(string aob, modes mode) {
            string result = "";
            int addAmount = 0;

            if (mode == modes.full) { // If its a full mask, check every char one by one.
                addAmount = 1;
            } else if (mode == modes.half) { // If it's a half mask, skip every third char.
                addAmount = 3;
            }

            char[] splitBytes = aob.ToCharArray();
            for (int i = 0; i < splitBytes.Length; i += addAmount) { // Loops through all the char's in the AOB, `i` value gets added based on the `addAmount` we assigned previously
                if (splitBytes[i].ToString() == " ")
                    continue;

                if (mode == modes.half) {
                    if (splitBytes[i].ToString() != "?" && splitBytes[(i + 1)].ToString() != "?") { // If the current char, and the next char, isn't a question mark add an x.
                        result += "x";
                    } else { // If it is a question mark, then add one.
                        result += "?";
                    }                
                } else if (mode == modes.full) { // If it's a question mark, add a question mark. If it's anything other add an x.
                    if (splitBytes[i].ToString() == "?") {
                        result += "?";
                    } else {
                        result += "x";
                    }
                }
            }

            return result;
        }

        string generateBytes(string AOB, modes Mode) {
            if (Mode == modes.code) {
                AOB = AOB.Insert(0, "\\x");
                AOB = AOB.Replace(" ", "\\x");
                AOB = AOB.Replace("?", "0");
                return AOB;
            } else if (Mode == modes.array) {
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

            return "(null)";
        }

        private void BaseCpyBtn_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(baseBx.Text))
                 Clipboard.SetText(baseBx.Text);
        }

        private void BasePstBtn_Click(object sender, EventArgs e) {
            baseBx.Text = Clipboard.GetText();
        }

        private void CompareCpyBtn_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(compareBx.Text))
                Clipboard.SetText(compareBx.Text);
        }

        private void ComparePstBtn_Click(object sender, EventArgs e) {
            compareBx.Text = Clipboard.GetText();
        }

        private void DifferenceCpyBtn_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(differenceBx.Text))
                Clipboard.SetText(differenceBx.Text);
        }

        private void HalfMaskCpyBtn_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(halfMaskBx.Text))
                Clipboard.SetText(halfMaskBx.Text);
        }

        private void FullMaskCpyBtn_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(fullMaskBx.Text))
                Clipboard.SetText(fullMaskBx.Text);
        }

        private void CodeCpyBtn_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(codeBx.Text))
                Clipboard.SetText(codeBx.Text);
        }

        private void ArrayCpyBtn_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(arrayBx.Text))
                Clipboard.SetText(arrayBx.Text);
        }

        private void CompareBtn_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(baseBx.Text) && !string.IsNullOrEmpty(compareBx.Text)) {
                differenceBx.Text = compareBytes(baseBx.Text, compareBx.Text);
                halfMaskBx.Text = generateMask(differenceBx.Text, modes.half);
                fullMaskBx.Text = generateMask(differenceBx.Text, modes.full);
                codeBx.Text = generateBytes(differenceBx.Text, modes.code);
                arrayBx.Text = generateBytes(differenceBx.Text, modes.array);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(baseBx.Text))
                baseBx.Items.Add(baseBx.Text);

            if (!string.IsNullOrEmpty(compareBx.Text))
                baseBx.Items.Add(compareBx.Text);

            baseBx.Text = "";
            compareBx.Clear();
            differenceBx.Clear();
            halfMaskBx.Clear();
            fullMaskBx.Clear();
            codeBx.Clear();
            arrayBx.Clear();

            statusLbl.Text = "Awaiting input...";
            statusLbl.ForeColor = blueClr;
        }

        private void SwapBtn_Click(object sender, EventArgs e) {
            if (baseBx.Text != "")
                baseBx.Items.Add(baseBx.Text);

            baseBx.Text = compareBx.Text;
            compareBx.Clear();
        }
    }
}
