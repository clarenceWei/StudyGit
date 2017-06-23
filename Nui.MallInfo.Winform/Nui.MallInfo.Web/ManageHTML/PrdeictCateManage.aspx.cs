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
    public partial class PrdeictCateManage : System.Web.UI.Page
    {
        //B_PrdeictCate bpcate = new B_PrdeictCate();
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

        public void GetDataBind() 
        {
            //GridView1.DataSource = bpcate.GetALLData();
            //GridView1.DataBind();
        }


        /// <summary>
        /// 给文本赋值
        /// </summary>
        public void GetModel()
        {
            //T_PrdeictCate model = new T_PrdeictCate();
            //string id = Request["id"].ToString();
            //model = bpcate.GetModel(id);
            //txt_name.Text = model.TypeName;
            //txt_des.Text = model.Des;
        }
        protected void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            //T_PrdeictCate tmodel = new T_PrdeictCate();
            //tmodel.TypeName = name;
            //tmodel.AddTime = DateTime.Now;
            //tmodel.Des = txt_des.Text;
            //if (bpcate.InsertOrUpdateAbount(tmodel) > 0)
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
            //T_PrdeictCate model = new T_PrdeictCate();
            //int id = int.Parse(Request["id"].ToString());
            //model.ID = id;
            //model.TypeName = txt_name.Text;
            //model.AddTime = DateTime.Now;
            //model.Des = txt_des.Text;
            //if (bpcate.InsertOrUpdateAbount(model) > 0)
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
            //if (bpcate.Delete(cateid))
            //{
            //    GetDataBind();
            //}
        }
    }
}