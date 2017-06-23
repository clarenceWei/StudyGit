namespace Nui.MallInfo.Winform
{
    partial class UC_sysUser
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
            this.nGroupBox1 = new Nevron.UI.WinForm.Controls.NGroupBox();
            this.btnRefresh = new Nevron.UI.WinForm.Controls.NButton();
            this.txtKeyWord = new Nevron.UI.WinForm.Controls.NTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartDate = new Nevron.UI.WinForm.Controls.NDateTimePicker();
            this.EndDate = new Nevron.UI.WinForm.Controls.NDateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sysUserDataGrid = new Nevron.UI.WinForm.Controls.NDataGridView();
            this.USERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_ACCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_ROLEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_ROLENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMO_TEXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddTool = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelTool = new System.Windows.Forms.ToolStripMenuItem();
            this.winFormPager1 = new Tony.Controls.Winform.WinFormPager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sysUserTreeView = new Nevron.UI.WinForm.Controls.NTreeView();
            this.nContextMenu1 = new Nevron.UI.WinForm.Controls.NContextMenu();
            this.nCommand1 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCommand2 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCommand3 = new Nevron.UI.WinForm.Controls.NCommand();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.nGroupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sysUserDataGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.nGroupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1076, 654);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // nGroupBox1
            // 
            this.nGroupBox1.Controls.Add(this.btnRefresh);
            this.nGroupBox1.Controls.Add(this.txtKeyWord);
            this.nGroupBox1.Controls.Add(this.label3);
            this.nGroupBox1.Controls.Add(this.label2);
            this.nGroupBox1.Controls.Add(this.label1);
            this.nGroupBox1.Controls.Add(this.StartDate);
            this.nGroupBox1.Controls.Add(this.EndDate);
            this.nGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.nGroupBox1.Name = "nGroupBox1";
            this.nGroupBox1.Size = new System.Drawing.Size(1076, 68);
            this.nGroupBox1.TabIndex = 0;
            this.nGroupBox1.TabStop = false;
            this.nGroupBox1.Text = "查询";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRefresh.Location = new System.Drawing.Point(790, 19);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 31);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "查询";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKeyWord.Location = new System.Drawing.Point(562, 23);
            this.txtKeyWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(211, 23);
            this.txtKeyWord.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "关键字:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "到:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "从:";
            // 
            // StartDate
            // 
            this.StartDate.AllowDrop = true;
            this.StartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.StartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StartDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.StartDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.StartDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.StartDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.StartDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.StartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StartDate.Location = new System.Drawing.Point(75, 23);
            this.StartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(183, 26);
            this.StartDate.TabIndex = 15;
            // 
            // EndDate
            // 
            this.EndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.EndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EndDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.EndDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.EndDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.EndDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.EndDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.EndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EndDate.Location = new System.Drawing.Point(301, 23);
            this.EndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(183, 26);
            this.EndDate.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.sysUserDataGrid, 0, 0);
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
            // sysUserDataGrid
            // 
            this.sysUserDataGrid.AllowUserToAddRows = false;
            this.sysUserDataGrid.AllowUserToDeleteRows = false;
            this.sysUserDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.sysUserDataGrid.ColumnHeadersHeight = 30;
            this.sysUserDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USERID,
            this.U_ACCOUNT,
            this.U_NAME,
            this.U_PASSWORD,
            this.U_PHONE,
            this.U_EMAIL,
            this.U_ROLEID,
            this.U_ROLENAME,
            this.CREATE_DATE,
            this.MEMO_TEXT,
            this.EDIT_USER,
            this.EDIT_DATE});
            this.sysUserDataGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.sysUserDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sysUserDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sysUserDataGrid.Location = new System.Drawing.Point(3, 2);
            this.sysUserDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sysUserDataGrid.Name = "sysUserDataGrid";
            this.sysUserDataGrid.ReadOnly = true;
            this.sysUserDataGrid.RowTemplate.Height = 27;
            this.sysUserDataGrid.Size = new System.Drawing.Size(908, 518);
            this.sysUserDataGrid.TabIndex = 2;
            this.sysUserDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sysUserDataGrid_CellClick);
            this.sysUserDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sysUserDataGrid_CellDoubleClick);
            // 
            // USERID
            // 
            this.USERID.HeaderText = "用户编号";
            this.USERID.Name = "USERID";
            this.USERID.ReadOnly = true;
            // 
            // U_ACCOUNT
            // 
            this.U_ACCOUNT.HeaderText = "用户账号";
            this.U_ACCOUNT.Name = "U_ACCOUNT";
            this.U_ACCOUNT.ReadOnly = true;
            // 
            // U_NAME
            // 
            this.U_NAME.HeaderText = "用户名称";
            this.U_NAME.Name = "U_NAME";
            this.U_NAME.ReadOnly = true;
            // 
            // U_PASSWORD
            // 
            this.U_PASSWORD.HeaderText = "用户密码";
            this.U_PASSWORD.Name = "U_PASSWORD";
            this.U_PASSWORD.ReadOnly = true;
            this.U_PASSWORD.Visible = false;
            // 
            // U_PHONE
            // 
            this.U_PHONE.HeaderText = "手机号码";
            this.U_PHONE.Name = "U_PHONE";
            this.U_PHONE.ReadOnly = true;
            this.U_PHONE.Width = 130;
            // 
            // U_EMAIL
            // 
            this.U_EMAIL.HeaderText = "电子邮箱";
            this.U_EMAIL.Name = "U_EMAIL";
            this.U_EMAIL.ReadOnly = true;
            this.U_EMAIL.Width = 160;
            // 
            // U_ROLEID
            // 
            this.U_ROLEID.HeaderText = "角色ID";
            this.U_ROLEID.Name = "U_ROLEID";
            this.U_ROLEID.ReadOnly = true;
            this.U_ROLEID.Visible = false;
            // 
            // U_ROLENAME
            // 
            this.U_ROLENAME.HeaderText = "角色名称";
            this.U_ROLENAME.Name = "U_ROLENAME";
            this.U_ROLENAME.ReadOnly = true;
            this.U_ROLENAME.Width = 130;
            // 
            // CREATE_DATE
            // 
            this.CREATE_DATE.HeaderText = "创建时间";
            this.CREATE_DATE.Name = "CREATE_DATE";
            this.CREATE_DATE.ReadOnly = true;
            this.CREATE_DATE.Width = 160;
            // 
            // MEMO_TEXT
            // 
            this.MEMO_TEXT.HeaderText = "编辑备注";
            this.MEMO_TEXT.Name = "MEMO_TEXT";
            this.MEMO_TEXT.ReadOnly = true;
            this.MEMO_TEXT.Width = 150;
            // 
            // EDIT_USER
            // 
            this.EDIT_USER.HeaderText = "编辑人";
            this.EDIT_USER.Name = "EDIT_USER";
            this.EDIT_USER.ReadOnly = true;
            // 
            // EDIT_DATE
            // 
            this.EDIT_DATE.HeaderText = "编辑时间";
            this.EDIT_DATE.Name = "EDIT_DATE";
            this.EDIT_DATE.ReadOnly = true;
            this.EDIT_DATE.Width = 160;
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
            this.groupBox2.Controls.Add(this.sysUserTreeView);
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
            // sysUserTreeView
            // 
            this.sysUserTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sysUserTreeView.CheckBoxes = true;
            this.sysUserTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sysUserTreeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sysUserTreeView.Location = new System.Drawing.Point(4, 22);
            this.sysUserTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.sysUserTreeView.Name = "sysUserTreeView";
            this.sysUserTreeView.Size = new System.Drawing.Size(146, 488);
            this.sysUserTreeView.TabIndex = 2;
            this.sysUserTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.sysUserTreeView_AfterCheck);
            // 
            // nContextMenu1
            // 
            this.nContextMenu1.Commands.AddRange(new Nevron.UI.WinForm.Controls.NCommand[] {
            this.nCommand1,
            this.nCommand2,
            this.nCommand3});
            // 
            // nCommand1
            // 
            this.nCommand1.Properties.Text = "新增";
            // 
            // nCommand2
            // 
            this.nCommand2.Properties.Text = "修改";
            // 
            // nCommand3
            // 
            this.nCommand3.Properties.Text = "删除";
            // 
            // UC_sysUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_sysUser";
            this.Size = new System.Drawing.Size(1076, 654);
            this.Load += new System.EventHandler(this.UC_sysUser_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.nGroupBox1.ResumeLayout(false);
            this.nGroupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sysUserDataGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Tony.Controls.Winform.WinFormPager winFormPager1;
        private Nevron.UI.WinForm.Controls.NDataGridView sysUserDataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private Nevron.UI.WinForm.Controls.NTreeView sysUserTreeView;
        private Nevron.UI.WinForm.Controls.NGroupBox nGroupBox1;
        private Nevron.UI.WinForm.Controls.NButton btnRefresh;
        private Nevron.UI.WinForm.Controls.NTextBox txtKeyWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Nevron.UI.WinForm.Controls.NDateTimePicker StartDate;
        private Nevron.UI.WinForm.Controls.NDateTimePicker EndDate;
        private Nevron.UI.WinForm.Controls.NContextMenu nContextMenu1;
        private Nevron.UI.WinForm.Controls.NCommand nCommand1;
        private Nevron.UI.WinForm.Controls.NCommand nCommand2;
        private Nevron.UI.WinForm.Controls.NCommand nCommand3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddTool;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelTool;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERID;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ACCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ROLEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ROLENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMO_TEXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDIT_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDIT_DATE;
    }
}
