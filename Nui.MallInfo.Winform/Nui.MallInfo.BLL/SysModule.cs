using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nui.MallInfo.IDAL;
using Nui.MallInfo.Model;
using Nui.MallInfo.DAL;

namespace Nui.MallInfo.BLL
{
    public class SysModule:ISysModuleD
    {
        SysModuleD sysModule_ = new SysModuleD();

        /// <summary>
        /// 功能菜单树加载
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable GetModule()
        {
            return sysModule_.GetModule();
        }

        /// <summary>
        /// 点击用户加载功能菜单树加载
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable GetModule(int RoleId)
        {
            return sysModule_.GetModule(RoleId);
        }

        /// <summary>
        /// 用户登录加载
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable GetModuleTreeView(int RoleId)
        {
            return sysModule_.GetModuleTreeView(RoleId);
        }
    }
}
