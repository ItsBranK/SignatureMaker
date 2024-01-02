
namespace SignatureMaker
{
    partial class AboutFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutFrm));
            GitHubLbl = new System.Windows.Forms.Label();
            IconsLbl = new System.Windows.Forms.Label();
            VersionLbl = new System.Windows.Forms.Label();
            ArchetypeLbl = new System.Windows.Forms.Label();
            GitHubTitle = new System.Windows.Forms.Label();
            IconsTitle = new System.Windows.Forms.Label();
            VersionTitle = new System.Windows.Forms.Label();
            ArchetypeTitle = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // GitHubLbl
            // 
            GitHubLbl.BackColor = System.Drawing.Color.Transparent;
            GitHubLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            GitHubLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline);
            GitHubLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            GitHubLbl.Location = new System.Drawing.Point(103, 69);
            GitHubLbl.Name = "GitHubLbl";
            GitHubLbl.Size = new System.Drawing.Size(255, 30);
            GitHubLbl.TabIndex = 10;
            GitHubLbl.Text = "www.github.com/ItsBranK/SignatureMaker";
            GitHubLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            GitHubLbl.Click += GitHubLbl_Click;
            // 
            // IconsLbl
            // 
            IconsLbl.BackColor = System.Drawing.Color.Transparent;
            IconsLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            IconsLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline);
            IconsLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            IconsLbl.Location = new System.Drawing.Point(103, 99);
            IconsLbl.Name = "IconsLbl";
            IconsLbl.Size = new System.Drawing.Size(255, 30);
            IconsLbl.TabIndex = 9;
            IconsLbl.Text = "www.remixicon.com";
            IconsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            IconsLbl.Click += IconsLbl_Click;
            // 
            // VersionLbl
            // 
            VersionLbl.BackColor = System.Drawing.Color.Transparent;
            VersionLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            VersionLbl.Location = new System.Drawing.Point(103, 39);
            VersionLbl.Name = "VersionLbl";
            VersionLbl.Size = new System.Drawing.Size(255, 30);
            VersionLbl.TabIndex = 7;
            VersionLbl.Text = "v0.0";
            VersionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ArchetypeLbl
            // 
            ArchetypeLbl.BackColor = System.Drawing.Color.Transparent;
            ArchetypeLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            ArchetypeLbl.Location = new System.Drawing.Point(103, 9);
            ArchetypeLbl.Name = "ArchetypeLbl";
            ArchetypeLbl.Size = new System.Drawing.Size(255, 30);
            ArchetypeLbl.TabIndex = 6;
            ArchetypeLbl.Text = "x0";
            ArchetypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GitHubTitle
            // 
            GitHubTitle.BackColor = System.Drawing.Color.Transparent;
            GitHubTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            GitHubTitle.Location = new System.Drawing.Point(12, 69);
            GitHubTitle.Name = "GitHubTitle";
            GitHubTitle.Size = new System.Drawing.Size(85, 30);
            GitHubTitle.TabIndex = 5;
            GitHubTitle.Text = "GitHub:";
            GitHubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IconsTitle
            // 
            IconsTitle.BackColor = System.Drawing.Color.Transparent;
            IconsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            IconsTitle.Location = new System.Drawing.Point(12, 99);
            IconsTitle.Name = "IconsTitle";
            IconsTitle.Size = new System.Drawing.Size(85, 30);
            IconsTitle.TabIndex = 4;
            IconsTitle.Text = "Icons:";
            IconsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VersionTitle
            // 
            VersionTitle.BackColor = System.Drawing.Color.Transparent;
            VersionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            VersionTitle.Location = new System.Drawing.Point(12, 39);
            VersionTitle.Name = "VersionTitle";
            VersionTitle.Size = new System.Drawing.Size(85, 30);
            VersionTitle.TabIndex = 2;
            VersionTitle.Text = "Version:";
            VersionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ArchetypeTitle
            // 
            ArchetypeTitle.BackColor = System.Drawing.Color.Transparent;
            ArchetypeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            ArchetypeTitle.Location = new System.Drawing.Point(12, 9);
            ArchetypeTitle.Name = "ArchetypeTitle";
            ArchetypeTitle.Size = new System.Drawing.Size(85, 30);
            ArchetypeTitle.TabIndex = 1;
            ArchetypeTitle.Text = "Archetype:";
            ArchetypeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AboutFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(374, 141);
            Controls.Add(GitHubLbl);
            Controls.Add(IconsLbl);
            Controls.Add(ArchetypeTitle);
            Controls.Add(VersionLbl);
            Controls.Add(VersionTitle);
            Controls.Add(ArchetypeLbl);
            Controls.Add(IconsTitle);
            Controls.Add(GitHubTitle);
            ForeColor = System.Drawing.Color.Black;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutFrm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ItsBranK's Signature Maker - About";
            TopMost = true;
            Load += AboutFrm_Load;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label GitHubLbl;
        private System.Windows.Forms.Label IconsLbl;
        private System.Windows.Forms.Label VersionLbl;
        private System.Windows.Forms.Label ArchetypeLbl;
        private System.Windows.Forms.Label GitHubTitle;
        private System.Windows.Forms.Label IconsTitle;
        private System.Windows.Forms.Label VersionTitle;
        private System.Windows.Forms.Label ArchetypeTitle;
    }
}