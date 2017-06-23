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
    public partial class ADDCustomerCenter : System.Web.UI.Page
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

        //B_CustomerCenter babount = new B_CustomerCenter();
        public void GetDrop()
        {
            //DropDownCateID.DataSource = babount.GetCateData();
            //DropDownCateID.DataTextField = "CateName";
            //DropDownCateID.DataValueField = "ID";
            //DropDownCateID.DataBind();
        }

        public void GetModels()
        {
            //string ID = Request["id"].ToString();
            //T_CustomerCenter model = new T_CustomerCenter();
            //model = babount.GetModel(ID);
             
            //txt_title.Text = model.Title;
            //DropDownCateID.SelectedValue = model.Cate_Id.ToString();
            //newscontent.Value = model.Coutents;
        }

        protected void btn_ok_Click(object sender, EventArgs e)
        {
//            T_CustomerCenter model = new T_CustomerCenter();
//            model.Cate_Id = int.Parse(DropDownCateID.SelectedValue);
//            model.AddTime = DateTime.Now;
//            model.Coutents = Request.Form["newscontent"];
          
//            model.Title = txt_title.Text;
           

//            if (Request["id"] == null)
//            {
//                if (babount.InsertOrUpdateAbount(model) > 0)
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
//                if (babount.InsertOrUpdateAbount(model) > 0)
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('修改成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
//                    Response.Redirect("ManageCustomerCenter.aspx");
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