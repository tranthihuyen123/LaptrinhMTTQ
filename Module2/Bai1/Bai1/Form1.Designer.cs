namespace Bai1
{
    partial class frm1
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
            this.lblNhap = new System.Windows.Forms.Label();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(27, 13);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(124, 20);
            this.lblNhap.TabIndex = 0;
            this.lblNhap.Text = "Nhập Password:";
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Location = new System.Drawing.Point(27, 64);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(71, 20);
            this.lblHienThi.TabIndex = 1;
            this.lblHienThi.Text = "Hiển Thị:";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(185, 6);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(152, 26);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(185, 58);
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.Size = new System.Drawing.Size(152, 26);
            this.txtHienThi.TabIndex = 3;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(31, 118);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(120, 36);
            this.btnHienThi.TabIndex = 4;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(185, 118);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(126, 36);
            this.btnTiep.TabIndex = 5;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(345, 118);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(110, 36);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.lblNhap);
            this.Name = "frm1";
            this.Text = "Sử dụng Lable & Textbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnDong;
    }
}

