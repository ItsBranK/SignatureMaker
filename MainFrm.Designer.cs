namespace SigKit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.BaseLbl = new System.Windows.Forms.Label();
            this.CompareBx = new System.Windows.Forms.TextBox();
            this.CompareLbl = new System.Windows.Forms.Label();
            this.CompareBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.BaseCpyBtn = new System.Windows.Forms.Button();
            this.BasePstBtn = new System.Windows.Forms.Button();
            this.ComparePstBtn = new System.Windows.Forms.Button();
            this.CompareCpyBtn = new System.Windows.Forms.Button();
            this.DifferenceBx = new System.Windows.Forms.TextBox();
            this.DifferenceLbl = new System.Windows.Forms.Label();
            this.DifferenceCpyBtn = new System.Windows.Forms.Button();
            this.HalfMaskCpyBtn = new System.Windows.Forms.Button();
            this.HalfMaskLbl = new System.Windows.Forms.Label();
            this.HalfMaskBx = new System.Windows.Forms.TextBox();
            this.CodeCpyBtn = new System.Windows.Forms.Button();
            this.CodeLbl = new System.Windows.Forms.Label();
            this.CodeBx = new System.Windows.Forms.TextBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.ArrayCpyBtn = new System.Windows.Forms.Button();
            this.ArrayLbl = new System.Windows.Forms.Label();
            this.ArrayBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SwapBtn = new System.Windows.Forms.Button();
            this.FullMaskCpyBtn = new System.Windows.Forms.Button();
            this.FullMaskLbl = new System.Windows.Forms.Label();
            this.FullMaskBx = new System.Windows.Forms.TextBox();
            this.BaseBx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BaseLbl
            // 
            this.BaseLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseLbl.ForeColor = System.Drawing.Color.Black;
            this.BaseLbl.Location = new System.Drawing.Point(10, 10);
            this.BaseLbl.Name = "BaseLbl";
            this.BaseLbl.Size = new System.Drawing.Size(125, 25);
            this.BaseLbl.TabIndex = 0;
            this.BaseLbl.Text = "Original/Base AOB:";
            this.BaseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CompareBx
            // 
            this.CompareBx.BackColor = System.Drawing.Color.White;
            this.CompareBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompareBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareBx.ForeColor = System.Drawing.Color.Black;
            this.CompareBx.Location = new System.Drawing.Point(140, 40);
            this.CompareBx.Name = "CompareBx";
            this.CompareBx.Size = new System.Drawing.Size(420, 25);
            this.CompareBx.TabIndex = 3;
            // 
            // CompareLbl
            // 
            this.CompareLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareLbl.ForeColor = System.Drawing.Color.Black;
            this.CompareLbl.Location = new System.Drawing.Point(10, 40);
            this.CompareLbl.Name = "CompareLbl";
            this.CompareLbl.Size = new System.Drawing.Size(125, 25);
            this.CompareLbl.TabIndex = 2;
            this.CompareLbl.Text = "AOB to Compare:";
            this.CompareLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CompareBtn
            // 
            this.CompareBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareBtn.ForeColor = System.Drawing.Color.Black;
            this.CompareBtn.Location = new System.Drawing.Point(140, 70);
            this.CompareBtn.Name = "CompareBtn";
            this.CompareBtn.Size = new System.Drawing.Size(205, 25);
            this.CompareBtn.TabIndex = 4;
            this.CompareBtn.Text = "Compare";
            this.CompareBtn.UseVisualStyleBackColor = true;
            this.CompareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.Black;
            this.ResetBtn.Location = new System.Drawing.Point(355, 70);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(205, 25);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "Reset All";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // BaseCpyBtn
            // 
            this.BaseCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.BaseCpyBtn.Location = new System.Drawing.Point(565, 10);
            this.BaseCpyBtn.Name = "BaseCpyBtn";
            this.BaseCpyBtn.Size = new System.Drawing.Size(25, 25);
            this.BaseCpyBtn.TabIndex = 6;
            this.BaseCpyBtn.Text = "C";
            this.BaseCpyBtn.UseVisualStyleBackColor = true;
            this.BaseCpyBtn.Click += new System.EventHandler(this.BaseCpyBtn_Click);
            // 
            // BasePstBtn
            // 
            this.BasePstBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasePstBtn.ForeColor = System.Drawing.Color.Black;
            this.BasePstBtn.Location = new System.Drawing.Point(595, 10);
            this.BasePstBtn.Name = "BasePstBtn";
            this.BasePstBtn.Size = new System.Drawing.Size(25, 25);
            this.BasePstBtn.TabIndex = 7;
            this.BasePstBtn.Text = "P";
            this.BasePstBtn.UseVisualStyleBackColor = true;
            this.BasePstBtn.Click += new System.EventHandler(this.BasePstBtn_Click);
            // 
            // ComparePstBtn
            // 
            this.ComparePstBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComparePstBtn.ForeColor = System.Drawing.Color.Black;
            this.ComparePstBtn.Location = new System.Drawing.Point(595, 40);
            this.ComparePstBtn.Name = "ComparePstBtn";
            this.ComparePstBtn.Size = new System.Drawing.Size(25, 25);
            this.ComparePstBtn.TabIndex = 9;
            this.ComparePstBtn.Text = "P";
            this.ComparePstBtn.UseVisualStyleBackColor = true;
            this.ComparePstBtn.Click += new System.EventHandler(this.ComparePstBtn_Click);
            // 
            // CompareCpyBtn
            // 
            this.CompareCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.CompareCpyBtn.Location = new System.Drawing.Point(565, 40);
            this.CompareCpyBtn.Name = "CompareCpyBtn";
            this.CompareCpyBtn.Size = new System.Drawing.Size(25, 25);
            this.CompareCpyBtn.TabIndex = 8;
            this.CompareCpyBtn.Text = "C";
            this.CompareCpyBtn.UseVisualStyleBackColor = true;
            this.CompareCpyBtn.Click += new System.EventHandler(this.CompareCpyBtn_Click);
            // 
            // DifferenceBx
            // 
            this.DifferenceBx.BackColor = System.Drawing.Color.White;
            this.DifferenceBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DifferenceBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifferenceBx.ForeColor = System.Drawing.Color.Black;
            this.DifferenceBx.Location = new System.Drawing.Point(140, 100);
            this.DifferenceBx.Name = "DifferenceBx";
            this.DifferenceBx.Size = new System.Drawing.Size(420, 25);
            this.DifferenceBx.TabIndex = 11;
            // 
            // DifferenceLbl
            // 
            this.DifferenceLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifferenceLbl.ForeColor = System.Drawing.Color.Black;
            this.DifferenceLbl.Location = new System.Drawing.Point(10, 100);
            this.DifferenceLbl.Name = "DifferenceLbl";
            this.DifferenceLbl.Size = new System.Drawing.Size(125, 25);
            this.DifferenceLbl.TabIndex = 12;
            this.DifferenceLbl.Text = "Difference:";
            this.DifferenceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DifferenceCpyBtn
            // 
            this.DifferenceCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifferenceCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.DifferenceCpyBtn.Location = new System.Drawing.Point(565, 100);
            this.DifferenceCpyBtn.Name = "DifferenceCpyBtn";
            this.DifferenceCpyBtn.Size = new System.Drawing.Size(55, 25);
            this.DifferenceCpyBtn.TabIndex = 13;
            this.DifferenceCpyBtn.Text = "Copy";
            this.DifferenceCpyBtn.UseVisualStyleBackColor = true;
            this.DifferenceCpyBtn.Click += new System.EventHandler(this.DifferenceCpyBtn_Click);
            // 
            // HalfMaskCpyBtn
            // 
            this.HalfMaskCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HalfMaskCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.HalfMaskCpyBtn.Location = new System.Drawing.Point(565, 130);
            this.HalfMaskCpyBtn.Name = "HalfMaskCpyBtn";
            this.HalfMaskCpyBtn.Size = new System.Drawing.Size(55, 25);
            this.HalfMaskCpyBtn.TabIndex = 16;
            this.HalfMaskCpyBtn.Text = "Copy";
            this.HalfMaskCpyBtn.UseVisualStyleBackColor = true;
            this.HalfMaskCpyBtn.Click += new System.EventHandler(this.HalfMaskCpyBtn_Click);
            // 
            // HalfMaskLbl
            // 
            this.HalfMaskLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HalfMaskLbl.ForeColor = System.Drawing.Color.Black;
            this.HalfMaskLbl.Location = new System.Drawing.Point(10, 130);
            this.HalfMaskLbl.Name = "HalfMaskLbl";
            this.HalfMaskLbl.Size = new System.Drawing.Size(125, 25);
            this.HalfMaskLbl.TabIndex = 15;
            this.HalfMaskLbl.Text = "Half Byte Mask:";
            this.HalfMaskLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HalfMaskBx
            // 
            this.HalfMaskBx.BackColor = System.Drawing.Color.White;
            this.HalfMaskBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HalfMaskBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HalfMaskBx.ForeColor = System.Drawing.Color.Black;
            this.HalfMaskBx.Location = new System.Drawing.Point(140, 130);
            this.HalfMaskBx.Name = "HalfMaskBx";
            this.HalfMaskBx.ReadOnly = true;
            this.HalfMaskBx.Size = new System.Drawing.Size(420, 25);
            this.HalfMaskBx.TabIndex = 14;
            // 
            // CodeCpyBtn
            // 
            this.CodeCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.CodeCpyBtn.Location = new System.Drawing.Point(565, 190);
            this.CodeCpyBtn.Name = "CodeCpyBtn";
            this.CodeCpyBtn.Size = new System.Drawing.Size(55, 25);
            this.CodeCpyBtn.TabIndex = 19;
            this.CodeCpyBtn.Text = "Copy";
            this.CodeCpyBtn.UseVisualStyleBackColor = true;
            this.CodeCpyBtn.Click += new System.EventHandler(this.CodeCpyBtn_Click);
            // 
            // CodeLbl
            // 
            this.CodeLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeLbl.ForeColor = System.Drawing.Color.Black;
            this.CodeLbl.Location = new System.Drawing.Point(10, 190);
            this.CodeLbl.Name = "CodeLbl";
            this.CodeLbl.Size = new System.Drawing.Size(125, 25);
            this.CodeLbl.TabIndex = 18;
            this.CodeLbl.Text = "Code Style:";
            this.CodeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CodeBx
            // 
            this.CodeBx.BackColor = System.Drawing.Color.White;
            this.CodeBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodeBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeBx.ForeColor = System.Drawing.Color.Black;
            this.CodeBx.Location = new System.Drawing.Point(140, 190);
            this.CodeBx.Name = "CodeBx";
            this.CodeBx.ReadOnly = true;
            this.CodeBx.Size = new System.Drawing.Size(420, 25);
            this.CodeBx.TabIndex = 17;
            // 
            // StatusLbl
            // 
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.ForeColor = System.Drawing.Color.Blue;
            this.StatusLbl.Location = new System.Drawing.Point(140, 250);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(480, 25);
            this.StatusLbl.TabIndex = 22;
            this.StatusLbl.Text = "Awaiting input...";
            this.StatusLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ArrayCpyBtn
            // 
            this.ArrayCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.ArrayCpyBtn.Location = new System.Drawing.Point(565, 220);
            this.ArrayCpyBtn.Name = "ArrayCpyBtn";
            this.ArrayCpyBtn.Size = new System.Drawing.Size(55, 25);
            this.ArrayCpyBtn.TabIndex = 25;
            this.ArrayCpyBtn.Text = "Copy";
            this.ArrayCpyBtn.UseVisualStyleBackColor = true;
            this.ArrayCpyBtn.Click += new System.EventHandler(this.ArrayCpyBtn_Click);
            // 
            // ArrayLbl
            // 
            this.ArrayLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayLbl.ForeColor = System.Drawing.Color.Black;
            this.ArrayLbl.Location = new System.Drawing.Point(10, 220);
            this.ArrayLbl.Name = "ArrayLbl";
            this.ArrayLbl.Size = new System.Drawing.Size(125, 25);
            this.ArrayLbl.TabIndex = 24;
            this.ArrayLbl.Text = "Array Style:";
            this.ArrayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ArrayBx
            // 
            this.ArrayBx.BackColor = System.Drawing.Color.White;
            this.ArrayBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArrayBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayBx.ForeColor = System.Drawing.Color.Black;
            this.ArrayBx.Location = new System.Drawing.Point(140, 220);
            this.ArrayBx.Name = "ArrayBx";
            this.ArrayBx.ReadOnly = true;
            this.ArrayBx.Size = new System.Drawing.Size(420, 25);
            this.ArrayBx.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "@ItsBranK";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SwapBtn
            // 
            this.SwapBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapBtn.ForeColor = System.Drawing.Color.Black;
            this.SwapBtn.Location = new System.Drawing.Point(565, 70);
            this.SwapBtn.Name = "SwapBtn";
            this.SwapBtn.Size = new System.Drawing.Size(55, 25);
            this.SwapBtn.TabIndex = 27;
            this.SwapBtn.Text = "Swap";
            this.SwapBtn.UseVisualStyleBackColor = true;
            this.SwapBtn.Click += new System.EventHandler(this.SwapBtn_Click);
            // 
            // FullMaskCpyBtn
            // 
            this.FullMaskCpyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullMaskCpyBtn.ForeColor = System.Drawing.Color.Black;
            this.FullMaskCpyBtn.Location = new System.Drawing.Point(565, 160);
            this.FullMaskCpyBtn.Name = "FullMaskCpyBtn";
            this.FullMaskCpyBtn.Size = new System.Drawing.Size(55, 25);
            this.FullMaskCpyBtn.TabIndex = 30;
            this.FullMaskCpyBtn.Text = "Copy";
            this.FullMaskCpyBtn.UseVisualStyleBackColor = true;
            this.FullMaskCpyBtn.Click += new System.EventHandler(this.FullMaskCpyBtn_Click);
            // 
            // FullMaskLbl
            // 
            this.FullMaskLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullMaskLbl.ForeColor = System.Drawing.Color.Black;
            this.FullMaskLbl.Location = new System.Drawing.Point(10, 160);
            this.FullMaskLbl.Name = "FullMaskLbl";
            this.FullMaskLbl.Size = new System.Drawing.Size(125, 25);
            this.FullMaskLbl.TabIndex = 29;
            this.FullMaskLbl.Text = "Full Byte Mask:";
            this.FullMaskLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FullMaskBx
            // 
            this.FullMaskBx.BackColor = System.Drawing.Color.White;
            this.FullMaskBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullMaskBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullMaskBx.ForeColor = System.Drawing.Color.Black;
            this.FullMaskBx.Location = new System.Drawing.Point(140, 160);
            this.FullMaskBx.Name = "FullMaskBx";
            this.FullMaskBx.ReadOnly = true;
            this.FullMaskBx.Size = new System.Drawing.Size(420, 25);
            this.FullMaskBx.TabIndex = 28;
            // 
            // BaseBx
            // 
            this.BaseBx.BackColor = System.Drawing.Color.White;
            this.BaseBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseBx.ForeColor = System.Drawing.Color.Black;
            this.BaseBx.FormattingEnabled = true;
            this.BaseBx.Location = new System.Drawing.Point(140, 10);
            this.BaseBx.Name = "BaseBx";
            this.BaseBx.Size = new System.Drawing.Size(420, 25);
            this.BaseBx.TabIndex = 31;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 285);
            this.Controls.Add(this.BaseBx);
            this.Controls.Add(this.FullMaskCpyBtn);
            this.Controls.Add(this.FullMaskLbl);
            this.Controls.Add(this.FullMaskBx);
            this.Controls.Add(this.SwapBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ArrayCpyBtn);
            this.Controls.Add(this.ArrayLbl);
            this.Controls.Add(this.ArrayBx);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.CodeCpyBtn);
            this.Controls.Add(this.CodeLbl);
            this.Controls.Add(this.CodeBx);
            this.Controls.Add(this.HalfMaskCpyBtn);
            this.Controls.Add(this.HalfMaskLbl);
            this.Controls.Add(this.HalfMaskBx);
            this.Controls.Add(this.DifferenceCpyBtn);
            this.Controls.Add(this.DifferenceLbl);
            this.Controls.Add(this.DifferenceBx);
            this.Controls.Add(this.ComparePstBtn);
            this.Controls.Add(this.CompareCpyBtn);
            this.Controls.Add(this.BasePstBtn);
            this.Controls.Add(this.BaseCpyBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.CompareBtn);
            this.Controls.Add(this.CompareBx);
            this.Controls.Add(this.CompareLbl);
            this.Controls.Add(this.BaseLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SigKit v1.0";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BaseLbl;
        private System.Windows.Forms.TextBox CompareBx;
        private System.Windows.Forms.Label CompareLbl;
        private System.Windows.Forms.Button CompareBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button BaseCpyBtn;
        private System.Windows.Forms.Button BasePstBtn;
        private System.Windows.Forms.Button ComparePstBtn;
        private System.Windows.Forms.Button CompareCpyBtn;
        private System.Windows.Forms.TextBox DifferenceBx;
        private System.Windows.Forms.Label DifferenceLbl;
        private System.Windows.Forms.Button DifferenceCpyBtn;
        private System.Windows.Forms.Button HalfMaskCpyBtn;
        private System.Windows.Forms.Label HalfMaskLbl;
        private System.Windows.Forms.TextBox HalfMaskBx;
        private System.Windows.Forms.Button CodeCpyBtn;
        private System.Windows.Forms.Label CodeLbl;
        private System.Windows.Forms.TextBox CodeBx;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Button ArrayCpyBtn;
        private System.Windows.Forms.Label ArrayLbl;
        private System.Windows.Forms.TextBox ArrayBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SwapBtn;
        private System.Windows.Forms.Button FullMaskCpyBtn;
        private System.Windows.Forms.Label FullMaskLbl;
        private System.Windows.Forms.TextBox FullMaskBx;
        private System.Windows.Forms.ComboBox BaseBx;
    }
}

