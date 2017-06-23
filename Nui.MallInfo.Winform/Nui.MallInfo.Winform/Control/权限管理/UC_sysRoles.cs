using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nui.MallInfo.Utility;
using Nui.MallInfo.BLL;
using Nui.MallInfo.Model;
using Fx678Member.Framework.Log;
using Nevron.UI.WinForm.Controls;

namespace Nui.MallInfo.Winform
{
    public partial class UC_sysRoles : UserControl
    {
        SysModule sysModuleBll = new SysModule();
        SysRole sysRoleBll = new SysRole();
        SysRolePerMission sysRolePerBll = new SysRolePerMission();

        public UC_sysRoles()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 角色列表
        /// </summary>
        /// <param name="Index"></param>
        private void BindGetRolePage(int Index)
        {
            try
            {
                int Count = 0;
                //DateTime nStartDate = StartDate.Value;
                //DateTime nEndDate = EndDate.Value;
                SysRoleInfo[] sysRoleList = sysRoleBll.GetRolePage(txtKeyWord.Text, Properties.Settings.Default.U_Account, Index, winFormPager1.PageSize, out Count);
                winFormPager1.RecordCount = Count;
                sysRoleDataGrid.Rows.Clear();

                if (sysRoleList != null && sysRoleList.Length > 0)
                {
                    for (int i = 0; i < sysRoleList.Length; i++)
                    {
                        sysRoleDataGrid.Rows.Add(new object[]
                         {
                            sysRoleList[i].RoleId,
                            sysRoleList[i].R_RoleName,
                            sysRoleList[i].R_DescripTion,
                            sysRoleList[i].MemoText,
                            sysRoleList[i].EditUser,
                            sysRoleList[i].EditDate== DateTime.MinValue ? "": sysRoleList[i].EditDate.ToString()
                         });
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error("角色列表", ex);
            }
        }

        //--------------------------------------页面事件区域------------------------------------------//

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_sysRoles_Load(object sender, EventArgs e)
        {
            BindGetRolePage(1);
            //权限列表
            //AutoUser.BindRoot(sysModuleBll.GetModule(Properties.Settings.Default.U_Account), sysRoleTreeview);
        }

        /// <summary>
        /// 分页事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void winFormPager1_PageIndexChanged(object sender, EventArgs e)
        {
            BindGetRolePage(winFormPager1.PageIndex);
        }

        /// <summary>
        /// 单击单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sysRoleDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == -1)
                {
                    sysRoleDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    sysRoleDataGrid.Rows[e.RowIndex].Selected = true;
                }
                else
                {
                    sysRoleDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    sysRoleDataGrid.Rows[e.RowIndex].Selected = true;
                }
            }

            if (sysRoleDataGrid.SelectedRows.Count > 0)
            {
                int RoleId = Convert.ToInt32(sysRoleDataGrid.SelectedRows[0].Cells["ROLEID"].Value);

                sysRoleTreeview.Nodes.Clear();

                //权限列表
                AutoUser.BindRoot(sysModuleBll.GetModule(RoleId), sysRoleTreeview);
            }

            this.sysRoleTreeview.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.sysRoleTreeview_AfterCheck);
        }

        /// <summary>
        /// 双击单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sysRoleDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == -1)
                {
                    sysRoleDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    sysRoleDataGrid.Rows[e.RowIndex].Selected = true;
                }

                else
                {
                    sysRoleDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    sysRoleDataGrid.Rows[e.RowIndex].Selected = true;

                }
            }
        }

        /// <summary>
        /// 权限列表点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sysRoleTreeview_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (AutoUser.check == false)
                {
                    AutoUser.SetChild(e.Node);
                }
                AutoUser.SetParent(e.Node);
                AutoUser.check = false;
            }
            catch { AutoUser.check = false; }


            //获取所有选中的节点项

        }

        /// <summary>
        /// 保存当前角色对应的权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolSubmit_Click(object sender, EventArgs e)
        {
            if (sysRoleDataGrid.SelectedRows.Count > 0)
            {
                AutoUser.nodesTag = new StringBuilder();
                TreeNode node = sysRoleTreeview.TopNode;//得到TreeView的根结点，注意根结点只有一个
                //每次搜寻到根结点
                while (node.PrevNode != null)
                    node = node.PrevNode;
                AutoUser.TraversNodes(node);//遍历根结点

                //MessageBox.Show(AutoUser.nodesTag.ToString());

                string toolConfig = AutoUser.nodesTag.ToString();

                int RoleId = Convert.ToInt32(sysRoleDataGrid.SelectedRows[0].Cells["ROLEID"].Value);

                if (sysRolePerBll.toolSubmit(RoleId, toolConfig))
                {
                    MessageBox.Show("已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            else
            {
                MessageBox.Show("请选中一行操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        /// <summary>
        /// 右键操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTool_Click(object sender, EventArgs e)
        {
            AutoMainXml.DeserializeXml("AutoMainXml.xml");

            int NSkinForm = Convert.ToInt32(AutoMainXml.StaticAutoXml.NSkinForm);

            NFrameAppearance appearance = NUIManager.GetPredefinedFrame((PredefinedFrame)NSkinForm);

            using (AddRole frm = new AddRole())
            {
                if (NSkinForm != 0)
                {
                    frm.UseGlassIfEnabled = CommonTriState.False;
                    frm.EnableSkinning = false;
                    frm.Palette.Copy(NUIManager.Palette);

                    frm.Text = sender.ToString() == "新增" ? "新增" : "修改";
                    frm.DialogsFormString = frm.Text;
                    frm.FrameAppearance = appearance;
                }

                frm.ShowCaptionImage = true;
                frm.StartPosition = FormStartPosition.CenterParent;

                if (sender.ToString() == "修改")
                {
                    //给实体赋值
                    SysRoleInfo modelRole = new SysRoleInfo();
                    modelRole.RoleId = Convert.ToInt32(sysRoleDataGrid.SelectedRows[0].Cells["ROLEID"].Value);
                    modelRole.R_RoleName = Convert.ToString(sysRoleDataGrid.SelectedRows[0].Cells["R_ROLENAME"].Value);
                    modelRole.MemoText = Convert.ToString(sysRoleDataGrid.SelectedRows[0].Cells["MEMO_TEXT"].Value);
                    frm._sysRole = modelRole;
                }

                if (frm.ShowDialog() == DialogResult.Cancel)
                    return;

                if (frm.Text == "新增" ? sysRoleBll.Add(frm.sysRole) : sysRoleBll.Edit(frm.sysRole))
                {
                    MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    BindGetRolePage(winFormPager1.PageIndex);
                }
                else
                {
                    MessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 右键删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelTool_Click(object sender, EventArgs e)
        {
            if (sysRoleDataGrid.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("你确认要删除该角色吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int RoleId = Convert.ToInt32(sysRoleDataGrid.SelectedRows[0].Cells["ROLEID"].Value);

                    if (sysRoleBll.Role_UserCount(RoleId))
                    {
                        MessageBox.Show("该角色已被占用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }

                    if (sysRoleBll.Del(RoleId))
                    {
                        MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        BindGetRolePage(winFormPager1.PageIndex);
                    }
                    else
                    {
                        MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选中一行操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

    }
}
