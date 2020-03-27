namespace Bai3
{
    partial class frmBaiTapHoTen
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
            this.lblHo = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHoLot = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoVaTen = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(67, 105);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(51, 20);
            this.lblHo.TabIndex = 0;
            this.lblHo.Text = "Họ lót";
            this.lblHo.Click += new System.EventHandler(this.lblHo_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(67, 157);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(36, 20);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên";
            this.lblTen.Click += new System.EventHandler(this.lblTen_Click);
            // 
            // txtHoLot
            // 
            this.txtHoLot.Location = new System.Drawing.Point(179, 99);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(243, 26);
            this.txtHoLot.TabIndex = 2;
            this.txtHoLot.TextChanged += new System.EventHandler(this.txtHoLot_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(179, 151);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(243, 26);
            this.txtTen.TabIndex = 3;
            // 
            // btnHoLot
            // 
            this.btnHoLot.Location = new System.Drawing.Point(69, 204);
            this.btnHoLot.Name = "btnHoLot";
            this.btnHoLot.Size = new System.Drawing.Size(88, 42);
            this.btnHoLot.TabIndex = 4;
            this.btnHoLot.Text = "Họ Lót";
            this.btnHoLot.UseVisualStyleBackColor = true;
            this.btnHoLot.Click += new System.EventHandler(this.btnHoLot_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(238, 204);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(92, 42);
            this.btnTen.TabIndex = 5;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoVaTen
            // 
            this.btnHoVaTen.Location = new System.Drawing.Point(406, 204);
            this.btnHoVaTen.Name = "btnHoVaTen";
            this.btnHoVaTen.Size = new System.Drawing.Size(107, 42);
            this.btnHoVaTen.TabIndex = 6;
            this.btnHoVaTen.Text = "Họ Và Tên";
            this.btnHoVaTen.UseVisualStyleBackColor = true;
            this.btnHoVaTen.Click += new System.EventHandler(this.btnHoVaTen_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(179, 277);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(203, 42);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát Chương Trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblHoTen.Location = new System.Drawing.Point(69, 9);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(450, 66);
            this.lblHoTen.TabIndex = 8;
            this.lblHoTen.Text = "                            ";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblHoTen.Click += new System.EventHandler(this.lblHoTen_Click);
            // 
            // frmBaiTapHoTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoVaTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHoLot);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHo);
            this.Name = "frmBaiTapHoTen";
            this.Text = "Bài Tập Họ Tên";
            this.Load += new System.EventHandler(this.frmBaiTapHoTen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHoLot;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoVaTen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblHoTen;
    }
}

