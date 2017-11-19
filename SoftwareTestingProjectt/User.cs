using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTestingProjectt
{
    public class User
    {
        public int UsersID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public int UserRolesID { get; set; }
        public int ConnectsID { get; set; }
        public bool isActive { get; set; }
    }
}
