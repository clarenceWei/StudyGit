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
    public partial class PartnerManager : System.Web.UI.Page
    {
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
            //T_Partner model = new T_Partner();
            //string id = Request["id"].ToString();
            //model = bpartner.GetModel(id);
            //txt_name.Text = model.CompanyName;
            //txt_httpurl.Text = model.httpurl;
            //Session["PartnerImg"] = model.ImgUrl;

        }




        //B_Partner bpartner = new B_Partner();
        protected void btn_add_Click(object sender, EventArgs e)
        {

            string name = txt_name.Text;
            if (string.IsNullOrEmpty(name))
            {
                return;
            }
            //T_Partner model = new T_Partner();
            //model.CompanyName = name;
            //model.AddTime = DateTime.Now;
            //model.ImgUrl = Session["PartnerImg"] == null ? string.Empty : Session["PartnerImg"].ToString();
            //if (bpartner.InsertOrUpdateParner(model) > 0)
            //{

            //    lb_message.Text = "分类添加成功！";
            //    GetDataBind();
            //    Session.Remove("PartnerImg");
            //}
            //else
            //{
            //    lb_message.Text = "分类添加失败！";
            //}
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            //T_Partner model = new T_Partner();
            //int id = int.Parse(Request["id"].ToString());
            //model.ID = id;
            //model.CompanyName = txt_name.Text;
            //model.httpurl = txt_httpurl.Text;
            //model.ImgUrl = Session["PartnerImg"] == null ? string.Empty : Session["PartnerImg"].ToString();
            //model.AddTime = DateTime.Now;
            //if (bpartner.InsertOrUpdateParner(model) > 0)
            //{

            //    lb_message.Text = "分类修改成功！";
            //    GetDataBind();
            //    Session.Remove("PartnerImg");

            //}
            //else
            //{
            //    lb_message.Text = "分类修改失败！";
            //}
        }

        public void GetDataBind()
        {
            //GridView1.DataSource = bpartner.GetDataPartner();
            //GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string cateid = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //if (bpartner.Delete(cateid))
            //{
            //    GetDataBind();
            //}
        }

        protected void btn_cancle_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            Session.Remove("PartnerImg");
        }

    }
}