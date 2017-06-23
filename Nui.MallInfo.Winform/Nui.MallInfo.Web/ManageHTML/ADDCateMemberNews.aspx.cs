using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using BLL;
//using Model;

namespace Nui.MallInfo.Web.ManageHTML
{
    public partial class ADDCateMemberNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                Response.Redirect("../login.aspx");
            }
            if (IsPostBack)
                return;
            GetDataBind();
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
        //B_MemberNews bMemberNew = new B_MemberNews();
        /// <summary>
        /// 给文本赋值
        /// </summary>
        public void GetModel()
        {
            //T_MemberNews model = new T_MemberNews();
            //string id = Request["id"].ToString();
            //model = bMemberNew.GetModel(id);
            //txt_name.Text = model.Title;
        }

        public void GetDataBind()
        {
            //GridView1.DataSource = bMemberNew.GetCateData();
            //GridView1.DataBind();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text; 
            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            //T_MemberNews tmodel = new T_MemberNews();
            //tmodel.Title = name;
            //tmodel.AddDate = DateTime.Now; 

            //if (bMemberNew.InsertOrUpdateAbount(tmodel) > 0)
            //{
            //    lb_message.Text = "分类添加成功！";
            //    GetDataBind();
            //}
            //else
            //{
            //    lb_message.Text = "分类添加失败！";
            //}
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            //T_MemberNews model = new T_MemberNews();
            //int id = int.Parse(Request["id"].ToString());
            //model.ID = id;
            //model.Title = txt_name.Text; 
            //model.AddDate = DateTime.Now;
            //if (bMemberNew.InsertOrUpdateAbount(model) > 0)
            //{
            //    lb_message.Text = "分类修改成功！";
            //    GetDataBind();
            //}
            //else
            //{
            //    lb_message.Text = "分类修改失败！";
            //}
        }

        protected void btn_cancle_Click(object sender, EventArgs e)
        {
            txt_name.Text = ""; 
            lb_catename.Text = "";
            // lb_des.Text = "";
            lb_message.Text = "";
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string cateid = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //if (bMemberNew.Delete(cateid))
            //{
            //    GetDataBind();
            //}
        }
    }
}