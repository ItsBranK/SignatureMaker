
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
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HexMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EscapedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByteArrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCtrl = new System.Windows.Forms.MenuStrip();
            this.ProcessGroupBx = new System.Windows.Forms.GroupBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.PasteBtn = new System.Windows.Forms.Button();
            this.LengthBx = new System.Windows.Forms.NumericUpDown();
            this.PIDBx = new System.Windows.Forms.NumericUpDown();
            this.ProcessBx = new System.Windows.Forms.ComboBox();
            this.AddressBx = new System.Windows.Forms.TextBox();
            this.LengthLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.ProcessLbl = new System.Windows.Forms.Label();
            this.InputGroupBx = new System.Windows.Forms.GroupBox();
            this.DifferenceBx = new System.Windows.Forms.TextBox();
            this.DifferenceLbl = new System.Windows.Forms.Label();
            this.SwapBtn = new System.Windows.Forms.Button();
            this.CompareBtn = new System.Windows.Forms.Button();
            this.BaseBx = new System.Windows.Forms.ComboBox();
            this.CompareBx = new System.Windows.Forms.TextBox();
            this.CompareLbl = new System.Windows.Forms.Label();
            this.BaseLbl = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.OutputGroupBx = new System.Windows.Forms.GroupBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.TestBtn = new System.Windows.Forms.Button();
            this.MaskCopyBtn = new System.Windows.Forms.Button();
            this.MaskBx = new System.Windows.Forms.TextBox();
            this.ByteCopyBtn = new System.Windows.Forms.Button();
            this.BytesBx = new System.Windows.Forms.TextBox();
            this.MaskLbl = new System.Windows.Forms.Label();
            this.BytesLbl = new System.Windows.Forms.Label();
            this.MenuCtrl.SuspendLayout();
            this.ProcessGroupBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIDBx)).BeginInit();
            this.InputGroupBx.SuspendLayout();
            this.OutputGroupBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModesMenuItem,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // ModesMenuItem
            // 
            this.ModesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HexMenuItem,
            this.EscapedMenuItem,
            this.ByteArrayMenuItem});
            this.ModesMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ModesMenuItem.Image = global::SignatureMaker.Properties.Resources.Settings;
            this.ModesMenuItem.Name = "ModesMenuItem";
            this.ModesMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ModesMenuItem.Text = "Output Mode";
            // 
            // HexMenuItem
            // 
            this.HexMenuItem.ForeColor = System.Drawing.Color.Black;
            this.HexMenuItem.Image = global::SignatureMaker.Properties.Resources.Hex;
            this.HexMenuItem.Name = "HexMenuItem";
            this.HexMenuItem.Size = new System.Drawing.Size(152, 22);
            this.HexMenuItem.Text = "Hex";
            this.HexMenuItem.Click += new System.EventHandler(this.HexMenuItem_Click);
            // 
            // EscapedMenuItem
            // 
            this.EscapedMenuItem.ForeColor = System.Drawing.Color.Black;
            this.EscapedMenuItem.Image = global::SignatureMaker.Properties.Resources.Escaped;
            this.EscapedMenuItem.Name = "EscapedMenuItem";
            this.EscapedMenuItem.Size = new System.Drawing.Size(152, 22);
            this.EscapedMenuItem.Text = "√ Hex Escaped";
            this.EscapedMenuItem.Click += new System.EventHandler(this.EscapedMenuItem_Click);
            // 
            // ByteArrayMenuItem
            // 
            this.ByteArrayMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ByteArrayMenuItem.Image = global::SignatureMaker.Properties.Resources.Array;
            this.ByteArrayMenuItem.Name = "ByteArrayMenuItem";
            this.ByteArrayMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ByteArrayMenuItem.Text = "Byte Array";
            this.ByteArrayMenuItem.Click += new System.EventHandler(this.ByteArrayMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ExitMenuItem.Image = global::SignatureMaker.Properties.Resources.Exit;
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // MenuCtrl
            // 
            this.MenuCtrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.AboutMenuItem});
            this.MenuCtrl.Location = new System.Drawing.Point(0, 0);
            this.MenuCtrl.Name = "MenuCtrl";
            this.MenuCtrl.Size = new System.Drawing.Size(519, 24);
            this.MenuCtrl.TabIndex = 1;
            this.MenuCtrl.Text = "menuStrip2";
            // 
            // ProcessGroupBx
            // 
            this.ProcessGroupBx.Controls.Add(this.RefreshBtn);
            this.ProcessGroupBx.Controls.Add(this.CreateBtn);
            this.ProcessGroupBx.Controls.Add(this.PasteBtn);
            this.ProcessGroupBx.Controls.Add(this.LengthBx);
            this.ProcessGroupBx.Controls.Add(this.PIDBx);
            this.ProcessGroupBx.Controls.Add(this.ProcessBx);
            this.ProcessGroupBx.Controls.Add(this.AddressBx);
            this.ProcessGroupBx.Controls.Add(this.LengthLbl);
            this.ProcessGroupBx.Controls.Add(this.AddressLbl);
            this.ProcessGroupBx.Controls.Add(this.ProcessLbl);
            this.ProcessGroupBx.Location = new System.Drawing.Point(12, 27);
            this.ProcessGroupBx.Name = "ProcessGroupBx";
            this.ProcessGroupBx.Size = new System.Drawing.Size(495, 115);
            this.ProcessGroupBx.TabIndex = 2;
            this.ProcessGroupBx.TabStop = false;
            this.ProcessGroupBx.Text = "Process (Optional)";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(385, 20);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(100, 25);
            this.RefreshBtn.TabIndex = 10;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(385, 80);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(100, 25);
            this.CreateBtn.TabIndex = 9;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // PasteBtn
            // 
            this.PasteBtn.Location = new System.Drawing.Point(385, 50);
            this.PasteBtn.Name = "PasteBtn";
            this.PasteBtn.Size = new System.Drawing.Size(100, 25);
            this.PasteBtn.TabIndex = 8;
            this.PasteBtn.Text = "Paste";
            this.PasteBtn.UseVisualStyleBackColor = true;
            this.PasteBtn.Click += new System.EventHandler(this.PasteBtn_Click);
            // 
            // LengthBx
            // 
            this.LengthBx.BackColor = System.Drawing.Color.White;
            this.LengthBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LengthBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LengthBx.ForeColor = System.Drawing.Color.Black;
            this.LengthBx.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.LengthBx.Location = new System.Drawing.Point(95, 80);
            this.LengthBx.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.LengthBx.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.LengthBx.Name = "LengthBx";
            this.LengthBx.Size = new System.Drawing.Size(285, 25);
            this.LengthBx.TabIndex = 6;
            this.LengthBx.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // PIDBx
            // 
            this.PIDBx.BackColor = System.Drawing.Color.White;
            this.PIDBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PIDBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PIDBx.ForeColor = System.Drawing.Color.Black;
            this.PIDBx.Location = new System.Drawing.Point(316, 20);
            this.PIDBx.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PIDBx.Name = "PIDBx";
            this.PIDBx.Size = new System.Drawing.Size(64, 25);
            this.PIDBx.TabIndex = 5;
            this.PIDBx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PIDBx_KeyUp);
            // 
            // ProcessBx
            // 
            this.ProcessBx.BackColor = System.Drawing.Color.White;
            this.ProcessBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProcessBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProcessBx.ForeColor = System.Drawing.Color.Black;
            this.ProcessBx.FormattingEnabled = true;
            this.ProcessBx.Location = new System.Drawing.Point(95, 20);
            this.ProcessBx.Name = "ProcessBx";
            this.ProcessBx.Size = new System.Drawing.Size(215, 25);
            this.ProcessBx.TabIndex = 4;
            this.ProcessBx.SelectedValueChanged += new System.EventHandler(this.ProcessBx_SelectedValueChanged);
            // 
            // AddressBx
            // 
            this.AddressBx.BackColor = System.Drawing.Color.White;
            this.AddressBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressBx.ForeColor = System.Drawing.Color.Black;
            this.AddressBx.Location = new System.Drawing.Point(95, 50);
            this.AddressBx.Name = "AddressBx";
            this.AddressBx.Size = new System.Drawing.Size(285, 25);
            this.AddressBx.TabIndex = 3;
            // 
            // LengthLbl
            // 
            this.LengthLbl.BackColor = System.Drawing.Color.Transparent;
            this.LengthLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LengthLbl.Location = new System.Drawing.Point(5, 80);
            this.LengthLbl.Name = "LengthLbl";
            this.LengthLbl.Size = new System.Drawing.Size(85, 25);
            this.LengthLbl.TabIndex = 2;
            this.LengthLbl.Text = "Byte Length";
            this.LengthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddressLbl
            // 
            this.AddressLbl.BackColor = System.Drawing.Color.Transparent;
            this.AddressLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressLbl.Location = new System.Drawing.Point(5, 50);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(85, 25);
            this.AddressLbl.TabIndex = 1;
            this.AddressLbl.Text = "Address:";
            this.AddressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProcessLbl
            // 
            this.ProcessLbl.BackColor = System.Drawing.Color.Transparent;
            this.ProcessLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProcessLbl.Location = new System.Drawing.Point(5, 20);
            this.ProcessLbl.Name = "ProcessLbl";
            this.ProcessLbl.Size = new System.Drawing.Size(85, 25);
            this.ProcessLbl.TabIndex = 0;
            this.ProcessLbl.Text = "Process/PID:";
            this.ProcessLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InputGroupBx
            // 
            this.InputGroupBx.Controls.Add(this.DifferenceBx);
            this.InputGroupBx.Controls.Add(this.DifferenceLbl);
            this.InputGroupBx.Controls.Add(this.SwapBtn);
            this.InputGroupBx.Controls.Add(this.CompareBtn);
            this.InputGroupBx.Controls.Add(this.BaseBx);
            this.InputGroupBx.Controls.Add(this.CompareBx);
            this.InputGroupBx.Controls.Add(this.CompareLbl);
            this.InputGroupBx.Controls.Add(this.BaseLbl);
            this.InputGroupBx.Location = new System.Drawing.Point(12, 148);
            this.InputGroupBx.Name = "InputGroupBx";
            this.InputGroupBx.Size = new System.Drawing.Size(495, 145);
            this.InputGroupBx.TabIndex = 3;
            this.InputGroupBx.TabStop = false;
            this.InputGroupBx.Text = "Input";
            // 
            // DifferenceBx
            // 
            this.DifferenceBx.BackColor = System.Drawing.Color.White;
            this.DifferenceBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DifferenceBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DifferenceBx.ForeColor = System.Drawing.Color.Black;
            this.DifferenceBx.Location = new System.Drawing.Point(95, 80);
            this.DifferenceBx.Name = "DifferenceBx";
            this.DifferenceBx.ReadOnly = true;
            this.DifferenceBx.Size = new System.Drawing.Size(391, 25);
            this.DifferenceBx.TabIndex = 13;
            // 
            // DifferenceLbl
            // 
            this.DifferenceLbl.BackColor = System.Drawing.Color.Transparent;
            this.DifferenceLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DifferenceLbl.Location = new System.Drawing.Point(5, 80);
            this.DifferenceLbl.Name = "DifferenceLbl";
            this.DifferenceLbl.Size = new System.Drawing.Size(85, 25);
            this.DifferenceLbl.TabIndex = 12;
            this.DifferenceLbl.Text = "Difference:";
            this.DifferenceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SwapBtn
            // 
            this.SwapBtn.Location = new System.Drawing.Point(294, 110);
            this.SwapBtn.Name = "SwapBtn";
            this.SwapBtn.Size = new System.Drawing.Size(192, 25);
            this.SwapBtn.TabIndex = 11;
            this.SwapBtn.Text = "Swap";
            this.SwapBtn.UseVisualStyleBackColor = true;
            this.SwapBtn.Click += new System.EventHandler(this.SwapBtn_Click);
            // 
            // CompareBtn
            // 
            this.CompareBtn.Location = new System.Drawing.Point(95, 110);
            this.CompareBtn.Name = "CompareBtn";
            this.CompareBtn.Size = new System.Drawing.Size(192, 25);
            this.CompareBtn.TabIndex = 10;
            this.CompareBtn.Text = "Compare";
            this.CompareBtn.UseVisualStyleBackColor = true;
            this.CompareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // BaseBx
            // 
            this.BaseBx.BackColor = System.Drawing.Color.White;
            this.BaseBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BaseBx.ForeColor = System.Drawing.Color.Black;
            this.BaseBx.FormattingEnabled = true;
            this.BaseBx.Location = new System.Drawing.Point(95, 20);
            this.BaseBx.Name = "BaseBx";
            this.BaseBx.Size = new System.Drawing.Size(391, 25);
            this.BaseBx.TabIndex = 5;
            // 
            // CompareBx
            // 
            this.CompareBx.BackColor = System.Drawing.Color.White;
            this.CompareBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompareBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompareBx.ForeColor = System.Drawing.Color.Black;
            this.CompareBx.Location = new System.Drawing.Point(95, 50);
            this.CompareBx.Name = "CompareBx";
            this.CompareBx.Size = new System.Drawing.Size(391, 25);
            this.CompareBx.TabIndex = 5;
            // 
            // CompareLbl
            // 
            this.CompareLbl.BackColor = System.Drawing.Color.Transparent;
            this.CompareLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompareLbl.Location = new System.Drawing.Point(5, 50);
            this.CompareLbl.Name = "CompareLbl";
            this.CompareLbl.Size = new System.Drawing.Size(85, 25);
            this.CompareLbl.TabIndex = 2;
            this.CompareLbl.Text = "Comapre:";
            this.CompareLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BaseLbl
            // 
            this.BaseLbl.BackColor = System.Drawing.Color.Transparent;
            this.BaseLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BaseLbl.Location = new System.Drawing.Point(5, 20);
            this.BaseLbl.Name = "BaseLbl";
            this.BaseLbl.Size = new System.Drawing.Size(85, 25);
            this.BaseLbl.TabIndex = 1;
            this.BaseLbl.Text = "Base:";
            this.BaseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(430, 80);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(55, 25);
            this.ResetBtn.TabIndex = 11;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // OutputGroupBx
            // 
            this.OutputGroupBx.Controls.Add(this.StatusLbl);
            this.OutputGroupBx.Controls.Add(this.ResetBtn);
            this.OutputGroupBx.Controls.Add(this.TestBtn);
            this.OutputGroupBx.Controls.Add(this.MaskCopyBtn);
            this.OutputGroupBx.Controls.Add(this.MaskBx);
            this.OutputGroupBx.Controls.Add(this.ByteCopyBtn);
            this.OutputGroupBx.Controls.Add(this.BytesBx);
            this.OutputGroupBx.Controls.Add(this.MaskLbl);
            this.OutputGroupBx.Controls.Add(this.BytesLbl);
            this.OutputGroupBx.Location = new System.Drawing.Point(12, 300);
            this.OutputGroupBx.Name = "OutputGroupBx";
            this.OutputGroupBx.Size = new System.Drawing.Size(495, 140);
            this.OutputGroupBx.TabIndex = 4;
            this.OutputGroupBx.TabStop = false;
            this.OutputGroupBx.Text = "Output";
            // 
            // StatusLbl
            // 
            this.StatusLbl.BackColor = System.Drawing.Color.Transparent;
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StatusLbl.Location = new System.Drawing.Point(95, 110);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(390, 25);
            this.StatusLbl.TabIndex = 22;
            this.StatusLbl.Text = "Status: Awaiting input...";
            this.StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(95, 80);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(329, 25);
            this.TestBtn.TabIndex = 21;
            this.TestBtn.Text = "Test Signature";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // MaskCopyBtn
            // 
            this.MaskCopyBtn.Location = new System.Drawing.Point(430, 50);
            this.MaskCopyBtn.Name = "MaskCopyBtn";
            this.MaskCopyBtn.Size = new System.Drawing.Size(55, 25);
            this.MaskCopyBtn.TabIndex = 20;
            this.MaskCopyBtn.Text = "Copy";
            this.MaskCopyBtn.UseVisualStyleBackColor = true;
            this.MaskCopyBtn.Click += new System.EventHandler(this.MaskCopyBtn_Click);
            // 
            // MaskBx
            // 
            this.MaskBx.BackColor = System.Drawing.Color.White;
            this.MaskBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaskBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaskBx.ForeColor = System.Drawing.Color.Black;
            this.MaskBx.Location = new System.Drawing.Point(95, 50);
            this.MaskBx.Name = "MaskBx";
            this.MaskBx.Size = new System.Drawing.Size(329, 25);
            this.MaskBx.TabIndex = 19;
            // 
            // ByteCopyBtn
            // 
            this.ByteCopyBtn.Location = new System.Drawing.Point(430, 20);
            this.ByteCopyBtn.Name = "ByteCopyBtn";
            this.ByteCopyBtn.Size = new System.Drawing.Size(55, 25);
            this.ByteCopyBtn.TabIndex = 18;
            this.ByteCopyBtn.Text = "Copy";
            this.ByteCopyBtn.UseVisualStyleBackColor = true;
            this.ByteCopyBtn.Click += new System.EventHandler(this.ByteCopyBtn_Click);
            // 
            // BytesBx
            // 
            this.BytesBx.BackColor = System.Drawing.Color.White;
            this.BytesBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BytesBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BytesBx.ForeColor = System.Drawing.Color.Black;
            this.BytesBx.Location = new System.Drawing.Point(95, 20);
            this.BytesBx.Name = "BytesBx";
            this.BytesBx.Size = new System.Drawing.Size(329, 25);
            this.BytesBx.TabIndex = 17;
            // 
            // MaskLbl
            // 
            this.MaskLbl.BackColor = System.Drawing.Color.Transparent;
            this.MaskLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaskLbl.Location = new System.Drawing.Point(6, 50);
            this.MaskLbl.Name = "MaskLbl";
            this.MaskLbl.Size = new System.Drawing.Size(85, 25);
            this.MaskLbl.TabIndex = 3;
            this.MaskLbl.Text = "Mask:";
            this.MaskLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BytesLbl
            // 
            this.BytesLbl.BackColor = System.Drawing.Color.Transparent;
            this.BytesLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BytesLbl.Location = new System.Drawing.Point(5, 20);
            this.BytesLbl.Name = "BytesLbl";
            this.BytesLbl.Size = new System.Drawing.Size(85, 25);
            this.BytesLbl.TabIndex = 2;
            this.BytesLbl.Text = "Bytes:";
            this.BytesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 451);
            this.Controls.Add(this.OutputGroupBx);
            this.Controls.Add(this.InputGroupBx);
            this.Controls.Add(this.ProcessGroupBx);
            this.Controls.Add(this.MenuCtrl);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItsBranK\'s Signature Maker";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.MenuCtrl.ResumeLayout(false);
            this.MenuCtrl.PerformLayout();
            this.ProcessGroupBx.ResumeLayout(false);
            this.ProcessGroupBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIDBx)).EndInit();
            this.InputGroupBx.ResumeLayout(false);
            this.InputGroupBx.PerformLayout();
            this.OutputGroupBx.ResumeLayout(false);
            this.OutputGroupBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem ModesMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.ToolStripMenuItem HexMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EscapedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ByteArrayMenuItem;
    }
}

