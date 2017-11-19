using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTestingProjectt
{
    public partial class frmListOfMainProcess : Form
    {
        public int id = 0;
        public string projectName = "";
        public frmListOfMainProcess(int id, string pName)
        {
            this.id = id;
            this.projectName = pName;
            InitializeComponent();
        }

        private void btnInsertMainProcess_Click(object sender, EventArgs e)
        {
            frmInsertMainProcess imp = new frmInsertMainProcess(id, projectName);
            imp.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void lblRequestProcess_Click(object sender, EventArgs e)
        {

        }
    }
}
