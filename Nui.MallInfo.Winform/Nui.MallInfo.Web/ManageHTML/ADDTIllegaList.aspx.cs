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
    public partial class ADDTIllegaList : System.Web.UI.Page
    {

        //B_IllegaList BIlllist = new B_IllegaList();
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
        //B_MemberCate BMcate = new B_MemberCate();
        public void BindDrop() 
        {
            //DropDownCateID.DataSource = BMcate.GetCateALLData();
            //DropDownCateID.DataTextField = "TypeName";
            //DropDownCateID.DataValueField = "ID";
            //DropDownCateID.DataBind();

        }

        public void GetModel() 
        {
            //T_IllegaList model = new T_IllegaList(); 
            //string ID = Request["ID"].ToString();
            //model = BIlllist.GetModel(ID);
            //txt_Address.Text = model.Address;
            //txt_Email.Text = model.Email;
            //txt_HttpUrl.Text = model.HttpUrl;
            //txt_MicroBlogURL.Text = model.MicroBlogURL;
            //txt_name.Text = model.Name;
            //txt_phone.Text = model.Phone;
            //txt_QQ.Text = model.QQ;
            //txt_tel.Text = model.Tel;
            //txt_WeChat.Text = model.WeChat;
            //DropDownCateID.SelectedValue = model.CateId.ToString() ;
        }

        protected void btn_ok_Click(object sender, EventArgs e)
        {
//            T_IllegaList model = new T_IllegaList();
//            model.AddDate = DateTime.Now;
//            model.Address = txt_Address.Text;
//            model.CateId = int.Parse(DropDownCateID.SelectedValue);
//            model.Email = txt_Email.Text;
//            model.HttpUrl = txt_HttpUrl.Text;
//            model.MicroBlogURL = txt_MicroBlogURL.Text;
//            model.Name = txt_name.Text;
//            model.Phone = txt_phone.Text;
//            model.QQ = txt_QQ.Text;
//            model.Tel = txt_tel.Text;
//            model.WeChat = txt_WeChat.Text;

//            if (Request["id"] == null)
//            {
//                if (BIlllist.InsertOrUpdateAbount(model) > 0)
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
//                if (BIlllist.InsertOrUpdateAbount(model) > 0)
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('修改成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
//                    Response.Redirect("TIllegaListManage.aspx");
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