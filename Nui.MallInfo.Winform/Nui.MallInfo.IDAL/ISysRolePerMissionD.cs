using Nui.MallInfo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nui.MallInfo.IDAL
{
    public interface ISysRolePerMissionD
    {
        /// <summary>
        /// 更新角色权限配置
        /// </summary>
        /// <param name="rolePer">角色实体</param>
        /// <param name="toolConfig">权限项</param>
        /// <returns></returns>
        bool toolSubmit(int RoleId, string toolConfig);
    }
}
