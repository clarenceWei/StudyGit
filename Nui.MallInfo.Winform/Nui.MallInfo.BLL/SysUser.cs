using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nui.MallInfo.Model;
using Nui.MallInfo.IDAL;
using Nui.MallInfo.DAL;

namespace Nui.MallInfo.BLL
{
    public class SysUser:ISysUserD
    {
        SysUserD sysUser_ = new SysUserD();

        /// <summary>
        /// 用户列表加载
        /// </summary>
        /// <param name="StartTime">开始时间</param>
        /// <param name="EndTime">结束时间</param>
        /// <param name="KeyWord">关键字</param>
        /// <param name="UserAccount">登录用户账号</param>
        /// <param name="Page"></param>
        /// <param name="Size"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public SysUserInfo[] GetUserPage(DateTime StartTime, DateTime EndTime, string KeyWord, string UserAccount, int Page, int Size, out int Count)
        {
            string sqlWhere = string.Empty;

            sqlWhere = "WHERE CREATE_DATE BETWEEN @STARTDATE AND @ENDDATE ";

            if (KeyWord != string.Empty)
            {
                sqlWhere += "WHERE (U_ACCOUNT like @KEYWORD ";
                sqlWhere += "OR U_NAME like @KEYWORD ";
                sqlWhere += "OR U_PHONE like @KEYWORD ";
                sqlWhere += "OR U_EMAIL like @KEYWORD ";
                sqlWhere += "OR U_ROLENAME like @KEYWORD ";
                sqlWhere += "OR MEMO_TEXT like @KEYWORD ";
                sqlWhere += "OR EDIT_USER like @KEYWORD ";
            }

            if (UserAccount != "admin")
            {
                sqlWhere += "AND U_ACCOUNT <> 'admin' ";
            }



            return sysUser_.GetUserPage(StartTime, EndTime, KeyWord, sqlWhere, Page, Size, out Count).ToArray<SysUserInfo>();
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="modelUser">用户实体</param>
        /// <returns></returns>
        public bool Add(SysUserInfo modelUser)
        {
            return sysUser_.Add(modelUser);
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="modelUser">用户实体</param>
        /// <returns></returns>
        public bool Edit(SysUserInfo modelUser)
        {
            return sysUser_.Edit(modelUser);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="UserId">用户主键</param>
        /// <returns></returns>
        public bool Del(int UserId)
        {
            return sysUser_.Del(UserId);
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="Account">用户账号</param>
        /// <param name="Pwd">密码，暂不MD5加密</param>
        /// <returns></returns>
        public bool GetLoginUser(string Account, string Pwd)
        {
            return sysUser_.GetLoginUser(Account, Pwd);
        }
    }
}
