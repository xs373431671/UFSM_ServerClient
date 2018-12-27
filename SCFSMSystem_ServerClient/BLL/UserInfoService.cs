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
                StaticObject.user = user;
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<UFSM_UserInfo> GetUserList(out string returnMessage)
        {
            UserInfoDal userInfoDal = new UserInfoDal();
            List<UFSM_UserInfo> userList = userInfoDal.GetUserList(out returnMessage);
            return userList;
        }


        public bool AddUserInfo(UFSM_UserInfo user)
        {
            return new UserInfoDal().AddUserInfo(user);
        }

        public bool ChangeUserInfo(UFSM_UserInfo user)
        {
            return new UserInfoDal().ChangeUserInfo(user);
        }

        public bool DeleteUserInfo(UFSM_UserInfo user)
        {
            return new UserInfoDal().DeleteUserInfo(user);
        }
    }
}
