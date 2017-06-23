using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Model;
//using BLL;

namespace Nui.MallInfo.Web.ManageHTML
{
    public partial class ADDLaws : System.Web.UI.Page
    {
        //B_Laws blaws = new B_Laws();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                Response.Redirect("../login.aspx");
            }
            if (IsPostBack)
                return;
            BindDrop();
            if (Request["id"] != null) 
            {
                GetModel();
            }
        }

        public void BindDrop() 
        {
            //Drop_cateID.DataSource = blaws.GetCateData();
            //Drop_cateID.DataTextField = "Title";
            //Drop_cateID.DataValueField = "ID";
            //Drop_cateID.DataBind();
        }

        public void GetModel()
        {
            //string ID = Request["id"].ToString();
            //T_Laws model = new T_Laws();
            //model = blaws.GetModel(ID);
            //txt_clickRate.Text = model.ClickRate.ToString();
            //txt_source.Text = model.Source;
            //txt_sourceUrl.Text = model.SourceUrl;
            //txt_title.Text = model.Title;
            //newscontent.Value = model.Contents;
            //Drop_cateID.SelectedValue = model.CateId.ToString();

        }
        
        protected void btn_ok_Click(object sender, EventArgs e)
        {
//            T_Laws model = new T_Laws();
//            model.Title = txt_title.Text;
//            model.AddTime = DateTime.Now;
//            model.CateId = int.Parse(Drop_cateID.SelectedValue);
//            model.ClickRate = int.Parse(txt_clickRate.Text == "" ? "0" : txt_clickRate.Text);
//            model.Contents = Request.Form["newscontent"].ToString();
//            model.Source = txt_source.Text;
//            model.SourceUrl = txt_sourceUrl.Text;

//            if (Request["id"] == null) 
//            {
//                if (blaws.InsertOrUpdateAbount(model) > 0) 
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('添加成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
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
//                int ID = int.Parse(Request["id"]);
//                model.ID = ID;

//                if (blaws.InsertOrUpdateAbount(model) > 0) 
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('修改成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
//                    Response.Redirect("LawsManage.aspx");
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