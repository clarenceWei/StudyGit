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
    public partial class ADDAbount : System.Web.UI.Page
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

        //B_Abount babount=new B_Abount ();
        public void GetDrop() 
        {
            //DropDownCateID.DataSource = babount.GetCateData();
            //DropDownCateID.DataTextField = "Title";
            //DropDownCateID.DataValueField = "ID";
            //DropDownCateID.DataBind();
        }

        public void GetModels() 
        {
            //string ID = Request["id"].ToString();
            //T_Abount model = new T_Abount();
            //model = babount.GetModel(ID);
            //txt_level.Text = model.Level.ToString();
            //txt_title.Text = model.Title;
            //txt_vedio.Text = model.Vedio_Url;
            //DropDownCateID.SelectedValue = model.Cate_Id.ToString();
            //newscontent.Value = model.DES;
        }

      


        protected void btn_ok_Click(object sender, EventArgs e)
        {
//            T_Abount model = new T_Abount();
//            if (txt_level.Text == "" || txt_level.Text == null) 
//            {
//                txt_level.Text = "0";
//            }

//            model.Cate_Id =int.Parse(DropDownCateID.SelectedValue);
//            model.AddDate = DateTime.Now;
//            model.DES = Request.Form["newscontent"];
//            model.Level = int.Parse(txt_level.Text);
            
//            model.Title = txt_title.Text;
//            model.Vedio_Url = txt_vedio.Text;

//            if (Request["id"] == null)
//            {
//                if (babount.InsertOrUpdateAbount(model) > 0)
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('添加成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
//                  //  Response.Redirect("AbountManage.aspx");
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
//                    Response.Redirect("AbountManage.aspx");
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