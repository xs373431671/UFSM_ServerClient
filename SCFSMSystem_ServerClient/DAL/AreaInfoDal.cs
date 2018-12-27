using SCFSMSystem_ServerClient.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCFSMSystem_ServerClient.DAL
{
    class AreaInfoDal
    {        
        public List<UFSM_AreaInfo> GetAreaList(out string returnMessage)
        {
            try
            {
                List<UFSM_AreaInfo> areaList = new List<UFSM_AreaInfo>();
                using (xs373431671Entities db = new xs373431671Entities())
                {
                    var areas = from u in db.UFSM_AreaInfo select u;
                    foreach (UFSM_AreaInfo area in areas)
                    {
                        areaList.Add(area);
                    }             
                }
                returnMessage = "获取成功";
                return areaList;
            }
            catch
            {
                returnMessage = "异常错误!";
                return null;
            }
        }

        





    }
}
