using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nui.MallInfo.Model;
using System.Data.Entity;
using System.Transactions;


namespace Nui.MallInfo.DAL
{
    public class SysRolePerMissionD
    {

        MALLDBEntities malldb = new MALLDBEntities();

        /// <summary>
        /// 更新角色权限配置
        /// </summary>
        /// <param name="rolePer">角色实体</param>
        /// <param name="toolConfig">权限项</param>
        /// <returns></returns>
        public bool toolSubmit(int RoleId, string toolConfig)
        {
            //删除当前角色对应的所有权限配置

            using (var scope = new TransactionScope())
            {

                var RolePerModel = malldb.T_SYS_ROLEPERMISSION.Where(c => c.ROLEID == RoleId).ToList();

                if (RolePerModel != null && RolePerModel.Count() > 0)
                {
                    foreach (var item in RolePerModel)
                    {
                        T_SYS_ROLEPERMISSION mailModel = malldb.T_SYS_ROLEPERMISSION.Find(item.PERMISSIONID);

                        malldb.T_SYS_ROLEPERMISSION.Remove(mailModel);

                        malldb.SaveChanges();
                    }


                }

                //直接插入数据

                if (!string.IsNullOrEmpty(toolConfig))
                {
                    string[] strModuleId = toolConfig.Substring(0, toolConfig.LastIndexOf(",")).Split(',');

                    if (strModuleId != null && strModuleId.Length > 0)
                    {
                        foreach (var row in strModuleId)
                        {
                            T_SYS_ROLEPERMISSION roleperModel = new T_SYS_ROLEPERMISSION();

                            roleperModel.ROLEID = RoleId;
                            roleperModel.MODULEID = malldb.T_SYS_MODULE.Where(c => c.M_CNAME == row).FirstOrDefault().MODULEID;

                            malldb.T_SYS_ROLEPERMISSION.Add(roleperModel);

                            malldb.SaveChanges();
                        }
                    }
                }


                scope.Complete();

                return true;
            }

        }

        //分页  
        //public IQueryable<T> LoadPagerEntities<S>(int pageSize, int pageIndex, out int total,  
        //    Func<T, bool> whereLambda, bool isAsc, Func<T, S> orderByLambda)  
        //{  
        //    var tempData = db.Set<T>().Where<T>(whereLambda);  

        //    total = tempData.Count();  

        //    //排序获取当前页的数据  
        //    if (isAsc)  
        //    {  
        //        tempData = tempData.OrderBy<T, S>(orderByLambda).  
        //              Skip<T>(pageSize * (pageIndex - 1)).  
        //              Take<T>(pageSize).AsQueryable();  
        //    }  
        //    else  
        //    {  
        //        tempData = tempData.OrderByDescending<T, S>(orderByLambda).  
        //             Skip<T>(pageSize * (pageIndex - 1)).  
        //             Take<T>(pageSize).AsQueryable();  
        //    }  
        //    return tempData.AsQueryable();  
        //}  

    }
}
