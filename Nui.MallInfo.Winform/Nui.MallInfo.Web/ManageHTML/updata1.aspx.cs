using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Nui.MallInfo.Web.ManageHTML
{
    public partial class updata1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //获取上传的文件数据
                HttpPostedFile file = Request.Files["Filedata"];
                string fileName = file.FileName;
                string fileType = Path.GetExtension(fileName).ToLower();
                //由于不同浏览器取出的FileName不同（有的是文件绝对路径，有的是只有文件名），故要进行处理
                fileName = fileName.Trim();
                if (fileName.IndexOf('/') > -1)
                {
                    fileName = fileName.Substring(fileName.LastIndexOf('/') + 1);
                }
                //上传的目录
                string uploadDir = "../../Productimg/";
                //上传的路径
                string uploadPath = uploadDir + fileName;
                if (File.Exists(uploadPath)) { File.Delete(uploadPath); }
                //保存文件
                file.SaveAs(Server.MapPath(uploadPath));
                // SqlHelperFactory.RunExecuteNonQuery("insert into temp(temp_mid,temp_content)values('" + mid + "','" + uploadPath + "')");
                // Response.Write(uploadPath);
                Session["uploadPath1"] = uploadPath;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}