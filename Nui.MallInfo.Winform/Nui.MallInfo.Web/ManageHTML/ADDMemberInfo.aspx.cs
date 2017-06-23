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
    public partial class ADDMemberInfo : System.Web.UI.Page
    {
        //B_MemberInfo bmember = new B_MemberInfo();
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
            //B_MemberCate bmemeber=new B_MemberCate();
            //Drop_cateID.DataSource = bmemeber.GetCateALLData();
            //Drop_cateID.DataTextField = "TypeName";
            //Drop_cateID.DataValueField = "ID";
            //Drop_cateID.DataBind();
        }

        public void GetModel()
        {
            //string ID = Request["id"].ToString();
            //T_MemberInfo model = new T_MemberInfo();
            //model = bmember.GetModel(ID);
            //Drop_cateID.SelectedValue = model.CateId.ToString();
            //txt_CompanyName.Text = model.CompanyName;
            //txt_CompanyUrl.Text = model.CompanyUrl;
            //txt_OperaHead.Text = model.OperaHead;
            //Drop_isbroker.SelectedValue = model.IsBroker.ToString();
        }

        protected void btn_ok_Click(object sender, EventArgs e)
        {
//            T_MemberInfo model = new T_MemberInfo();
//            model.CateId = int.Parse(Drop_cateID.SelectedValue);
//            model.CompanyName = txt_CompanyName.Text;
//            model.CompanyUrl = txt_CompanyUrl.Text;
//            model.IsBroker = int.Parse(Drop_isbroker.SelectedValue);
//            model.OperaHead = txt_OperaHead.Text;

//            if (Request["id"] == null)
//            {
//                if (bmember.InsertOrUpdateAbount(model) > 0)
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

//                if (bmember.InsertOrUpdateAbount(model) > 0)
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('修改成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
//                    Response.Redirect("MemberInfoManage.aspx");
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