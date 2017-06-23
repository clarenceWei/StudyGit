using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nui.MallInfo.BLL;
using Nui.MallInfo.Model;
using Fx678Member.Framework.Log;
using Nevron.UI.WinForm.Controls;
using Nevron.UI;
using Nevron.GraphicsCore;
using Nui.MallInfo.Utility;

namespace Nui.MallInfo.Winform
{
    public partial class UC_sysUser : UserControl
    {
        SysUser sysUserBll = new SysUser();
        SysModule sysModuleBll = new SysModule();

        public UC_sysUser()
        {
            InitializeComponent();

            StartDate.Value = DateTime.Now.AddDays(-30);


        }

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <param name="Index"></param>
        private void BindGetUserPage(int Index)
        {
            try
            {
                int Count = 0;
                DateTime nStartDate = StartDate.Value;
                DateTime nEndDate = EndDate.Value.AddMinutes(10);
                SysUserInfo[] sysUserList = sysUserBll.GetUserPage(nStartDate, nEndDate, txtKeyWord.Text, Properties.Settings.Default.U_Account, Index, winFormPager1.PageSize, out Count);
                winFormPager1.RecordCount = Count;
                sysUserDataGrid.Rows.Clear();

                if (sysUserList != null && sysUserList.Length > 0)
                {
                    for (int i = 0; i < sysUserList.Length; i++)
                    {
                        sysUserDataGrid.Rows.Add(new object[]
                         {
                            sysUserList[i].UserId,
                            sysUserList[i].U_Account,
                            sysUserList[i].U_Name,
                            sysUserList[i].U_PassWord,
                            sysUserList[i].U_Phone,
                            sysUserList[i].U_Email,
                            sysUserList[i].U_RoleId,
                            sysUserList[i].U_RoleName,
                            sysUserList[i].CREATE_DATE == DateTime.MinValue ? "": sysUserList[i].CREATE_DATE.ToString(),
                            sysUserList[i].MemoText,
                            sysUserList[i].EditUser,
                            sysUserList[i].EditDate== DateTime.MinValue ? "": sysUserList[i].EditDate.ToString()
                         });
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error("用户列表", ex);
            }
        }


        //--------------------------------------页面事件区域------------------------------------------//

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_sysUser_Load(object sender, EventArgs e)
        {
            //用户列表
            BindGetUserPage(1);

            //权限列表
            //AutoUser.BindRoot(sysModuleBll.GetModule(), sysUserTreeView);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGetUserPage(winFormPager1.PageIndex);
        }

        /// <summary>
        /// 分页事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void winFormPager1_PageIndexChanged(object sender, EventArgs e)
        {
            BindGetUserPage(winFormPager1.PageIndex);
        }

        /// <summary>
        /// 单击单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sysUserDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == -1)
                {
                    sysUserDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    sysUserDataGrid.Rows[e.RowIndex].Selected = true;
                }
                else
                {
                    sysUserDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    sysUserDataGrid.Rows[e.RowIndex].Selected = true;
                }
            }

            if (sysUserDataGrid.SelectedRows.Count > 0)
            {
                int RoleId = Convert.ToInt32(sysUserDataGrid.SelectedRows[0].Cells["U_ROLEID"].Value);

                sysUserTreeView.Nodes.Clear();

                //权限列表
                AutoUser.BindRoot(sysModuleBll.GetModule(RoleId), sysUserTreeView);
            }

            this.sysUserTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.sysUserTreeView_AfterCheck);
        }

        /// <summary>
        /// 双击单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sysUserDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == -1)
                {
                    sysUserDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    sysUserDataGrid.Rows[e.RowIndex].Selected = true;
                }

                else
                {
                    sysUserDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    sysUserDataGrid.Rows[e.RowIndex].Selected = true;

                }
            }
        }

        /// <summary>
        /// 右键操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTool_Click(object sender, EventArgs e)
        {

            //Simple:1
            //VistaSlate:2
            //VistaRoyal:3
            //OpusAlpha:4
            //Inspirat:5
            //Office2007Blue:6
            //Office2007Aqua:7
            //NFrameAppearance appearance = NUIManager.GetPredefinedFrame((PredefinedFrame)4);
            //NForm form = new NForm();
            //form.UseGlassIfEnabled = CommonTriState.False;
            //form.EnableSkinning = false;
            //form.Palette.Copy(NUIManager.Palette);
            //form.Text = "Custom Form Example";
            //form.FrameAppearance = appearance;
            //form.ShowCaptionImage = true;
            //form.StartPosition = FormStartPosition.CenterParent;
            //form.ShowDialog();

            AutoMainXml.DeserializeXml("AutoMainXml.xml");

            int NSkinForm = Convert.ToInt32(AutoMainXml.StaticAutoXml.NSkinForm);

            NFrameAppearance appearance = NUIManager.GetPredefinedFrame((PredefinedFrame)NSkinForm);

            using (AddUser frm = new AddUser())
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
                    SysUserInfo modelUser = new SysUserInfo();
                    modelUser.U_Account = Convert.ToString(sysUserDataGrid.SelectedRows[0].Cells["U_ACCOUNT"].Value);
                    modelUser.U_Name = Convert.ToString(sysUserDataGrid.SelectedRows[0].Cells["U_NAME"].Value);
                    modelUser.U_PassWord = Convert.ToString(sysUserDataGrid.SelectedRows[0].Cells["U_PASSWORD"].Value);
                    modelUser.U_Phone = Convert.ToString(sysUserDataGrid.SelectedRows[0].Cells["U_PHONE"].Value);
                    modelUser.U_Email = Convert.ToString(sysUserDataGrid.SelectedRows[0].Cells["U_EMAIL"].Value);
                    modelUser.MemoText = Convert.ToString(sysUserDataGrid.SelectedRows[0].Cells["MEMO_TEXT"].Value);
                    frm._sysUser = modelUser;
                }

                if (frm.ShowDialog() == DialogResult.Cancel)
                    return;

                if (frm.Text == "新增" ? sysUserBll.Add(frm.sysUser) : sysUserBll.Edit(frm.sysUser))
                {
                    MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    BindGetUserPage(winFormPager1.PageIndex);
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
            if (sysUserDataGrid.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("你确认要删除该用户吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int UserId = Convert.ToInt32(sysUserDataGrid.SelectedRows[0].Cells["USERID"].Value);

                    if (sysUserBll.Del(UserId))
                    {
                        MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        BindGetUserPage(winFormPager1.PageIndex);
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


        /// <summary>
        /// 权限列表点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sysUserTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            //try
            //{
            //    //if (AutoUser.check == false)
            //    //{
            //    //    AutoUser.SetChild(e.Node);
            //    //}
            //    //AutoUser.SetParent(e.Node);
            //    //AutoUser.check = false;

            //    SetChildChecked(e.Node);  // 判断是否是根节点 
            //    //if (e.Node.Parent != null)
            //    {
            //        SetParentChecked(e.Node);
            //    }
            //}
            //catch { }

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


        }

    }
}
