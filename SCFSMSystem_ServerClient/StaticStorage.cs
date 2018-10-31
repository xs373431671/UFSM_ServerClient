using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCFSMSystem_ServerClient
{
    static class StaticStorage
    {
        public static MainFrm MainFrm
        {
            get;
            set;
        }
        public static GisFrm GisFrm
        {
            get;
            set;
        }  
        public static string UserName
        {
            get;
            set;
        }
       


    }
}
