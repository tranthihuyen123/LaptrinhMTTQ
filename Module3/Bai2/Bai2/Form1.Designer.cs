namespace Bai2
{
    partial class frmTinhDienTich
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
            this.lblChieuDsi = new System.Windows.Forms.Label();
            this.lblChieuRong = new System.Windows.Forms.Label();
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.txtDientich = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChieuDsi
            // 
            this.lblChieuDsi.AutoSize = true;
            this.lblChieuDsi.Location = new System.Drawing.Point(41, 24);
            this.lblChieuDsi.Name = "lblChieuDsi";
            this.lblChieuDsi.Size = new System.Drawing.Size(78, 20);
            this.lblChieuDsi.TabIndex = 0;
            this.lblChieuDsi.Text = "Chiều Dài";
            this.lblChieuDsi.Click += new System.EventHandler(this.lblNhapA_Click);
            // 
            // lblChieuRong
            // 
            this.lblChieuRong.AutoSize = true;
            this.lblChieuRong.Location = new System.Drawing.Point(41, 79);
            this.lblChieuRong.Name = "lblChieuRong";
            this.lblChieuRong.Size = new System.Drawing.Size(93, 20);
            this.lblChieuRong.TabIndex = 1;
            this.lblChieuRong.Text = "Chiều Rộng";
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(161, 17);
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(100, 26);
            this.txtChieuDai.TabIndex = 2;
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(161, 76);
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(100, 26);
            this.txtChieuRong.TabIndex = 3;
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(44, 194);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(75, 20);
            this.lblDienTich.TabIndex = 4;
            this.lblDienTich.Text = "Diện Tích";
            // 
            // txtDientich
            // 
            this.txtDientich.Location = new System.Drawing.Point(161, 188);
            this.txtDientich.Name = "txtDientich";
            this.txtDientich.Size = new System.Drawing.Size(100, 26);
            this.txtDientich.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(108, 126);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 35);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmTinhDienTich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 315);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtDientich);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.txtChieuRong);
            this.Controls.Add(this.txtChieuDai);
            this.Controls.Add(this.lblChieuRong);
            this.Controls.Add(this.lblChieuDsi);
            this.Name = "frmTinhDienTich";
            this.Text = "Tính diện tích hình chữ nhật";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChieuDsi;
        private System.Windows.Forms.Label lblChieuRong;
        private System.Windows.Forms.TextBox txtChieuDai;
        private System.Windows.Forms.TextBox txtChieuRong;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.TextBox txtDientich;
        private System.Windows.Forms.Button btnStart;
    }
}

