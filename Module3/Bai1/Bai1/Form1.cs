using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmTinhTien : Form
    {
        public frmTinhTien()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int SoLuong = 0;
            decimal DonGia, ThanhTien;

            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng hàng");
                txtSoLuong.Focus();
            }
            else if (txtDonGia.Text == "")
            {
                MessageBox.Show("Chua nhap don hang");
                txtDonGia.Focus();
            }
            else
                SoLuong = Convert.ToInt32(txtSoLuong.Text);
                DonGia = Convert.ToInt32(txtDonGia.Text);

            if (SoLuong <=0)
            {
                MessageBox.Show("So luong hang >0");
                txtSoLuong.SelectAll();
                txtSoLuong.Focus();
            }
            else if (DonGia < 0)
            {
                MessageBox.Show("Don gia > 0");
                txtDonGia.SelectAll();
                txtDonGia.Focus();
            }
            else
            {
                ThanhTien = SoLuong * DonGia;
                txtThanhTien.Text = ThanhTien.ToString();
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
                e.Handled = true;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Co chac la ban muon dong ung dung ?", "Warning",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                Close();


        }
    }
}
