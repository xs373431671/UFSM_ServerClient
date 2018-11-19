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
    }
}
