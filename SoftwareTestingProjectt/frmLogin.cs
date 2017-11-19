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


namespace SoftwareTestingProjectt
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string pass = txtPassword.Text;
            string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=SoftwareTestingProject;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);
            cmd.Parameters.AddWithValue("Name", name);
            cmd.Parameters.AddWithValue("Password", pass);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                User u = new User();
                while (reader.Read() == true)
                {
                    if((reader[1].ToString() == name) && (reader[3].ToString() == pass))
                    {
                        u.UsersID = Convert.ToInt32(reader[0]);
                        u.Name = reader[1].ToString();
                        u.Surname = reader[2].ToString();
                        u.Password = reader[3].ToString();
                        u.UserRolesID = Convert.ToInt32(reader[4]);
                        u.ConnectsID = Convert.ToInt32(reader[5]);
                        u.isActive = Convert.ToBoolean(reader[6]);
                    }
                }
                if(u.Name == null)
                {
                    MessageBox.Show("Please enter your informations as correct.");
                    txtUserName.Focus();
                }
                else
                {
                    int UsersID = u.UsersID;
                    reader.Close();
                    cmd.CommandText = "UPDATE Users SET isActive='true' WHERE UsersID = @UsersID";
                    cmd.Parameters.AddWithValue("UsersID", @UsersID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(u.Name + " is successfully logged in.");
                    if (u.UserRolesID == 1)
                    {
                        frmListOfProjects lopp = new frmListOfProjects();
                        lopp.Show();
                    }
                    if(u.UserRolesID == 2)
                    {
                        frmInsertProject ip = new frmInsertProject();
                        ip.Show();
                    }
                    if(u.UserRolesID == 3)
                    {
                        //TODO redirect
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
