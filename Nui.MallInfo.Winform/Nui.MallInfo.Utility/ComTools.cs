using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Collections;

namespace Nui.MallInfo.Utility
{
   public class ComTools
    {
        
        /// <summary>
        /// 将数据表中的内容转换为IList
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="datatable"></param>
        /// <returns></returns>
        public static List<T> ToEntityList<T>(DataTable datatable)
        {
            List<T> entities = new List<T>();
            PropertyInfo[] propertys = typeof(T).GetProperties();

            foreach (DataRow row in datatable.Rows)
            {
                T entity = Activator.CreateInstance<T>(); 

                foreach (PropertyInfo pi in propertys)
                {
                    if (datatable.Columns.Contains(pi.Name))
                    {
                        if (!pi.CanWrite) continue;
                        object value = row[pi.Name];
                        if (value != DBNull.Value)
                            pi.SetValue(entity, value, null);
                    }
                }
                entities.Add(entity);
            }

            return entities;
        }
    
       /// <summary>
        /// 将数据表中的内容转换为T
       /// </summary>
       /// <typeparam name="T"></typeparam>
       /// <param name="datatable"></param>
       /// <returns></returns>
        public static T ToEntity<T>(DataTable datatable)
        {

            PropertyInfo[] propertys = typeof(T).GetProperties();
            if (datatable == null || datatable.Rows.Count == 0)
            { 
                return default(T);
            }
            DataRow row = datatable.Rows[0];
            T entity = Activator.CreateInstance<T>();

            foreach (PropertyInfo pi in propertys)
            {
                if (datatable.Columns.Contains(pi.Name))
                {
                    if (!pi.CanWrite) continue;
                    object value = row[pi.Name];
                    if (value != DBNull.Value)
                        pi.SetValue(entity, value, null);
                }
            }
            return entity;
        }

        public static DataTable ToDataTable(IList list)
        {
            DataTable result = new DataTable(); 
            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties(); 
                foreach (PropertyInfo pi in propertys) { 
                    result.Columns.Add(pi.Name, pi.PropertyType); 
                }

                for (int i = 0; i < list.Count; i++) { 
                    ArrayList tempList = new ArrayList(); 
                    foreach (PropertyInfo pi in propertys) { 
                        object obj = pi.GetValue(list[i], null);
                        tempList.Add(obj);
                    } 
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }
            return result;
        }
        public static DataTable ToDataTable<T>(T list)
        {
            DataTable result = new DataTable();
            if (list != null)
            {
                PropertyInfo[] propertys = list.GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    Type colType = pi.PropertyType;
                    if ((colType.IsGenericType) && colType.GetGenericTypeDefinition() == typeof(Nullable<>)) {
                        colType = colType.GetGenericArguments()[0];
                    }
                    result.Columns.Add(new DataColumn(pi.Name,colType));  //pi.Name, pi.PropertyType
                }


                ArrayList tempList = new ArrayList();
                foreach (PropertyInfo pi in propertys)
                {
                    object obj = pi.GetValue(list, null);
                    tempList.Add(obj);
                }
                object[] array = tempList.ToArray();
                result.LoadDataRow(array, true);

            }
            return result;
        }


        public static string[] RegexSplitString(string str, string patten) {
            return Regex.Split(str, patten); 
        }
        
       
    }

}
