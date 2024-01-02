
namespace SignatureMaker
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            ModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            HexMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            EscapedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ArrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuCtrl = new System.Windows.Forms.MenuStrip();
            ProcessGroupBx = new System.Windows.Forms.GroupBox();
            RefreshBtn = new System.Windows.Forms.Button();
            CreateBtn = new System.Windows.Forms.Button();
            PasteBtn = new System.Windows.Forms.Button();
            LengthBx = new System.Windows.Forms.NumericUpDown();
            PIDBx = new System.Windows.Forms.NumericUpDown();
            ProcessBx = new System.Windows.Forms.ComboBox();
            AddressBx = new System.Windows.Forms.TextBox();
            LengthLbl = new System.Windows.Forms.Label();
            AddressLbl = new System.Windows.Forms.Label();
            ProcessLbl = new System.Windows.Forms.Label();
            InputGroupBx = new System.Windows.Forms.GroupBox();
            DifferenceBx = new System.Windows.Forms.TextBox();
            DifferenceLbl = new System.Windows.Forms.Label();
            SwapBtn = new System.Windows.Forms.Button();
            CompareBtn = new System.Windows.Forms.Button();
            BaseBx = new System.Windows.Forms.ComboBox();
            CompareBx = new System.Windows.Forms.TextBox();
            CompareLbl = new System.Windows.Forms.Label();
            BaseLbl = new System.Windows.Forms.Label();
            ResetBtn = new System.Windows.Forms.Button();
            OutputGroupBx = new System.Windows.Forms.GroupBox();
            StatusLbl = new System.Windows.Forms.Label();
            TestBtn = new System.Windows.Forms.Button();
            MaskCopyBtn = new System.Windows.Forms.Button();
            MaskBx = new System.Windows.Forms.TextBox();
            ByteCopyBtn = new System.Windows.Forms.Button();
            BytesBx = new System.Windows.Forms.TextBox();
            MaskLbl = new System.Windows.Forms.Label();
            BytesLbl = new System.Windows.Forms.Label();
            MenuCtrl.SuspendLayout();
            ProcessGroupBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LengthBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PIDBx).BeginInit();
            InputGroupBx.SuspendLayout();
            OutputGroupBx.SuspendLayout();
            SuspendLayout();
            // 
            // ModeMenuItem
            // 
            ModeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { HexMenuItem, EscapedMenuItem, ArrayMenuItem });
            ModeMenuItem.Name = "ModeMenuItem";
            ModeMenuItem.Size = new System.Drawing.Size(50, 20);
            ModeMenuItem.Text = "Mode";
            // 
            // HexMenuItem
            // 
            HexMenuItem.Image = Properties.Resources.Hex;
            HexMenuItem.Name = "HexMenuItem";
            HexMenuItem.Size = new System.Drawing.Size(180, 22);
            HexMenuItem.Text = "Hex";
            HexMenuItem.Click += HexMenuItem_Click;
            // 
            // EscapedMenuItem
            // 
            EscapedMenuItem.Image = Properties.Resources.Escaped;
            EscapedMenuItem.Name = "EscapedMenuItem";
            EscapedMenuItem.Size = new System.Drawing.Size(180, 22);
            EscapedMenuItem.Text = "> Hex Escaped";
            EscapedMenuItem.Click += EscapedMenuItem_Click;
            // 
            // ArrayMenuItem
            // 
            ArrayMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ArrayMenuItem.Image = Properties.Resources.Array;
            ArrayMenuItem.Name = "ArrayMenuItem";
            ArrayMenuItem.Size = new System.Drawing.Size(180, 22);
            ArrayMenuItem.Text = "Byte Array";
            ArrayMenuItem.Click += ArrayMenuItem_Click;
            // 
            // AboutMenuItem
            // 
            AboutMenuItem.Name = "AboutMenuItem";
            AboutMenuItem.Size = new System.Drawing.Size(52, 20);
            AboutMenuItem.Text = "About";
            AboutMenuItem.Click += AboutMenuItem_Click;
            // 
            // MenuCtrl
            // 
            MenuCtrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ModeMenuItem, AboutMenuItem });
            MenuCtrl.Location = new System.Drawing.Point(0, 0);
            MenuCtrl.Name = "MenuCtrl";
            MenuCtrl.Size = new System.Drawing.Size(519, 24);
            MenuCtrl.TabIndex = 1;
            MenuCtrl.Text = "menuStrip2";
            // 
            // ProcessGroupBx
            // 
            ProcessGroupBx.Controls.Add(RefreshBtn);
            ProcessGroupBx.Controls.Add(CreateBtn);
            ProcessGroupBx.Controls.Add(PasteBtn);
            ProcessGroupBx.Controls.Add(LengthBx);
            ProcessGroupBx.Controls.Add(PIDBx);
            ProcessGroupBx.Controls.Add(ProcessBx);
            ProcessGroupBx.Controls.Add(AddressBx);
            ProcessGroupBx.Controls.Add(LengthLbl);
            ProcessGroupBx.Controls.Add(AddressLbl);
            ProcessGroupBx.Controls.Add(ProcessLbl);
            ProcessGroupBx.Location = new System.Drawing.Point(12, 27);
            ProcessGroupBx.Name = "ProcessGroupBx";
            ProcessGroupBx.Size = new System.Drawing.Size(495, 115);
            ProcessGroupBx.TabIndex = 2;
            ProcessGroupBx.TabStop = false;
            ProcessGroupBx.Text = "Process (Optional)";
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new System.Drawing.Point(385, 20);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new System.Drawing.Size(100, 25);
            RefreshBtn.TabIndex = 10;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new System.Drawing.Point(385, 80);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new System.Drawing.Size(100, 25);
            CreateBtn.TabIndex = 9;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // PasteBtn
            // 
            PasteBtn.Location = new System.Drawing.Point(385, 50);
            PasteBtn.Name = "PasteBtn";
            PasteBtn.Size = new System.Drawing.Size(100, 25);
            PasteBtn.TabIndex = 8;
            PasteBtn.Text = "Paste";
            PasteBtn.UseVisualStyleBackColor = true;
            PasteBtn.Click += PasteBtn_Click;
            // 
            // LengthBx
            // 
            LengthBx.BackColor = System.Drawing.Color.White;
            LengthBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            LengthBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            LengthBx.ForeColor = System.Drawing.Color.Black;
            LengthBx.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            LengthBx.Location = new System.Drawing.Point(95, 80);
            LengthBx.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            LengthBx.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            LengthBx.Name = "LengthBx";
            LengthBx.Size = new System.Drawing.Size(285, 25);
            LengthBx.TabIndex = 6;
            LengthBx.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // PIDBx
            // 
            PIDBx.BackColor = System.Drawing.Color.White;
            PIDBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PIDBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            PIDBx.ForeColor = System.Drawing.Color.Black;
            PIDBx.Location = new System.Drawing.Point(316, 20);
            PIDBx.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            PIDBx.Name = "PIDBx";
            PIDBx.Size = new System.Drawing.Size(64, 25);
            PIDBx.TabIndex = 5;
            PIDBx.KeyUp += PIDBx_KeyUp;
            // 
            // ProcessBx
            // 
            ProcessBx.BackColor = System.Drawing.Color.White;
            ProcessBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ProcessBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            ProcessBx.ForeColor = System.Drawing.Color.Black;
            ProcessBx.FormattingEnabled = true;
            ProcessBx.Location = new System.Drawing.Point(95, 20);
            ProcessBx.Name = "ProcessBx";
            ProcessBx.Size = new System.Drawing.Size(215, 25);
            ProcessBx.TabIndex = 4;
            ProcessBx.SelectedValueChanged += ProcessBx_SelectedValueChanged;
            // 
            // AddressBx
            // 
            AddressBx.BackColor = System.Drawing.Color.White;
            AddressBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            AddressBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            AddressBx.ForeColor = System.Drawing.Color.Black;
            AddressBx.Location = new System.Drawing.Point(95, 50);
            AddressBx.Name = "AddressBx";
            AddressBx.Size = new System.Drawing.Size(285, 25);
            AddressBx.TabIndex = 3;
            // 
            // LengthLbl
            // 
            LengthLbl.BackColor = System.Drawing.Color.Transparent;
            LengthLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            LengthLbl.Location = new System.Drawing.Point(5, 80);
            LengthLbl.Name = "LengthLbl";
            LengthLbl.Size = new System.Drawing.Size(85, 25);
            LengthLbl.TabIndex = 2;
            LengthLbl.Text = "Byte Length";
            LengthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddressLbl
            // 
            AddressLbl.BackColor = System.Drawing.Color.Transparent;
            AddressLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            AddressLbl.Location = new System.Drawing.Point(5, 50);
            AddressLbl.Name = "AddressLbl";
            AddressLbl.Size = new System.Drawing.Size(85, 25);
            AddressLbl.TabIndex = 1;
            AddressLbl.Text = "Address:";
            AddressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProcessLbl
            // 
            ProcessLbl.BackColor = System.Drawing.Color.Transparent;
            ProcessLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            ProcessLbl.Location = new System.Drawing.Point(5, 20);
            ProcessLbl.Name = "ProcessLbl";
            ProcessLbl.Size = new System.Drawing.Size(85, 25);
            ProcessLbl.TabIndex = 0;
            ProcessLbl.Text = "Process/PID:";
            ProcessLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InputGroupBx
            // 
            InputGroupBx.Controls.Add(DifferenceBx);
            InputGroupBx.Controls.Add(DifferenceLbl);
            InputGroupBx.Controls.Add(SwapBtn);
            InputGroupBx.Controls.Add(CompareBtn);
            InputGroupBx.Controls.Add(BaseBx);
            InputGroupBx.Controls.Add(CompareBx);
            InputGroupBx.Controls.Add(CompareLbl);
            InputGroupBx.Controls.Add(BaseLbl);
            InputGroupBx.Location = new System.Drawing.Point(12, 148);
            InputGroupBx.Name = "InputGroupBx";
            InputGroupBx.Size = new System.Drawing.Size(495, 145);
            InputGroupBx.TabIndex = 3;
            InputGroupBx.TabStop = false;
            InputGroupBx.Text = "Input";
            // 
            // DifferenceBx
            // 
            DifferenceBx.BackColor = System.Drawing.Color.White;
            DifferenceBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DifferenceBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            DifferenceBx.ForeColor = System.Drawing.Color.Black;
            DifferenceBx.Location = new System.Drawing.Point(95, 80);
            DifferenceBx.Name = "DifferenceBx";
            DifferenceBx.ReadOnly = true;
            DifferenceBx.Size = new System.Drawing.Size(391, 25);
            DifferenceBx.TabIndex = 13;
            // 
            // DifferenceLbl
            // 
            DifferenceLbl.BackColor = System.Drawing.Color.Transparent;
            DifferenceLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            DifferenceLbl.Location = new System.Drawing.Point(5, 80);
            DifferenceLbl.Name = "DifferenceLbl";
            DifferenceLbl.Size = new System.Drawing.Size(85, 25);
            DifferenceLbl.TabIndex = 12;
            DifferenceLbl.Text = "Difference:";
            DifferenceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SwapBtn
            // 
            SwapBtn.Location = new System.Drawing.Point(294, 110);
            SwapBtn.Name = "SwapBtn";
            SwapBtn.Size = new System.Drawing.Size(192, 25);
            SwapBtn.TabIndex = 11;
            SwapBtn.Text = "Swap";
            SwapBtn.UseVisualStyleBackColor = true;
            SwapBtn.Click += SwapBtn_Click;
            // 
            // CompareBtn
            // 
            CompareBtn.Location = new System.Drawing.Point(95, 110);
            CompareBtn.Name = "CompareBtn";
            CompareBtn.Size = new System.Drawing.Size(192, 25);
            CompareBtn.TabIndex = 10;
            CompareBtn.Text = "Compare";
            CompareBtn.UseVisualStyleBackColor = true;
            CompareBtn.Click += CompareBtn_Click;
            // 
            // BaseBx
            // 
            BaseBx.BackColor = System.Drawing.Color.White;
            BaseBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            BaseBx.ForeColor = System.Drawing.Color.Black;
            BaseBx.FormattingEnabled = true;
            BaseBx.Location = new System.Drawing.Point(95, 20);
            BaseBx.Name = "BaseBx";
            BaseBx.Size = new System.Drawing.Size(391, 25);
            BaseBx.TabIndex = 5;
            // 
            // CompareBx
            // 
            CompareBx.BackColor = System.Drawing.Color.White;
            CompareBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            CompareBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            CompareBx.ForeColor = System.Drawing.Color.Black;
            CompareBx.Location = new System.Drawing.Point(95, 50);
            CompareBx.Name = "CompareBx";
            CompareBx.Size = new System.Drawing.Size(391, 25);
            CompareBx.TabIndex = 5;
            // 
            // CompareLbl
            // 
            CompareLbl.BackColor = System.Drawing.Color.Transparent;
            CompareLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            CompareLbl.Location = new System.Drawing.Point(5, 50);
            CompareLbl.Name = "CompareLbl";
            CompareLbl.Size = new System.Drawing.Size(85, 25);
            CompareLbl.TabIndex = 2;
            CompareLbl.Text = "Comapre:";
            CompareLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BaseLbl
            // 
            BaseLbl.BackColor = System.Drawing.Color.Transparent;
            BaseLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            BaseLbl.Location = new System.Drawing.Point(5, 20);
            BaseLbl.Name = "BaseLbl";
            BaseLbl.Size = new System.Drawing.Size(85, 25);
            BaseLbl.TabIndex = 1;
            BaseLbl.Text = "Base:";
            BaseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new System.Drawing.Point(430, 80);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new System.Drawing.Size(55, 25);
            ResetBtn.TabIndex = 11;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // OutputGroupBx
            // 
            OutputGroupBx.Controls.Add(StatusLbl);
            OutputGroupBx.Controls.Add(ResetBtn);
            OutputGroupBx.Controls.Add(TestBtn);
            OutputGroupBx.Controls.Add(MaskCopyBtn);
            OutputGroupBx.Controls.Add(MaskBx);
            OutputGroupBx.Controls.Add(ByteCopyBtn);
            OutputGroupBx.Controls.Add(BytesBx);
            OutputGroupBx.Controls.Add(MaskLbl);
            OutputGroupBx.Controls.Add(BytesLbl);
            OutputGroupBx.Location = new System.Drawing.Point(12, 300);
            OutputGroupBx.Name = "OutputGroupBx";
            OutputGroupBx.Size = new System.Drawing.Size(495, 140);
            OutputGroupBx.TabIndex = 4;
            OutputGroupBx.TabStop = false;
            OutputGroupBx.Text = "Output";
            // 
            // StatusLbl
            // 
            StatusLbl.BackColor = System.Drawing.Color.Transparent;
            StatusLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            StatusLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            StatusLbl.Location = new System.Drawing.Point(95, 110);
            StatusLbl.Name = "StatusLbl";
            StatusLbl.Size = new System.Drawing.Size(390, 25);
            StatusLbl.TabIndex = 22;
            StatusLbl.Text = "Status: Awaiting input...";
            StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TestBtn
            // 
            TestBtn.Location = new System.Drawing.Point(95, 80);
            TestBtn.Name = "TestBtn";
            TestBtn.Size = new System.Drawing.Size(329, 25);
            TestBtn.TabIndex = 21;
            TestBtn.Text = "Test Signature";
            TestBtn.UseVisualStyleBackColor = true;
            TestBtn.Click += TestBtn_Click;
            // 
            // MaskCopyBtn
            // 
            MaskCopyBtn.Location = new System.Drawing.Point(430, 50);
            MaskCopyBtn.Name = "MaskCopyBtn";
            MaskCopyBtn.Size = new System.Drawing.Size(55, 25);
            MaskCopyBtn.TabIndex = 20;
            MaskCopyBtn.Text = "Copy";
            MaskCopyBtn.UseVisualStyleBackColor = true;
            MaskCopyBtn.Click += MaskCopyBtn_Click;
            // 
            // MaskBx
            // 
            MaskBx.BackColor = System.Drawing.Color.White;
            MaskBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            MaskBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            MaskBx.ForeColor = System.Drawing.Color.Black;
            MaskBx.Location = new System.Drawing.Point(95, 50);
            MaskBx.Name = "MaskBx";
            MaskBx.Size = new System.Drawing.Size(329, 25);
            MaskBx.TabIndex = 19;
            // 
            // ByteCopyBtn
            // 
            ByteCopyBtn.Location = new System.Drawing.Point(430, 20);
            ByteCopyBtn.Name = "ByteCopyBtn";
            ByteCopyBtn.Size = new System.Drawing.Size(55, 25);
            ByteCopyBtn.TabIndex = 18;
            ByteCopyBtn.Text = "Copy";
            ByteCopyBtn.UseVisualStyleBackColor = true;
            ByteCopyBtn.Click += ByteCopyBtn_Click;
            // 
            // BytesBx
            // 
            BytesBx.BackColor = System.Drawing.Color.White;
            BytesBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            BytesBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            BytesBx.ForeColor = System.Drawing.Color.Black;
            BytesBx.Location = new System.Drawing.Point(95, 20);
            BytesBx.Name = "BytesBx";
            BytesBx.Size = new System.Drawing.Size(329, 25);
            BytesBx.TabIndex = 17;
            // 
            // MaskLbl
            // 
            MaskLbl.BackColor = System.Drawing.Color.Transparent;
            MaskLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            MaskLbl.Location = new System.Drawing.Point(6, 50);
            MaskLbl.Name = "MaskLbl";
            MaskLbl.Size = new System.Drawing.Size(85, 25);
            MaskLbl.TabIndex = 3;
            MaskLbl.Text = "Mask:";
            MaskLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BytesLbl
            // 
            BytesLbl.BackColor = System.Drawing.Color.Transparent;
            BytesLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            BytesLbl.Location = new System.Drawing.Point(5, 20);
            BytesLbl.Name = "BytesLbl";
            BytesLbl.Size = new System.Drawing.Size(85, 25);
            BytesLbl.TabIndex = 2;
            BytesLbl.Text = "Bytes:";
            BytesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(519, 451);
            Controls.Add(OutputGroupBx);
            Controls.Add(InputGroupBx);
            Controls.Add(ProcessGroupBx);
            Controls.Add(MenuCtrl);
            ForeColor = System.Drawing.Color.Black;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainFrm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ItsBranK's Signature Maker";
            Load += MainFrm_Load;
            MenuCtrl.ResumeLayout(false);
            MenuCtrl.PerformLayout();
            ProcessGroupBx.ResumeLayout(false);
            ProcessGroupBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LengthBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)PIDBx).EndInit();
            InputGroupBx.ResumeLayout(false);
            InputGroupBx.PerformLayout();
            OutputGroupBx.ResumeLayout(false);
            OutputGroupBx.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ModeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.MenuStrip MenuCtrl;
        private System.Windows.Forms.GroupBox ProcessGroupBx;
        private System.Windows.Forms.NumericUpDown LengthBx;
        private System.Windows.Forms.NumericUpDown PIDBx;
        private System.Windows.Forms.ComboBox ProcessBx;
        private System.Windows.Forms.TextBox AddressBx;
        private System.Windows.Forms.Label LengthLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label ProcessLbl;
        private System.Windows.Forms.Button PasteBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.GroupBox InputGroupBx;
        private System.Windows.Forms.Button SwapBtn;
        private System.Windows.Forms.Button CompareBtn;
        private System.Windows.Forms.ComboBox BaseBx;
        private System.Windows.Forms.TextBox CompareBx;
        private System.Windows.Forms.Label CompareLbl;
        private System.Windows.Forms.Label BaseLbl;
        private System.Windows.Forms.GroupBox OutputGroupBx;
        private System.Windows.Forms.TextBox DifferenceBx;
        private System.Windows.Forms.Label DifferenceLbl;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.Button MaskCopyBtn;
        private System.Windows.Forms.TextBox MaskBx;
        private System.Windows.Forms.Button ByteCopyBtn;
        private System.Windows.Forms.TextBox BytesBx;
        private System.Windows.Forms.Label MaskLbl;
        private System.Windows.Forms.Label BytesLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.ToolStripMenuItem HexMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EscapedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArrayMenuItem;
    }
}

