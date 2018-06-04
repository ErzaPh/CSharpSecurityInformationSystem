using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSecurityInformationSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            abovepanel.Width = btnAccnts.Width;
           // abovepanel.Top = btnAccnts.Top;
            abovepanel.Location = new Point(232, 5);
            userControlAccnt1.BringToFront();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            

            DialogResult result = MessageBox.Show("Are you sure you want to Logout", "Notification", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                frmlogin.Show();
            }
            else
            {

            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAccnts_Click(object sender, EventArgs e)
        {
            abovepanel.Width = btnAccnts.Width;
            //abovepanel.Top = btnAccnts.Top;
            abovepanel.Location = new Point(232, 5);
            userControlAccnt1.BringToFront();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            abovepanel.Width = btnEmp.Width;
           // abovepanel.Top = btnEmp.Top;
            abovepanel.Location = new Point(350, 5);
            userControlEmp1.BringToFront();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            abovepanel.Width = btnPos.Width;
            abovepanel.Top = btnPos.Top;
            abovepanel.Location = new Point(468, 5);
            userControlPos1.BringToFront();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            abovepanel.Width = btnReports.Width;
            abovepanel.Top = btnReports.Top;
            abovepanel.Location = new Point(586, 5);
            userControlReports1.BringToFront();
        }

        private void userControlReports1_Load(object sender, EventArgs e)
        {

        }

  
    }
}
