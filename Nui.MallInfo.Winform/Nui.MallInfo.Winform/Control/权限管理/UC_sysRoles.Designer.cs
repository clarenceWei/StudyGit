namespace Nui.MallInfo.Winform
{
    partial class UC_sysRoles
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nButton1 = new Nevron.UI.WinForm.Controls.NButton();
            this.txtKeyWord = new Nevron.UI.WinForm.Controls.NTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sysRoleDataGrid = new Nevron.UI.WinForm.Controls.NDataGridView();
            this.ROLEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_ROLENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMO_TEXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddTool = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelTool = new System.Windows.Forms.ToolStripMenuItem();
            this.winFormPager1 = new Tony.Controls.Winform.WinFormPager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sysRoleTreeview = new Nevron.UI.WinForm.Controls.NTreeView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolSubmit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sysRoleDataGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1076, 654);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nButton1);
            this.groupBox1.Controls.Add(this.txtKeyWord);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1076, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // nButton1
            // 
            this.nButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nButton1.Location = new System.Drawing.Point(345, 20);
            this.nButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nButton1.Name = "nButton1";
            this.nButton1.Size = new System.Drawing.Size(100, 31);
            this.nButton1.TabIndex = 13;
            this.nButton1.Text = "查询";
            this.nButton1.UseVisualStyleBackColor = false;
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKeyWord.Location = new System.Drawing.Point(117, 24);
            this.txtKeyWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(211, 23);
            this.txtKeyWord.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "关键字:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.sysRoleDataGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.winFormPager1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1076, 581);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sysRoleDataGrid
            // 
            this.sysRoleDataGrid.AllowUserToAddRows = false;
            this.sysRoleDataGrid.AllowUserToDeleteRows = false;
            this.sysRoleDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.sysRoleDataGrid.ColumnHeadersHeight = 30;
            this.sysRoleDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ROLEID,
            this.R_ROLENAME,
            this.R_DESCRIPTION,
            this.MEMO_TEXT,
            this.EDIT_USER,
            this.EDIT_DATE});
            this.sysRoleDataGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.sysRoleDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sysRoleDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sysRoleDataGrid.Location = new System.Drawing.Point(3, 2);
            this.sysRoleDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sysRoleDataGrid.Name = "sysRoleDataGrid";
            this.sysRoleDataGrid.ReadOnly = true;
            this.sysRoleDataGrid.RowTemplate.Height = 27;
            this.sysRoleDataGrid.Size = new System.Drawing.Size(908, 518);
            this.sysRoleDataGrid.TabIndex = 2;
            this.sysRoleDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sysRoleDataGrid_CellClick);
            this.sysRoleDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sysRoleDataGrid_CellDoubleClick);
            // 
            // ROLEID
            // 
            this.ROLEID.HeaderText = "角色编号";
            this.ROLEID.Name = "ROLEID";
            this.ROLEID.ReadOnly = true;
            // 
            // R_ROLENAME
            // 
            this.R_ROLENAME.HeaderText = "角色名称";
            this.R_ROLENAME.Name = "R_ROLENAME";
            this.R_ROLENAME.ReadOnly = true;
            this.R_ROLENAME.Width = 150;
            // 
            // R_DESCRIPTION
            // 
            this.R_DESCRIPTION.HeaderText = "角色介绍";
            this.R_DESCRIPTION.Name = "R_DESCRIPTION";
            this.R_DESCRIPTION.ReadOnly = true;
            this.R_DESCRIPTION.Width = 200;
            // 
            // MEMO_TEXT
            // 
            this.MEMO_TEXT.HeaderText = "编辑备注";
            this.MEMO_TEXT.Name = "MEMO_TEXT";
            this.MEMO_TEXT.ReadOnly = true;
            this.MEMO_TEXT.Width = 200;
            // 
            // EDIT_USER
            // 
            this.EDIT_USER.HeaderText = "编辑人";
            this.EDIT_USER.Name = "EDIT_USER";
            this.EDIT_USER.ReadOnly = true;
            // 
            // EDIT_DATE
            // 
            this.EDIT_DATE.HeaderText = "编辑日期";
            this.EDIT_DATE.Name = "EDIT_DATE";
            this.EDIT_DATE.ReadOnly = true;
            this.EDIT_DATE.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTool,
            this.修改ToolStripMenuItem,
            this.DelTool});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 110);
            // 
            // AddTool
            // 
            this.AddTool.Name = "AddTool";
            this.AddTool.Size = new System.Drawing.Size(181, 26);
            this.AddTool.Text = "新增";
            this.AddTool.Click += new System.EventHandler(this.AddTool_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.AddTool_Click);
            // 
            // DelTool
            // 
            this.DelTool.Name = "DelTool";
            this.DelTool.Size = new System.Drawing.Size(181, 26);
            this.DelTool.Text = "删除";
            this.DelTool.Click += new System.EventHandler(this.DelTool_Click);
            // 
            // winFormPager1
            // 
            this.winFormPager1.BackColor = System.Drawing.SystemColors.Control;
            this.winFormPager1.BtnTextNext = "下页";
            this.winFormPager1.BtnTextPrevious = "上页";
            this.tableLayoutPanel1.SetColumnSpan(this.winFormPager1, 2);
            this.winFormPager1.Location = new System.Drawing.Point(5, 527);
            this.winFormPager1.Margin = new System.Windows.Forms.Padding(5);
            this.winFormPager1.Name = "winFormPager1";
            this.winFormPager1.PageSize = 20;
            this.winFormPager1.RecordCount = 0;
            this.winFormPager1.Size = new System.Drawing.Size(1066, 39);
            this.winFormPager1.TabIndex = 0;
            this.winFormPager1.PageIndexChanged += new Tony.Controls.Winform.WinFormPager.EventHandler(this.winFormPager1_PageIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sysRoleTreeview);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(918, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(154, 514);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "权限";
            // 
            // sysRoleTreeview
            // 
            this.sysRoleTreeview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sysRoleTreeview.CheckBoxes = true;
            this.sysRoleTreeview.ContextMenuStrip = this.contextMenuStrip2;
            this.sysRoleTreeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sysRoleTreeview.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sysRoleTreeview.Location = new System.Drawing.Point(4, 22);
            this.sysRoleTreeview.Margin = new System.Windows.Forms.Padding(4);
            this.sysRoleTreeview.Name = "sysRoleTreeview";
            this.sysRoleTreeview.Size = new System.Drawing.Size(146, 488);
            this.sysRoleTreeview.TabIndex = 2;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSubmit});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(115, 30);
            // 
            // toolSubmit
            // 
            this.toolSubmit.Name = "toolSubmit";
            this.toolSubmit.Size = new System.Drawing.Size(114, 26);
            this.toolSubmit.Text = "保存";
            this.toolSubmit.Click += new System.EventHandler(this.toolSubmit_Click);
            // 
            // UC_sysRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_sysRoles";
            this.Size = new System.Drawing.Size(1076, 654);
            this.Load += new System.EventHandler(this.UC_sysRoles_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sysRoleDataGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Nevron.UI.WinForm.Controls.NButton nButton1;
        private Nevron.UI.WinForm.Controls.NTextBox txtKeyWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Tony.Controls.Winform.WinFormPager winFormPager1;
        private Nevron.UI.WinForm.Controls.NDataGridView sysRoleDataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private Nevron.UI.WinForm.Controls.NTreeView sysRoleTreeview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_ROLENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMO_TEXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDIT_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDIT_DATE;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddTool;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelTool;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolSubmit;
    }
}
