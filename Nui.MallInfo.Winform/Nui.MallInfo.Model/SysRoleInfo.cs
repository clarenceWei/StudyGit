using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nui.MallInfo.Model
{
   public class SysRoleInfo
    {
       public int RoleId { get; set; }
       public string R_RoleName { get; set; }
       public string R_DescripTion { get; set; }
       public string MemoText { get; set; }
       public string EditUser { get; set; }
       public DateTime? EditDate { get; set; }

    }
}
