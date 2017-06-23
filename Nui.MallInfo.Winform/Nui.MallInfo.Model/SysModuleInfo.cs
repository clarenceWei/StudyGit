using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nui.MallInfo.Model
{
   public class SysModuleInfo
    {
       public int ModuleId { get; set; }
       public int? M_ParentId { get; set; }
       public string M_Code { get; set; }
       public string M_Name { get; set; }
       public string M_DirecTory { get; set; }
       public string M_Level { get; set; }
       public int M_Close { get; set; }
       public string M_Icon { get; set; }
       public string MemoText { get; set; }
       public string EditUser { get; set; }
       public DateTime EditDate { get; set; }

       public int? RoleId { get; set; }
    }
}
