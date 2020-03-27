namespace Bai5
{
    partial class frmBanHang
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
            this.gbThongTinNhap = new System.Windows.Forms.GroupBox();
            this.gbThongKe = new System.Windows.Forms.GroupBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.btnBanMoi = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTrungBinh = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTrungBinh = new System.Windows.Forms.TextBox();
            this.gbThongTinNhap.SuspendLayout();
            this.gbThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongTinNhap
            // 
            this.gbThongTinNhap.Controls.Add(this.txtThanhTien);
            this.gbThongTinNhap.Controls.Add(this.txtDonGia);
            this.gbThongTinNhap.Controls.Add(this.txtSoLuong);
            this.gbThongTinNhap.Controls.Add(this.btnThoat);
            this.gbThongTinNhap.Controls.Add(this.btnTinh);
            this.gbThongTinNhap.Controls.Add(this.btnBanMoi);
            this.gbThongTinNhap.Controls.Add(this.lblThanhTien);
            this.gbThongTinNhap.Controls.Add(this.lblDonGia);
            this.gbThongTinNhap.Controls.Add(this.lblSoLuong);
            this.gbThongTinNhap.Location = new System.Drawing.Point(30, 13);
            this.gbThongTinNhap.Name = "gbThongTinNhap";
            this.gbThongTinNhap.Size = new System.Drawing.Size(648, 189);
            this.gbThongTinNhap.TabIndex = 0;
            this.gbThongTinNhap.TabStop = false;
            this.gbThongTinNhap.Text = "Thông tin nhập";
            // 
            // gbThongKe
            // 
            this.gbThongKe.Controls.Add(this.txtTrungBinh);
            this.gbThongKe.Controls.Add(this.txtTongTien);
            this.gbThongKe.Controls.Add(this.txtTong);
            this.gbThongKe.Controls.Add(this.lblTrungBinh);
            this.gbThongKe.Controls.Add(this.lblTongTien);
            this.gbThongKe.Controls.Add(this.lblTong);
            this.gbThongKe.Location = new System.Drawing.Point(30, 218);
            this.gbThongKe.Name = "gbThongKe";
            this.gbThongKe.Size = new System.Drawing.Size(648, 209);
            this.gbThongKe.TabIndex = 1;
            this.gbThongKe.TabStop = false;
            this.gbThongKe.Text = "Thông tin thống kê";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(33, 41);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(72, 20);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(33, 95);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(64, 20);
            this.lblDonGia.TabIndex = 1;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(33, 148);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(84, 20);
            this.lblThanhTien.TabIndex = 2;
            this.lblThanhTien.Text = "Thành tiền";
            // 
            // btnBanMoi
            // 
            this.btnBanMoi.Location = new System.Drawing.Point(514, 30);
            this.btnBanMoi.Name = "btnBanMoi";
            this.btnBanMoi.Size = new System.Drawing.Size(87, 36);
            this.btnBanMoi.TabIndex = 3;
            this.btnBanMoi.Text = "Bản Mới";
            this.btnBanMoi.UseVisualStyleBackColor = true;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(514, 85);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(87, 30);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(514, 133);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 35);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(156, 35);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(297, 26);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(156, 89);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(297, 26);
            this.txtDonGia.TabIndex = 7;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(156, 142);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(297, 26);
            this.txtThanhTien.TabIndex = 8;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(33, 45);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(109, 20);
            this.lblTong.TabIndex = 0;
            this.lblTong.Text = "Tổng số lượng";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(33, 99);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(75, 20);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // lblTrungBinh
            // 
            this.lblTrungBinh.AutoSize = true;
            this.lblTrungBinh.Location = new System.Drawing.Point(33, 153);
            this.lblTrungBinh.Name = "lblTrungBinh";
            this.lblTrungBinh.Size = new System.Drawing.Size(84, 20);
            this.lblTrungBinh.TabIndex = 2;
            this.lblTrungBinh.Text = "Trung bình";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(156, 38);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(297, 26);
            this.txtTong.TabIndex = 3;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(156, 92);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(297, 26);
            this.txtTongTien.TabIndex = 4;
            // 
            // txtTrungBinh
            // 
            this.txtTrungBinh.Location = new System.Drawing.Point(156, 146);
            this.txtTrungBinh.Name = "txtTrungBinh";
            this.txtTrungBinh.Size = new System.Drawing.Size(297, 26);
            this.txtTrungBinh.TabIndex = 5;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.gbThongKe);
            this.Controls.Add(this.gbThongTinNhap);
            this.Name = "frmBanHang";
            this.Text = "CHƯƠNG TRÌNH BÁN HÀNG";
            this.gbThongTinNhap.ResumeLayout(false);
            this.gbThongTinNhap.PerformLayout();
            this.gbThongKe.ResumeLayout(false);
            this.gbThongKe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTinNhap;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnBanMoi;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.GroupBox gbThongKe;
        private System.Windows.Forms.TextBox txtTrungBinh;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label lblTrungBinh;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTong;
    }
}

