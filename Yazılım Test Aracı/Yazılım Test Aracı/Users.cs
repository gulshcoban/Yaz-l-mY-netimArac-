using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Test_Aracı
{
    public class Users
    {
        public int UsersID { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserNickname { get; set; }
        public string UserPassword { get; set; }
        public int UserRole { get; set; }
        public DateTime UserCreatedDate { get; set; }
    }
}
