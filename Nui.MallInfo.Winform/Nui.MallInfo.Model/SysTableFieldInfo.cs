using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nui.MallInfo.Model
{
    public class SysTableFieldInfo
    {
        public int TableFieldId { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string CapTion { get; set; }
        public int CanChoose { get; set; }
        public string MemoText { get; set; }
        public string EditUser { get; set; }
        public DateTime EditDate { get; set; }

    }
}
