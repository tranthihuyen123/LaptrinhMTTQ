using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class frmBaiTapHoTen : Form
    {
        public frmBaiTapHoTen()
        {
            InitializeComponent();
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHoLot.Text;
        }

        private void lblTen_Click(object sender, EventArgs e)
        {

        }

        private void txtHoLot_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHo_Click(object sender, EventArgs e)
        {

        }

        private void frmBaiTapHoTen_Load(object sender, EventArgs e)
        {

        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void btnHoVaTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHoLot.Text + " " + txtTen.Text;
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = " ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
