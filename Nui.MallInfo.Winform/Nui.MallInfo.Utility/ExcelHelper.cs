using System;
using System.IO;
using System.Data;
using System.Collections;
using System.Data.OleDb;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Collections.Generic;

namespace Nui.MallInfo.Utility
{
    /// <summary>
    /// Excel操作类
    /// </summary>
    /// Microsoft Excel 11.0 Object Library
    public class ExcelHelper
    {
        #region 数据导出至Excel文件
        /// </summary> 
        /// 导出Excel文件，自动返回可下载的文件流 
        /// </summary> 
        public static void DataTable1Excel(System.Data.DataTable dtData)
        {
            GridView gvExport = null;
            HttpContext curContext = HttpContext.Current;
            StringWriter strWriter = null;
            HtmlTextWriter htmlWriter = null;
            if (dtData != null)
            {
                curContext.Response.ContentType = "application/vnd.ms-excel";
                curContext.Response.ContentEncoding = System.Text.Encoding.GetEncoding("gb2312");
                curContext.Response.Charset = "utf-8";
                strWriter = new StringWriter();
                htmlWriter = new HtmlTextWriter(strWriter);
                gvExport = new GridView();
                gvExport.DataSource = dtData.DefaultView;
                gvExport.AllowPaging = false;
                gvExport.DataBind();
                gvExport.RenderControl(htmlWriter);
                curContext.Response.Write("<meta http-equiv=\"Content-Type\" content=\"text/html;charset=gb2312\"/>" + strWriter.ToString());
                curContext.Response.End();
            }
        }

        /// <summary>
        /// 导出Excel文件，转换为可读模式
        /// </summary>
        public static void DataTable2Excel(System.Data.DataTable dtData)
        {
            DataGrid dgExport = null;
            HttpContext curContext = HttpContext.Current;
            StringWriter strWriter = null;
            HtmlTextWriter htmlWriter = null;

            if (dtData != null)
            {
                curContext.Response.ContentType = "application/vnd.ms-excel";
                curContext.Response.ContentEncoding = System.Text.Encoding.UTF8;
                curContext.Response.Charset = "";
                strWriter = new StringWriter();
                htmlWriter = new HtmlTextWriter(strWriter);
                dgExport = new DataGrid();
                dgExport.DataSource = dtData.DefaultView;
                dgExport.AllowPaging = false;
                dgExport.DataBind();
                dgExport.RenderControl(htmlWriter);
                curContext.Response.Write(strWriter.ToString());
                curContext.Response.End();
            }
        }

        /// <summary>
        /// 导出Excel文件，并自定义文件名
        /// </summary>
        public static void DataTable3Excel(System.Data.DataTable dtData, String FileName)
        {
            GridView dgExport = null;
            HttpContext curContext = HttpContext.Current;
            StringWriter strWriter = null;
            HtmlTextWriter htmlWriter = null;

            if (dtData != null)
            {
                HttpUtility.UrlEncode(FileName, System.Text.Encoding.UTF8);
                curContext.Response.AddHeader("content-disposition", "attachment;filename=" + HttpUtility.UrlEncode(FileName, System.Text.Encoding.UTF8) + ".xls");
                curContext.Response.ContentType = "application nd.ms-excel";
                curContext.Response.ContentEncoding = System.Text.Encoding.UTF8;
                curContext.Response.Charset = "UTF-8";
                strWriter = new StringWriter();
                htmlWriter = new HtmlTextWriter(strWriter);
                dgExport = new GridView();
                dgExport.DataSource = dtData.DefaultView;
                dgExport.AllowPaging = false;
                dgExport.DataBind();
                curContext.Response.Write("<meta http-equiv=\"content-type\" content=\"application/ms-excel; charset=UTF-8\"/>");
                dgExport.RenderControl(htmlWriter);
                curContext.Response.Write(strWriter.ToString());
                curContext.Response.End();
            }
        }

        /// <summary>
        /// 导出Excel文件，并自定义文件名
        /// </summary>
        public static void DataTable3Excel(System.Data.DataSet dsData, String FileName)
        {
            GridView dgExport = null;
            HttpContext curContext = HttpContext.Current;
            StringWriter strWriter = null;
            HtmlTextWriter htmlWriter = null;

            if (dsData != null)
            {
                HttpUtility.UrlEncode(FileName, System.Text.Encoding.UTF8);
                curContext.Response.AddHeader("content-disposition", "attachment;filename=" + HttpUtility.UrlEncode(FileName, System.Text.Encoding.UTF8) + ".xls");
                curContext.Response.ContentType = "application nd.ms-excel";
                curContext.Response.ContentEncoding = System.Text.Encoding.UTF8;
                curContext.Response.Charset = "GB2312";

                foreach (DataTable dtData in dsData.Tables)
                {
                    if (dtData != null && dtData.Rows.Count == 0)
                    {
                        //continue;
                        DataRow dr = dtData.NewRow();
                        dtData.Rows.Add(dr);
                    }

                    strWriter = new StringWriter();
                    htmlWriter = new HtmlTextWriter(strWriter);
                    dgExport = new GridView();
                    dgExport.DataSource = dtData.DefaultView;
                    dgExport.AllowPaging = false;
                    dgExport.DataBind();
                    dgExport.RenderControl(htmlWriter);


                    curContext.Response.Write(dtData.TableName);
                    curContext.Response.Write(strWriter.ToString());
                    curContext.Response.Write("");
                }
                curContext.Response.End();
            }
        }


        /// <summary>
        /// 将数据导出至Excel文件
        /// </summary>
        /// <param name="Table">DataTable对象</param>
        /// <param name="ExcelFilePath">Excel文件路径</param>
        public static bool OutputToExcel(DataTable Table, string ExcelFilePath)
        {
            if (File.Exists(ExcelFilePath))
            {
                throw new Exception("该文件已经存在！");
            }

            if ((Table.TableName.Trim().Length == 0) || (Table.TableName.ToLower() == "table"))
            {
                Table.TableName = "Sheet1";
            }

            //数据表的列数
            int ColCount = Table.Columns.Count;

            //用于记数，实例化参数时的序号
            int i = 0;

            //创建参数
            OleDbParameter[] para = new OleDbParameter[ColCount];

            //创建表结构的SQL语句
            string TableStructStr = @"Create Table " + Table.TableName + "(";

            //连接字符串
            string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ExcelFilePath + ";Extended Properties=Excel 8.0;";
            OleDbConnection objConn = new OleDbConnection(connString);

            //创建表结构
            OleDbCommand objCmd = new OleDbCommand();

            //数据类型集合
            ArrayList DataTypeList = new ArrayList();
            DataTypeList.Add("System.Decimal");
            DataTypeList.Add("System.Double");
            DataTypeList.Add("System.Int16");
            DataTypeList.Add("System.Int32");
            DataTypeList.Add("System.Int64");
            DataTypeList.Add("System.Single");

            //遍历数据表的所有列，用于创建表结构
            foreach (DataColumn col in Table.Columns)
            {
                //如果列属于数字列，则设置该列的数据类型为double
                if (DataTypeList.IndexOf(col.DataType.ToString()) >= 0)
                {
                    para[i] = new OleDbParameter("@" + col.ColumnName, OleDbType.Double);
                    objCmd.Parameters.Add(para[i]);

                    //如果是最后一列
                    if (i + 1 == ColCount)
                    {
                        TableStructStr += col.ColumnName + " double)";
                    }
                    else
                    {
                        TableStructStr += col.ColumnName + " double,";
                    }
                }
                else
                {
                    para[i] = new OleDbParameter("@" + col.ColumnName, OleDbType.VarChar);
                    objCmd.Parameters.Add(para[i]);

                    //如果是最后一列
                    if (i + 1 == ColCount)
                    {
                        TableStructStr += col.ColumnName + " varchar)";
                    }
                    else
                    {
                        TableStructStr += col.ColumnName + " varchar,";
                    }
                }
                i++;
            }

            //创建Excel文件及文件结构
            try
            {
                objCmd.Connection = objConn;
                objCmd.CommandText = TableStructStr;

                if (objConn.State == ConnectionState.Closed)
                {
                    objConn.Open();
                }
                objCmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                throw exp;
            }

            //插入记录的SQL语句
            string InsertSql_1 = "Insert into " + Table.TableName + " (";
            string InsertSql_2 = " Values (";
            string InsertSql = "";

            //遍历所有列，用于插入记录，在此创建插入记录的SQL语句
            for (int colID = 0; colID < ColCount; colID++)
            {
                if (colID + 1 == ColCount)  //最后一列
                {
                    InsertSql_1 += Table.Columns[colID].ColumnName + ")";
                    InsertSql_2 += "@" + Table.Columns[colID].ColumnName + ")";
                }
                else
                {
                    InsertSql_1 += Table.Columns[colID].ColumnName + ",";
                    InsertSql_2 += "@" + Table.Columns[colID].ColumnName + ",";
                }
            }

            InsertSql = InsertSql_1 + InsertSql_2;

            //遍历数据表的所有数据行
            for (int rowID = 0; rowID < Table.Rows.Count; rowID++)
            {
                for (int colID = 0; colID < ColCount; colID++)
                {
                    if (para[colID].DbType == DbType.Double && Table.Rows[rowID][colID].ToString().Trim() == "")
                    {
                        para[colID].Value = 0;
                    }
                    else
                    {
                        para[colID].Value = Table.Rows[rowID][colID].ToString().Trim();
                    }
                }
                try
                {
                    objCmd.CommandText = InsertSql;
                    objCmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    string str = exp.Message;
                }
            }
            try
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
            return true;
        }

        /// <summary>
        /// 将数据导出至Excel文件
        /// </summary>
        /// <param name="Table">DataTable对象</param>
        /// <param name="Columns">要导出的数据列集合</param>
        /// <param name="ExcelFilePath">Excel文件路径</param>
        public static bool OutputToExcel(DataTable Table, ArrayList Columns, string ExcelFilePath)
        {
            if (File.Exists(ExcelFilePath))
            {
                throw new Exception("该文件已经存在！");
            }

            //如果数据列数大于表的列数，取数据表的所有列
            if (Columns.Count > Table.Columns.Count)
            {
                for (int s = Table.Columns.Count + 1; s <= Columns.Count; s++)
                {
                    Columns.RemoveAt(s);   //移除数据表列数后的所有列
                }
            }

            //遍历所有的数据列，如果有数据列的数据类型不是 DataColumn，则将它移除
            DataColumn column = new DataColumn();
            for (int j = 0; j < Columns.Count; j++)
            {
                try
                {
                    column = (DataColumn)Columns[j];
                }
                catch (Exception)
                {
                    Columns.RemoveAt(j);
                }
            }
            if ((Table.TableName.Trim().Length == 0) || (Table.TableName.ToLower() == "table"))
            {
                Table.TableName = "Sheet1";
            }

            //数据表的列数
            int ColCount = Columns.Count;

            //创建参数
            OleDbParameter[] para = new OleDbParameter[ColCount];

            //创建表结构的SQL语句
            string TableStructStr = @"Create Table " + Table.TableName + "(";

            //连接字符串
            string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ExcelFilePath + ";Extended Properties=Excel 8.0;";
            OleDbConnection objConn = new OleDbConnection(connString);

            //创建表结构
            OleDbCommand objCmd = new OleDbCommand();

            //数据类型集合
            ArrayList DataTypeList = new ArrayList();
            DataTypeList.Add("System.Decimal");
            DataTypeList.Add("System.Double");
            DataTypeList.Add("System.Int16");
            DataTypeList.Add("System.Int32");
            DataTypeList.Add("System.Int64");
            DataTypeList.Add("System.Single");

            DataColumn col = new DataColumn();

            //遍历数据表的所有列，用于创建表结构
            for (int k = 0; k < ColCount; k++)
            {
                col = (DataColumn)Columns[k];

                //列的数据类型是数字型
                if (DataTypeList.IndexOf(col.DataType.ToString().Trim()) >= 0)
                {
                    para[k] = new OleDbParameter("@" + col.Caption.Trim(), OleDbType.Double);
                    objCmd.Parameters.Add(para[k]);

                    //如果是最后一列
                    if (k + 1 == ColCount)
                    {
                        TableStructStr += col.Caption.Trim() + " Double)";
                    }
                    else
                    {
                        TableStructStr += col.Caption.Trim() + " Double,";
                    }
                }
                else
                {
                    para[k] = new OleDbParameter("@" + col.Caption.Trim(), OleDbType.VarChar);
                    objCmd.Parameters.Add(para[k]);

                    //如果是最后一列
                    if (k + 1 == ColCount)
                    {
                        TableStructStr += col.Caption.Trim() + " VarChar)";
                    }
                    else
                    {
                        TableStructStr += col.Caption.Trim() + " VarChar,";
                    }
                }
            }

            //创建Excel文件及文件结构
            try
            {
                objCmd.Connection = objConn;
                objCmd.CommandText = TableStructStr;

                if (objConn.State == ConnectionState.Closed)
                {
                    objConn.Open();
                }
                objCmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                throw exp;
            }

            //插入记录的SQL语句
            string InsertSql_1 = "Insert into " + Table.TableName + " (";
            string InsertSql_2 = " Values (";
            string InsertSql = "";

            //遍历所有列，用于插入记录，在此创建插入记录的SQL语句
            for (int colID = 0; colID < ColCount; colID++)
            {
                if (colID + 1 == ColCount)  //最后一列
                {
                    InsertSql_1 += Columns[colID].ToString().Trim() + ")";
                    InsertSql_2 += "@" + Columns[colID].ToString().Trim() + ")";
                }
                else
                {
                    InsertSql_1 += Columns[colID].ToString().Trim() + ",";
                    InsertSql_2 += "@" + Columns[colID].ToString().Trim() + ",";
                }
            }

            InsertSql = InsertSql_1 + InsertSql_2;

            //遍历数据表的所有数据行
            DataColumn DataCol = new DataColumn();
            for (int rowID = 0; rowID < Table.Rows.Count; rowID++)
            {
                for (int colID = 0; colID < ColCount; colID++)
                {
                    //因为列不连续，所以在取得单元格时不能用行列编号，列需得用列的名称
                    DataCol = (DataColumn)Columns[colID];
                    if (para[colID].DbType == DbType.Double && Table.Rows[rowID][DataCol.Caption].ToString().Trim() == "")
                    {
                        para[colID].Value = 0;
                    }
                    else
                    {
                        para[colID].Value = Table.Rows[rowID][DataCol.Caption].ToString().Trim();
                    }
                }
                try
                {
                    objCmd.CommandText = InsertSql;
                    objCmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    string str = exp.Message;
                }
            }
            try
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
            return true;
        }
        #endregion

        /// <summary>
        /// 获取Excel文件数据表列表
        /// </summary>
        public static ArrayList GetExcelTables(string ExcelFileName)
        {
            DataTable dt = new DataTable();
            ArrayList TablesList = new ArrayList();
            if (File.Exists(ExcelFileName))
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source=" + ExcelFileName))
                {
                    try
                    {
                        conn.Open();
                        dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    }
                    catch (Exception exp)
                    {
                        throw exp;
                    }

                    //获取数据表个数
                    int tablecount = dt.Rows.Count;
                    for (int i = 0; i < tablecount; i++)
                    {
                        string tablename = dt.Rows[i][2].ToString().Trim().TrimEnd('$');
                        if (TablesList.IndexOf(tablename) < 0)
                        {
                            TablesList.Add(tablename);
                        }
                    }
                }
            }
            return TablesList;
        }

        /// <summary>
        /// 将Excel文件导出至DataTable(第一行作为表头)
        /// </summary>
        /// <param name="ExcelFilePath">Excel文件路径</param>
        /// <param name="TableName">数据表名，如果数据表名错误，默认为第一个数据表名</param>
        public static DataTable InputFromExcel(string ExcelFilePath, string TableName)
        {
            if (!File.Exists(ExcelFilePath))
            {
                throw new Exception("Excel文件不存在！");
            }

            //如果数据表名不存在，则数据表名为Excel文件的第一个数据表
            ArrayList TableList = new ArrayList();
            TableList = GetExcelTables(ExcelFilePath);

            if (TableName.IndexOf(TableName) < 0)
            {
                TableName = TableList[0].ToString().Trim();
            }

            DataTable table = new DataTable();
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ExcelFilePath + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
            OleDbConnection dbcon = new OleDbConnection(strConn);
            OleDbCommand cmd = new OleDbCommand("select * from [" + TableName + "$]", dbcon);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

            try
            {
                if (dbcon.State == ConnectionState.Closed)
                {
                    dbcon.Open();
                }
                adapter.Fill(table);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                if (dbcon.State == ConnectionState.Open)
                {
                    dbcon.Close();
                }
            }
            return table;
        }



        /// <summary>
        /// 获取Excel文件指定数据表的数据列表
        /// </summary>
        /// <param name="ExcelFileName">Excel文件名</param>
        /// <param name="TableName">数据表名</param>
        public static ArrayList GetExcelTableColumns(string ExcelFileName, string TableName)
        {
            DataTable dt = new DataTable();
            ArrayList ColsList = new ArrayList();
            if (File.Exists(ExcelFileName))
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source=" + ExcelFileName))
                {
                    conn.Open();
                    dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, TableName, null });
                    //获取列个数
                    int colcount = dt.Rows.Count;
                    for (int i = 0; i < colcount; i++)
                    {
                        string colname = dt.Rows[i]["Column_Name"].ToString().Trim();
                        ColsList.Add(colname);
                    }
                }
            }
            return ColsList;
        }


        //将IEnumerable<T>类型的集合转换为DataTable类型 
        public static DataTable LINQToDataTable<T>(IEnumerable<T> varlist)
        {   //定义要返回的DataTable对象
            DataTable dtReturn = new DataTable();
            // 保存列集合的属性信息数组
            PropertyInfo[] oProps = null;
            if (varlist == null) return dtReturn;//安全性检查
            //循环遍历集合，使用反射获取类型的属性信息
            foreach (T rec in varlist)
            {
                //使用反射获取T类型的属性信息，返回一个PropertyInfo类型的集合
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    //循环PropertyInfo数组
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;//得到属性的类型
                        //如果属性为泛型类型
                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {   //获取泛型类型的参数
                            colType = colType.GetGenericArguments()[0];
                        }
                        //将类型的属性名称与属性类型作为DataTable的列数据
                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }
                //新建一个用于添加到DataTable中的DataRow对象
                DataRow dr = dtReturn.NewRow();
                //循环遍历属性集合
                foreach (PropertyInfo pi in oProps)
                {   //为DataRow中的指定列赋值
                    dr[pi.Name] = pi.GetValue(rec, null) == null ?
                        DBNull.Value : pi.GetValue(rec, null);
                }
                //将具有结果值的DataRow添加到DataTable集合中
                dtReturn.Rows.Add(dr);
            }
            return dtReturn;//返回DataTable对象
        }



        public static List<DataTable> GetDataTable(string excelFileName, int headerRow = 0)
        {
            List<DataTable> dtList = new List<DataTable>();
            try
            {
                Aspose.Cells.Workbook workBook = new Aspose.Cells.Workbook(excelFileName);
                foreach (var r in workBook.Worksheets)
                {
                    try
                    {
                        //获取所有的数据
                        var dt = r.Cells.ExportDataTable(headerRow + 1, 0, r.Cells.Rows.Count, r.Cells.Columns.Count);
                        //设置header
                        for (int i = 0; i < r.Cells.Columns.Count; i++)
                        {
                            try
                            {
                                dt.Columns[i].ColumnName = dt.Rows[headerRow][i].ToString();
                            }
                            catch
                            { }
                        }
                        dtList.Add(dt);
                    }
                    catch
                    { }
                }
            }
            catch
            { }
            return dtList;
        }



        public static List<DataTable> GetDataTableFromExcel(string ExcelFileName)
        {
            List<DataTable> dtList = new List<DataTable>();
            try
            {
                Aspose.Cells.Workbook workBook = new Aspose.Cells.Workbook(ExcelFileName);
                foreach (var r in workBook.Worksheets)
                {
                    try
                    {
                        dtList.Add(r.Cells.ExportDataTable(1, 0, r.Cells.Rows.Count, r.Cells.Columns.Count));
                    }
                    catch
                    { }
                }
            }
            catch
            { }
            return dtList;
        }



    }

}
