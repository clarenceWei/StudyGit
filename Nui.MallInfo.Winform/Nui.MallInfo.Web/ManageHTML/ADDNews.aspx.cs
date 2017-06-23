using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Model;
//using BLL;
using System.IO;
using System.Net;

namespace Nui.MallInfo.Web.ManageHTML
{
    public partial class ADDNews : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                Response.Redirect("../login.aspx");
            }
            if (IsPostBack)
                return;
            Drop();
            if (Request["id"] != null)
            {
                GetModel();
            }
        }
        //B_NewCate bNwecate = new B_NewCate();
        //B_News bNews = new B_News();
        public void Drop() 
        {
            //Drop_cateID.DataSource = bNwecate.GetCateALLData();
            //Drop_cateID.DataTextField = "CateName";
            //Drop_cateID.DataValueField = "ID";
            //Drop_cateID.DataBind();
        }

        public void GetModel() 
        {
            //string ID = Request["id"].ToString();
            //T_News model = new T_News();
            //model = bNews.GetModel(ID);
            //txt_title.Text = model.Title;
            //txt_AttachName.Text = model.AttachName;
            //txt_ClickRate.Text = model.ClickRate.ToString();
            //txt_SourceName.Text = model.SourceName;
            //txt_SourceUrl.Text = model.SourceUrl;
            //newscontent.Value = model.Contents;
            //Drop_cateID.SelectedValue = model.Cate_Id.ToString();
            //Label1.Text = model.AttachUrl;
        }

         
        protected void btn_ok_Click(object sender, EventArgs e)
        {
//            T_News model = new T_News();
//            model.Cate_Id = int.Parse(Drop_cateID.SelectedValue);
//            model.Title = txt_title.Text;
//            model.Contents = Request.Form["newscontent"];
//            model.AddTime = DateTime.Now;
//            model.AttachName = txt_AttachName.Text; 
//            model.SourceName = txt_SourceName.Text;
//            model.SourceUrl = txt_SourceUrl.Text;
//            string clicks = txt_ClickRate.Text == ""?"0" :txt_ClickRate.Text;
//            model.ClickRate = int.Parse(clicks);

//            if (Request["id"] == null)
//            {
//                model.AttachUrl = Session["uploadPath2"] == null ? string.Empty : Session["uploadPath2"].ToString();
//                if (bNews.InsertOrUpdateAbount(model) > 0)
//                {
//                    Session.Clear();
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('添加成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
                   
//                    return;
//                }
//                else
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "error", @"
//                    <script type='text/javascript'>window.art.dialog.tips('添加失败');</script>
//            ");
//                }
//            }
//            else
//            {
//                model.ID = int.Parse(Request["id"]);
//              //  model.AttachUrl = Session["uploadPath"] == null ? string.Empty : Session["uploadPath"].ToString();
//                if (Session["uploadPath2"] != null) 
//                {
//                    model.AttachUrl=Session["uploadPath2"].ToString();
//                }
//                else
//                {
//                    if (Label1.Text == null) 
//                    {
//                        model.AttachUrl = string.Empty;
//                    }
//                    else
//                    {
//                        model.AttachUrl = Label1.Text;
//                    }
//                }

//                if (bNews.InsertOrUpdateAbount(model) > 0)
//                {
//                    Session.Clear();
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('修改成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
//                    Response.Redirect("NewsManage.aspx");
//                    return;
//                }
//                else
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "error", @"
//                    <script type='text/javascript'>window.art.dialog.tips('修改失败');</script>
//            ");
//                }

//            }

        }
    }
}