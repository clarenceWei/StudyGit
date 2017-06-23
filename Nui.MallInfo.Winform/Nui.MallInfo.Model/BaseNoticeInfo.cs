using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nui.MallInfo.Model
{
    public class BaseNoticeInfo
    {
        public int NoticeId { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string PubliSher { get; set; }
        public DateTime SendTime { get; set; }
        public DateTime ExpipeTime { get; set; }
        public string EditUser { get; set; }
        public DateTime EditDate { get; set; }

    }
}
