using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nui.MallInfo.Model;

namespace Nui.MallInfo.IDAL
{
    public interface ISysUserD
    {
        /// <summary>
        /// 用户列表加载
        /// </summary>
        /// <param name="StartTime"></param>
        /// <param name="EndTime"></param>
        /// <param name="KeyWord"></param>
        /// <param name="Page"></param>
        /// <param name="Size"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        SysUserInfo[] GetUserPage(DateTime StartTime, DateTime EndTime, string KeyWord, string UserAccount, int Page, int Size, out int Count);

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="modelUser">用户实体</param>
        /// <returns></returns>
        bool Add(SysUserInfo modelUser);

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="modelUser">用户实体</param>
        /// <returns></returns>
        bool Edit(SysUserInfo modelUser);

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="UserId">用户主键</param>
        /// <returns></returns>
        bool Del(int UserId);

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="Account">用户账号</param>
        /// <param name="Pwd">密码，暂不MD5加密</param>
        /// <returns></returns>
        bool GetLoginUser(string Account, string Pwd);
    }
}
