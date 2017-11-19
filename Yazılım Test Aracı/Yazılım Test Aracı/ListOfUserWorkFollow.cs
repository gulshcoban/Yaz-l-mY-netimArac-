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
    public partial class frmListOfUserWorkFollow : Form
    {
        public frmListOfUserWorkFollow()
        {
            InitializeComponent();
        }

        private void ListOfUserWorkFollow_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM WorkFollow WF INNER JOIN tblWorkFollowDetails WFD ON WF.WorkFollowDetailsID = WFD.WorkFollowDetailsID", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read() == true)
                {
                    int i;
                    i = dtGridWorkFollow.Rows.Add();
                    dtGridWorkFollow.Rows[i].Cells[0].Value = Convert.ToInt32(reader[0]);
                    dtGridWorkFollow.Rows[i].Cells[1].Value = Convert.ToInt32(reader[1]);
                    dtGridWorkFollow.Rows[i].Cells[2].Value = Convert.ToDateTime(reader[2]);
                    dtGridWorkFollow.Rows[i].Cells[3].Value = Convert.ToDateTime(reader[3]);
                    dtGridWorkFollow.Rows[i].Cells[4].Value = Convert.ToInt32(reader[5]);
                    dtGridWorkFollow.Rows[i].Cells[5].Value = Convert.ToInt32(reader[6]);
                    dtGridWorkFollow.Rows[i].Cells[6].Value = reader[6].ToString();
                }
                reader.Close();
            }
            con.Close();
        }
    }
}
