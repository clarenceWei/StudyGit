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
    public partial class ADDCateDownLoadManage : System.Web.UI.Page
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

        //B_DownLoad bDown = new B_DownLoad();

        /// <summary>
        /// 给文本赋值
        /// </summary>
        public void GetModel()
        {
            //T_DownLoad model = new T_DownLoad();
            //string id = Request["id"].ToString();
            //model = bDown.GetModel(id); 
            //txt_name.Text = model.SoftName;
        }


        public void GetDataBind() 
        {
            //GridView1.DataSource = bDown.GetCateData();
            //GridView1.DataBind();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text; 
            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            //T_DownLoad tmodel = new T_DownLoad();
            //tmodel.SoftName = name;
            //tmodel.UpdateDate = DateTime.Now; 

            //if (bDown.InsertOrUpdateAbount(tmodel) > 0)
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
            //T_DownLoad model = new T_DownLoad();
            //int id = int.Parse(Request["id"].ToString());
            //model.ID = id;
            //model.SoftName = txt_name.Text; 
            //model.UpdateDate = DateTime.Now;
            //if (bDown.InsertOrUpdateAbount(model) > 0)
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
            //if (bDown.Delete(cateid))
            //{
            //    GetDataBind();
            //}
        }
    }
}