//#define X64BIT
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SignatureMaker
{
    public partial class AboutFrm : Form
    {
        public AboutFrm()
        {
            InitializeComponent();
        }

        private void AboutFrm_Load(object sender, EventArgs e)
        {
#if X64BIT
            this.Text = "ItsBranK's Signature Maker (x64) - About";
            ArchetypeLbl.Text = "x64";
#else
            this.Text = "ItsBranK's Signature Maker (x32) - About";
            ArchetypeLbl.Text = "x32";
#endif
            VersionLbl.Text = "v2.5";
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
