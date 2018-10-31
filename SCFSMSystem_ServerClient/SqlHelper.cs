using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace SCFSMSystem_ServerClient
{
    class SqlHelper
    {
        #region 获取SQL连接字符串方法GetSqlConnectionString()

        public string GetSqlConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["mySqlServerAddress"].ConnectionString;
        }
        #endregion

        #region SQL判断登录信息是否正确LoginJudge(string account,string password)
        public bool LoginJudge(string account,string password)
        {
            using (SqlConnection conn = new SqlConnection(this.GetSqlConnectionString()))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from [xs373431671].[Tb_UserInfo] where UserName=@UserName and UserPassword=@UserPassword";
                    cmd.Parameters.AddWithValue("@UserName", account);
                    cmd.Parameters.AddWithValue("@UserPassword", password);
                    object result = cmd.ExecuteScalar();
                    int rows = 0;
                    try
                    {
                        rows=int.Parse(result.ToString());

                    }
                    catch
                    {

                    }
                    if(rows>=1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                        
                }
            }
        }
        #endregion



    }
}
