using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using Nui.MallInfo.Model;

namespace Nui.MallInfo.DAL
{
    public class SysModuleD
    {
        MALLDBEntities malldb = new MALLDBEntities();

        /// <summary>
        /// 功能菜单树加载
        /// </summary>
        /// <returns></returns>
        public DataTable GetModule()
        {
            //int? RoleId = malldb.T_SYS_USER.Where(c => c.U_ACCOUNT == Account).FirstOrDefault().U_ROLEID;

            List<T_SYS_MODULE> moduleList = malldb.T_SYS_MODULE.ToList().Select(c => new T_SYS_MODULE
                {
                    MODULEID = c.MODULEID,
                    M_PARENTID = c.M_PARENTID,
                    M_CODE = c.M_CODE,
                    M_CNAME = c.M_CNAME
                }).ToList<T_SYS_MODULE>();

            DataTable dt = ToDataTable<T_SYS_MODULE>(moduleList);


            return dt;
        }

        /// <summary>
        /// 点击用户加载功能权限菜单树加载
        /// </summary>
        /// <returns></returns>
        public DataTable GetModule(int RoleId)
        {
            //int? RoleId = malldb.T_SYS_USER.Where(c => c.U_ACCOUNT == Account).FirstOrDefault().U_ROLEID;

            var list = from c in malldb.T_SYS_MODULE
                       join g in malldb.T_SYS_ROLEPERMISSION.Where(a => a.ROLEID == RoleId)
                       on c.MODULEID equals g.MODULEID into result
                       from r in result.DefaultIfEmpty()
                       select new
                       {
                           c.MODULEID,
                           c.M_PARENTID,
                           c.M_CODE,
                           c.M_CNAME,
                           r.ROLEID
                       };
            List<SysModuleInfo> moduleList = list.ToList().Select(c => new SysModuleInfo()
            {
                ModuleId = c.MODULEID,
                M_ParentId = (int)c.M_PARENTID,
                M_Code = c.M_CODE,
                M_Name = c.M_CNAME,
                RoleId = c.ROLEID
            }).ToList<SysModuleInfo>();

            DataTable dt = ToDataTable<SysModuleInfo>(moduleList);


            return dt;
        }

        /// <summary>
        /// 用户登录加载
        /// </summary>
        /// <returns></returns>
        public DataTable GetModuleTreeView(int RoleId)
        {
            //int? RoleId = malldb.T_SYS_USER.Where(c => c.U_ACCOUNT == Account).FirstOrDefault().U_ROLEID;

            var list = from c in malldb.T_SYS_ROLEPERMISSION.Where(a => a.ROLEID == RoleId)
                       join g in malldb.T_SYS_MODULE
                       on c.MODULEID equals g.MODULEID into result
                       from r in result.DefaultIfEmpty()
                       select new
                       {
                           r.M_CNAME,
                           r.M_PARENTID,
                           r.MODULEID
                       };
            List<SysModuleInfo> moduleList = list.ToList().Select(c => new SysModuleInfo()
            {
                M_Name = c.M_CNAME,
                M_ParentId = c.M_PARENTID,
                ModuleId = c.MODULEID
            }).ToList<SysModuleInfo>();

            DataTable dt = ToDataTable<SysModuleInfo>(moduleList);


            return dt;
        }

        /// <summary>
        /// 新增权限
        /// </summary>
        /// <param name="RoleModel"></param>
        /// <returns></returns>
        public bool Add(SysModuleInfo RoleModel)
        {

            return true;
        }


        /// <summary>
        /// list to table
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        private DataTable ToDataTable<T>(List<T> items)
        {
            var tb = new DataTable(typeof(T).Name);

            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                tb.Columns.Add(prop.Name, t);
            }

            foreach (T item in items)
            {
                var values = new object[props.Length];

                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                tb.Rows.Add(values);
            }

            return tb;
        }

        public static bool IsNullable(Type t)
        {
            return !t.IsValueType || (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }

        public static Type GetCoreType(Type t)
        {
            if (t != null && IsNullable(t))
            {
                if (!t.IsValueType)
                {
                    return t;
                }
                else
                {
                    return Nullable.GetUnderlyingType(t);
                }
            }
            else
            {
                return t;
            }
        }
    }
}
