using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nui.MallInfo.Model;
using Nui.MallInfo.IDAL;
using Nui.MallInfo.DAL;

namespace Nui.MallInfo.BLL
{
    public class SysRolePerMission:ISysRolePerMissionD
    {
        SysRolePerMissionD _sysRolePerMissionD = new SysRolePerMissionD();

        /// <summary>
        /// 更新角色权限配置
        /// </summary>
        /// <param name="rolePer">角色实体</param>
        /// <param name="toolConfig">权限项</param>
        /// <returns></returns>
        public bool toolSubmit(int RoleId, string toolConfig)
        {
            return _sysRolePerMissionD.toolSubmit(RoleId, toolConfig);
        }
    }
}
