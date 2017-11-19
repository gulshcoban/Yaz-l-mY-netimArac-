using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Test_Aracı
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserNickname = txtUserName.Text;
            string UserPassword = txtPassword.Text;
            string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsers", con);
            cmd.Parameters.AddWithValue("UserNickname", UserNickname);
            cmd.Parameters.AddWithValue("UserPassword", UserPassword);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Users u = new Users();
                while (reader.Read() == true)
                {
                    if ((reader[3].ToString() == UserNickname) && (reader[4].ToString() == UserPassword))
                    {
                        u.UsersID = Convert.ToInt32(reader[0]);
                        u.UserName = reader[1].ToString();
                        u.UserSurname = reader[2].ToString();
                        u.UserNickname = reader[3].ToString();
                        u.UserPassword = reader[4].ToString();
                        u.UserRole = Convert.ToInt32(reader[5]);
                    }
                }
                if (u.UserNickname == null)
                {
                    MessageBox.Show("Please enter your informations as correct.");
                    txtUserName.Focus();
                }
                else
                {
                    int UsersID = u.UsersID;
                    reader.Close();
                    MessageBox.Show(u.UserNickname + " is successfully logged in.");
                    if (u.UserRole == 1)
                    {
                        frmListOfProjects lopp = new frmListOfProjects(UsersID);
                        lopp.Show();
                    }
                    if (u.UserRole == 2)
                    {
                        frmInsertProjects ip = new frmInsertProjects(UsersID);
                        ip.Show();
                    }
                    if (u.UserRole== 3)
                    {
                        frmListOfUserWorkFollow wf = new frmListOfUserWorkFollow();
                        wf.Show();
                    }
                }

            }
            txtPassword.Text = "";
            txtUserName.Text = "";
            con.Close();
        
    }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtUserName.Focus();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtPassword.Focus();
            }
        }
    }
}
