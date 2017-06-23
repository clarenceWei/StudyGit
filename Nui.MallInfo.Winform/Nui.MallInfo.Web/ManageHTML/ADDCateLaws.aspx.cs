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
    public partial class ADDCateLaws : System.Web.UI.Page
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
                GetModels();
            }
        }
        //B_Laws blaws = new B_Laws();
        protected void btn_add_Click(object sender, EventArgs e)
        {
            //T_Laws model = new T_Laws();
            //model.Title = txt_title.Text;
            //model.AddTime = DateTime.Now;

            //if (blaws.InsertOrUpdateAbount(model) > 0)
            //{
            //    lb_message.Text = "分类添加成功！";
            //    GetDataBind();
            //}
            //else
            //{
            //    lb_message.Text = "分类添加失败！";
            //} 
        }

        public void GetDataBind()
        {
            //GridView1.DataSource = blaws.GetCateData();
            //GridView1.DataBind();
        }

        public void GetModels() 
        {
            //string ID=Request["id"].ToString();
            //T_Laws model = new T_Laws();
            //model = blaws.GetModel(ID);
            //txt_title.Text = model.Title;
        }


        protected void btn_update_Click(object sender, EventArgs e)
        {
            //T_Laws model = new T_Laws();
            //int id = int.Parse(Request["id"].ToString());
            //model.ID = id;
            //model.Title = txt_title.Text;
          
            //model.AddTime = DateTime.Now;
            //if (blaws.InsertOrUpdateAbount(model) > 0)
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

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string cateid = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //if (blaws.Delete(cateid))
            //{
            //    GetDataBind();
            //}
        }
    }
}