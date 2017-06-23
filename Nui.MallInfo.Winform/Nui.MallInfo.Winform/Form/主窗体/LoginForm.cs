using Nevron.UI.WinForm.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nui.MallInfo.BLL;
using Nui.MallInfo.Utility;
using Nui.MallInfo.Winform.Properties;
using System.Threading;
using Fx678Member.Framework.Log;

namespace Nui.MallInfo.Winform
{
    public partial class LoginForm : NForm
    {
        public LoginForm()
        {
            InitializeComponent();

            //多线程操作UI报错机制屏蔽
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        SysUser _sysUser = new SysUser();

        //Timer timer = new Timer();

        //private int timerInterval = 5;

        /// <summary>
        /// 定义多线程
        /// </summary>
        ThreadStart threadStart = null;

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {

                label1.Text = "核心数据处理中......";

                label1.Visible = true;

                if (_sysUser.GetLoginUser(txtAccount.Text.Trim(), txtPwd.Text.Trim()))
                {
                    
                    //开启一个新的线程，使数据在后台线程执行而不影响UI线程，即不占用
                    threadStart = new ThreadStart(BindRootTreeList);
                    Thread thread = new Thread(threadStart);
                    thread.IsBackground = true;
                    thread.Start();

                    //timer.Enabled = true;

                    //timer.Tick += timer_Tick;

                    //timer.Interval = 1000;

                    //AutoMainXml.DeserializeXml("AutoMainXml.xml");

                    //int NSkinForm = Convert.ToInt32(AutoMainXml.StaticAutoXml.NSkinForm);

                    //NFrameAppearance appearance = NUIManager.GetPredefinedFrame((PredefinedFrame)NSkinForm);


                }
                else
                {
                    MessageBox.Show("账号或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("系统登录", ex);

                label1.Text = "数据源无法连接...请关闭系统！";

                label1.Visible = true;

            }
        }

        private void BindRootTreeList()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate() { BindRootTreeList(); }), new object[] { });
            }
            else
            {

                Settings.Default.U_Account = txtAccount.Text.Trim();

                using (MainForm frm = new MainForm())
                {
                    this.Hide();

                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }

                }
            }
        }


        /// <summary>
        /// 取消登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAccount_Enter(object sender, EventArgs e)
        {
            txtAccount.SelectAll();
        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {
            txtPwd.SelectAll();
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Submit_Click(null, null);
            }
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            txtAccount.Focus();
        }
    }
}
