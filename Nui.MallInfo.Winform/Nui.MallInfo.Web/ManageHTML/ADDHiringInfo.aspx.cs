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
    public partial class ADDHiringInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                Response.Redirect("../login.aspx");
            }
            if (IsPostBack)
                return;
            if (Request["id"] != null) 
            {
                GetModels();
            }
        }
        //B_HiringInfo bhiring = new B_HiringInfo();

        public void GetModels() 
        {
            //T_HiringInfo model = new T_HiringInfo();
            //string ID=Request["id"].ToString();
            //model = bhiring.GetModel(ID);
            //txt_Department.Text = model.Department;
            //txt_Number.Text = model.Hiring_Number.ToString();
            //txt_position.Text = model.Position;
            //newscontent.Value = model.PositionDes;
            //Drop_isValid.SelectedValue = model.IsValid.ToString();
        }

        protected void btn_ok_Click(object sender, EventArgs e)
        {
//            T_HiringInfo model = new T_HiringInfo();
//            model.AddDate = DateTime.Now;
//            model.Department = txt_Department.Text;
//            model.Hiring_Number = int.Parse(txt_Number.Text);
//            model.IsValid = int.Parse(Drop_isValid.SelectedValue);
//            model.Position = txt_position.Text;
//            model.PositionDes = Request.Form["newscontent"];

//            if (Request["id"]==null)
//            {
//                if (bhiring.InsertOrUpdateAbount(model) > 0)
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('添加成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
//                    Response.Redirect("HiringInfoManage.aspx");
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
//                if (bhiring.InsertOrUpdateAbount(model) > 0)
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('修改成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
//                    Response.Redirect("HiringInfoManage.aspx");
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