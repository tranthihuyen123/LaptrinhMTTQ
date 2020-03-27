namespace Bai4
{
    partial class frmGiaiPhuongTrinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBac1 = new System.Windows.Forms.RadioButton();
            this.rdBac2 = new System.Windows.Forms.RadioButton();
            this.lblNhapA = new System.Windows.Forms.Label();
            this.lblNhapB = new System.Windows.Forms.Label();
            this.lblNhapc = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBac2);
            this.groupBox1.Controls.Add(this.rdBac1);
            this.groupBox1.Location = new System.Drawing.Point(144, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phương trình cần giải";
            // 
            // rdBac1
            // 
            this.rdBac1.AutoSize = true;
            this.rdBac1.Checked = true;
            this.rdBac1.Location = new System.Drawing.Point(43, 37);
            this.rdBac1.Name = "rdBac1";
            this.rdBac1.Size = new System.Drawing.Size(198, 24);
            this.rdBac1.TabIndex = 0;
            this.rdBac1.TabStop = true;
            this.rdBac1.Text = "Giải phương trình bậc 1";
            this.rdBac1.UseVisualStyleBackColor = true;
            this.rdBac1.CheckedChanged += new System.EventHandler(this.rdBac1_CheckedChanged);
            // 
            // rdBac2
            // 
            this.rdBac2.AutoSize = true;
            this.rdBac2.Location = new System.Drawing.Point(43, 84);
            this.rdBac2.Name = "rdBac2";
            this.rdBac2.Size = new System.Drawing.Size(198, 24);
            this.rdBac2.TabIndex = 1;
            this.rdBac2.Text = "Giải phương trình bậc 2";
            this.rdBac2.UseVisualStyleBackColor = true;
            this.rdBac2.CheckedChanged += new System.EventHandler(this.rdBac2_CheckedChanged);
            // 
            // lblNhapA
            // 
            this.lblNhapA.AutoSize = true;
            this.lblNhapA.Location = new System.Drawing.Point(67, 176);
            this.lblNhapA.Name = "lblNhapA";
            this.lblNhapA.Size = new System.Drawing.Size(60, 20);
            this.lblNhapA.TabIndex = 1;
            this.lblNhapA.Text = "Nhập a";
            // 
            // lblNhapB
            // 
            this.lblNhapB.AutoSize = true;
            this.lblNhapB.Location = new System.Drawing.Point(66, 228);
            this.lblNhapB.Name = "lblNhapB";
            this.lblNhapB.Size = new System.Drawing.Size(60, 20);
            this.lblNhapB.TabIndex = 2;
            this.lblNhapB.Text = "Nhập b";
            // 
            // lblNhapc
            // 
            this.lblNhapc.AutoSize = true;
            this.lblNhapc.Location = new System.Drawing.Point(68, 283);
            this.lblNhapc.Name = "lblNhapc";
            this.lblNhapc.Size = new System.Drawing.Size(59, 20);
            this.lblNhapc.TabIndex = 3;
            this.lblNhapc.Text = "Nhập c";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(154, 222);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 26);
            this.txtB.TabIndex = 4;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(154, 173);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 26);
            this.txtA.TabIndex = 5;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(154, 277);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 26);
            this.txtC.TabIndex = 6;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(154, 327);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(337, 26);
            this.txtKetQua.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả";
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(409, 216);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(82, 38);
            this.btnGiai.TabIndex = 9;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(239, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 38);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmGiaiPhuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblNhapc);
            this.Controls.Add(this.lblNhapB);
            this.Controls.Add(this.lblNhapA);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGiaiPhuongTrinh";
            this.Text = "Giải Phương Trình Bậc 1 - 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBac2;
        private System.Windows.Forms.RadioButton rdBac1;
        private System.Windows.Forms.Label lblNhapA;
        private System.Windows.Forms.Label lblNhapB;
        private System.Windows.Forms.Label lblNhapc;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnThoat;
    }
}

