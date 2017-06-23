using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Nui.MallInfo.Web
{
    public partial class Admin_Top : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                Response.Redirect("login.aspx");
            }
            if (User.Identity.IsAuthenticated)
            {
                Label1.Text = User.Identity.Name;
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Cookies["loginname"].Expires = DateTime.Now.Add(new TimeSpan(-1));
            string url = FormsAuthentication.LoginUrl;
            Response.Redirect(url);
        }
    }
}