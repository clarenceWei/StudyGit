using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Nui.MallInfo.Web.ManageHTML
{
    public partial class upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mid = Request.QueryString["mid"].ToString();
            try
            {
                //获取上传的文件数据
                HttpPostedFile file = Request.Files["Filedata"];
                string fileName = file.FileName;
                string fileType = Path.GetExtension(fileName).ToLower();
                //由于不同浏览器取出的FileName不同（有的是文件绝对路径，有的是只有文件名），故要进行处理
                if (fileName.IndexOf(' ') > -1)
                {
                    fileName = fileName.Substring(fileName.LastIndexOf(' ') + 1);
                }
                else if (fileName.IndexOf('/') > -1)
                {
                    fileName = fileName.Substring(fileName.LastIndexOf('/') + 1);
                }
                //上传的目录
                string uploadDir = "Download";
                //上传的路径
                string uploadPath = uploadDir + fileName;
                Response.Write("<script>alert(" + uploadPath + ")</script>");
                if (File.Exists(uploadPath)) { File.Delete(uploadPath); }
                //保存文件
                file.SaveAs(Server.MapPath(uploadPath));
                //下面这句代码缺少的话，上传成功后上传队列的显示不会自动消失
               // SqlHelperFactory.RunExecuteNonQuery("insert into temp(temp_mid,temp_content) values('" + mid + "','" + uploadPath + "')");
                //Response.Write("1");
                Session["uploadPath"] = uploadPath;
            }
            catch
            {
                //Response.Write("0");
            }
        }
    }
}