using Nui.MallInfo.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nui.MallInfo.Web
{
    public partial class UserList : System.Web.UI.Page
    {

        SysUser sysUserBll = new SysUser();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                Response.Redirect("../login.aspx");
            }

            if (IsPostBack)
                return;

            GetDataBind();
        }

        /// <summary>
        /// 数据加载
        /// </summary>
        public void GetDataBind()
        {
            DateTime nStartDate = Convert.ToDateTime("2016-01-01");
            DateTime nEndDate = Convert.ToDateTime("2016-04-23");
            int Count = 0;

            GridView1.DataSource = sysUserBll.GetUserPage(nStartDate, nEndDate, "", "admin", 1, 20, out Count);
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btn_add_Click(object sender, EventArgs e)
        {

        }

        protected void btn_update_Click(object sender, EventArgs e)
        {

        }

        protected void btn_cancle_Click(object sender, EventArgs e)
        {

        }



    }
}