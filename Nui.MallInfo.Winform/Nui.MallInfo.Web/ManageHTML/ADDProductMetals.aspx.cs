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
    public partial class ADDProductMetals : System.Web.UI.Page
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
        //B_ProductMetals bpmetals = new B_ProductMetals();
        public void Drop()
        {
            //DropDownCateID.DataSource = bpmetals.GetCateData();
            //DropDownCateID.DataTextField = "Title";
            //DropDownCateID.DataValueField = "ID";
            //DropDownCateID.DataBind();
        }

        public void GetModel() 
        {
            //T_ProductMetals model = new T_ProductMetals();
            //string IDs = Request["id"].ToString();
            //model = bpmetals.GetModel(IDs);
            //DropDownCateID.SelectedValue = model.FID.ToString();
            //txt_title.Text = model.Title;
            //newscontent.Value = model.Des;
        }

        protected void btn_ok_Click(object sender, EventArgs e)
        {
//            T_ProductMetals model = new T_ProductMetals();
//            model.Addtime = DateTime.Now;
//            model.FID = int.Parse(DropDownCateID.SelectedValue);
//            model.Title = txt_title.Text;
//            model.Des = Request.Form["newscontent"];
            
//            if (Request["id"] == null)
//            {
//                if (bpmetals.InsertOrUpdateAbount(model) > 0)
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
//                if (bpmetals.InsertOrUpdateAbount(model) > 0)
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('修改成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
//                    Response.Redirect("ProductMetalsManage.aspx");
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