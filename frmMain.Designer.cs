namespace CSharpSecurityInformationSystem
{
    partial class frmMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.abovepanel = new System.Windows.Forms.Panel();
            this.lblexit = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.btnAccnts = new System.Windows.Forms.Button();
            this.userControlAccnt1 = new CSharpSecurityInformationSystem.UserControlAccnt();
            this.userControlEmp1 = new CSharpSecurityInformationSystem.UserControlEmp();
            this.userControlPos1 = new CSharpSecurityInformationSystem.UserControlPos();
            this.userControlReports1 = new CSharpSecurityInformationSystem.UserControlReports();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelMenu.Controls.Add(this.abovepanel);
            this.panelMenu.Controls.Add(this.lblexit);
            this.panelMenu.Controls.Add(this.Label1);
            this.panelMenu.Controls.Add(this.Label2);
            this.panelMenu.Controls.Add(this.btnReports);
            this.panelMenu.Controls.Add(this.btnPos);
            this.panelMenu.Controls.Add(this.btnEmp);
            this.panelMenu.Controls.Add(this.btnAccnts);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1129, 102);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // abovepanel
            // 
            this.abovepanel.BackColor = System.Drawing.Color.White;
            this.abovepanel.Location = new System.Drawing.Point(232, 5);
            this.abovepanel.Name = "abovepanel";
            this.abovepanel.Size = new System.Drawing.Size(112, 10);
            this.abovepanel.TabIndex = 12;
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblexit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.White;
            this.lblexit.Location = new System.Drawing.Point(1074, 5);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(52, 15);
            this.lblexit.TabIndex = 11;
            this.lblexit.Text = "Logout";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(37, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 28);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Secure";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Label2.Location = new System.Drawing.Point(120, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 55);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "It";
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReports.BackgroundImage = global::CSharpSecurityInformationSystem.Properties.Resources.icons8_Report_Card_48px;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(586, 12);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(112, 87);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnPos
            // 
            this.btnPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPos.BackgroundImage = global::CSharpSecurityInformationSystem.Properties.Resources.icons8_Investment_48px;
            this.btnPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPos.FlatAppearance.BorderSize = 0;
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPos.ForeColor = System.Drawing.Color.White;
            this.btnPos.Location = new System.Drawing.Point(468, 12);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(112, 87);
            this.btnPos.TabIndex = 0;
            this.btnPos.Text = "Positions";
            this.btnPos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPos.UseVisualStyleBackColor = false;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEmp.BackgroundImage = global::CSharpSecurityInformationSystem.Properties.Resources.icons8_Name_Tag_48px;
            this.btnEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmp.FlatAppearance.BorderSize = 0;
            this.btnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmp.ForeColor = System.Drawing.Color.White;
            this.btnEmp.Location = new System.Drawing.Point(350, 12);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(112, 87);
            this.btnEmp.TabIndex = 0;
            this.btnEmp.Text = "Employee";
            this.btnEmp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // btnAccnts
            // 
            this.btnAccnts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAccnts.BackgroundImage = global::CSharpSecurityInformationSystem.Properties.Resources.icons8_User_48px_3;
            this.btnAccnts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccnts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccnts.FlatAppearance.BorderSize = 0;
            this.btnAccnts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccnts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccnts.ForeColor = System.Drawing.Color.White;
            this.btnAccnts.Location = new System.Drawing.Point(232, 12);
            this.btnAccnts.Name = "btnAccnts";
            this.btnAccnts.Size = new System.Drawing.Size(112, 87);
            this.btnAccnts.TabIndex = 0;
            this.btnAccnts.Text = "Accounts";
            this.btnAccnts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccnts.UseVisualStyleBackColor = false;
            this.btnAccnts.Click += new System.EventHandler(this.btnAccnts_Click);
            // 
            // userControlAccnt1
            // 
            this.userControlAccnt1.BackColor = System.Drawing.Color.White;
            this.userControlAccnt1.Location = new System.Drawing.Point(0, 101);
            this.userControlAccnt1.Name = "userControlAccnt1";
            this.userControlAccnt1.Size = new System.Drawing.Size(1129, 630);
            this.userControlAccnt1.TabIndex = 1;
            // 
            // userControlEmp1
            // 
            this.userControlEmp1.Location = new System.Drawing.Point(2, 101);
            this.userControlEmp1.Name = "userControlEmp1";
            this.userControlEmp1.Size = new System.Drawing.Size(1129, 630);
            this.userControlEmp1.TabIndex = 2;
            // 
            // userControlPos1
            // 
            this.userControlPos1.Location = new System.Drawing.Point(0, 139);
            this.userControlPos1.Name = "userControlPos1";
            this.userControlPos1.Size = new System.Drawing.Size(1129, 592);
            this.userControlPos1.TabIndex = 3;
            // 
            // userControlReports1
            // 
            this.userControlReports1.Location = new System.Drawing.Point(0, 101);
            this.userControlReports1.Name = "userControlReports1";
            this.userControlReports1.Size = new System.Drawing.Size(1129, 630);
            this.userControlReports1.TabIndex = 4;
            this.userControlReports1.Load += new System.EventHandler(this.userControlReports1_Load);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 733);
            this.Controls.Add(this.userControlReports1);
            this.Controls.Add(this.userControlPos1);
            this.Controls.Add(this.userControlEmp1);
            this.Controls.Add(this.userControlAccnt1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAccnts;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Panel abovepanel;
        private UserControlAccnt userControlAccnt1;
        private UserControlEmp userControlEmp1;
        private UserControlPos userControlPos1;
        private UserControlReports userControlReports1;
    }
}