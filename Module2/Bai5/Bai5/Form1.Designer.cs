namespace Bai5
{
    partial class frm
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
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.lblLapTrinh = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.txtLapTrinh = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.RadGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.chkDam = new System.Windows.Forms.CheckBox();
            this.chkNghieng = new System.Windows.Forms.CheckBox();
            this.chkGachChan = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.AutoSize = true;
            this.lblNhapTen.ForeColor = System.Drawing.Color.Lime;
            this.lblNhapTen.Location = new System.Drawing.Point(46, 19);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(82, 20);
            this.lblNhapTen.TabIndex = 3;
            this.lblNhapTen.Text = "Nhập Tên:";
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.AutoSize = true;
            this.lblLapTrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLapTrinh.Location = new System.Drawing.Point(46, 372);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(110, 20);
            this.lblLapTrinh.TabIndex = 4;
            this.lblLapTrinh.Text = "Lập Trình Bởi :";
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Location = new System.Drawing.Point(163, 16);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(100, 26);
            this.txtNhapTen.TabIndex = 5;
            this.txtNhapTen.TextChanged += new System.EventHandler(this.txtNhapTen_TextChanged);
            // 
            // txtLapTrinh
            // 
            this.txtLapTrinh.Location = new System.Drawing.Point(163, 369);
            this.txtLapTrinh.Name = "txtLapTrinh";
            this.txtLapTrinh.Size = new System.Drawing.Size(174, 26);
            this.txtLapTrinh.TabIndex = 6;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(50, 85);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(46, 20);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(313, 85);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(42, 20);
            this.lblFont.TabIndex = 8;
            this.lblFont.Text = "Font";
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Checked = true;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(86, 130);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(64, 24);
            this.radRed.TabIndex = 9;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // RadGreen
            // 
            this.RadGreen.AutoSize = true;
            this.RadGreen.ForeColor = System.Drawing.Color.Lime;
            this.RadGreen.Location = new System.Drawing.Point(86, 176);
            this.RadGreen.Name = "RadGreen";
            this.RadGreen.Size = new System.Drawing.Size(79, 24);
            this.RadGreen.TabIndex = 10;
            this.RadGreen.Text = "Green";
            this.RadGreen.UseVisualStyleBackColor = true;
            this.RadGreen.CheckedChanged += new System.EventHandler(this.RadGreen_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(86, 229);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(66, 24);
            this.radBlue.TabIndex = 11;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Location = new System.Drawing.Point(86, 271);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(73, 24);
            this.radBlack.TabIndex = 12;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // chkDam
            // 
            this.chkDam.AutoSize = true;
            this.chkDam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDam.Location = new System.Drawing.Point(351, 129);
            this.chkDam.Name = "chkDam";
            this.chkDam.Size = new System.Drawing.Size(113, 24);
            this.chkDam.TabIndex = 13;
            this.chkDam.Text = "Đậm Bold";
            this.chkDam.UseVisualStyleBackColor = true;
            this.chkDam.CheckedChanged += new System.EventHandler(this.chkDam_CheckedChanged);
            // 
            // chkNghieng
            // 
            this.chkNghieng.AutoSize = true;
            this.chkNghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNghieng.Location = new System.Drawing.Point(351, 175);
            this.chkNghieng.Name = "chkNghieng";
            this.chkNghieng.Size = new System.Drawing.Size(131, 24);
            this.chkNghieng.TabIndex = 14;
            this.chkNghieng.Text = "Nghiêng Italic";
            this.chkNghieng.UseVisualStyleBackColor = true;
            this.chkNghieng.CheckedChanged += new System.EventHandler(this.chkNghieng_CheckedChanged);
            // 
            // chkGachChan
            // 
            this.chkGachChan.AutoSize = true;
            this.chkGachChan.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachChan.Location = new System.Drawing.Point(351, 217);
            this.chkGachChan.Name = "chkGachChan";
            this.chkGachChan.Size = new System.Drawing.Size(118, 24);
            this.chkGachChan.TabIndex = 15;
            this.chkGachChan.Text = "Gạch Chân";
            this.chkGachChan.UseVisualStyleBackColor = true;
            this.chkGachChan.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(482, 353);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 57);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.chkGachChan);
            this.Controls.Add(this.chkNghieng);
            this.Controls.Add(this.chkDam);
            this.Controls.Add(this.radBlack);
            this.Controls.Add(this.radBlue);
            this.Controls.Add(this.RadGreen);
            this.Controls.Add(this.radRed);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtLapTrinh);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.lblNhapTen);
            this.Name = "frm";
            this.Text = "Định Dạng (Formater)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.Label lblLapTrinh;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.TextBox txtLapTrinh;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton RadGreen;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.CheckBox chkDam;
        private System.Windows.Forms.CheckBox chkNghieng;
        private System.Windows.Forms.CheckBox chkGachChan;
        private System.Windows.Forms.Button btnThoat;
    }
}

