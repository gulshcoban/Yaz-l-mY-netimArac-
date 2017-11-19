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
    public partial class frmListOfProjects : Form
    {
        int UsersID;
        public frmListOfProjects(int usersID)
        {
            this.UsersID = usersID;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListOfProjects_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblProjects P INNER JOIN tblUsers U ON P.CreateUserID = U.UsersID", con);
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
                    dtGridProjects.Rows[i].Cells[5].Value = Convert.ToBoolean(reader[4]);
                    dtGridProjects.Rows[i].Cells[4].Value = Convert.ToInt32(reader[5]);
                    dtGridProjects.Rows[i].Cells[6].Value = reader[9].ToString();
                }
                reader.Close();
            }
            con.Close();

            string connectionString1 = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
            SqlConnection con1 = new SqlConnection(connectionString1);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM tblUsers WHERE UsersID = @UsersID", con1);
            cmd1.Parameters.AddWithValue("UsersID", UsersID);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.HasRows)
            {
                Users u1 = new Users();
                while (reader1.Read() == true)
                {
                    u1.UserName = reader1[1].ToString();
                    u1.UserSurname = reader1[2].ToString();
                }
                lblActivePerson.Text = u1.UserName + " " + u1.UserSurname;
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
                frmListOfProcess lomp = new frmListOfProcess(id, projectname, UsersID);
                lomp.Show();
            }
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
                string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsers WHERE UsersID = @UsersID ", con);
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
    }
}
