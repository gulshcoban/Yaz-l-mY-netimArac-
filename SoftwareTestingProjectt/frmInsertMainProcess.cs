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
    public partial class frmInsertMainProcess : Form
    {
        public int id = 0;
        public string projectname = "";
        public frmInsertMainProcess(int id, string pName)
        {
            this.id = id;
            this.projectname = pName;
            InitializeComponent();
        }

     
        private void frmInsertMainProcess_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=SoftwareTestingProject;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserRolesID != 1 AND UserRolesID != 2", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read() == true)
                {
                    cmbPanalyze.Items.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                    cmbPtable.Items.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                    cmbPprocedure.Items.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                    cmbPdllList.Items.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                    cmbPdllProcess.Items.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                    cmbPinterface.Items.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                    cmbPtest1.Items.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                    cmbPtest2.Items.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                    cmbPtest3.Items.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                    cmbPtest4.Items.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                    cmbPtest5.Items.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                }
            }
            con.Close();
            con.Open();
            cmd.CommandText = "SELECT * FROM Users WHERE UsersID = 2";
            SqlDataReader reader1 = cmd.ExecuteReader();
            if(reader1.HasRows)
            {
                while(reader1.Read() == true)
                {
                    cmbFromWho.Items.Add(reader1["Name"].ToString() + " " + reader1["Surname"].ToString());  
                }
            }
            con.Close();

            for(int i=1; i<6; i++)
            {
                cmbPriority.Items.Add(i);
            }

            cmbState.Items.Add("On Stand-by");
            cmbState.Items.Add("In the planning phase");
            cmbState.Items.Add("Project is being done.");
            cmbState.Items.Add("Completed");
            
            txtID.Text = id.ToString();
            txtProjectName.Text = projectname;
        }
        public int Fonksiyon(DateTime start, DateTime finish)
        {
            TimeSpan gunFarki = finish.Subtract(start);
            int fark = Convert.ToInt32(gunFarki.Days);
            if (fark <= 0)
                 return 1;
   
            return 0;  
        }

        private void btnMainProcessSave_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[13];
            string title = txtTitle.Text;
            /*string fromWho = cmbFromWho.Text;
            string state = cmbState.Text; 
            int priority = Convert.ToInt32(cmbPriority.Text);*/ 
            DateTime planstartdate = Convert.ToDateTime(dtPlanStart.Text);
            DateTime planfinishdate = Convert.ToDateTime(dtPlanFinish.Text);
            if (Fonksiyon(planstartdate, planfinishdate) == 1) { dizi[0] = 1; lblY2.Text = "***"; lblY2.ForeColor = Color.Red ; dtPlanFinish.Focus(); }
            else { dizi[0] = 0; lblY2.Text = ""; }
            /*DateTime requestdate = Convert.ToDateTime(dtRequest.Text);
            DateTime dateofappointment = Convert.ToDateTime(dtAppointment.Text);
            if (Fonksiyon(requestdate, dateofappointment) == 1) { dizi[1] = 1;lblY1.Text = "***"; lblY1.ForeColor = Color.Red ;  dtAppointment.Focus(); }
            else { dizi[1] = 0;  lblY1.Text = "";}
            DateTime completedate = Convert.ToDateTime(dtComplete.Text);
            string completeState = lblCompleteState.Text;*/

            string Panalyze = cmbPanalyze.Text;
          /*  string Ptable = cmbPtable.Text;
            string Pprocedure = cmbPprocedure.Text;
            string PdllList = cmbPdllList.Text;
            string PdllProcess = cmbPdllProcess.Text;
            string Pinterface = cmbPinterface.Text;
            string Ptest1 = cmbPtest1.Text;
            string Ptest2 = cmbPtest2.Text;
            string Ptest3 = cmbPtest3.Text;
            string Ptest4 = cmbPtest4.Text;
            string Ptest5 = cmbPtest5.Text;*/

            DateTime SDanalyze = Convert.ToDateTime(dtSDanalyze.Text);
           /* DateTime SDtable = Convert.ToDateTime(dtSDtable.Text);
            DateTime SDprocedure = Convert.ToDateTime(dtSDprocedure.Text);
            DateTime SDdllList = Convert.ToDateTime(dtSDdllList.Text);
            DateTime SDdllProcess = Convert.ToDateTime(dtSDdllProcess.Text);
            DateTime SDinterface = Convert.ToDateTime(dtSDinterface.Text);
            DateTime SDtest1 = Convert.ToDateTime(dtSDtest1.Text);
            DateTime SDtest2 = Convert.ToDateTime(dtSDtest2.Text);
            DateTime SDtest3 = Convert.ToDateTime(dtSDtest3.Text);
            DateTime SDtest4 = Convert.ToDateTime(dtSDtest4.Text); 
            DateTime SDtest5 = Convert.ToDateTime(dtSDtest5.Text);*/

            DateTime FDanalyze = Convert.ToDateTime(dtFDanalyze.Text);
            /* DateTime FDtable = Convert.ToDateTime(dtFDtable.Text);
             DateTime FDprocedure = Convert.ToDateTime(dtFDprocedure.Text);
             DateTime FDdllList = Convert.ToDateTime(dtFDdllList.Text);
             DateTime FDdllProcess = Convert.ToDateTime(dtFDdllProcess.Text);
             DateTime FDinterface = Convert.ToDateTime(dtFDinterface.Text);
             DateTime FDtest1 = Convert.ToDateTime(dtFDtest1.Text);
             DateTime FDtest2 = Convert.ToDateTime(dtFDtest2.Text);
             DateTime FDtest3 = Convert.ToDateTime(dtFDtest3.Text);
             DateTime FDtest4 = Convert.ToDateTime(dtFDtest4.Text);
             DateTime FDtest5 = Convert.ToDateTime(dtFDtest5.Text);*/

            if (Fonksiyon(SDanalyze, FDanalyze) == 1) { dizi[2] = 1;  dtFDanalyze.Focus(); lblY3.Text = "***"; lblY3.ForeColor = Color.Red; }
            else { dizi[2] = 0; lblY3.Text = ""; }
            /* if (Fonksiyon(SDtable, FDtable) == 1) {dizi[3] = 1; dtFDtable.Focus();lblY4.Text = "***"; lblY4.ForeColor = Color.Red ;  }
            else { dizi[3] = 0; lblY4.Text = ""; } 
            if (Fonksiyon(SDprocedure, FDprocedure) == 1) { dizi[4] = 1 ;dtFDprocedure.Focus(); lblY5.Text = "***"; lblY5.ForeColor = Color.Red ; }
            else { dizi[4] = 0; lblY5.Text = ""; } 
            if (Fonksiyon(SDdllList, FDdllList) == 1) {dizi[5] = 1 ;dtFDdllList.Focus(); lblY6.Text = "***"; lblY6.ForeColor = Color.Red ; }
            else { dizi[5] = 0; lblY6.Text = ""; } 
            if (Fonksiyon(SDdllProcess, FDdllProcess) == 1) {dizi[6] = 1; dtFDdllProcess.Focus(); lblY7.Text = "***"; lblY7.ForeColor = Color.Red ; }
            else { dizi[6] = 0; lblY7.Text = ""; } 
            if (Fonksiyon(SDinterface, FDinterface) == 1) {dizi[7] = 1; dtFDinterface.Focus(); lblY8.Text = "***"; lblY8.ForeColor = Color.Red ; }
            else { dizi[7] = 0; lblY8.Text = ""; }
            if (Fonksiyon(SDtest1, FDtest1) == 1) { dizi[8] = 1; dtFDtest1.Focus(); lblY9.Text = "***"; lblY9.ForeColor = Color.Red ; }
            else { dizi[8] = 0; lblY9.Text = ""; } 
            if (Fonksiyon(SDtest2, FDtest2) == 1) { dizi[9] = 1 ;dtFDtest2.Focus(); lblY10.Text = "***"; lblY10.ForeColor = Color.Red ; }
            else { dizi[9] = 0; lblY10.Text = ""; } 
            if (Fonksiyon(SDtest3, FDtest3) == 1) { dizi[10] = 1 ;dtFDtest3.Focus(); lblY11.Text = "***"; lblY11.ForeColor = Color.Red ; }
            else { dizi[10] = 0; lblY11.Text = ""; } 
            if (Fonksiyon(SDtest4, FDtest4) == 1) { dizi[11] = 1; dtFDtest4.Focus(); lblY12.Text = "***"; lblY12.ForeColor = Color.Red ; }
            else { dizi[11] = 0; lblY12.Text = ""; } 
            if (Fonksiyon(SDtest5, FDtest5) == 1) {dizi[12] = 1 ;dtFDtest5.Focus(); lblY13.Text = "***"; lblY13.ForeColor = Color.Red ; }*/
            /*else { dizi[12] = 0; lblY13.Text = ""; }*/


            string Hanalyze = txtHanalyze.Text;
            /*string Htable = txtHtable.Text;
            string Hprocedure = txtHprocedure.Text;
            string HdllList = txtHdllList.Text;
            string HdllProcess = txtHdllProcess.Text;
            string Hinterface = txtHinterface.Text;
            string Htest1 = txtHtest1.Text;
            string Htest2 = txtHtest2.Text;
            string Htest3 = txtHtest3.Text;
            string Htest4 = txtHtest4.Text;
            string Htest5 = txtHtest5.Text;*/
            
            DateTime CDanalyze = Convert.ToDateTime(dtCDanalyze.Text);
           /* DateTime CDtable = Convert.ToDateTime(dtCDtable.Text);
            DateTime CDprocedure = Convert.ToDateTime(dtCDprocedure.Text);
            DateTime CDdllList = Convert.ToDateTime(dtCDdllList.Text);
            DateTime CDdllProcess = Convert.ToDateTime(dtCDdllProcess.Text);
            DateTime CDinterface = Convert.ToDateTime(dtCDinterface.Text);
            DateTime CDtest1 = Convert.ToDateTime(dtCDtest1.Text);
            DateTime CDtest2 = Convert.ToDateTime(dtCDtest2.Text);
            DateTime CDtest3 = Convert.ToDateTime(dtCDtest3.Text);
            DateTime CDtest4 = Convert.ToDateTime(dtCDtest4.Text);
            DateTime CDtest5 = Convert.ToDateTime(dtCDtest5.Text);
            */
            string CRanalyze = txtCRanalyze.Text;
            /*string CRtable = txtCRtable.Text;
            string CRprocedure = txtCRprocedure.Text;
            string CRdllList = txtCRdllList.Text;
            string CRdllProcess = txtCRdllProcess.Text;
            string CRinterface = txtCRinterface.Text;
            string CRtest1 = txtCRtest1.Text;
            string CRtest2 = txtCRtest2.Text;
            string CRtest3 = txtCRtest3.Text;
            string CRtest4 = txtCRtest4.Text;
            string CRtest5 = txtCRtest5.Text;*/

           int ProjectID = id;
            string MainProcessName = title;
            string Duration = Hanalyze;
            string Complete = CRanalyze;
            DateTime StartDate = SDanalyze;
            DateTime FinishDate = FDanalyze;
            if(dizi[0] == 0 && dizi[1] == 0 && dizi[2] == 0 && dizi[3] == 0 && dizi[4] == 0 && dizi[5] == 0 && dizi[6] == 0 && dizi[7] == 0 && dizi[8] == 0 && dizi[9] == 0 && dizi[10] == 0 && dizi[11] == 0 && dizi[12] == 0)
            {
                string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=SoftwareTestingProject;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO MainProcess (ProjectID,MainProcessName,Duration,Complete,StartDate,FinishDate) VALUES (@ProjectID,@MainProcessName,@Duration,@Complete,@StartDate,@FinishDate) ", con);
                cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
                cmd.Parameters.AddWithValue("@MainProcessName", MainProcessName);
                cmd.Parameters.AddWithValue("@Duration", Duration);
                cmd.Parameters.AddWithValue("@Complete", Complete);
                cmd.Parameters.AddWithValue("@StartDate",StartDate);
                cmd.Parameters.AddWithValue("@FinishDate", FinishDate);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The project was saved.");
                con.Close(); 
                MessageBox.Show("Hayat bize güzelsdjnfjksdnjkf");
            }
            else
            {
                MessageBox.Show("Please enter your informations as correct.");
            }
         
        }

        private void cmbState_Leave(object sender, EventArgs e)
        {
            if(cmbState.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbState.Focus();
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

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtTitle.Focus();
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

        private void dtPlanStart_Leave(object sender, EventArgs e)
        {
            if (dtPlanStart.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                dtPlanStart.Focus();
            }
        }

        private void dtPlanFinish_Leave(object sender, EventArgs e)
        {
            if (dtPlanFinish.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                dtPlanFinish.Focus();
            }
        }

        private void cmbPanalyze_Leave(object sender, EventArgs e)
        {
            if (cmbPanalyze.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbPanalyze.Focus();
            }
        }

        private void cmbPtable_Leave(object sender, EventArgs e)
        {
            if (cmbPtable.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbPtable.Focus();
            }
        }

        private void cmbPprocedure_Leave(object sender, EventArgs e)
        {
            if (cmbPprocedure.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbPprocedure.Focus();
            }
        }

        private void cmbPdllList_Leave(object sender, EventArgs e)
        {
            if (cmbPdllList.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbPdllList.Focus();
            }
        }

        private void cmbPdllProcess_Leave(object sender, EventArgs e)
        {

            if (cmbPdllProcess.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbPdllProcess.Focus();
            }
        }

        private void cmbPinterface_Leave(object sender, EventArgs e)
        {
            if (cmbPinterface.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbPinterface.Focus();
            }
        }

        private void cmbPtest1_Leave(object sender, EventArgs e)
        {
            if (cmbPtest1.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbPtest1.Focus();
            }
        }

        private void cmbPtest2_Leave(object sender, EventArgs e)
        {
            if (cmbPtest2.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbPtest2.Focus();
            }
        }

        private void cmbPtest3_Leave(object sender, EventArgs e)
        {
            if (cmbPtest3.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbPtest3.Focus();
            }
        }

        private void cmbPtest4_Leave(object sender, EventArgs e)
        {
            if (cmbPtest4.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbPtest4.Focus();
            }
        }

        private void cmbPtest5_Leave(object sender, EventArgs e)
        {
            if (cmbPtest5.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                cmbPtest5.Focus();
            }
        }

        private void txtHanalyze_Leave(object sender, EventArgs e)
        {
            if (txtHanalyze.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtHanalyze.Focus();
            }
        }

        private void txtHtable_Leave(object sender, EventArgs e)
        {
            if (txtHtable.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtHtable.Focus();
            }
        }

        private void txtHprocedure_Leave(object sender, EventArgs e)
        {
            if (txtHprocedure.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtHprocedure.Focus();
            }
        }

        private void txtHdllList_Leave(object sender, EventArgs e)
        {
            if (txtHdllList.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtHdllList.Focus();
            }
        }

        private void txtHdllProcess_Leave(object sender, EventArgs e)
        {
            if (txtHdllProcess.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtHdllProcess.Focus();
            }
        }

        private void txtHinterface_Leave(object sender, EventArgs e)
        {
            if (txtHinterface.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtHinterface.Focus();
            }
        }

        private void txtHtest1_Leave(object sender, EventArgs e)
        {
            if (txtHtest1.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtHtest1.Focus();
            }
        }

        private void txtHtest2_Leave(object sender, EventArgs e)
        {
            if (txtHtest2.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtHtest2.Focus();
            }
        }

        private void txtHtest3_Leave(object sender, EventArgs e)
        {
            if (txtHtest3.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtHtest3.Focus();
            }
        }

        private void txtHtest4_Leave(object sender, EventArgs e)
        {
            if (txtHtest4.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtHtest4.Focus();
            }
        }

        private void txtHtest5_Leave(object sender, EventArgs e)
        {
            if (txtHtest5.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtHtest5.Focus();
            }
        }

        private void txtCRanalyze_Leave(object sender, EventArgs e)
        {
            if (txtCRanalyze.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtCRanalyze.Focus();
            }
        }

        private void txtCRtable_Leave(object sender, EventArgs e)
        {
            if (txtCRtable.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtCRtable.Focus();
            }
        }

        private void txtCRprocedure_Leave(object sender, EventArgs e)
        {
            if (txtCRprocedure.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtCRprocedure.Focus();
            }
        }

        private void txtCRdllList_Leave(object sender, EventArgs e)
        {
            if (txtCRdllList.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtCRdllList.Focus();
            }
        }

        private void txtCRdllProcess_Leave(object sender, EventArgs e)
        {
            if (txtCRdllProcess.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtCRdllProcess.Focus();
            }
        }

        private void txtCRinterface_Leave(object sender, EventArgs e)
        {
            if (txtCRinterface.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtCRinterface.Focus();
            }
        }

        private void txtCRtest1_Leave(object sender, EventArgs e)
        {
            if (txtCRtest1.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtCRtest1.Focus();
            }
        }

        private void txtCRtest2_Leave(object sender, EventArgs e)
        {
            if (txtCRtest2.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtCRtest2.Focus();
            }
        }

        private void txtCRtest3_Leave(object sender, EventArgs e)
        {
            if (txtCRtest3.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtCRtest3.Focus();
            }
        }

        private void txtCRtest4_Leave(object sender, EventArgs e)
        {
            if (txtCRtest4.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtCRtest4.Focus();
            }
        }

        private void txtCRtest5_Leave(object sender, EventArgs e)
        {
            if (txtCRtest5.Text == "")
            {
                MessageBox.Show("Please fill in the blank area.");
                txtCRtest5.Focus();
            }
        }
    }
}
