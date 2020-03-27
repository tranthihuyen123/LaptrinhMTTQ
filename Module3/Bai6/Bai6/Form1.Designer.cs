namespace Bai6
{
    partial class frmQuanLySach
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
            this.lblChuongTrinh = new System.Windows.Forms.Label();
            this.gbHoaDon = new System.Windows.Forms.GroupBox();
            this.gbThongke = new System.Windows.Forms.GroupBox();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblSinhVien = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.lblTongSinhVien = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.chbKhachHang = new System.Windows.Forms.CheckBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.gbHoaDon.SuspendLayout();
            this.gbThongke.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChuongTrinh
            // 
            this.lblChuongTrinh.AutoSize = true;
            this.lblChuongTrinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuongTrinh.Location = new System.Drawing.Point(26, 23);
            this.lblChuongTrinh.Name = "lblChuongTrinh";
            this.lblChuongTrinh.Size = new System.Drawing.Size(552, 32);
            this.lblChuongTrinh.TabIndex = 0;
            this.lblChuongTrinh.Text = "CHƯƠNG TRÌNH TÍNH TIỀN BÁN SÁCH";
            // 
            // gbHoaDon
            // 
            this.gbHoaDon.Controls.Add(this.chbKhachHang);
            this.gbHoaDon.Controls.Add(this.textBox3);
            this.gbHoaDon.Controls.Add(this.textBox2);
            this.gbHoaDon.Controls.Add(this.textBox1);
            this.gbHoaDon.Controls.Add(this.lblThanhTien);
            this.gbHoaDon.Controls.Add(this.lblSinhVien);
            this.gbHoaDon.Controls.Add(this.lblSoLuong);
            this.gbHoaDon.Controls.Add(this.lblTenKhach);
            this.gbHoaDon.Location = new System.Drawing.Point(19, 72);
            this.gbHoaDon.Name = "gbHoaDon";
            this.gbHoaDon.Size = new System.Drawing.Size(576, 200);
            this.gbHoaDon.TabIndex = 1;
            this.gbHoaDon.TabStop = false;
            this.gbHoaDon.Text = "Hóa Đơn";
            // 
            // gbThongke
            // 
            this.gbThongke.Controls.Add(this.textBox6);
            this.gbThongke.Controls.Add(this.textBox5);
            this.gbThongke.Controls.Add(this.textBox4);
            this.gbThongke.Controls.Add(this.lblTongDoanhThu);
            this.gbThongke.Controls.Add(this.lblTongSinhVien);
            this.gbThongke.Controls.Add(this.lblTongSo);
            this.gbThongke.Location = new System.Drawing.Point(19, 325);
            this.gbThongke.Name = "gbThongke";
            this.gbThongke.Size = new System.Drawing.Size(576, 202);
            this.gbThongke.TabIndex = 2;
            this.gbThongke.TabStop = false;
            this.gbThongke.Text = "Thống Kê";
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Location = new System.Drawing.Point(22, 25);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(132, 20);
            this.lblTenKhach.TabIndex = 0;
            this.lblTenKhach.Text = "Tên Khách Hàng:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(27, 76);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(123, 20);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "Số Lượng Sách:";
            // 
            // lblSinhVien
            // 
            this.lblSinhVien.AutoSize = true;
            this.lblSinhVien.Location = new System.Drawing.Point(22, 126);
            this.lblSinhVien.Name = "lblSinhVien";
            this.lblSinhVien.Size = new System.Drawing.Size(149, 20);
            this.lblSinhVien.TabIndex = 2;
            this.lblSinhVien.Text = "Khách Hàng Là SV:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(22, 171);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(92, 20);
            this.lblThanhTien.TabIndex = 3;
            this.lblThanhTien.Text = "Thành Tiền:";
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Location = new System.Drawing.Point(27, 34);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(99, 20);
            this.lblTongSo.TabIndex = 0;
            this.lblTongSo.Text = "Tổng Số KH:";
            // 
            // lblTongSinhVien
            // 
            this.lblTongSinhVien.AutoSize = true;
            this.lblTongSinhVien.Location = new System.Drawing.Point(22, 85);
            this.lblTongSinhVien.Name = "lblTongSinhVien";
            this.lblTongSinhVien.Size = new System.Drawing.Size(141, 20);
            this.lblTongSinhVien.TabIndex = 1;
            this.lblTongSinhVien.Text = "Tổng Số KH là SV:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(27, 138);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(132, 20);
            this.lblTongDoanhThu.TabIndex = 2;
            this.lblTongDoanhThu.Text = "Tổng Doanh Thu:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(199, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(337, 26);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(199, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(337, 26);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(199, 79);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(337, 26);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(199, 132);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(337, 26);
            this.textBox6.TabIndex = 5;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chbKhachHang
            // 
            this.chbKhachHang.AutoSize = true;
            this.chbKhachHang.Location = new System.Drawing.Point(199, 127);
            this.chbKhachHang.Name = "chbKhachHang";
            this.chbKhachHang.Size = new System.Drawing.Size(22, 21);
            this.chbKhachHang.TabIndex = 7;
            this.chbKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(58, 277);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(87, 41);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Tính TT";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Enter += new System.EventHandler(this.btnTinh_Enter);
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(186, 278);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(103, 41);
            this.btnTiep.TabIndex = 4;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(327, 278);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(103, 41);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(467, 278);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(111, 41);
            this.btnKetThuc.TabIndex = 6;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // frmQuanLySach
            // 
            this.AcceptButton = this.btnTinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 539);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.gbThongke);
            this.Controls.Add(this.gbHoaDon);
            this.Controls.Add(this.lblChuongTrinh);
            this.Name = "frmQuanLySach";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sách";
            this.gbHoaDon.ResumeLayout(false);
            this.gbHoaDon.PerformLayout();
            this.gbThongke.ResumeLayout(false);
            this.gbThongke.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChuongTrinh;
        private System.Windows.Forms.GroupBox gbHoaDon;
        private System.Windows.Forms.CheckBox chbKhachHang;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblSinhVien;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.GroupBox gbThongke;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTongSinhVien;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnKetThuc;
    }
}

