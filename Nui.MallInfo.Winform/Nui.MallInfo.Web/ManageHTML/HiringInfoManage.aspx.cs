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
    public partial class HiringInfoManage : System.Web.UI.Page
    {
        //B_HiringInfo bhiting = new B_HiringInfo();
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

        public void GetDataBind() 
        {
            //GridView1.DataSource = bhiting.GetAllData();
            //GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string cateid = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //if (bhiting.Delete(cateid))
            //{
            //    GetDataBind();
            //}
        }
       
    }
}