namespace Bai6
{
    partial class frmMessage
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
            this.lblNameMessage = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.btnDislay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkMessageVisible = new System.Windows.Forms.CheckBox();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBig = new System.Windows.Forms.PictureBox();
            this.picSmall = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameMessage
            // 
            this.lblNameMessage.AutoSize = true;
            this.lblNameMessage.Location = new System.Drawing.Point(23, 9);
            this.lblNameMessage.Name = "lblNameMessage";
            this.lblNameMessage.Size = new System.Drawing.Size(181, 20);
            this.lblNameMessage.TabIndex = 0;
            this.lblNameMessage.Text = "Input Name và Message";
            this.lblNameMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(57, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(57, 91);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(78, 20);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Message:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtName.Location = new System.Drawing.Point(137, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(537, 26);
            this.txtName.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMessage.Location = new System.Drawing.Point(137, 85);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(537, 26);
            this.txtMessage.TabIndex = 4;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblColor.Location = new System.Drawing.Point(3, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(46, 20);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(3, 1);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(54, 20);
            this.lblAction.TabIndex = 6;
            this.lblAction.Text = "Action";
            this.lblAction.Click += new System.EventHandler(this.lblAction_Click);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(78, 215);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(64, 24);
            this.radRed.TabIndex = 7;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = false;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radGreen.ForeColor = System.Drawing.Color.Lime;
            this.radGreen.Location = new System.Drawing.Point(78, 261);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(79, 24);
            this.radGreen.TabIndex = 8;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = false;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(77, 305);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(66, 24);
            this.radBlue.TabIndex = 6;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = false;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radBlack.Location = new System.Drawing.Point(78, 357);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(73, 24);
            this.radBlack.TabIndex = 7;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = false;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // btnDislay
            // 
            this.btnDislay.Location = new System.Drawing.Point(32, 33);
            this.btnDislay.Name = "btnDislay";
            this.btnDislay.Size = new System.Drawing.Size(90, 38);
            this.btnDislay.TabIndex = 11;
            this.btnDislay.Text = "Display";
            this.btnDislay.UseVisualStyleBackColor = true;
            this.btnDislay.Click += new System.EventHandler(this.btnDislay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(32, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 39);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(32, 147);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 37);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkMessageVisible
            // 
            this.chkMessageVisible.AutoSize = true;
            this.chkMessageVisible.Location = new System.Drawing.Point(287, 182);
            this.chkMessageVisible.Name = "chkMessageVisible";
            this.chkMessageVisible.Size = new System.Drawing.Size(150, 24);
            this.chkMessageVisible.TabIndex = 14;
            this.chkMessageVisible.Text = "Message Visible";
            this.chkMessageVisible.UseVisualStyleBackColor = true;
            this.chkMessageVisible.CheckedChanged += new System.EventHandler(this.chkMessageVisible_CheckedChanged);
            // 
            // txtMain
            // 
            this.txtMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMain.Location = new System.Drawing.Point(-2, 422);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(694, 26);
            this.txtMain.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Location = new System.Drawing.Point(61, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 212);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnDislay);
            this.panel2.Controls.Add(this.lblAction);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(497, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 212);
            this.panel2.TabIndex = 23;
            // 
            // picBig
            // 
            this.picBig.Image = global::Bai6.Properties.Resources.CD_ROM;
            this.picBig.Location = new System.Drawing.Point(309, 258);
            this.picBig.Name = "picBig";
            this.picBig.Size = new System.Drawing.Size(100, 50);
            this.picBig.TabIndex = 20;
            this.picBig.TabStop = false;
            // 
            // picSmall
            // 
            this.picSmall.ErrorImage = null;
            this.picSmall.Image = global::Bai6.Properties.Resources.CD_ROM1;
            this.picSmall.Location = new System.Drawing.Point(328, 211);
            this.picSmall.Name = "picSmall";
            this.picSmall.Size = new System.Drawing.Size(68, 42);
            this.picSmall.TabIndex = 15;
            this.picSmall.TabStop = false;
            this.picSmall.Visible = false;
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.picBig);
            this.Controls.Add(this.picSmall);
            this.Controls.Add(this.chkMessageVisible);
            this.Controls.Add(this.radBlack);
            this.Controls.Add(this.radBlue);
            this.Controls.Add(this.radGreen);
            this.Controls.Add(this.radRed);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmMessage";
            this.Text = "Message Formater";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameMessage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.Button btnDislay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkMessageVisible;
        private System.Windows.Forms.PictureBox picSmall;
        private System.Windows.Forms.PictureBox picBig;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

