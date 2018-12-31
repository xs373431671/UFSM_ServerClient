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

        public bool UpdateAreaRiskGrade(List<UFSM_AreaInfo> areaList)
        {
            using (xs373431671Entities db = new xs373431671Entities())
            {
                try
                {
                    foreach(UFSM_AreaInfo area in areaList)
                    {
                        var areaInfoList = from u in db.UFSM_AreaInfo where u.AreaNum == area.AreaNum select u;
                        var areaInfo = areaInfoList.FirstOrDefault();
                        areaInfo.AreaRiskGrade = area.AreaRiskGrade;
                        db.Entry<UFSM_AreaInfo>(areaInfo).State = System.Data.Entity.EntityState.Modified;
                        
                    }
                    db.SaveChanges();        
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
