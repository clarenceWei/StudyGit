using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nui.MallInfo.Model
{
   public class BaseConfigInfo
    {
       public int ConfigId { get; set; }
       public string ConfigType { get; set; }
       public string ConfigCode { get; set; }
       public string ConfigName { get; set; }
       public string ConfigValue { get; set; }
       public string MemoText { get; set; }
       public string EditUser { get; set; }
       public DateTime EditDate { get; set; }
      
    }
}
