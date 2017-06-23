using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using BLL;

namespace Nui.MallInfo.Web.ManageHTML
{
    public partial class DownLoadManage : System.Web.UI.Page
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
        }
        //B_DownLoad bdown = new B_DownLoad();

        public void GetDataBind() 
        {
            //GridView1.DataSource = bdown.GetALLData();
            //GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string ID = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //if (bdown.Delete(ID))
            //{
            //    GetDataBind();
            //}
        }
    }
}