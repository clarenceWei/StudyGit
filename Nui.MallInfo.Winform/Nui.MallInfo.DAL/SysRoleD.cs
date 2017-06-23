using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nui.MallInfo.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

namespace Nui.MallInfo.DAL
{
    public class SysRoleD
    {

        MALLDBEntities malldb = new MALLDBEntities();

        /// <summary>
        /// 角色列表加载
        /// </summary>
        /// <param name="KeyWord">关键字</param>
        /// <param name="Page"></param>
        /// <param name="Size"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public List<SysRoleInfo> GetRolePage(string KeyWord, string sqlWhere, int Page, int Size, out int Count)
        {
            Database db = DatabaseFactory.CreateDatabase();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append("SELECT ROW_NUMBER() OVER(ORDER BY ROLEID DESC) AS ROWNUMBER,");
            strSql.Append("ROLEID,");
            strSql.Append("R_ROLENAME,");
            strSql.Append("R_DESCRIPTION,");
            strSql.Append("MEMO_TEXT,");
            strSql.Append("EDIT_USER,");
            strSql.Append("EDIT_DATE ");
            strSql.Append("FROM ");
            strSql.Append("T_SYS_ROLES " + sqlWhere + ") H ");
            strSql.Append("WHERE H.ROWNUMBER BETWEEN CONVERT(VARCHAR(20),@PAGE*@SIZE-@SIZE+1) AND CONVERT(VARCHAR(20),@PAGE*@SIZE)");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            db.AddInParameter(dbCommand, "KEYWORD", DbType.String, "%" + KeyWord + "%");
            db.AddInParameter(dbCommand, "PAGE", DbType.Int32, Page);
            db.AddInParameter(dbCommand, "SIZE", DbType.Int32, Size);
            DataTable table = db.ExecuteDataSet(dbCommand).Tables[0];
            if (table != null)
            {
                List<SysRoleInfo> roleinfo = new List<SysRoleInfo>();
                foreach (DataRow row in table.Rows)
                {
                    roleinfo.Add(new SysRoleInfo()
                    {
                        RoleId = row["ROLEID"] == DBNull.Value ? 0 : Convert.ToInt32(row["ROLEID"]),
                        R_RoleName = row["R_ROLENAME"] == DBNull.Value ? "" : Convert.ToString(row["R_ROLENAME"]),
                        R_DescripTion = row["R_DESCRIPTION"] == DBNull.Value ? "" : Convert.ToString(row["R_DESCRIPTION"]),
                        MemoText = row["MEMO_TEXT"] == DBNull.Value ? "" : Convert.ToString(row["MEMO_TEXT"]),
                        EditUser = row["EDIT_USER"] == DBNull.Value ? "" : Convert.ToString(row["EDIT_USER"]),
                        EditDate = row["EDIT_DATE"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["EDIT_DATE"])
                    });
                }

                string sql = "SELECT COUNT(1) FROM T_SYS_ROLES " + sqlWhere + "";
                dbCommand = db.GetSqlStringCommand(sql);
                db.AddInParameter(dbCommand, "KEYWORD", DbType.String, "%" + KeyWord + "%");
                Count = db.ExecuteScalar(dbCommand) == null ? 0 : Convert.ToInt32(db.ExecuteScalar(dbCommand));
                return roleinfo;

            }
            else
            {
                Count = 0;
                return null;
            }
        }

        /// <summary>
        /// 通过登录账户获取RoleId
        /// </summary>
        /// <param name="Account"></param>
        /// <returns></returns>
        public int? GetRoleId(string Account)
        {
            var model = malldb.T_SYS_USER.Where(c => c.U_ACCOUNT == Account).FirstOrDefault();

            if (model != null)
            {
                return model.U_ROLEID;
            }
            else
            {
                return 0;
            }

        }

        /// <summary>
        /// 获取角色ID,角色名称列表，除超级管理员角色外
        /// 当然，如果是超级管理员登录，可以加载超级管理员角色
        /// </summary>
        /// <param name="Account">登录用户账号</param>
        /// <returns></returns>
        public List<SysRoleInfo> GetRoleList(string Account)
        {
            if (Account == "admin")
            {
                var model = malldb.T_SYS_ROLES.ToList();

                if (model != null && model.Count() > 0)
                {
                    List<SysRoleInfo> listRole = new List<SysRoleInfo>();

                    foreach (var row in model)
                    {
                        listRole.Add(new SysRoleInfo()
                        {
                            RoleId = row.ROLEID,
                            R_RoleName = row.R_ROLENAME
                        });
                    }
                    return listRole;
                }
            }
            else
            {
                var model = malldb.T_SYS_ROLES.Where(c => c.ROLEID != 10000).ToList();
                //var model = malldb.T_SYS_ROLES.ToList();

                if (model != null && model.Count() > 0)
                {
                    List<SysRoleInfo> listRole = new List<SysRoleInfo>();

                    foreach (var row in model)
                    {
                        listRole.Add(new SysRoleInfo()
                        {
                            RoleId = row.ROLEID,
                            R_RoleName = row.R_ROLENAME
                        });
                    }
                    return listRole;
                }
            }
            return null;
        }

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="modelRole">角色实体</param>
        /// <returns></returns>
        public bool Add(SysRoleInfo modelRole)
        {
            try
            {

                T_SYS_ROLES RoleInfo = new T_SYS_ROLES();
                RoleInfo.R_ROLENAME = modelRole.R_RoleName;
                RoleInfo.MEMO_TEXT = modelRole.MemoText;
                RoleInfo.EDIT_USER = modelRole.EditUser;
                RoleInfo.EDIT_DATE = modelRole.EditDate;

                malldb.T_SYS_ROLES.Add(RoleInfo);

                malldb.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="modelRole">角色实体</param>
        /// <returns></returns>
        public bool Edit(SysRoleInfo modelRole)
        {
            try
            {

                T_SYS_ROLES RoleInfo = malldb.T_SYS_ROLES.Where(c => c.ROLEID == modelRole.RoleId).FirstOrDefault();
                RoleInfo.R_ROLENAME = modelRole.R_RoleName;
                RoleInfo.R_DESCRIPTION = modelRole.R_DescripTion;
                RoleInfo.MEMO_TEXT = modelRole.MemoText;
                RoleInfo.EDIT_USER = modelRole.EditUser;
                RoleInfo.EDIT_DATE = modelRole.EditDate;

                malldb.Entry(RoleInfo).State = System.Data.Entity.EntityState.Modified;

                malldb.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="RoleId">角色主键</param>
        /// <returns></returns>
        public bool Del(int RoleId)
        {
            try
            {
                T_SYS_ROLES RoleInfo = malldb.T_SYS_ROLES.Find(RoleId);

                malldb.T_SYS_ROLES.Remove(RoleInfo);

                malldb.SaveChanges();

                //删除角色对应的配置

                var model = malldb.T_SYS_ROLEPERMISSION.Where(c => c.ROLEID == RoleId).ToList();

                if (model != null && model.Count() > 0)
                {
                    foreach (var row in model)
                    {
                        T_SYS_ROLEPERMISSION Per = malldb.T_SYS_ROLEPERMISSION.Find(row.PERMISSIONID);

                        malldb.T_SYS_ROLEPERMISSION.Remove(Per);

                        malldb.SaveChanges();
                    }
                }

                //删除角色前还要一个方法，先判断该角色是否已经被占用


                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断当前角色是否已被占用
        /// </summary>
        /// <param name="RoleId">角色主键</param>
        /// <returns></returns>
        public bool Role_UserCount(int RoleId)
        {
            var model = malldb.T_SYS_USER.Where(c => c.U_ROLEID == RoleId).ToList();

            if (model != null && model.Count() > 0)
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
