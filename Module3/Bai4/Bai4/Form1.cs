using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class frmGiaiPhuongTrinh : Form
    {
        public frmGiaiPhuongTrinh()
        {
            InitializeComponent();
        }
        double a, b, c, delta, x1, x2;

        private void rdBac2_CheckedChanged(object sender, EventArgs e)
        {
            txtKetQua.Enabled = true;
            this.txtA.ResetText();
            this.txtB.ResetText();
            this.txtC.ResetText();
            this.txtKetQua.ResetText();
        }

        private void rdBac1_CheckedChanged(object sender, EventArgs e)
        {
            txtKetQua.Enabled = false;
            this.txtA.ResetText();
            this.txtB.ResetText();
            this.txtKetQua.ResetText();
        }

        string s;

        private void btnGiai_Click(object sender, EventArgs e)
        {
            if (rdBac1.Checked == true)
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                if (a == 0)
                    if (b == 0)
                        txtKetQua.Text = "Phuong trinh co vo so nghiem";
                    else
                        txtKetQua.Text = "Phuong trinh vo nghiem";
                else
                    txtKetQua.Text = " Phuong trinh co nghiem " + ((-b) / a).ToString();
            }
            if (rdBac2.Checked == true)
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                if (a == 0)
                    if (b == 0)
                        if (c == 0)
                            txtKetQua.Text = "Phương trình có vô số nghiệm";
                        else
                            txtKetQua.Text = "Phương trình vô nghiệm";
                    else
                        txtKetQua.Text = "Phương trình có nghiệm" + ((-c) / b).ToString();
                else
                {
                    delta = (b * b) - (4 * a * c);
                    if (delta < 0)
                        txtKetQua.Text = "Phương trình vô nghiệm";
                    else
                    {
                        if (delta == 0)
                            txtKetQua.Text = "Phương trình có 1 nghiệm" + ((-b) / 2 * a).ToString();
                        else
                        {
                            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                            txtKetQua.Text = "Phương trình có 2 nghiệm" + "x1 =" + x1 + "x2=" + x2;
                        }
                    }
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
//Phương trình có vô số nghiệm
//Phương trình có nghiệm
//Phương trình có 2 nghiệm

