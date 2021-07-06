namespace Signature_Maker
{
    partial class MainFrm
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
            this.BaseLbl = new System.Windows.Forms.Label();
            this.CompareBox = new System.Windows.Forms.TextBox();
            this.CompareLbl = new System.Windows.Forms.Label();
            this.CompareBtn = new System.Windows.Forms.Button();
            this.SwapBtn = new System.Windows.Forms.Button();
            this.BaseCopyBtn = new System.Windows.Forms.Button();
            this.BasePasteBtn = new System.Windows.Forms.Button();
            this.ComparePasteBtn = new System.Windows.Forms.Button();
            this.CompareCopyBtn = new System.Windows.Forms.Button();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.BaseBox = new System.Windows.Forms.ComboBox();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.MaskCopyBtn = new System.Windows.Forms.Button();
            this.ByteArrayCopyBtn = new System.Windows.Forms.Button();
            this.HexEcapedCopyBtn = new System.Windows.Forms.Button();
            this.HexCopyBtn = new System.Windows.Forms.Button();
            this.DifferenceCopyBtn = new System.Windows.Forms.Button();
            this.ByteArrayBox = new System.Windows.Forms.TextBox();
            this.ByteArrayLbl = new System.Windows.Forms.Label();
            this.HexEscapedBox = new System.Windows.Forms.TextBox();
            this.HexEscapedLbl = new System.Windows.Forms.Label();
            this.HexBox = new System.Windows.Forms.TextBox();
            this.HexLbl = new System.Windows.Forms.Label();
            this.MaskBox = new System.Windows.Forms.TextBox();
            this.MaskLbl = new System.Windows.Forms.Label();
            this.DifferenceBox = new System.Windows.Forms.TextBox();
            this.DifferenceLbl = new System.Windows.Forms.Label();
            this.ProcessGroupBox = new System.Windows.Forms.GroupBox();
            this.PIDBox = new System.Windows.Forms.NumericUpDown();
            this.ProcessBox = new System.Windows.Forms.ComboBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.AddressPasteBtn = new System.Windows.Forms.Button();
            this.LengthLbl = new System.Windows.Forms.Label();
            this.LengthBox = new System.Windows.Forms.NumericUpDown();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ProcessLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.InputGroupBox.SuspendLayout();
            this.OutputGroupBox.SuspendLayout();
            this.ProcessGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIDBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseLbl
            // 
            this.BaseLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseLbl.ForeColor = System.Drawing.Color.Black;
            this.BaseLbl.Location = new System.Drawing.Point(6, 18);
            this.BaseLbl.Name = "BaseLbl";
            this.BaseLbl.Size = new System.Drawing.Size(105, 25);
            this.BaseLbl.TabIndex = 0;
            this.BaseLbl.Text = "Base AOB:";
            this.BaseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CompareBox
            // 
            this.CompareBox.BackColor = System.Drawing.Color.White;
            this.CompareBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompareBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareBox.ForeColor = System.Drawing.Color.Black;
            this.CompareBox.Location = new System.Drawing.Point(117, 48);
            this.CompareBox.Name = "CompareBox";
            this.CompareBox.Size = new System.Drawing.Size(350, 25);
            this.CompareBox.TabIndex = 3;
            // 
            // CompareLbl
            // 
            this.CompareLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareLbl.ForeColor = System.Drawing.Color.Black;
            this.CompareLbl.Location = new System.Drawing.Point(6, 48);
            this.CompareLbl.Name = "CompareLbl";
            this.CompareLbl.Size = new System.Drawing.Size(105, 25);
            this.CompareLbl.TabIndex = 2;
            this.CompareLbl.Text = "Comapre AOB:";
            this.CompareLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CompareBtn
            // 
            this.CompareBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareBtn.ForeColor = System.Drawing.Color.Black;
            this.CompareBtn.Location = new System.Drawing.Point(117, 79);
            this.CompareBtn.Name = "CompareBtn";
            this.CompareBtn.Size = new System.Drawing.Size(172, 25);
            this.CompareBtn.TabIndex = 4;
            this.CompareBtn.Text = "Compare";
            this.CompareBtn.UseVisualStyleBackColor = true;
            this.CompareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // SwapBtn
            // 
            this.SwapBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapBtn.ForeColor = System.Drawing.Color.Black;
            this.SwapBtn.Location = new System.Drawing.Point(295, 79);
            this.SwapBtn.Name = "SwapBtn";
            this.SwapBtn.Size = new System.Drawing.Size(172, 25);
            this.SwapBtn.TabIndex = 5;
            this.SwapBtn.Text = "Swap";
            this.SwapBtn.UseVisualStyleBackColor = true;
            this.SwapBtn.Click += new System.EventHandler(this.SwapBtn_Click);
            // 
            // BaseCopyBtn
            // 
            this.BaseCopyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseCopyBtn.ForeColor = System.Drawing.Color.Black;
            this.BaseCopyBtn.Location = new System.Drawing.Point(473, 18);
            this.BaseCopyBtn.Name = "BaseCopyBtn";
            this.BaseCopyBtn.Size = new System.Drawing.Size(25, 25);
            this.BaseCopyBtn.TabIndex = 6;
            this.BaseCopyBtn.Text = "C";
            this.BaseCopyBtn.UseVisualStyleBackColor = true;
            this.BaseCopyBtn.Click += new System.EventHandler(this.BaseCopyBtn_Click);
            // 
            // BasePasteBtn
            // 
            this.BasePasteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasePasteBtn.ForeColor = System.Drawing.Color.Black;
            this.BasePasteBtn.Location = new System.Drawing.Point(503, 18);
            this.BasePasteBtn.Name = "BasePasteBtn";
            this.BasePasteBtn.Size = new System.Drawing.Size(25, 25);
            this.BasePasteBtn.TabIndex = 7;
            this.BasePasteBtn.Text = "P";
            this.BasePasteBtn.UseVisualStyleBackColor = true;
            this.BasePasteBtn.Click += new System.EventHandler(this.BasePasteBtn_Click);
            // 
            // ComparePasteBtn
            // 
            this.ComparePasteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComparePasteBtn.ForeColor = System.Drawing.Color.Black;
            this.ComparePasteBtn.Location = new System.Drawing.Point(503, 49);
            this.ComparePasteBtn.Name = "ComparePasteBtn";
            this.ComparePasteBtn.Size = new System.Drawing.Size(25, 25);
            this.ComparePasteBtn.TabIndex = 9;
            this.ComparePasteBtn.Text = "P";
            this.ComparePasteBtn.UseVisualStyleBackColor = true;
            this.ComparePasteBtn.Click += new System.EventHandler(this.ComparePasteBtn_Click);
            // 
            // CompareCopyBtn
            // 
            this.CompareCopyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareCopyBtn.ForeColor = System.Drawing.Color.Black;
            this.CompareCopyBtn.Location = new System.Drawing.Point(473, 49);
            this.CompareCopyBtn.Name = "CompareCopyBtn";
            this.CompareCopyBtn.Size = new System.Drawing.Size(25, 25);
            this.CompareCopyBtn.TabIndex = 8;
            this.CompareCopyBtn.Text = "C";
            this.CompareCopyBtn.UseVisualStyleBackColor = true;
            this.CompareCopyBtn.Click += new System.EventHandler(this.CompareCopyBtn_Click);
            // 
            // StatusLbl
            // 
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.ForeColor = System.Drawing.Color.Blue;
            this.StatusLbl.Location = new System.Drawing.Point(117, 173);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(411, 25);
            this.StatusLbl.TabIndex = 22;
            this.StatusLbl.Text = "Awaiting input...";
            this.StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BaseBox
            // 
            this.BaseBox.BackColor = System.Drawing.Color.White;
            this.BaseBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseBox.ForeColor = System.Drawing.Color.Black;
            this.BaseBox.FormattingEnabled = true;
            this.BaseBox.Location = new System.Drawing.Point(117, 18);
            this.BaseBox.Name = "BaseBox";
            this.BaseBox.Size = new System.Drawing.Size(350, 25);
            this.BaseBox.TabIndex = 31;
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.ResetBtn);
            this.InputGroupBox.Controls.Add(this.BaseLbl);
            this.InputGroupBox.Controls.Add(this.CompareLbl);
            this.InputGroupBox.Controls.Add(this.CompareBox);
            this.InputGroupBox.Controls.Add(this.CompareBtn);
            this.InputGroupBox.Controls.Add(this.SwapBtn);
            this.InputGroupBox.Controls.Add(this.BaseBox);
            this.InputGroupBox.Controls.Add(this.BaseCopyBtn);
            this.InputGroupBox.Controls.Add(this.BasePasteBtn);
            this.InputGroupBox.Controls.Add(this.CompareCopyBtn);
            this.InputGroupBox.Controls.Add(this.ComparePasteBtn);
            this.InputGroupBox.Location = new System.Drawing.Point(12, 133);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(535, 112);
            this.InputGroupBox.TabIndex = 37;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Input";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.Black;
            this.ResetBtn.Location = new System.Drawing.Point(473, 79);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(55, 25);
            this.ResetBtn.TabIndex = 54;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Controls.Add(this.MaskCopyBtn);
            this.OutputGroupBox.Controls.Add(this.ByteArrayCopyBtn);
            this.OutputGroupBox.Controls.Add(this.HexEcapedCopyBtn);
            this.OutputGroupBox.Controls.Add(this.HexCopyBtn);
            this.OutputGroupBox.Controls.Add(this.DifferenceCopyBtn);
            this.OutputGroupBox.Controls.Add(this.ByteArrayBox);
            this.OutputGroupBox.Controls.Add(this.ByteArrayLbl);
            this.OutputGroupBox.Controls.Add(this.HexEscapedBox);
            this.OutputGroupBox.Controls.Add(this.HexEscapedLbl);
            this.OutputGroupBox.Controls.Add(this.HexBox);
            this.OutputGroupBox.Controls.Add(this.HexLbl);
            this.OutputGroupBox.Controls.Add(this.MaskBox);
            this.OutputGroupBox.Controls.Add(this.MaskLbl);
            this.OutputGroupBox.Controls.Add(this.DifferenceBox);
            this.OutputGroupBox.Controls.Add(this.StatusLbl);
            this.OutputGroupBox.Controls.Add(this.DifferenceLbl);
            this.OutputGroupBox.Location = new System.Drawing.Point(12, 251);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(535, 205);
            this.OutputGroupBox.TabIndex = 40;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Output";
            // 
            // MaskCopyBtn
            // 
            this.MaskCopyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskCopyBtn.ForeColor = System.Drawing.Color.Black;
            this.MaskCopyBtn.Location = new System.Drawing.Point(473, 142);
            this.MaskCopyBtn.Name = "MaskCopyBtn";
            this.MaskCopyBtn.Size = new System.Drawing.Size(55, 25);
            this.MaskCopyBtn.TabIndex = 53;
            this.MaskCopyBtn.Text = "Copy";
            this.MaskCopyBtn.UseVisualStyleBackColor = true;
            this.MaskCopyBtn.Click += new System.EventHandler(this.MaskCopyBtn_Click);
            // 
            // ByteArrayCopyBtn
            // 
            this.ByteArrayCopyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByteArrayCopyBtn.ForeColor = System.Drawing.Color.Black;
            this.ByteArrayCopyBtn.Location = new System.Drawing.Point(473, 111);
            this.ByteArrayCopyBtn.Name = "ByteArrayCopyBtn";
            this.ByteArrayCopyBtn.Size = new System.Drawing.Size(55, 25);
            this.ByteArrayCopyBtn.TabIndex = 52;
            this.ByteArrayCopyBtn.Text = "Copy";
            this.ByteArrayCopyBtn.UseVisualStyleBackColor = true;
            this.ByteArrayCopyBtn.Click += new System.EventHandler(this.ByteArrayCopyBtn_Click);
            // 
            // HexEcapedCopyBtn
            // 
            this.HexEcapedCopyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexEcapedCopyBtn.ForeColor = System.Drawing.Color.Black;
            this.HexEcapedCopyBtn.Location = new System.Drawing.Point(473, 80);
            this.HexEcapedCopyBtn.Name = "HexEcapedCopyBtn";
            this.HexEcapedCopyBtn.Size = new System.Drawing.Size(55, 25);
            this.HexEcapedCopyBtn.TabIndex = 51;
            this.HexEcapedCopyBtn.Text = "Copy";
            this.HexEcapedCopyBtn.UseVisualStyleBackColor = true;
            this.HexEcapedCopyBtn.Click += new System.EventHandler(this.HexEcapedCopyBtn_Click);
            // 
            // HexCopyBtn
            // 
            this.HexCopyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexCopyBtn.ForeColor = System.Drawing.Color.Black;
            this.HexCopyBtn.Location = new System.Drawing.Point(473, 49);
            this.HexCopyBtn.Name = "HexCopyBtn";
            this.HexCopyBtn.Size = new System.Drawing.Size(55, 25);
            this.HexCopyBtn.TabIndex = 50;
            this.HexCopyBtn.Text = "Copy";
            this.HexCopyBtn.UseVisualStyleBackColor = true;
            this.HexCopyBtn.Click += new System.EventHandler(this.HexCopyBtn_Click);
            // 
            // DifferenceCopyBtn
            // 
            this.DifferenceCopyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifferenceCopyBtn.ForeColor = System.Drawing.Color.Black;
            this.DifferenceCopyBtn.Location = new System.Drawing.Point(473, 18);
            this.DifferenceCopyBtn.Name = "DifferenceCopyBtn";
            this.DifferenceCopyBtn.Size = new System.Drawing.Size(55, 25);
            this.DifferenceCopyBtn.TabIndex = 49;
            this.DifferenceCopyBtn.Text = "Copy";
            this.DifferenceCopyBtn.UseVisualStyleBackColor = true;
            this.DifferenceCopyBtn.Click += new System.EventHandler(this.DifferenceCopyBtn_Click);
            // 
            // ByteArrayBox
            // 
            this.ByteArrayBox.BackColor = System.Drawing.Color.White;
            this.ByteArrayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ByteArrayBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByteArrayBox.ForeColor = System.Drawing.Color.Black;
            this.ByteArrayBox.Location = new System.Drawing.Point(117, 111);
            this.ByteArrayBox.Name = "ByteArrayBox";
            this.ByteArrayBox.ReadOnly = true;
            this.ByteArrayBox.Size = new System.Drawing.Size(350, 25);
            this.ByteArrayBox.TabIndex = 48;
            // 
            // ByteArrayLbl
            // 
            this.ByteArrayLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByteArrayLbl.ForeColor = System.Drawing.Color.Black;
            this.ByteArrayLbl.Location = new System.Drawing.Point(6, 111);
            this.ByteArrayLbl.Name = "ByteArrayLbl";
            this.ByteArrayLbl.Size = new System.Drawing.Size(105, 25);
            this.ByteArrayLbl.TabIndex = 47;
            this.ByteArrayLbl.Text = "Byte Array:";
            this.ByteArrayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HexEscapedBox
            // 
            this.HexEscapedBox.BackColor = System.Drawing.Color.White;
            this.HexEscapedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HexEscapedBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexEscapedBox.ForeColor = System.Drawing.Color.Black;
            this.HexEscapedBox.Location = new System.Drawing.Point(117, 80);
            this.HexEscapedBox.Name = "HexEscapedBox";
            this.HexEscapedBox.ReadOnly = true;
            this.HexEscapedBox.Size = new System.Drawing.Size(350, 25);
            this.HexEscapedBox.TabIndex = 46;
            // 
            // HexEscapedLbl
            // 
            this.HexEscapedLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexEscapedLbl.ForeColor = System.Drawing.Color.Black;
            this.HexEscapedLbl.Location = new System.Drawing.Point(6, 80);
            this.HexEscapedLbl.Name = "HexEscapedLbl";
            this.HexEscapedLbl.Size = new System.Drawing.Size(105, 25);
            this.HexEscapedLbl.TabIndex = 45;
            this.HexEscapedLbl.Text = "Hex Escaped:";
            this.HexEscapedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HexBox
            // 
            this.HexBox.BackColor = System.Drawing.Color.White;
            this.HexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HexBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexBox.ForeColor = System.Drawing.Color.Black;
            this.HexBox.Location = new System.Drawing.Point(117, 49);
            this.HexBox.Name = "HexBox";
            this.HexBox.ReadOnly = true;
            this.HexBox.Size = new System.Drawing.Size(350, 25);
            this.HexBox.TabIndex = 44;
            // 
            // HexLbl
            // 
            this.HexLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexLbl.ForeColor = System.Drawing.Color.Black;
            this.HexLbl.Location = new System.Drawing.Point(6, 49);
            this.HexLbl.Name = "HexLbl";
            this.HexLbl.Size = new System.Drawing.Size(105, 25);
            this.HexLbl.TabIndex = 43;
            this.HexLbl.Text = "Hex:";
            this.HexLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MaskBox
            // 
            this.MaskBox.BackColor = System.Drawing.Color.White;
            this.MaskBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaskBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskBox.ForeColor = System.Drawing.Color.Black;
            this.MaskBox.Location = new System.Drawing.Point(117, 142);
            this.MaskBox.Name = "MaskBox";
            this.MaskBox.ReadOnly = true;
            this.MaskBox.Size = new System.Drawing.Size(350, 25);
            this.MaskBox.TabIndex = 42;
            // 
            // MaskLbl
            // 
            this.MaskLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskLbl.ForeColor = System.Drawing.Color.Black;
            this.MaskLbl.Location = new System.Drawing.Point(6, 142);
            this.MaskLbl.Name = "MaskLbl";
            this.MaskLbl.Size = new System.Drawing.Size(105, 25);
            this.MaskLbl.TabIndex = 41;
            this.MaskLbl.Text = "Mask:";
            this.MaskLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DifferenceBox
            // 
            this.DifferenceBox.BackColor = System.Drawing.Color.White;
            this.DifferenceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DifferenceBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifferenceBox.ForeColor = System.Drawing.Color.Black;
            this.DifferenceBox.Location = new System.Drawing.Point(117, 18);
            this.DifferenceBox.Name = "DifferenceBox";
            this.DifferenceBox.ReadOnly = true;
            this.DifferenceBox.Size = new System.Drawing.Size(350, 25);
            this.DifferenceBox.TabIndex = 40;
            // 
            // DifferenceLbl
            // 
            this.DifferenceLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifferenceLbl.ForeColor = System.Drawing.Color.Black;
            this.DifferenceLbl.Location = new System.Drawing.Point(6, 18);
            this.DifferenceLbl.Name = "DifferenceLbl";
            this.DifferenceLbl.Size = new System.Drawing.Size(105, 25);
            this.DifferenceLbl.TabIndex = 0;
            this.DifferenceLbl.Text = "Difference:";
            this.DifferenceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProcessGroupBox
            // 
            this.ProcessGroupBox.Controls.Add(this.PIDBox);
            this.ProcessGroupBox.Controls.Add(this.ProcessBox);
            this.ProcessGroupBox.Controls.Add(this.CreateBtn);
            this.ProcessGroupBox.Controls.Add(this.AddressPasteBtn);
            this.ProcessGroupBox.Controls.Add(this.LengthLbl);
            this.ProcessGroupBox.Controls.Add(this.LengthBox);
            this.ProcessGroupBox.Controls.Add(this.RefreshBtn);
            this.ProcessGroupBox.Controls.Add(this.ProcessLbl);
            this.ProcessGroupBox.Controls.Add(this.AddressLbl);
            this.ProcessGroupBox.Controls.Add(this.AddressBox);
            this.ProcessGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ProcessGroupBox.Name = "ProcessGroupBox";
            this.ProcessGroupBox.Size = new System.Drawing.Size(535, 115);
            this.ProcessGroupBox.TabIndex = 41;
            this.ProcessGroupBox.TabStop = false;
            this.ProcessGroupBox.Text = "Process (Optional)";
            // 
            // PIDBox
            // 
            this.PIDBox.BackColor = System.Drawing.Color.White;
            this.PIDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PIDBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIDBox.ForeColor = System.Drawing.Color.Black;
            this.PIDBox.Location = new System.Drawing.Point(337, 17);
            this.PIDBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PIDBox.Name = "PIDBox";
            this.PIDBox.Size = new System.Drawing.Size(75, 25);
            this.PIDBox.TabIndex = 52;
            this.PIDBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PIDBox_KeyUp);
            // 
            // ProcessBox
            // 
            this.ProcessBox.BackColor = System.Drawing.Color.White;
            this.ProcessBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProcessBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessBox.ForeColor = System.Drawing.Color.Black;
            this.ProcessBox.FormattingEnabled = true;
            this.ProcessBox.Location = new System.Drawing.Point(117, 18);
            this.ProcessBox.Name = "ProcessBox";
            this.ProcessBox.Size = new System.Drawing.Size(214, 23);
            this.ProcessBox.TabIndex = 40;
            this.ProcessBox.SelectedValueChanged += new System.EventHandler(this.ProcessBox_SelectedValueChanged);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.ForeColor = System.Drawing.Color.Black;
            this.CreateBtn.Location = new System.Drawing.Point(418, 79);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(110, 25);
            this.CreateBtn.TabIndex = 51;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // AddressPasteBtn
            // 
            this.AddressPasteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressPasteBtn.ForeColor = System.Drawing.Color.Black;
            this.AddressPasteBtn.Location = new System.Drawing.Point(418, 48);
            this.AddressPasteBtn.Name = "AddressPasteBtn";
            this.AddressPasteBtn.Size = new System.Drawing.Size(110, 25);
            this.AddressPasteBtn.TabIndex = 50;
            this.AddressPasteBtn.Text = "Paste";
            this.AddressPasteBtn.UseVisualStyleBackColor = true;
            this.AddressPasteBtn.Click += new System.EventHandler(this.AddressPasteBtn_Click);
            // 
            // LengthLbl
            // 
            this.LengthLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthLbl.ForeColor = System.Drawing.Color.Black;
            this.LengthLbl.Location = new System.Drawing.Point(6, 77);
            this.LengthLbl.Name = "LengthLbl";
            this.LengthLbl.Size = new System.Drawing.Size(105, 25);
            this.LengthLbl.TabIndex = 44;
            this.LengthLbl.Text = "Byte Length:";
            this.LengthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LengthBox
            // 
            this.LengthBox.BackColor = System.Drawing.Color.White;
            this.LengthBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LengthBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthBox.ForeColor = System.Drawing.Color.Black;
            this.LengthBox.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.LengthBox.Location = new System.Drawing.Point(117, 79);
            this.LengthBox.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.LengthBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.LengthBox.Name = "LengthBox";
            this.LengthBox.Size = new System.Drawing.Size(295, 25);
            this.LengthBox.TabIndex = 43;
            this.LengthBox.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshBtn.Location = new System.Drawing.Point(418, 17);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(110, 25);
            this.RefreshBtn.TabIndex = 41;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ProcessLbl
            // 
            this.ProcessLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessLbl.ForeColor = System.Drawing.Color.Black;
            this.ProcessLbl.Location = new System.Drawing.Point(6, 18);
            this.ProcessLbl.Name = "ProcessLbl";
            this.ProcessLbl.Size = new System.Drawing.Size(105, 25);
            this.ProcessLbl.TabIndex = 0;
            this.ProcessLbl.Text = "Process/PID:";
            this.ProcessLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddressLbl
            // 
            this.AddressLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLbl.ForeColor = System.Drawing.Color.Black;
            this.AddressLbl.Location = new System.Drawing.Point(6, 48);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(105, 25);
            this.AddressLbl.TabIndex = 2;
            this.AddressLbl.Text = "Address:";
            this.AddressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddressBox
            // 
            this.AddressBox.BackColor = System.Drawing.Color.White;
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBox.ForeColor = System.Drawing.Color.Black;
            this.AddressBox.Location = new System.Drawing.Point(117, 48);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(295, 25);
            this.AddressBox.TabIndex = 3;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 466);
            this.Controls.Add(this.ProcessGroupBox);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.InputGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItsBranK\'s Signature Maker (x64)";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.OutputGroupBox.ResumeLayout(false);
            this.OutputGroupBox.PerformLayout();
            this.ProcessGroupBox.ResumeLayout(false);
            this.ProcessGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIDBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BaseLbl;
        private System.Windows.Forms.TextBox CompareBox;
        private System.Windows.Forms.Label CompareLbl;
        private System.Windows.Forms.Button CompareBtn;
        private System.Windows.Forms.Button SwapBtn;
        private System.Windows.Forms.Button BaseCopyBtn;
        private System.Windows.Forms.Button BasePasteBtn;
        private System.Windows.Forms.Button ComparePasteBtn;
        private System.Windows.Forms.Button CompareCopyBtn;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.ComboBox BaseBox;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.TextBox ByteArrayBox;
        private System.Windows.Forms.Label ByteArrayLbl;
        private System.Windows.Forms.TextBox HexEscapedBox;
        private System.Windows.Forms.Label HexEscapedLbl;
        private System.Windows.Forms.TextBox HexBox;
        private System.Windows.Forms.Label HexLbl;
        private System.Windows.Forms.TextBox MaskBox;
        private System.Windows.Forms.Label MaskLbl;
        private System.Windows.Forms.TextBox DifferenceBox;
        private System.Windows.Forms.Label DifferenceLbl;
        private System.Windows.Forms.Button MaskCopyBtn;
        private System.Windows.Forms.Button ByteArrayCopyBtn;
        private System.Windows.Forms.Button HexEcapedCopyBtn;
        private System.Windows.Forms.Button HexCopyBtn;
        private System.Windows.Forms.Button DifferenceCopyBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.GroupBox ProcessGroupBox;
        private System.Windows.Forms.NumericUpDown LengthBox;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Label ProcessLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Button AddressPasteBtn;
        private System.Windows.Forms.Label LengthLbl;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.ComboBox ProcessBox;
        private System.Windows.Forms.NumericUpDown PIDBox;
    }
}

