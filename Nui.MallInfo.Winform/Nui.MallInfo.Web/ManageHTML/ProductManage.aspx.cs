using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using BLL;

namespace Nui.MallInfo.Web.ManageHTML
{
    public partial class ProductManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                Response.Redirect("../login.aspx");
            }
            if (IsPostBack)
                return;
            GetBindData();
        }
        //B_Product bproduct = new B_Product();
        public void GetBindData()
        {
            //GridView1.DataSource = bproduct.GetALLData();
            //GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string cateid = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //if (bproduct.Delete(cateid)>0)
            //{
            //    GetBindData();
            //}
        }

    }
}