using SCFSMSystem_ServerClient.DAL;
using SCFSMSystem_ServerClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCFSMSystem_ServerClient.BLL
{
    class UserInfoService
    {
        public bool CheckUserInfo(string account,string pwd,out string returnMessage)
        {
            UserInfoDal userInfoDal = new UserInfoDal();
            UFSM_UserInfo user = userInfoDal.CheckUserInfo(account, pwd, out returnMessage);
            if(user!=null)
            {
                StaticUserInfo.Account=user.Account;
                StaticUserInfo.Password=user.Password;
                StaticUserInfo.ID=user.ID;
                StaticUserInfo.Name=user.Name;
                StaticUserInfo.Authority=user.Authority;
                StaticUserInfo.AreaNum=user.AreaNum;
                StaticUserInfo.Department=user.Department;
                StaticUserInfo.Email=user.Email;
                StaticUserInfo.Telephone=user.Telephone;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
