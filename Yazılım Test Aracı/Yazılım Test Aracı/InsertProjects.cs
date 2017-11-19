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
    public partial class frmInsertProjects : Form
    {
        int UsersID;
        public frmInsertProjects(int usersID)
        {
            this.UsersID = usersID;
            InitializeComponent();
        }

        private void frmInsertProjects_Load(object sender, EventArgs e)
        {
            cmbisActive.Items.Add("True");
            cmbisActive.Items.Add("False");
            string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsers WHERE UsersID = @UsersID", con);
            cmd.Parameters.AddWithValue("UsersID", UsersID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Users u = new Users();
                while (reader.Read() == true)
                {
                    u.UserName = reader[1].ToString();
                    u.UserSurname = reader[2].ToString();
                }
                lblActivePerson.Text = u.UserName + " " + u.UserSurname;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string projectName = txtProjectName.Text;
            int budget = Convert.ToInt32(txtBudget.Text);
            DateTime startdate = Convert.ToDateTime(dtTimeStart.Text);
            DateTime finishdate = Convert.ToDateTime(dtTimeFinish.Text);
            bool isActive = Convert.ToBoolean(cmbisActive.Text);

            TimeSpan gunFarki = dtTimeFinish.Value.Subtract(dtTimeStart.Value);
            int fark = Convert.ToInt32(gunFarki.Days);
            if (fark <= 0)
            {
                MessageBox.Show("Please enter finish date bigger than start date.");
                dtTimeFinish.Focus();
            }
            else
            {
                string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsers WHERE UsersID = @UsersID", con);
                cmd.Parameters.AddWithValue("UsersID", UsersID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Users u = new Users();
                    while (reader.Read() == true)
                    {
                        u.UsersID = Convert.ToInt32(reader[0]);
                    }
                    int UsersID = u.UsersID;
                    reader.Close();

                    cmd.CommandText = "INSERT INTO tblProjects (ProjectName, StartDate, FinishDate,isActive, Budget, CreateUserID) VALUES(@projectName, @startdate, @finishdate,@isActive ,@budget, @UsersID)";
                    cmd.Parameters.AddWithValue("@ProjectName", projectName);
                    cmd.Parameters.AddWithValue("@StartDate", startdate);
                    cmd.Parameters.AddWithValue("@FinishDate", finishdate);
                    cmd.Parameters.AddWithValue("@isActive", isActive);
                    cmd.Parameters.AddWithValue("@Budget", budget);
                    cmd.Parameters.AddWithValue("@CreateUserID", UsersID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The project was saved.");
                }
                con.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsertProjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz?", "Çıkış Mesajı", MessageBoxButtons.YesNo);
            if (x == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsers WHERE UsersID = @UsersID", con);
                cmd.Parameters.AddWithValue("UsersID", UsersID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Users u = new Users();
                    while (reader.Read() == true)
                    {
                        u.UsersID = Convert.ToInt32(reader[0]);
                    }
                    reader.Close();
                    con.Close();
                    e.Cancel = false;
                }
            }
        }

        private void txtProjectName_Leave(object sender, EventArgs e)
        {
            if (txtProjectName.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtProjectName.Focus();
            }
        }

        private void txtBudget_Leave(object sender, EventArgs e)
        {
            if (txtBudget.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtBudget.Focus();
            }

            dtTimeStart.Focus();
        }

        private void txtBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
