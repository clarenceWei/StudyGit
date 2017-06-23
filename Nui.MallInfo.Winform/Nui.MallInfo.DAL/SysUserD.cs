using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Nui.MallInfo.Model;
using System.Data;
using System.Data.Common;


namespace Nui.MallInfo.DAL
{
    public class SysUserD
    {
        //Database db = DatabaseFactory.CreateDatabase();

        MALLDBEntities malldb = new MALLDBEntities();

        /// <summary>
        /// 用户列表加载
        /// </summary>
        /// <param name="KeyWord">关键字</param>
        /// <param name="Page"></param>
        /// <param name="Size"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public List<SysUserInfo> GetUserPage(DateTime StartTime, DateTime EndTime, string KeyWord, string sqlWhere, int Page, int Size, out int Count)
        {
            Database db = DatabaseFactory.CreateDatabase();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append("SELECT ROW_NUMBER() OVER(ORDER BY USERID DESC) AS ROWNUMBER,");
            strSql.Append("USERID,");
            strSql.Append("U_ACCOUNT,");
            strSql.Append("U_NAME,");
            strSql.Append("U_PASSWORD,");
            strSql.Append("U_PHONE,");
            strSql.Append("U_EMAIL,");
            strSql.Append("U_ROLEID,");
            strSql.Append("U_ROLENAME,");
            strSql.Append("MEMO_TEXT,");
            strSql.Append("EDIT_USER,");
            strSql.Append("CREATE_DATE,");
            strSql.Append("EDIT_DATE ");
            strSql.Append("FROM ");
            strSql.Append("T_SYS_USER " + sqlWhere + ") H ");
            strSql.Append("WHERE H.ROWNUMBER BETWEEN CONVERT(VARCHAR(20),@PAGE*@SIZE-@SIZE+1) AND CONVERT(VARCHAR(20),@PAGE*@SIZE)");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            db.AddInParameter(dbCommand, "STARTDATE", DbType.DateTime, StartTime);
            db.AddInParameter(dbCommand, "ENDDATE", DbType.DateTime, EndTime);
            db.AddInParameter(dbCommand, "KEYWORD", DbType.String, "%" + KeyWord + "%");
            db.AddInParameter(dbCommand, "PAGE", DbType.Int32, Page);
            db.AddInParameter(dbCommand, "SIZE", DbType.Int32, Size);
            DataTable table = db.ExecuteDataSet(dbCommand).Tables[0];
            if (table != null)
            {
                List<SysUserInfo> userinfo = new List<SysUserInfo>();
                foreach (DataRow row in table.Rows)
                {
                    userinfo.Add(new SysUserInfo()
                    {
                        UserId = row["UserId"] == DBNull.Value ? 0 : Convert.ToInt32(row["UserId"]),
                        U_Account = row["U_Account"] == DBNull.Value ? "" : Convert.ToString(row["U_Account"]),
                        U_Name = row["U_Name"] == DBNull.Value ? "" : Convert.ToString(row["U_Name"]),
                        U_PassWord = row["U_PASSWORD"] == DBNull.Value ? "" : Convert.ToString(row["U_PASSWORD"]),
                        U_Email = row["U_Email"] == DBNull.Value ? "" : Convert.ToString(row["U_Email"]),
                        U_Phone = row["U_Phone"] == DBNull.Value ? "" : Convert.ToString(row["U_Phone"]),
                        U_RoleId = row["U_RoleId"] == DBNull.Value ? 0 : Convert.ToInt32(row["U_RoleId"]),
                        U_RoleName = row["U_ROLENAME"] == DBNull.Value ? "" : Convert.ToString(row["U_ROLENAME"]),
                        CREATE_DATE = row["CREATE_DATE"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["CREATE_DATE"]),
                        MemoText = row["MEMO_TEXT"] == DBNull.Value ? "" : Convert.ToString(row["MEMO_TEXT"]),
                        EditUser = row["EDIT_USER"] == DBNull.Value ? "" : Convert.ToString(row["EDIT_USER"]),
                        EditDate = row["EDIT_DATE"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["EDIT_DATE"])
                    });
                }

                string sql = "SELECT COUNT(1) FROM T_SYS_USER " + sqlWhere + "";
                dbCommand = db.GetSqlStringCommand(sql);
                db.AddInParameter(dbCommand, "STARTDATE", DbType.DateTime, StartTime);
                db.AddInParameter(dbCommand, "ENDDATE", DbType.DateTime, EndTime);
                db.AddInParameter(dbCommand, "KEYWORD", DbType.String, "%" + KeyWord + "%");
                Count = db.ExecuteScalar(dbCommand) == null ? 0 : Convert.ToInt32(db.ExecuteScalar(dbCommand));
                return userinfo;

            }
            else
            {
                Count = 0;
                return null;
            }
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="modelUser">用户实体</param>
        /// <returns></returns>
        public bool Add(SysUserInfo modelUser)
        {
            try
            {

                T_SYS_USER UserInfo = new T_SYS_USER();
                UserInfo.U_ACCOUNT = modelUser.U_Account;
                UserInfo.U_NAME = modelUser.U_Name;
                UserInfo.U_PASSWORD = modelUser.U_PassWord;
                UserInfo.U_PHONE = modelUser.U_Phone;
                UserInfo.U_EMAIL = modelUser.U_Email;
                UserInfo.U_ROLEID = modelUser.U_RoleId;
                UserInfo.U_ROLENAME = modelUser.U_RoleName;
                UserInfo.MEMO_TEXT = modelUser.MemoText;
                UserInfo.CREATE_DATE = modelUser.CREATE_DATE;
                UserInfo.EDIT_USER = modelUser.EditUser;
                UserInfo.EDIT_DATE = modelUser.EditDate;

                malldb.T_SYS_USER.Add(UserInfo);

                malldb.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="modelUser">用户实体</param>
        /// <returns></returns>
        public bool Edit(SysUserInfo modelUser)
        {
            try
            {

                T_SYS_USER UserInfo = malldb.T_SYS_USER.Where(c => c.U_ACCOUNT == modelUser.U_Account).FirstOrDefault();

                UserInfo.U_NAME = modelUser.U_Name;
                UserInfo.U_PASSWORD = modelUser.U_PassWord;
                UserInfo.U_PHONE = modelUser.U_Phone;
                UserInfo.U_EMAIL = modelUser.U_Email;
                UserInfo.U_ROLEID = modelUser.U_RoleId;
                UserInfo.U_ROLENAME = modelUser.U_RoleName;
                UserInfo.MEMO_TEXT = modelUser.MemoText;
                UserInfo.EDIT_USER = modelUser.EditUser;
                UserInfo.EDIT_DATE = modelUser.EditDate;

                malldb.Entry(UserInfo).State = System.Data.Entity.EntityState.Modified;

                malldb.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="UserId">用户主键</param>
        /// <returns></returns>
        public bool Del(int UserId)
        {
            try
            {
                T_SYS_USER UserInfo = malldb.T_SYS_USER.Find(UserId);

                malldb.T_SYS_USER.Remove(UserInfo);

                malldb.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="Account">用户账号</param>
        /// <param name="Pwd">密码，暂不MD5加密</param>
        /// <returns></returns>
        public bool GetLoginUser(string Account, string Pwd)
        {
            //var model = malldb.T_SYS_USER.Where(c => c.U_ACCOUNT == Account && c.U_PASSWORD == Pwd).FirstOrDefault();

            Database db = DatabaseFactory.CreateDatabase();

            string strSql = "SELECT COUNT(1) FROM T_SYS_USER WHERE U_ACCOUNT=@U_ACCOUNT AND U_PASSWORD=@U_PASSWORD";

            DbCommand dbCommand = db.GetSqlStringCommand(strSql);

            db.AddInParameter(dbCommand, "U_ACCOUNT", DbType.String, Account);
            db.AddInParameter(dbCommand, "U_PASSWORD", DbType.String, Pwd);

            object obj = db.ExecuteScalar(dbCommand);

            if (obj != null && Convert.ToInt32(obj) >= 1)
            {
                return true;
            }

            //if (model != null)
            //{
            //    return true;
            //}

            return false;
        }
    }
}
