using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCFSMSystem_ServerClient.Model
{
    static class StaticUserInfo
    {
        public static int ID { get; set; }
        public static string Name { get; set; }
        public static string Authority { get; set; }
        public static Nullable<int> AreaNum { get; set; }
        public static string Department { get; set; }
        public static string Account { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        public static string Telephone { get; set; }
    }
}
