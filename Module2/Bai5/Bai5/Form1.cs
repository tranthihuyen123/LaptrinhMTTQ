using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Text = txtNhapTen.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.ForeColor = Color.Red;
            txtNhapTen.ForeColor = Color.Red;

        }

        private void RadGreen_CheckedChanged(object sender, EventArgs e)
        {

            txtLapTrinh.ForeColor = Color.Green;
            txtNhapTen.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {

            txtLapTrinh.ForeColor = Color.Blue;
            txtNhapTen.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {

            txtLapTrinh.ForeColor = Color.Black;
            txtNhapTen.ForeColor = Color.Black;
        }

        private void chkDam_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Font = new Font(txtLapTrinh.Font.Name,
                txtLapTrinh.Font.Size, txtLapTrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkNghieng_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Font = new Font(txtLapTrinh.Font.Name,
                txtLapTrinh.Font.Size, txtLapTrinh.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Font = new Font(txtLapTrinh.Font.Name,
                txtLapTrinh.Font.Size, txtLapTrinh.Font.Style ^ FontStyle.Underline);
        }
    }
}
