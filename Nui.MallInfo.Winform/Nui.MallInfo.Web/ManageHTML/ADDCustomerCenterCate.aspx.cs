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
    public partial class ADDCustomerCenterCate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(User.Identity.Name))
            //{
            //    Response.Redirect("../login.aspx");
            //}
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

        //B_CustomerCenterCate bnewcate = new B_CustomerCenterCate();
        public void GetDataBind()
        {
            //GridView1.DataSource = bnewcate.GetCateALLData();
            //GridView1.DataBind();
        }


        /// <summary>
        /// 给文本赋值
        /// </summary>
        public void GetModel()
        {
            //T_CustomerCenterCate model = new T_CustomerCenterCate();
            //string id = Request["id"].ToString();
            //model = bnewcate.GetModel(id);
            //txt_level.Text = model.SortLevel.ToString();
            //txt_name.Text = model.CateName;
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            //T_CustomerCenterCate model = new T_CustomerCenterCate();
            //model.AddDate = DateTime.Now;
            //model.CateName = txt_name.Text;
            //model.SortLevel = int.Parse(txt_level.Text);
            //if (bnewcate.InsertOrUpdateAbount(model) > 0)
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
            //T_CustomerCenterCate model = new T_CustomerCenterCate();
            //int id = int.Parse(Request["id"].ToString());
            //model.ID = id;
            //model.CateName = txt_name.Text;
            //model.SortLevel = int.Parse(txt_level.Text);
            //model.AddDate = DateTime.Now;
            //if (bnewcate.InsertOrUpdateAbount(model) > 0)
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
            txt_level.Text = "0";
            lb_message.Text = "";
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string cateid = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //if (bnewcate.Delete(cateid))
            //{
            //    GetDataBind();
            //}
        }
    }
}