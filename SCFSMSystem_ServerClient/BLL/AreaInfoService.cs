using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCFSMSystem_ServerClient.Model;
using SCFSMSystem_ServerClient.DAL;

namespace SCFSMSystem_ServerClient.BLL
{
    class AreaInfoService
    {
        public List<UFSM_AreaInfo> GetAreaList(out string returnMessage)
        {
            AreaInfoDal areaInfoDal = new AreaInfoDal();
            List<UFSM_AreaInfo>areaList= areaInfoDal.GetAreaList(out returnMessage);
            return areaList;
        }
    }
}
