using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmTinhDienTich : Form
    {
        public frmTinhDienTich()
        {
            InitializeComponent();
        }

        private void lblNhapA_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool check = true;
            try
            {
                double cd = double.Parse(txtChieuDai.Text);
            }
            catch
            {
                check = false;
                MessageBox.Show("Chiều dài không hợp lệ");
            }
            try
            {
                double cr = double.Parse(txtChieuDai.Text);
            }
            catch
            {
                check = false;
                MessageBox.Show("Chiều rộng không hợp lệ");
            }
            if ( check == true)
            {
                HinhChuNhat.ChieuDai = double.Parse(txtChieuDai.Text);
                HinhChuNhat.ChieuRong = double.Parse(txtChieuRong.Text);

                check = HinhChuNhat.KiemTraHinhChuNhat();
            }
            if (check == false)
            {
                MessageBox.Show("Đây không phải là hình chữ nhật");
            }
            else
            {
                txtDientich.Enabled = true;
                txtDientich.Text = HinhChuNhat.TinhDienTich().ToString();
            }
        }
    }
}
