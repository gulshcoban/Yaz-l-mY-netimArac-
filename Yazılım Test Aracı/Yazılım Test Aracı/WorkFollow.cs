using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Test_Aracı
{
    public class WorkFollow
    {
        public int WorkFollowID { get; set; }
        public int ProcessID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int WorkFollowDetailsID { get; set; }
        public int UserID { get; set; }
        public int CompleteRate { get; set; }
    }
}
