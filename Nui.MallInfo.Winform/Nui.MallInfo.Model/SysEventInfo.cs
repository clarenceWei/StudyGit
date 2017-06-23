using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nui.MallInfo.Model
{
   public class SysEventInfo
    {
       public int EventId { get; set; }
       public string E_U_Account { get; set; }
       public string E_U_Name { get; set; }
       public DateTime E_Datetime { get; set; }
       public string E_M_Name { get; set; }
       public string E_M_Code { get; set; }
       public string E_From { get; set; }
       public int E_Type { get; set; }
       public string E_IP { get; set; }
       public string E_Record { get; set; }
    }
}
