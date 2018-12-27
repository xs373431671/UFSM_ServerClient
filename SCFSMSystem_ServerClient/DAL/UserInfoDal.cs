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
    class UserInfoDal
    {
        /// <summary>
        /// 检查用户名与密码是否正确
        /// </summary>
        /// <param name="account"></param>
        /// <param name="pwd"></param>
        /// <param name="returnMessage"></param>
        /// <returns></returns>
        public UFSM_UserInfo CheckUserInfo(string account,string pwd,out string returnMessage)
        {
            try
            {
                using (xs373431671Entities db = new xs373431671Entities())
                {
                    var sql = "select * from UFSM_UserInfo where Account=@Account and Password=@Password and Authority='admin'";
                    var parameter = new DbParameter[]
                    {
                        new SqlParameter {ParameterName = "@Account", Value = account},
                        new SqlParameter {ParameterName = "@Password", Value = pwd}
                    };
                    var userList = db.Database.SqlQuery<UFSM_UserInfo>(sql,parameter);
                    foreach(UFSM_UserInfo user in userList)
                    {
                        if(user.ID>0)
                        {
                            returnMessage = "登录成功!";
                            return user;
                        }                      
                    }
                    returnMessage = "用户名或密码错误!";
                    return null;
                }
            }
            catch
            {
                returnMessage = "异常错误!";
                return null;
            }
            

        }

        /// <summary>
        /// 获取数据库中的所有用户信息，返回用户对象集合
        /// </summary>
        /// <param name="returnMessage"></param>
        /// <returns></returns>
        public List<UFSM_UserInfo> GetUserList(out string returnMessage)
        {
            try
            {
                List<UFSM_UserInfo> userList = new List<UFSM_UserInfo>();
                using (xs373431671Entities db = new xs373431671Entities())
                {
                    var users = from u in db.UFSM_UserInfo select u;
                    foreach (UFSM_UserInfo user in users)
                    {
                        userList.Add(user);
                    }
                }
                returnMessage = "获取成功";
                return userList;
            }
            catch
            {
                returnMessage = "异常错误!";
                return null;
            }
        }


        public bool AddUserInfo(UFSM_UserInfo user)
        {
            using (xs373431671Entities db = new xs373431671Entities())
            {
                try
                {
                    db.UFSM_UserInfo.Add(user);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }               
            }          
        }

        public bool ChangeUserInfo(UFSM_UserInfo user)
        {
            using (xs373431671Entities db = new xs373431671Entities())
            {
                try
                {
                    var userInfoList = from u in db.UFSM_UserInfo where u.ID == user.ID select u;
                    var userInfo = userInfoList.FirstOrDefault();
                    userInfo.Name = user.Name;
                    userInfo.Account = user.Account;
                    userInfo.Password = user.Password;
                    userInfo.Telephone = user.Telephone;
                    userInfo.Department = user.Department;
                    userInfo.AreaNum = user.AreaNum;
                    userInfo.Authority = user.Authority;
                    db.Entry<UFSM_UserInfo>(userInfo).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
                
            }
        }

        public bool DeleteUserInfo(UFSM_UserInfo user)
        {
            using (xs373431671Entities db = new xs373431671Entities())
            {
                try
                {
                    UFSM_UserInfo u = new UFSM_UserInfo() { ID = user.ID };
                    db.Entry<UFSM_UserInfo>(u).State = System.Data.Entity.EntityState.Deleted;
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
