using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nui.MallInfo.Model;
using Nui.MallInfo.IDAL;
using Nui.MallInfo.DAL;

namespace Nui.MallInfo.BLL
{
    public class SysRole : ISysRoleD
    {
        SysRoleD sysRole_ = new SysRoleD();


        /// <summary>
        /// 角色列表加载
        /// </summary>
        /// <param name="KeyWord">关键字</param>
        /// <param name="Page"></param>
        /// <param name="Size"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public SysRoleInfo[] GetRolePage(string KeyWord, string UserAccount, int Page, int Size, out int Count)
        {
            string sqlWhere = string.Empty;

            //sqlWhere = "WHERE CREATE_DATE BETWEEN @STARTDATE AND @ENDDATE ";

            if (KeyWord != string.Empty)
            {
                sqlWhere += "WHERE (R_ROLENAME like @KEYWORD ";
                sqlWhere += "OR R_DESCRIPTION like @KEYWORD ";
                sqlWhere += "OR MEMO_TEXT like @KEYWORD ";
                sqlWhere += "OR EDIT_USER like @KEYWORD ";
            }

            if (UserAccount != "admin")
            {
                sqlWhere += "AND ROLEID <> 10000 ";
            }

            return sysRole_.GetRolePage(KeyWord, "", Page, Size, out Count).ToArray<SysRoleInfo>(); ;
        }

        /// <summary>
        /// 通过登录账户获取RoleId
        /// </summary>
        /// <param name="Account">登录用户账号</param>
        /// <returns></returns>
        public int? GetRoleId(string Account)
        {
            return sysRole_.GetRoleId(Account);
        }

        /// <summary>
        /// 获取角色ID,角色名称列表，除超级管理员角色外
        /// 当然，如果是超级管理员登录，可以加载超级管理员角色
        /// </summary>
        /// <param name="Account">登录用户账号</param>
        /// <returns></returns>
        public SysRoleInfo[] GetRoleList(string Account)
        {
            return sysRole_.GetRoleList(Account).ToArray<SysRoleInfo>();
        }

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="modelRole">角色实体</param>
        /// <returns></returns>
        public bool Add(SysRoleInfo modelRole)
        {
            return sysRole_.Add(modelRole);
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="modelRole">角色实体</param>
        /// <returns></returns>
        public bool Edit(SysRoleInfo modelRole)
        {
            return sysRole_.Edit(modelRole);
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="RoleId">角色主键</param>
        /// <returns></returns>
        public bool Del(int RoleId)
        {
            return sysRole_.Del(RoleId);
        }

        /// <summary>
        /// 判断当前角色是否已被占用
        /// </summary>
        /// <param name="RoleId">角色主键</param>
        /// <returns></returns>
        public bool Role_UserCount(int RoleId)
        {
            return sysRole_.Role_UserCount(RoleId);
        }
    }
}
