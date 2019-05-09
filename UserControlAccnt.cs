using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSharpSecurityInformationSystem
{
    public partial class UserControlAccnt : UserControl
    {
        CryptoClass EncryptClass = new CryptoClass();
        public UserControlAccnt()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            MySqlConnection Mysqlcon = new MySqlConnection(constring.connect);
            MySqlCommand Mysqlcmd = new MySqlCommand("Insert Into users (user_name,user_pass,user_type)VALUES(@user_name,@user_pass,@user_type)",Mysqlcon);
            Mysqlcmd.Parameters.AddWithValue("@user_name", txtbxusernam.Text);
            Mysqlcmd.Parameters.AddWithValue("@user_pass", EncryptClass.Encrypt(txtbxuserpass.Text));
            Mysqlcmd.Parameters.AddWithValue("@user_type", cmbxusertype.Text);
            Mysqlcon.Open();
            Mysqlcmd.ExecuteNonQuery();
            MessageBox.Show("Account Saved", "Notification", MessageBoxButtons.OK);
            Mysqlcon.Close();
            loadGrid();
            clrtxtbx();
           
        }

        private void clrtxtbx()
        {
            lbluserid.Text = "";
            txtbxusernam.Clear();
            txtbxuserpass.Clear();
            //cmbxusertype.Text = "";
            cmbxusertype.SelectedIndex = -1;
                 
        }

        private void UserControlAccnt_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void loadGrid() {
            MySqlConnection Mysqlcon = new MySqlConnection(constring.connect);
            //MySqlDataAdapter MysqlAdap = new MySqlDataAdapter("Select * From users Order by user_id", Mysqlcon);
            MySqlDataAdapter MysqlAdap = new MySqlDataAdapter("Select user_id,user_name,user_type From users Order by user_id", Mysqlcon);
            DataSet datset = new DataSet();
            MysqlAdap.Fill(datset);
            dgvaccnts.DataSource = datset.Tables[0].DefaultView;
    }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvaccnts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dgvaccnts.Rows[index];
            lbluserid.Text = selectedrow.Cells[0].Value.ToString();
            txtbxusernam.Text = selectedrow.Cells[1].Value.ToString();
            txtbxuserpass.Text = selectedrow.Cells[2].Value.ToString();
            cmbxusertype.Text = selectedrow.Cells[3].Value.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clrtxtbx();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
            MySqlConnection Mysqlcon = new MySqlConnection(constring.connect);
            MySqlCommand Mysqlcmd = new MySqlCommand("Delete From 'informationsysdb'.'users' where 'users'.'user_id'=@user_id",Mysqlcon);
            Mysqlcmd.Parameters.AddWithValue("@user_id", lbluserid.Text);
            Mysqlcon.Open();
            Mysqlcmd.ExecuteNonQuery();
            MessageBox.Show("Account Deleted", "Notification", MessageBoxButtons.OK);
            Mysqlcon.Close();
            clrtxtbx();
            loadGrid();
            
        
        
        }
       

    }
}
