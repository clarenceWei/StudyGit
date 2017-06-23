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
    public partial class MemberCateManage : System.Web.UI.Page
    {
        //B_MemberCate bmemberCate = new B_MemberCate();
        protected void Page_Load(object sender, EventArgs e)
        {
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

        /// <summary>
        /// 给文本赋值
        /// </summary>
        public void GetModel()
        {
            //T_MemberCate model = new T_MemberCate();
            //string id = Request["id"].ToString();
            //model = bmemberCate.GetModel(id);
            //txt_level.Text = model.Level.ToString();
            //txt_name.Text = model.TypeName;
        }

        public void GetDataBind()
        {
           
            


        //    GridView1.DataSource = bmemberCate.GetCateALLData();
        //    GridView1.DataBind();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string lever = txt_level.Text;
            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            //T_MemberCate tmodel = new T_MemberCate();
            //tmodel.TypeName = name;
            //tmodel.AddTime = DateTime.Now;
            //tmodel.Level = int.Parse(lever);

            //if (bmemberCate.InsertOrUpdateAbount(tmodel) > 0)
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
            //T_MemberCate model = new T_MemberCate();
            //int id = int.Parse(Request["id"].ToString());
            //model.ID = id;
            //model.TypeName = txt_name.Text;
            //model.Level = int.Parse(txt_level.Text);
            //model.AddTime = DateTime.Now;
            //if (bmemberCate.InsertOrUpdateAbount(model) > 0)
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
            lb_catename.Text = "";
            // lb_des.Text = "";
            lb_message.Text = "";
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string cateid = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //if (bmemberCate.Delete(cateid))
            //{
            //    GetDataBind();
            //}
        }
    }
}