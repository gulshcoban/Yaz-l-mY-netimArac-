using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTestingProjectt
{
    public class Project
    {
        public int ProjectsID { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public decimal Budget { get; set; }
        public int UsersID { get; set; }
    }
}
