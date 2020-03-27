using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAction_Click(object sender, EventArgs e)
        {

        }

        private void btnDislay_Click(object sender, EventArgs e)
        {
            txtMain.Text = txtName.Text + ":" + txtMessage.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            txtName.Clear();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            txtMain.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            txtMain.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtMain.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            txtMain.ForeColor = Color.Black;
        }

        private void chkMessageVisible_CheckedChanged(object sender, EventArgs e)
        {
            txtMain.Visible = chkMessageVisible.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
