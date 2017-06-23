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
    public partial class ADDDownLoad : System.Web.UI.Page
    {
        //B_DownLoad bown = new B_DownLoad();
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
        public void Drop()
        {
            //Drop_cateID.DataSource = bown.GetCateData();
            //Drop_cateID.DataTextField = "SoftName";
            //Drop_cateID.DataValueField = "ID";
            //Drop_cateID.DataBind();
        }

        public void GetModel()
        {
            //string ID = Request["id"].ToString();
            //T_DownLoad model = new T_DownLoad();
            //model = bown.GetModel(ID);
            //Drop_cateID.SelectedValue = model.CateId.ToString();
            //txt_SoftName.Text = model.SoftName;
            //txt_Applicablesystem.Text = model.Applicablesystem; 
            //txt_DES.Text = model.DES; 
            //Label1.Text = model.SoftUrl;
            //txt_Versions.Text = model.Versions;
        }


        protected void btn_ok_Click(object sender, EventArgs e)
        {
//            T_DownLoad model = new T_DownLoad();
//            model.CateId = int.Parse(Drop_cateID.SelectedValue);
//            model.Applicablesystem = txt_Applicablesystem.Text;
//            model.DES = txt_DES.Text;
//            model.SoftName = txt_SoftName.Text;
//            model.UpdateDate = DateTime.Now;
//            model.Versions = txt_Versions.Text;

//            if (Request["id"] == null)
//            {
//                model.SoftUrl = Session["uploadPath"] == null ? string.Empty : Session["uploadPath"].ToString();
//                if (bown.InsertOrUpdateAbount(model) > 0)
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
//                //  model.AttachUrl = Session["uploadPath"] == null ? string.Empty : Session["uploadPath"].ToString();
//                if (Session["uploadPath"] != null)
//                {
//                    model.SoftUrl = Session["uploadPath"].ToString();
//                }
//                else
//                {
//                    if (Label1.Text == null)
//                    {
//                        model.SoftUrl = string.Empty;
//                    }
//                    else
//                    {
//                        model.SoftUrl = Label1.Text;
//                    }
//                }

//                if (bown.InsertOrUpdateAbount(model) > 0)
//                {
//                    Session.Clear();
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('修改成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
//                    Response.Redirect("DownLoadManage.aspx");
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