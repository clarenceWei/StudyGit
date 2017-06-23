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
    public partial class ADDMemberNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                Response.Redirect("../login.aspx");
            }
            if (IsPostBack)
                return;
            GetDrop();
            if (Request["id"] != null)
            {
                GetModels();
            }
        }
        //B_MemberNews bMemberNews = new B_MemberNews();
        //B_MemberCate Bmembercate = new B_MemberCate();
        public void GetDrop()
        {
            //DropDownCateID.DataSource = Bmembercate.GetCateALLData();
            //DropDownCateID.DataTextField = "TypeName";
            //DropDownCateID.DataValueField = "ID";
            //DropDownCateID.DataBind();
        }

        public void GetModels()
        {
            //string ID = Request["id"].ToString();
            //T_MemberNews model = new T_MemberNews();
            //model = bMemberNews.GetModel(ID);
            //txt_ClickRate.Text = model.ClickRate.ToString();
            //txt_Source.Text = model.Source;
            //txt_SourceUrl.Text = model.SourceUrl;
            //txt_title.Text = model.Title;
            //newscontent.Value = model.Contents;
            //DropDownCateID.SelectedValue = model.CateId.ToString();
        }

        protected void btn_ok_Click(object sender, EventArgs e)
        {
//            T_MemberNews model = new T_MemberNews();
//            model.AddDate = DateTime.Now;
//            model.CateId = int.Parse(DropDownCateID.SelectedValue);
//            model.ClickRate = int.Parse(txt_ClickRate.Text);
//            model.Contents = Request.Form["newscontent"];
//            model.Source = txt_Source.Text;
//            model.SourceUrl = txt_SourceUrl.Text;
//            model.Title = txt_title.Text;

//            if (Request["id"] == null)
//            {
//                if (bMemberNews.InsertOrUpdateAbount(model) > 0)
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('添加成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
//                    //  Response.Redirect("AbountManage.aspx");
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
//                if (bMemberNews.InsertOrUpdateAbount(model) > 0)
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('修改成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
//                    Response.Redirect("MemberNewsManage.aspx");
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