using Nevron.UI.WinForm.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nui.MallInfo.Utility;
using Fx678Member.Framework.Log;
using Nui.MallInfo.BLL;
using Nui.MallInfo.Winform.Properties;
using System.Threading;


namespace Nui.MallInfo.Winform
{
    public partial class MainForm : NForm
    {
        private Dictionary<TreeNode, NUIDocument> dic;
        private SysModule sysModuleBll = new SysModule();
        private SysRole sysRoleBll = new SysRole();

        /// <summary>
        /// 定义多线程
        /// </summary>
        //ThreadStart threadStart = null;

        public MainForm()
        {
            InitializeComponent();
            //记录用户名
            //Properties.Settings.Default.U_Account = "admin";

            //多线程操作UI报错机制屏蔽
            //Control.CheckForIllegalCrossThreadCalls = false;

            this.nStatusBarPanel2.Text = Settings.Default.U_Account;

            //默认主题设置
            AutoMainXml.DeserializeXml("AutoMainXml.xml");
            AutoMain.GetMenuCommand(AutoMainXml.StaticAutoXml.NSkinName,
                nCmd1, nCmd2, nCmd3, nCmd4, nCmd5, nCmd6);

            //默认Form主题设置
            AutoMain.GetFormCommand(AutoMainXml.StaticAutoXml.NSkinFormName,
                nCmd2_1, nCmd2_2, nCmd2_3, nCmd2_4,
                nCmd2_5, nCmd2_6, nCmd2_7, nCmd2_8);

            //获取功能菜单
            sysTreeView.Nodes.Add("首页");
            AutoUser.BindRoot(sysModuleBll.GetModuleTreeView((int)sysRoleBll.GetRoleId(Properties.Settings.Default.U_Account)), sysTreeView);
            //树默认展开
            sysTreeView.ExpandAll();

            //隐藏系统菜单关闭功能
            this.nDockingPanel3.Permissions.AllowHide = false;
        }

        /// <summary>
        /// 首次加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ////隐藏系统菜单关闭功能
            //this.nDockingPanel3.Permissions.AllowHide = false;

            ////默认主题设置
            //AutoMainXml.DeserializeXml("AutoMainXml.xml");
            //AutoMain.GetMenuCommand(AutoMainXml.StaticAutoXml.NSkinName,
            //    nCmd1, nCmd2, nCmd3, nCmd4, nCmd5, nCmd6);

            ////默认Form主题设置
            //AutoMain.GetFormCommand(AutoMainXml.StaticAutoXml.NSkinFormName,
            //    nCmd2_1, nCmd2_2, nCmd2_3, nCmd2_4,
            //    nCmd2_5, nCmd2_6, nCmd2_7, nCmd2_8);

            //开启一个新的线程，使数据在后台线程执行而不影响UI线程，即不占用
            //threadStart = new ThreadStart(BindRootTreeList);
            //Thread thread = new Thread(threadStart);
            //thread.IsBackground = true;
            //thread.Start();

            ////获取功能菜单
            //sysTreeView.Nodes.Add("首页");
            //AutoUser.BindRoot(sysModuleBll.GetModuleTreeView((int)sysRoleBll.GetRoleId(Properties.Settings.Default.U_Account)), sysTreeView);
            ////树默认展开
            //sysTreeView.ExpandAll();

            //关闭事件
            nDockManager1.DocumentManager.DocumentClosed += new DocumentEventHandler(DocumentManager_DocumentClosed);
        }

        //private void BindRootTreeList()
        //{
        //    if (this.InvokeRequired)
        //    {
        //        this.Invoke(new MethodInvoker(delegate() { BindRootTreeList(); }), new object[] { });
        //    }
        //    else
        //    {
        //        //获取功能菜单
        //        sysTreeView.Nodes.Add("首页");
        //        AutoUser.BindRoot(sysModuleBll.GetModuleTreeView((int)sysRoleBll.GetRoleId(Properties.Settings.Default.U_Account)), sysTreeView);
        //        //树默认展开
        //        sysTreeView.ExpandAll();
        //    }
        //}

        /// <summary>
        /// 页面关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DocumentManager_DocumentClosed(object sender, DocumentEventArgs e)
        {
            try
            {
                string str = e.Document.Text;
                foreach (KeyValuePair<TreeNode, NUIDocument> pair in dic)
                {
                    if (pair.Key.Text == str)
                    {
                        dic.Remove(pair.Key);
                    }
                }
            }
            catch (Exception ex)
            {
                Fx678Member.Framework.Log.Logger.Error("DocumentManager_DocumentClosed", ex);
            }

        }


        /// <summary>
        /// 页面主题设置事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nMenuCommand_Click(object sender, CommandEventArgs e)
        {
            AutoMain.GetMenuCommand(sender.ToString(),
                nCmd1, nCmd2, nCmd3, nCmd4, nCmd5, nCmd6);
        }

        /// <summary>
        /// Form主题设置事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCommand_Click(object sender, CommandEventArgs e)
        {
            AutoMain.GetFormCommand(sender.ToString(),
                nCmd2_1, nCmd2_2, nCmd2_3, nCmd2_4,
                nCmd2_5, nCmd2_6, nCmd2_7, nCmd2_8);

        }

        /// <summary>
        /// 系统菜单点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode node = e.Node;
                NUIDocument docItem;

                if (dic == null)
                {

                    dic = new Dictionary<TreeNode, NUIDocument>();
                    General GeneralConfig = new General() { Dock = DockStyle.Fill };
                    docItem = new NUIDocument("首页", -1, GeneralConfig);
                    nDockManager1.DocumentManager.AddDocument(docItem);
                    dic.Add(node, docItem);
                    return;
                }

                bool isexist = false;
                foreach (KeyValuePair<TreeNode, NUIDocument> pair in dic)
                {

                    if (pair.Key == node)
                    {
                        nDockManager1.DocumentManager.ActiveDocument = pair.Value;
                        isexist = true;

                    }

                }

                if (isexist) return;

                switch (node.Text)
                {
                    case "首页":
                        General GeneralConfig = new General() { Dock = DockStyle.Fill };
                        docItem = new NUIDocument("首页", -1, GeneralConfig);
                        nDockManager1.DocumentManager.AddDocument(docItem);
                        dic.Add(node, docItem);
                        break;
                    case "角色管理":
                        UC_sysRoles UC_RoleConfig = new UC_sysRoles() { Dock = DockStyle.Fill };
                        docItem = new NUIDocument("角色管理", -1, UC_RoleConfig);
                        nDockManager1.DocumentManager.AddDocument(docItem);
                        dic.Add(node, docItem);
                        break;
                    case "用户管理":
                        UC_sysUser UC_UserConfig = new UC_sysUser() { Dock = DockStyle.Fill };
                        docItem = new NUIDocument("用户管理", -1, UC_UserConfig);
                        nDockManager1.DocumentManager.AddDocument(docItem);
                        dic.Add(node, docItem);
                        break;

                }
            }
            catch (Exception ex)
            {
                Logger.Error("系统菜单点击事件", ex);
            }
        }

        /// <summary>
        /// 主窗体关闭，结束所有的进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
