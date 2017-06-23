using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nui.MallInfo.Model;

namespace Nui.MallInfo.IDAL
{
    public interface ISysRoleD
    {
        /// <summary>
        /// 角色列表加载
        /// </summary>
        /// <param name="KeyWord">关键字</param>
        /// <param name="Page"></param>
        /// <param name="Size"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        SysRoleInfo[] GetRolePage(string KeyWord, string UserAccount, int Page, int Size, out int Count);

        /// <summary>
        /// 通过登录账户获取RoleId
        /// </summary>
        /// <param name="Account">登录用户账号</param>
        /// <returns></returns>
        int? GetRoleId(string Account);

        /// <summary>
        /// 获取角色ID,角色名称列表，除超级管理员角色外
        /// 当然，如果是超级管理员登录，可以加载超级管理员角色
        /// </summary>
        /// <param name="Account">登录用户账号</param>
        /// <returns></returns>
        SysRoleInfo[] GetRoleList(string Account);

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="modelRole">角色实体</param>
        /// <returns></returns>
        bool Add(SysRoleInfo modelRole);

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="modelRole">角色实体</param>
        /// <returns></returns>
        bool Edit(SysRoleInfo modelRole);

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="RoleId">角色主键</param>
        /// <returns></returns>
        bool Del(int RoleId);

        /// <summary>
        /// 判断当前角色是否已被占用
        /// </summary>
        /// <param name="RoleId">角色主键</param>
        /// <returns></returns>
        bool Role_UserCount(int RoleId);
    }
}
