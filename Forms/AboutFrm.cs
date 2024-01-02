using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SignatureMaker
{
    public partial class AboutFrm : Form
    {
        private static bool _x64Bit = true;
        private static string _version = "v2.6";

        public AboutFrm()
        {
            InitializeComponent();
        }

        private void AboutFrm_Load(object sender, EventArgs e)
        {
            if (_x64Bit)
            {
                this.Text = "ItsBranK's Signature Maker (x64) - About";
                ArchetypeLbl.Text = "x64";
            }
            else
            {
                this.Text = "ItsBranK's Signature Maker (x32) - About";
                ArchetypeLbl.Text = "x32";
            }

            VersionLbl.Text = _version;
        }

        private void GitHubLbl_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(GitHubLbl.Text) { UseShellExecute = true });
        }

        private void IconsLbl_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(IconsLbl.Text) { UseShellExecute = true });
        }
    }
}
