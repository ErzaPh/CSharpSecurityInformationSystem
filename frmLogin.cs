using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSharpSecurityInformationSystem
{
    public partial class frmLogin : Form
    {
       constring connect = new constring();
       CryptoClass c1 = new CryptoClass();
        public frmLogin()
        {
             InitializeComponent();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close","Notification",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               // this.Close();
                System.Windows.Forms.Application.Exit();
              
            }
            else
            {

            }
        }

        private void btnlgn_Click(object sender, EventArgs e)
        {
            MySqlCommand MysqlCom = new MySqlCommand("",connect);
            frmMain frmmain = new frmMain();
            this.Hide();
            frmmain.Show();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
