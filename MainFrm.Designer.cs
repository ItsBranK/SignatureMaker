namespace Signature_Maker
{
    partial class mainFrm
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
            this.baseLbl = new System.Windows.Forms.Label();
            this.compareBx = new System.Windows.Forms.TextBox();
            this.compareLbl = new System.Windows.Forms.Label();
            this.compareBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.baseCpyBtn = new System.Windows.Forms.Button();
            this.basePstBtn = new System.Windows.Forms.Button();
            this.comparePstBtn = new System.Windows.Forms.Button();
            this.compareCpyBtn = new System.Windows.Forms.Button();
            this.differenceBx = new System.Windows.Forms.TextBox();
            this.differenceLbl = new System.Windows.Forms.Label();
            this.differenceCpyBtn = new System.Windows.Forms.Button();
            this.halfMaskCpyBtn = new System.Windows.Forms.Button();
            this.halfMaskLbl = new System.Windows.Forms.Label();
            this.halfMaskBx = new System.Windows.Forms.TextBox();
            this.codeCpyBtn = new System.Windows.Forms.Button();
            this.codeLbl = new System.Windows.Forms.Label();
            this.codeBx = new System.Windows.Forms.TextBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.arrayCpyBtn = new System.Windows.Forms.Button();
            this.arrayLbl = new System.Windows.Forms.Label();
            this.arrayBx = new System.Windows.Forms.TextBox();
            this.creditsLbl = new System.Windows.Forms.Label();
            this.swapBtn = new System.Windows.Forms.Button();
            this.fullMaskCpyBtn = new System.Windows.Forms.Button();
            this.fullMaskLbl = new System.Windows.Forms.Label();
            this.fullMaskBx = new System.Windows.Forms.TextBox();
            this.baseBx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // baseLbl
            // 
            this.baseLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLbl.ForeColor = System.Drawing.Color.Black;
            this.baseLbl.Location = new System.Drawing.Point(10, 10);
            this.baseLbl.Name = "baseLbl";
            this.baseLbl.Size = new System.Drawing.Size(125, 25);
            this.baseLbl.TabIndex = 0;
            this.baseLbl.Text = "Original/Base AOB:";
            this.baseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // compareBx
            // 
            this.compareBx.BackColor = System.Drawing.Color.White;
            this.compareBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compareBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareBx.ForeColor = System.Drawing.Color.Black;
            this.compareBx.Location = new System.Drawing.Point(140, 40);
            this.compareBx.Name = "compareBx";
            this.compareBx.Size = new System.Drawing.Size(420, 25);
            this.compareBx.TabIndex = 3;
            // 
            // compareLbl
            // 
            this.compareLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareLbl.ForeColor = System.Drawing.Color.Black;
            this.compareLbl.Location = new System.Drawing.Point(10, 40);
            this.compareLbl.Name = "compareLbl";
            this.compareLbl.Size = new System.Drawing.Size(125, 25);
            this.compareLbl.TabIndex = 2;
            this.compareLbl.Text = "AOB to Compare:";
            this.compareLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // compareBtn
            // 
            this.compareBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareBtn.ForeColor = System.Drawing.Color.Black;
            this.compareBtn.Location = new System.Drawing.Point(140, 70);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(205, 25);
            this.compareBtn.TabIndex = 4;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.Black;
            this.resetBtn.Location = new System.Drawing.Point(355, 70);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(205, 25);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset All";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // baseCpyBtn
            // 
            this.baseCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.baseCpyBtn.Location = new System.Drawing.Point(565, 10);
            this.baseCpyBtn.Name = "baseCpyBtn";
            this.baseCpyBtn.Size = new System.Drawing.Size(25, 25);
            this.baseCpyBtn.TabIndex = 6;
            this.baseCpyBtn.Text = "C";
            this.baseCpyBtn.UseVisualStyleBackColor = true;
            this.baseCpyBtn.Click += new System.EventHandler(this.BaseCpyBtn_Click);
            // 
            // basePstBtn
            // 
            this.basePstBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basePstBtn.ForeColor = System.Drawing.Color.Black;
            this.basePstBtn.Location = new System.Drawing.Point(595, 10);
            this.basePstBtn.Name = "basePstBtn";
            this.basePstBtn.Size = new System.Drawing.Size(25, 25);
            this.basePstBtn.TabIndex = 7;
            this.basePstBtn.Text = "P";
            this.basePstBtn.UseVisualStyleBackColor = true;
            this.basePstBtn.Click += new System.EventHandler(this.BasePstBtn_Click);
            // 
            // comparePstBtn
            // 
            this.comparePstBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comparePstBtn.ForeColor = System.Drawing.Color.Black;
            this.comparePstBtn.Location = new System.Drawing.Point(595, 40);
            this.comparePstBtn.Name = "comparePstBtn";
            this.comparePstBtn.Size = new System.Drawing.Size(25, 25);
            this.comparePstBtn.TabIndex = 9;
            this.comparePstBtn.Text = "P";
            this.comparePstBtn.UseVisualStyleBackColor = true;
            this.comparePstBtn.Click += new System.EventHandler(this.ComparePstBtn_Click);
            // 
            // compareCpyBtn
            // 
            this.compareCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.compareCpyBtn.Location = new System.Drawing.Point(565, 40);
            this.compareCpyBtn.Name = "compareCpyBtn";
            this.compareCpyBtn.Size = new System.Drawing.Size(25, 25);
            this.compareCpyBtn.TabIndex = 8;
            this.compareCpyBtn.Text = "C";
            this.compareCpyBtn.UseVisualStyleBackColor = true;
            this.compareCpyBtn.Click += new System.EventHandler(this.CompareCpyBtn_Click);
            // 
            // differenceBx
            // 
            this.differenceBx.BackColor = System.Drawing.Color.White;
            this.differenceBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.differenceBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differenceBx.ForeColor = System.Drawing.Color.Black;
            this.differenceBx.Location = new System.Drawing.Point(140, 100);
            this.differenceBx.Name = "differenceBx";
            this.differenceBx.Size = new System.Drawing.Size(420, 25);
            this.differenceBx.TabIndex = 11;
            // 
            // differenceLbl
            // 
            this.differenceLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differenceLbl.ForeColor = System.Drawing.Color.Black;
            this.differenceLbl.Location = new System.Drawing.Point(10, 100);
            this.differenceLbl.Name = "differenceLbl";
            this.differenceLbl.Size = new System.Drawing.Size(125, 25);
            this.differenceLbl.TabIndex = 12;
            this.differenceLbl.Text = "Difference:";
            this.differenceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // differenceCpyBtn
            // 
            this.differenceCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differenceCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.differenceCpyBtn.Location = new System.Drawing.Point(565, 100);
            this.differenceCpyBtn.Name = "differenceCpyBtn";
            this.differenceCpyBtn.Size = new System.Drawing.Size(55, 25);
            this.differenceCpyBtn.TabIndex = 13;
            this.differenceCpyBtn.Text = "Copy";
            this.differenceCpyBtn.UseVisualStyleBackColor = true;
            this.differenceCpyBtn.Click += new System.EventHandler(this.DifferenceCpyBtn_Click);
            // 
            // halfMaskCpyBtn
            // 
            this.halfMaskCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halfMaskCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.halfMaskCpyBtn.Location = new System.Drawing.Point(565, 130);
            this.halfMaskCpyBtn.Name = "halfMaskCpyBtn";
            this.halfMaskCpyBtn.Size = new System.Drawing.Size(55, 25);
            this.halfMaskCpyBtn.TabIndex = 16;
            this.halfMaskCpyBtn.Text = "Copy";
            this.halfMaskCpyBtn.UseVisualStyleBackColor = true;
            this.halfMaskCpyBtn.Click += new System.EventHandler(this.HalfMaskCpyBtn_Click);
            // 
            // halfMaskLbl
            // 
            this.halfMaskLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halfMaskLbl.ForeColor = System.Drawing.Color.Black;
            this.halfMaskLbl.Location = new System.Drawing.Point(10, 130);
            this.halfMaskLbl.Name = "halfMaskLbl";
            this.halfMaskLbl.Size = new System.Drawing.Size(125, 25);
            this.halfMaskLbl.TabIndex = 15;
            this.halfMaskLbl.Text = "Half Byte Mask:";
            this.halfMaskLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // halfMaskBx
            // 
            this.halfMaskBx.BackColor = System.Drawing.Color.White;
            this.halfMaskBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.halfMaskBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halfMaskBx.ForeColor = System.Drawing.Color.Black;
            this.halfMaskBx.Location = new System.Drawing.Point(140, 130);
            this.halfMaskBx.Name = "halfMaskBx";
            this.halfMaskBx.ReadOnly = true;
            this.halfMaskBx.Size = new System.Drawing.Size(420, 25);
            this.halfMaskBx.TabIndex = 14;
            // 
            // codeCpyBtn
            // 
            this.codeCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.codeCpyBtn.Location = new System.Drawing.Point(565, 190);
            this.codeCpyBtn.Name = "codeCpyBtn";
            this.codeCpyBtn.Size = new System.Drawing.Size(55, 25);
            this.codeCpyBtn.TabIndex = 19;
            this.codeCpyBtn.Text = "Copy";
            this.codeCpyBtn.UseVisualStyleBackColor = true;
            this.codeCpyBtn.Click += new System.EventHandler(this.CodeCpyBtn_Click);
            // 
            // codeLbl
            // 
            this.codeLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLbl.ForeColor = System.Drawing.Color.Black;
            this.codeLbl.Location = new System.Drawing.Point(10, 190);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(125, 25);
            this.codeLbl.TabIndex = 18;
            this.codeLbl.Text = "Code Style:";
            this.codeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // codeBx
            // 
            this.codeBx.BackColor = System.Drawing.Color.White;
            this.codeBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBx.ForeColor = System.Drawing.Color.Black;
            this.codeBx.Location = new System.Drawing.Point(140, 190);
            this.codeBx.Name = "codeBx";
            this.codeBx.ReadOnly = true;
            this.codeBx.Size = new System.Drawing.Size(420, 25);
            this.codeBx.TabIndex = 17;
            // 
            // statusLbl
            // 
            this.statusLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ForeColor = System.Drawing.Color.Blue;
            this.statusLbl.Location = new System.Drawing.Point(140, 250);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(480, 25);
            this.statusLbl.TabIndex = 22;
            this.statusLbl.Text = "Awaiting input...";
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // arrayCpyBtn
            // 
            this.arrayCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrayCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.arrayCpyBtn.Location = new System.Drawing.Point(565, 220);
            this.arrayCpyBtn.Name = "arrayCpyBtn";
            this.arrayCpyBtn.Size = new System.Drawing.Size(55, 25);
            this.arrayCpyBtn.TabIndex = 25;
            this.arrayCpyBtn.Text = "Copy";
            this.arrayCpyBtn.UseVisualStyleBackColor = true;
            this.arrayCpyBtn.Click += new System.EventHandler(this.ArrayCpyBtn_Click);
            // 
            // arrayLbl
            // 
            this.arrayLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrayLbl.ForeColor = System.Drawing.Color.Black;
            this.arrayLbl.Location = new System.Drawing.Point(10, 220);
            this.arrayLbl.Name = "arrayLbl";
            this.arrayLbl.Size = new System.Drawing.Size(125, 25);
            this.arrayLbl.TabIndex = 24;
            this.arrayLbl.Text = "Array Style:";
            this.arrayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // arrayBx
            // 
            this.arrayBx.BackColor = System.Drawing.Color.White;
            this.arrayBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrayBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrayBx.ForeColor = System.Drawing.Color.Black;
            this.arrayBx.Location = new System.Drawing.Point(140, 220);
            this.arrayBx.Name = "arrayBx";
            this.arrayBx.ReadOnly = true;
            this.arrayBx.Size = new System.Drawing.Size(420, 25);
            this.arrayBx.TabIndex = 23;
            // 
            // creditsLbl
            // 
            this.creditsLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLbl.ForeColor = System.Drawing.Color.Black;
            this.creditsLbl.Location = new System.Drawing.Point(10, 250);
            this.creditsLbl.Name = "creditsLbl";
            this.creditsLbl.Size = new System.Drawing.Size(125, 25);
            this.creditsLbl.TabIndex = 26;
            this.creditsLbl.Text = "@ItsBranK";
            this.creditsLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // swapBtn
            // 
            this.swapBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swapBtn.ForeColor = System.Drawing.Color.Black;
            this.swapBtn.Location = new System.Drawing.Point(565, 70);
            this.swapBtn.Name = "swapBtn";
            this.swapBtn.Size = new System.Drawing.Size(55, 25);
            this.swapBtn.TabIndex = 27;
            this.swapBtn.Text = "Swap";
            this.swapBtn.UseVisualStyleBackColor = true;
            this.swapBtn.Click += new System.EventHandler(this.SwapBtn_Click);
            // 
            // fullMaskCpyBtn
            // 
            this.fullMaskCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullMaskCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.fullMaskCpyBtn.Location = new System.Drawing.Point(565, 160);
            this.fullMaskCpyBtn.Name = "fullMaskCpyBtn";
            this.fullMaskCpyBtn.Size = new System.Drawing.Size(55, 25);
            this.fullMaskCpyBtn.TabIndex = 30;
            this.fullMaskCpyBtn.Text = "Copy";
            this.fullMaskCpyBtn.UseVisualStyleBackColor = true;
            this.fullMaskCpyBtn.Click += new System.EventHandler(this.FullMaskCpyBtn_Click);
            // 
            // fullMaskLbl
            // 
            this.fullMaskLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullMaskLbl.ForeColor = System.Drawing.Color.Black;
            this.fullMaskLbl.Location = new System.Drawing.Point(10, 160);
            this.fullMaskLbl.Name = "fullMaskLbl";
            this.fullMaskLbl.Size = new System.Drawing.Size(125, 25);
            this.fullMaskLbl.TabIndex = 29;
            this.fullMaskLbl.Text = "Full Byte Mask:";
            this.fullMaskLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fullMaskBx
            // 
            this.fullMaskBx.BackColor = System.Drawing.Color.White;
            this.fullMaskBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullMaskBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullMaskBx.ForeColor = System.Drawing.Color.Black;
            this.fullMaskBx.Location = new System.Drawing.Point(140, 160);
            this.fullMaskBx.Name = "fullMaskBx";
            this.fullMaskBx.ReadOnly = true;
            this.fullMaskBx.Size = new System.Drawing.Size(420, 25);
            this.fullMaskBx.TabIndex = 28;
            // 
            // baseBx
            // 
            this.baseBx.BackColor = System.Drawing.Color.White;
            this.baseBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseBx.ForeColor = System.Drawing.Color.Black;
            this.baseBx.FormattingEnabled = true;
            this.baseBx.Location = new System.Drawing.Point(140, 10);
            this.baseBx.Name = "baseBx";
            this.baseBx.Size = new System.Drawing.Size(420, 25);
            this.baseBx.TabIndex = 31;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 285);
            this.Controls.Add(this.baseBx);
            this.Controls.Add(this.fullMaskCpyBtn);
            this.Controls.Add(this.fullMaskLbl);
            this.Controls.Add(this.fullMaskBx);
            this.Controls.Add(this.swapBtn);
            this.Controls.Add(this.creditsLbl);
            this.Controls.Add(this.arrayCpyBtn);
            this.Controls.Add(this.arrayLbl);
            this.Controls.Add(this.arrayBx);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.codeCpyBtn);
            this.Controls.Add(this.codeLbl);
            this.Controls.Add(this.codeBx);
            this.Controls.Add(this.halfMaskCpyBtn);
            this.Controls.Add(this.halfMaskLbl);
            this.Controls.Add(this.halfMaskBx);
            this.Controls.Add(this.differenceCpyBtn);
            this.Controls.Add(this.differenceLbl);
            this.Controls.Add(this.differenceBx);
            this.Controls.Add(this.comparePstBtn);
            this.Controls.Add(this.compareCpyBtn);
            this.Controls.Add(this.basePstBtn);
            this.Controls.Add(this.baseCpyBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.compareBtn);
            this.Controls.Add(this.compareBx);
            this.Controls.Add(this.compareLbl);
            this.Controls.Add(this.baseLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signature Maker v1.1";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baseLbl;
        private System.Windows.Forms.TextBox compareBx;
        private System.Windows.Forms.Label compareLbl;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button baseCpyBtn;
        private System.Windows.Forms.Button basePstBtn;
        private System.Windows.Forms.Button comparePstBtn;
        private System.Windows.Forms.Button compareCpyBtn;
        private System.Windows.Forms.TextBox differenceBx;
        private System.Windows.Forms.Label differenceLbl;
        private System.Windows.Forms.Button differenceCpyBtn;
        private System.Windows.Forms.Button halfMaskCpyBtn;
        private System.Windows.Forms.Label halfMaskLbl;
        private System.Windows.Forms.TextBox halfMaskBx;
        private System.Windows.Forms.Button codeCpyBtn;
        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.TextBox codeBx;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button arrayCpyBtn;
        private System.Windows.Forms.Label arrayLbl;
        private System.Windows.Forms.TextBox arrayBx;
        private System.Windows.Forms.Label creditsLbl;
        private System.Windows.Forms.Button swapBtn;
        private System.Windows.Forms.Button fullMaskCpyBtn;
        private System.Windows.Forms.Label fullMaskLbl;
        private System.Windows.Forms.TextBox fullMaskBx;
        private System.Windows.Forms.ComboBox baseBx;
    }
}

