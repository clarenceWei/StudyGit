using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Model;
//using BLL;
using System.Web.Security;
using Nui.MallInfo.BLL;

namespace Nui.MallInfo.Web
{
    public partial class Login : System.Web.UI.Page
    {
        //B_Users buser = new B_Users();
        SysUser _sysUser = new SysUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_login_Click(object sender, EventArgs e)
        {

            string txtAccount = txt_username.Text.Trim();
            string txtPwd = txt_passwd.Text.Trim();

            if (_sysUser.GetLoginUser(txtAccount, txtPwd))
            {
                HttpCookie username = new HttpCookie("loginname", txtAccount);
                Response.Cookies.Add(username);
                FormsAuthentication.RedirectFromLoginPage(txtAccount, false);
                Response.Redirect("Main.aspx");
            }
            else
            {
                Response.Write("<script>alert('密码错误!')</script>");
                txt_username.Text = "";
                txt_passwd.Text = "";
                txt_validay.Text = "";
            }
            //if (String.Compare(Request.Cookies["yzmcode"].Value, txt_validay.Text, true) != 0)
            //{
            //    Response.Write("<script>alert('验证码错误!')</script>");
            //}
            
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_cancle_Click(object sender, EventArgs e)
        {
            txt_passwd.Text = "";
            txt_username.Text = "";
            txt_validay.Text = "";
        }

        protected void ChangeCode_Click(object sender, EventArgs e)
        {

        }
    }
}