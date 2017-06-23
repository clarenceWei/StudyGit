using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Nui.MallInfo.IDAL
{
    public interface ISysModuleD
    {
        /// <summary>
        /// 功能菜单树加载
        /// </summary>
        /// <returns></returns>
        DataTable GetModule();

        /// <summary>
        /// 点击用户加载功能菜单树加载
        /// </summary>
        /// <returns></returns>
        DataTable GetModule(int RoleId);

        /// <summary>
        /// 用户登录加载
        /// </summary>
        /// <returns></returns>
        DataTable GetModuleTreeView(int RoleId);
    }
}
