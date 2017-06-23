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
    public partial class ADDCateAbout : System.Web.UI.Page
    {
        //B_Abount babount = new B_Abount();
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
        /// <summary>
        /// 给文本赋值
        /// </summary>
        public void GetModel() 
        {
            //T_Abount model = new T_Abount();
            //string id=Request["id"].ToString();
            //model = babount.GetModel(id);
            //txt_level.Text = model.Level.ToString();
            //txt_name.Text = model.Title; 
        }


        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_add_Click(object sender, EventArgs e)
        {
            //string name = txt_name.Text;
            //string lever = txt_level.Text;
            //if (string.IsNullOrEmpty(name)) 
            //{
            //    return;
            //}
            
            //T_Abount tmodel = new T_Abount();
            //tmodel.Title = name;
            //tmodel.AddDate = DateTime.Now;
            //tmodel.Level = int.Parse(lever);

            //if (babount.InsertOrUpdateAbount(tmodel)>0)
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
            //GridView1.DataSource = babount.GetCateData();
            //GridView1.DataBind();
        }
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_update_Click(object sender, EventArgs e)
        {
            //T_Abount model = new T_Abount();
            //int id = int.Parse(Request["id"].ToString());
            //model.ID = id;
            //model.Title = txt_name.Text;
            //model.Level = int.Parse(txt_level.Text);
            //model.AddDate = DateTime.Now;
            //if (babount.InsertOrUpdateAbount(model) > 0)
            //{
            //    lb_message.Text = "分类修改成功！";
            //    GetDataBind();
            //}
            //else 
            //{
            //    lb_message.Text = "分类修改失败！"; 
            //}
            
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            //if (babount.Delete(cateid))
            //{
            //    GetDataBind();
            //}
        }

       
    }
}