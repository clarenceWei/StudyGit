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
    public partial class UserManage : System.Web.UI.Page
    {
        //B_Users buser = new B_Users();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                Response.Redirect("../login.aspx");
            }
            if (IsPostBack)
                return;
            GetDataBind();
            //判断是修改还是添加
            if (Request["id"] == null)
            {
                btn_add.Visible = true;
                btn_update.Visible = false;
            }
            else
            {
                btn_update.Visible = true;
                btn_add.Visible = false;
                GetModel();
            }
        }

        public void GetModel() 
        {
            //string IDs = Request["id"].ToString();
            //T_Users model = new T_Users();
            //model = buser.GetModel(IDs);
            //txt_newcatename.Text = model.UserName;
            //txt_pwd.Text = model.pwd;
        }

        public void GetDataBind() 
        {
            //GridView1.DataSource = buser.GetCateData();
            //GridView1.DataBind();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            //T_Users model = new T_Users();
            //model.UserName = txt_newcatename.Text;
            //model.pwd = txt_pwd.Text;
            //if (buser.InsertOrUpdateAbount(model) > 0) 
            //{
            //    lb_message.Text = "添加成功！";
            //    GetDataBind();
            //}
            //else
            //{
            //    lb_message.Text = "添加失败！";
            //}
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            //T_Users model = new T_Users();
            //string IDs = Request["id"].ToString();
            //model.ID =int.Parse(IDs);
            //model.UserName = txt_newcatename.Text;
            //model.pwd = txt_pwd.Text;

            //if (buser.InsertOrUpdateAbount(model) > 0)
            //{
            //    lb_message.Text = "修改成功！";
            //    GetDataBind();
            //}
            //else
            //{
            //    lb_message.Text = "修改失败！";
            //}
        }

        protected void btn_cancle_Click(object sender, EventArgs e)
        {
            lb_message.Text = "";
            lb_des.Text = "";
            lb_catename.Text = "";
            txt_newcatename.Text = "";
            txt_pwd.Text = "";
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string IDs = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //if (buser.Delete(IDs)) 
            //{
            //    GetDataBind();
            //}
        }
    }
}