using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nui.MallInfo.DAL
{
    public static class CommonHelper
    {
        /// <summary>
        /// 执行命令并返回受影响的行
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int ExecuteSqlCommand(string query, params object[] parameters)
        {
            using (MALLDBEntities db = new MALLDBEntities())
            {
                return db.Database.ExecuteSqlCommand(query, parameters);
            }
        }


        public static DataTable ExecuteSqlCommand(string query, params SqlParameter[] parameters)
        {
            using (MALLDBEntities db = new MALLDBEntities())
            {
                return db.Database.SqlQueryForDataTable(query, parameters);
            }
        }



        /// <summary>
        ///   SQL 语句返回 dataTable
        /// </summary>
        /// <param name="db"></param>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataTable SqlQueryForDataTable(this Database db,
                 string sql,
                 SqlParameter[] parameters, CommandType commandType = CommandType.StoredProcedure)
        {
            DataTable table = new DataTable();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = db.Connection.ConnectionString;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = commandType;

                if (parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                    //foreach (var item in parameters)
                    //{
                    //    cmd.Parameters.Add(item);
                    //}
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return table;
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="S"></typeparam>
        /// <param name="conditions"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public static PagedList<T> FindAllByPage<T, S>(Expression<Func<T, bool>> conditions, Expression<Func<T, S>> orderBy, int pageSize, int pageIndex) where T : class
        {
            MALLDBEntities DbContext = new MALLDBEntities();
            var queryList = conditions == null ? DbContext.Set<T>() : DbContext.Set<T>().Where(conditions) as IQueryable<T>;
            return queryList.OrderByDescending(orderBy).ToPagedList(pageIndex, pageSize);
        }

        /// <summary>
        /// 清空表
        /// </summary>
        /// <param name="tableName"></param>
        public static void CleanTable<T>() where T : class
        {
            var tableName = typeof(T).Name;
            string sql = string.Format("Truncate Table {0}", tableName);
            ExecuteSqlCommand(sql, null);
        }

    }






}
