using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nui.MallInfo.Utility
{
    public static class StringExtension
    {
        public static List<int> SplitToInt(this string str)
        {
            List<int> list = new List<int>();
            if (str.Length == 0 || null == str)
            {
                return list;
            }
            string[] array = str.Split(',');
            foreach (var item in array)
            {
                int value;
                if (int.TryParse(item, out value))
                {
                    list.Add(value);
                }
            }
            return list;
        }
        public static List<Guid> SplitToGuid(this string str)
        {
            List<Guid> list = new List<Guid>();
            if (str.Length == 0 || null == str)
            {
                return list;
            }
            string[] array = str.Split(',');
            foreach (var item in array)
            {
                Guid value;
                if (Guid.TryParse(item, out value))
                {
                    list.Add(value);
                }
            }
            return list;
        }
        public static List<string> SplitToString(this string str)
        {
            List<string> list = new List<string>();
            if (str.Length == 0 || null == str)
            {
                return list;
            }
            string[] array = str.Split(',');
            foreach (var item in array)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
