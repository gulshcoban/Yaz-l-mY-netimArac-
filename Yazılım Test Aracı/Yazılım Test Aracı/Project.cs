using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Test_Aracı
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool isActive { get; set; }
        public float Budget { get; set; }
        public int CreateUserID { get; set; }
        public int ProjectUserID { get; set; }
    }
}
