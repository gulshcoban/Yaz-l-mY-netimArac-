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
    public partial class frmInsertProcess : Form
    {
        public int id = 0;
        public string projectName = "";
        public int UsersID;
        public frmInsertProcess(int id, string pName, int usersID)
        {
            this.id = id;
            this.projectName = pName;
            this.UsersID = usersID;
            InitializeComponent();
        }
        private void frmInsertProcess_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                cmbPriority.Items.Add(i + 1);
            }
            for (int i = 0; i < 100; i++)
            {
                cmbCompleteRate.Items.Add(i + 1);
            }
            string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsers WHERE UserRole != 1 AND UserRole != 2", con);
            cmd.Parameters.AddWithValue("UsersID", UsersID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read() == true)
                {
                    Users u = new Users();
                    u.UserName = reader[1].ToString();
                    u.UserSurname = reader[2].ToString();
                    cmbFromWho.Items.Add(u.UserName + " " + u.UserSurname);
                }
            }
            reader.Close();
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ProcessName = txtProcessName.Text;
            DateTime StartDate = Convert.ToDateTime(dtpStartDate.Text);
            DateTime FinishDate = Convert.ToDateTime(dtpFinishDate.Text);
            int Duration = Convert.ToInt32(txtDuration.Text);
            int Priority = Convert.ToInt32(cmbPriority.Text);
            string Notes = txtNotes.Text;
            string Descriptions = txtDescription.Text;
            int CompleteRate = Convert.ToInt32(cmbCompleteRate.Text);

            string WorkFollowName = txtWorkFollowName.Text;
            string FromWho = cmbFromWho.Text;

            TimeSpan gunFarki = dtpFinishDate.Value.Subtract(dtpStartDate.Value);
            int fark = Convert.ToInt32(gunFarki.Days);
            if (fark <= 0)
            {
                MessageBox.Show("Please enter finish date bigger than start date.");
                dtpFinishDate.Focus();
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
                    int ProjectID = id;
                    int ParentID = 0;
                    reader.Close();
                    cmd.CommandText = "INSERT INTO tblProcess (ProcessName,ProjectID, StartDate, FinishDate,Duration,CompleteRate,Priority,ParentID,Notes,Descriptions,CreateUserID) VALUES(@ProcessName, @ProjectID, @StartDate,@FinishDate ,@Duration, @CompleteRate,@Priority, @ParentID,@Notes,@Descriptions,@UsersID)";
                    cmd.Parameters.AddWithValue("@ProcessName", ProcessName);
                    cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.Parameters.AddWithValue("@FinishDate", FinishDate);
                    cmd.Parameters.AddWithValue("@Duration", Duration);
                    cmd.Parameters.AddWithValue("@CompleteRate", CompleteRate);
                    cmd.Parameters.AddWithValue("@Priority", Priority);
                    cmd.Parameters.AddWithValue("@ParentID", ParentID);
                    cmd.Parameters.AddWithValue("@Notes", Notes);
                    cmd.Parameters.AddWithValue("@Descriptions", Descriptions);
                    cmd.Parameters.AddWithValue("@CreateUserID", UsersID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The process was saved.");
                }
                con.Close();
            }
        }

        private void txtProcessName_Leave(object sender, EventArgs e)
        {
            if (txtProcessName.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtProcessName.Focus();
            }
        }

        private void txtDuration_Leave(object sender, EventArgs e)
        {
            if (txtDuration.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtDuration.Focus();
            }
        }

        private void cmbPriority_Leave(object sender, EventArgs e)
        {
            if (cmbPriority.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbPriority.Focus();
            }
        }

        private void txtNotes_Leave(object sender, EventArgs e)
        {
            if (txtNotes.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtNotes.Focus();
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtDescription.Focus();
            }
        }

        private void txtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbCompleteRate_Leave(object sender, EventArgs e)
        {
            if (cmbCompleteRate.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbCompleteRate.Focus();
            }

        }

        private void txtWorkFollowName_Leave(object sender, EventArgs e)
        {
            if (txtWorkFollowName.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtWorkFollowName.Focus();
            }
        }

        private void cmbFromWho_Leave(object sender, EventArgs e)
        {
            if (cmbFromWho.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbFromWho.Focus();
            }
        }
    }
}