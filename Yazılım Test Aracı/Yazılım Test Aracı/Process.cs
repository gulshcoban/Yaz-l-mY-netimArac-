using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Test_Aracı
{
    public class Process
    {
        public int ProcessID { get; set; }
        public string ProcessName { get; set; }
        public int ProjectID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int Duration { get; set; }
        public int CompleteRate { get; set; }
        public int Priority { get; set; }
        public int ParentID { get; set; }
        public string Notes { get; set; }
        public string Descriptions { get; set; }
        public int CreateUserID { get; set; }
    }
}
