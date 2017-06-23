using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nevron.UI.WinForm.Controls;
using Nui.MallInfo.BLL;
using Nui.MallInfo.Model;
using Nui.MallInfo.Winform.Properties;

namespace Nui.MallInfo.Winform
{
    public partial class AddUser : NForm
    {
        /// <summary>
        /// 弹出界面标题
        /// </summary>
        public string DialogsFormString = string.Empty;

        public SysUserInfo _sysUser = new SysUserInfo();

        private SysRole _sysRole = new SysRole();

        public AddUser()
        {
            InitializeComponent();
        }

        public SysUserInfo sysUser
        {
            get
            {
                _sysUser.U_Account = txtAccount.Text;
                _sysUser.U_Name = txtName.Text;
                _sysUser.U_PassWord = txtPwd.Text;
                _sysUser.U_Phone = txtPhone.Text;
                _sysUser.U_Email = txtEmail.Text;
                _sysUser.MemoText = txtMemoText.Text;
                _sysUser.U_RoleId = Convert.ToInt32(cmbRoleName.SelectedItem);
                _sysUser.U_RoleName = Convert.ToString(cmbRoleName.Text);
                if (DialogsFormString == "新增")
                {
                    _sysUser.CREATE_DATE = DateTime.Now;
                    _sysUser.EditDate = null;
                }
                else
                {
                    _sysUser.EditUser = Properties.Settings.Default.U_Account;
                    _sysUser.EditDate = DateTime.Now;
                }
                return _sysUser;
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

            //----------------------角色下拉框数据绑定---------------------------
            if (DialogsFormString == "新增")
            {
                SysRoleInfo[] sysRoleList = _sysRole.GetRoleList(Settings.Default.U_Account);

                if (sysRoleList != null && sysRoleList.Length > 0)
                {
                    foreach (var row in sysRoleList)
                    {
                        NListBoxItem item = new NListBoxItem();
                        item.Tag = row.RoleId;
                        item.Text = row.R_RoleName;
                        cmbRoleName.Items.Add(item);
                    }
                    cmbRoleName.SelectedIndex = 0;
                }
            }
            else
            {
                //设置账号输入框为只读，不可输入
                txtAccount.ReadOnly = true;

                //设置密码框是否只读
                txtPwd.ReadOnly = Properties.Settings.Default.U_Account == "admin" ? false : true;

                //文本框数据绑定

                txtAccount.Text = _sysUser.U_Account;
                txtName.Text = _sysUser.U_Name;
                txtPwd.Text = _sysUser.U_PassWord;
                txtPhone.Text = _sysUser.U_Phone;
                txtEmail.Text = _sysUser.U_Email;
                txtMemoText.Text = _sysUser.MemoText;


                //修改用户界面显示当前已选中的角色项
                int Index = 0;

                SysRoleInfo[] sysRoleList = _sysRole.GetRoleList(Properties.Settings.Default.U_Account);

                if (sysRoleList != null && sysRoleList.Length > 0)
                {
                    for (int i = 0; i < sysRoleList.Length; i++)
                    {
                        NListBoxItem item = new NListBoxItem();
                        item.Tag = sysRoleList[i].RoleId;
                        item.Text = sysRoleList[i].R_RoleName;

                        if (item.Text == _sysUser.U_RoleName)
                        {
                            Index = i;
                        }

                        cmbRoleName.Items.Add(item);
                    }
                    cmbRoleName.SelectedIndex = Index;
                }
            }
        }

        /// <summary>
        /// 保存确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nSubmit_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text == string.Empty)
            {
                MessageBox.Show("请输入用户账号！", "提示");
                return;
            }

            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("请输入用户名称！", "提示");
                return;
            }

            if (cmbRoleName.Text == string.Empty)
            {
                MessageBox.Show("请选择用户角色！", "提示");
                return;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
