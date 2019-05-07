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
       constring connection = new constring();
       CryptoClass c1 = new CryptoClass();
        public frmLogin()
        {
             InitializeComponent();
        }
        MySqlCommand Mysqlcmd;
        MySqlConnection Mysqlcon;
        MySqlDataReader Mysqldr;

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
            Mysqlcon = new MySqlConnection(constring.connect);
            Mysqlcmd = new MySqlCommand();
            Mysqlcmd.Connection = Mysqlcon;
            Mysqlcon.Open();
            Mysqlcmd.CommandText = "Select *  from dbsecinfosystem.users where user_name='" + this.txtbxusernam.Text + "' and user_pass='" + this.txtuserpass.Text + "'";
            Mysqldr = Mysqlcmd.ExecuteReader();
            if (Mysqldr.Read())
            {
                clrtxtbx();
                frmMain frmmain = new frmMain();
                this.Hide();
                frmmain.Show();
            }
            else
            {
                MessageBox.Show("Access Denied", "Notification", MessageBoxButtons.OK);
                clrtxtbx();
            }
          
           /* allquery AllQuery = new allquery();
            int numnum = 2;
            AllQuery.sampfunc(numnum);
            */
        }
        public void clrtxtbx()
        {
            txtbxusernam.Clear();
            txtuserpass.Clear();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
          
        }
    }
}
