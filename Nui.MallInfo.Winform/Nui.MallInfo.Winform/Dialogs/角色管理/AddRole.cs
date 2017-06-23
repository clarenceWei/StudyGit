using Nevron.UI.WinForm.Controls;
using Nui.MallInfo.BLL;
using Nui.MallInfo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nui.MallInfo.Winform
{
    public partial class AddRole : NForm
    {

        /// <summary>
        /// 弹出界面标题
        /// </summary>
        public string DialogsFormString = string.Empty;

        public SysRoleInfo _sysRole = new SysRoleInfo();

        public AddRole()
        {
            InitializeComponent();
        }

        public SysRoleInfo sysRole
        {
            get
            {
                _sysRole.R_RoleName = txtRoleName.Text;
                _sysRole.R_DescripTion = txtDescripTion.Text;
                _sysRole.MemoText = txtMemoText.Text;
                if (DialogsFormString == "修改")
                {
                    _sysRole.EditUser = Properties.Settings.Default.U_Account;
                    _sysRole.EditDate = DateTime.Now;
                }
                else
                {
                    _sysRole.EditUser = null;
                    _sysRole.EditDate = null;
                }
                return _sysRole;
            }
        }

        private void AddRole_Load(object sender, EventArgs e)
        {
            txtRoleName.Text = _sysRole.R_RoleName;
            txtDescripTion.Text = _sysRole.R_DescripTion;
            txtMemoText.Text = _sysRole.MemoText;
        }

        /// <summary>
        /// 保存确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nSubmit_Click(object sender, EventArgs e)
        {
            if (txtRoleName.Text == string.Empty)
            {
                MessageBox.Show("请输入角色名称！", "提示");
                return;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }


    }
}
