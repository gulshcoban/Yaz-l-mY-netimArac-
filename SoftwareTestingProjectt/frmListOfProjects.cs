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
    public partial class frmListOfProjects : Form
    {
        public frmListOfProjects()
        {
            InitializeComponent();
        }

        private void frmListOfProjects_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=SoftwareTestingProject;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Projects P INNER JOIN Users U ON P.UsersID = U.UsersID", con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                int i;
                while (reader.Read() == true)
                {
                    i = dtGridProjects.Rows.Add();
                    dtGridProjects.Rows[i].Cells[0].Value = Convert.ToInt32(reader[0]);
                    dtGridProjects.Rows[i].Cells[1].Value = reader[1].ToString();
                    dtGridProjects.Rows[i].Cells[2].Value = Convert.ToDateTime(reader[2]);
                    dtGridProjects.Rows[i].Cells[3].Value = Convert.ToDateTime(reader[3]);
                    dtGridProjects.Rows[i].Cells[4].Value = Convert.ToInt32(reader[4]);
                    dtGridProjects.Rows[i].Cells[5].Value = reader[7].ToString();
                }
                reader.Close();
            }
            con.Close();

            string connectionString1 = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=SoftwareTestingProject;";
            SqlConnection con1 = new SqlConnection(connectionString1);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Users WHERE isActive = 'true'", con1);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.HasRows)
            {
                User u1 = new User();
                while (reader1.Read() == true)
                {
                    u1.Name = reader1[1].ToString();
                    u1.Surname = reader1[2].ToString();
                }
                lblActivePerson.Text = u1.Name + " " + u1.Surname;
            }
            con1.Close();
        }

        private void dtGridProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dtGridProjects.Rows[e.RowIndex].Selected = true;
            }
            int id = Convert.ToInt32(dtGridProjects.Rows[e.RowIndex].Cells[0].Value);
            string projectname = dtGridProjects.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dtGridProjects.Rows[e.RowIndex].Selected)
            {
                frmListOfMainProcess lomp = new frmListOfMainProcess(id, projectname);
                lomp.Show();
            }
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListOfProjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz?", "Çıkış Mesajı", MessageBoxButtons.YesNo);
            if (x == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=SoftwareTestingProject;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE isActive='true'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    User u = new User();
                    while (reader.Read() == true)
                    {
                        u.UsersID = Convert.ToInt32(reader[0]);
                    }
                    reader.Close();
                    int UsersID = u.UsersID;
                    cmd.CommandText = "UPDATE Users SET isActive='false' WHERE UsersID = @UsersID";
                    cmd.Parameters.AddWithValue("UsersID", @UsersID);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                e.Cancel = false;
            }
        }
    }
}
