namespace CSharpSecurityInformationSystem
{
    partial class frmLogin
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnlgn = new System.Windows.Forms.Button();
            this.txtuserpass = new System.Windows.Forms.TextBox();
            this.txtbxusernam = new System.Windows.Forms.TextBox();
            this.lblexit = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(216, 386);
            this.Panel1.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(43, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 28);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Secure";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Label2.Location = new System.Drawing.Point(126, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 55);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "It";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = global::CSharpSecurityInformationSystem.Properties.Resources._lock;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox1.Location = new System.Drawing.Point(30, 106);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(162, 174);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Label4.Location = new System.Drawing.Point(244, 158);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 18);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Password  :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Label3.Location = new System.Drawing.Point(244, 106);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(99, 18);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Username :";
            // 
            // btnlgn
            // 
            this.btnlgn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnlgn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlgn.FlatAppearance.BorderSize = 0;
            this.btnlgn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlgn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlgn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlgn.Location = new System.Drawing.Point(275, 212);
            this.btnlgn.Name = "btnlgn";
            this.btnlgn.Size = new System.Drawing.Size(100, 33);
            this.btnlgn.TabIndex = 9;
            this.btnlgn.Text = "Login";
            this.btnlgn.UseVisualStyleBackColor = false;
            this.btnlgn.Click += new System.EventHandler(this.btnlgn_Click);
            // 
            // txtuserpass
            // 
            this.txtuserpass.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserpass.Location = new System.Drawing.Point(247, 179);
            this.txtuserpass.Name = "txtuserpass";
            this.txtuserpass.PasswordChar = '•';
            this.txtuserpass.Size = new System.Drawing.Size(155, 27);
            this.txtuserpass.TabIndex = 8;
            this.txtuserpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbxusernam
            // 
            this.txtbxusernam.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxusernam.Location = new System.Drawing.Point(247, 127);
            this.txtbxusernam.Name = "txtbxusernam";
            this.txtbxusernam.Size = new System.Drawing.Size(155, 27);
            this.txtbxusernam.TabIndex = 5;
            this.txtbxusernam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblexit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblexit.Location = new System.Drawing.Point(402, 0);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(18, 18);
            this.lblexit.TabIndex = 10;
            this.lblexit.Text = "X";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 386);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnlgn);
            this.Controls.Add(this.txtuserpass);
            this.Controls.Add(this.txtbxusernam);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnlgn;
        internal System.Windows.Forms.TextBox txtuserpass;
        internal System.Windows.Forms.TextBox txtbxusernam;
        internal System.Windows.Forms.Label lblexit;
    }
}

