namespace Nui.MallInfo.Winform
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Nevron.UI.WinForm.Docking.NDockingPanelHost nDockZone1 = new Nevron.UI.WinForm.Docking.NDockingPanelHost();
            Nevron.UI.WinForm.Docking.NDockZone nDockZone2 = new Nevron.UI.WinForm.Docking.NDockZone();
            Nevron.UI.WinForm.Docking.NDockingPanelHost nDockZone3 = new Nevron.UI.WinForm.Docking.NDockingPanelHost();
            this.winFormPager1 = new Tony.Controls.Winform.WinFormPager();
            this.nDockManager1 = new Nevron.UI.WinForm.Docking.NDockManager(this.components);
            this.nStatusBar1 = new Nevron.UI.WinForm.Controls.NStatusBar();
            this.nStatusBarPanel1 = new Nevron.UI.WinForm.Controls.NStatusBarPanel();
            this.nStatusBarPanel2 = new Nevron.UI.WinForm.Controls.NStatusBarPanel();
            this.nDockingPanel1 = new Nevron.UI.WinForm.Docking.NDockingPanel();
            this.nTextBox1 = new Nevron.UI.WinForm.Controls.NTextBox();
            this.nCommandBarsManager1 = new Nevron.UI.WinForm.Controls.NCommandBarsManager(this.components);
            this.nMenuBar1 = new Nevron.UI.WinForm.Controls.NMenuBar();
            this.nMenuCommand = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCommand3 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd1 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd2 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd3 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd4 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd5 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd6 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCommand1 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd2_1 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd2_2 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd2_3 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd2_4 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd2_5 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd2_6 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd2_7 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCmd2_8 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCommand5 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nCommand2 = new Nevron.UI.WinForm.Controls.NCommand();
            this.nDockingPanel3 = new Nevron.UI.WinForm.Docking.NDockingPanel();
            this.sysTreeView = new Nevron.UI.WinForm.Controls.NTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.nDockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStatusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStatusBarPanel2)).BeginInit();
            this.nDockingPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCommandBarsManager1)).BeginInit();
            this.nDockingPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // winFormPager1
            // 
            this.winFormPager1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.winFormPager1.BackColor = System.Drawing.SystemColors.Control;
            this.winFormPager1.BtnTextNext = "下页";
            this.winFormPager1.BtnTextPrevious = "上页";
            this.winFormPager1.Location = new System.Drawing.Point(5, 3);
            this.winFormPager1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.winFormPager1.Name = "winFormPager1";
            this.winFormPager1.PageSize = 20;
            this.winFormPager1.RecordCount = 0;
            this.winFormPager1.Size = new System.Drawing.Size(1119, 39);
            this.winFormPager1.TabIndex = 0;
            // 
            // nDockManager1
            // 
            this.nDockManager1.Form = this;
            this.nDockManager1.RootContainerZIndex = 1;
            this.nDockManager1.UndockToleranceSize = 2;
            //  
            // Root Zone
            //  
            this.nDockManager1.RootContainer.RootZone.AddChild(nDockZone1);
            this.nDockManager1.RootContainer.RootZone.AddChild(nDockZone2);
            this.nDockManager1.RootContainer.RootZone.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //  
            // nDockZone1
            //  
            nDockZone1.AddChild(this.nDockingPanel3);
            nDockZone1.Name = "nDockZone1";
            nDockZone1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            nDockZone1.Index = 0;
            //  
            // nDockZone2
            //  
            nDockZone2.AddChild(this.nDockManager1.DocumentManager.DocumentViewHost);
            nDockZone2.AddChild(nDockZone3);
            nDockZone2.Name = "nDockZone2";
            nDockZone2.Orientation = System.Windows.Forms.Orientation.Vertical;
            nDockZone2.Index = 1;
            //  
            // nDockZone3
            //  
            nDockZone3.AddChild(this.nDockingPanel1);
            nDockZone3.Name = "nDockZone3";
            nDockZone3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            nDockZone3.Index = 1;
            // 
            // nStatusBar1
            // 
            this.nStatusBar1.Location = new System.Drawing.Point(0, 867);
            this.nStatusBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nStatusBar1.Name = "nStatusBar1";
            this.nStatusBar1.Panels.AddRange(new Nevron.UI.WinForm.Controls.NStatusBarPanel[] {
            this.nStatusBarPanel1,
            this.nStatusBarPanel2});
            this.nStatusBar1.ShowPanels = true;
            this.nStatusBar1.Size = new System.Drawing.Size(1524, 33);
            this.nStatusBar1.TabIndex = 2;
            this.nStatusBar1.Text = "nStatusBar1";
            // 
            // nStatusBarPanel1
            // 
            this.nStatusBarPanel1.Name = "nStatusBarPanel1";
            this.nStatusBarPanel1.Text = "登录账户:";
            // 
            // nStatusBarPanel2
            // 
            this.nStatusBarPanel2.Name = "nStatusBarPanel2";
            this.nStatusBarPanel2.Text = "admin";
            // 
            // nDockingPanel1
            // 
            this.nDockingPanel1.Controls.Add(this.nTextBox1);
            this.nDockingPanel1.FloatingSize = new System.Drawing.Size(200, 100);
            this.nDockingPanel1.Location = new System.Drawing.Point(1, 24);
            this.nDockingPanel1.Name = "nDockingPanel1";
            this.nDockingPanel1.Size = new System.Drawing.Size(1318, 171);
            this.nDockingPanel1.TabIndex = 1;
            this.nDockingPanel1.Text = "公告";
            // 
            // nTextBox1
            // 
            this.nTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTextBox1.Location = new System.Drawing.Point(0, 0);
            this.nTextBox1.Multiline = true;
            this.nTextBox1.Name = "nTextBox1";
            this.nTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.nTextBox1.Size = new System.Drawing.Size(1318, 171);
            this.nTextBox1.TabIndex = 1;
            // 
            // nCommandBarsManager1
            // 
            this.nCommandBarsManager1.ParentControl = this;
            this.nCommandBarsManager1.Toolbars.Add(this.nMenuBar1);
            // 
            // nMenuBar1
            // 
            this.nMenuBar1.AutoDropDownDelay = false;
            this.nMenuBar1.BackgroundType = Nevron.UI.WinForm.Controls.BackgroundType.Transparent;
            this.nMenuBar1.Commands.AddRange(new Nevron.UI.WinForm.Controls.NCommand[] {
            this.nMenuCommand});
            this.nMenuBar1.DefaultCommandStyle = Nevron.UI.WinForm.Controls.CommandStyle.Text;
            this.nMenuBar1.DefaultLocation = new System.Drawing.Point(0, 0);
            this.nMenuBar1.HasPendantCommand = false;
            this.nMenuBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nMenuBar1.Name = "nMenuBar1";
            this.nMenuBar1.PrefferedRowIndex = 0;
            this.nMenuBar1.RowIndex = 0;
            this.nMenuBar1.ShowTooltips = false;
            this.nMenuBar1.Text = "Menu Bar";
            // 
            // nMenuCommand
            // 
            this.nMenuCommand.Commands.AddRange(new Nevron.UI.WinForm.Controls.NCommand[] {
            this.nCommand3,
            this.nCommand1,
            this.nCommand5,
            this.nCommand2});
            this.nMenuCommand.Properties.ImageInfo.Image = global::Nui.MallInfo.Winform.Properties.Resources.Settings;
            this.nMenuCommand.Properties.ShowArrowStyle = Nevron.UI.WinForm.Controls.ShowArrowStyle.Never;
            this.nMenuCommand.Properties.Text = "系统设置";
            this.nMenuCommand.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.nMenuCommand_Click);
            // 
            // nCommand3
            // 
            this.nCommand3.Commands.AddRange(new Nevron.UI.WinForm.Controls.NCommand[] {
            this.nCmd1,
            this.nCmd2,
            this.nCmd3,
            this.nCmd4,
            this.nCmd5,
            this.nCmd6});
            this.nCommand3.Properties.Text = "页面主题";
            // 
            // nCmd1
            // 
            this.nCmd1.Properties.Text = "默认";
            this.nCmd1.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.nMenuCommand_Click);
            // 
            // nCmd2
            // 
            this.nCmd2.Properties.Text = "Vista";
            this.nCmd2.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.nMenuCommand_Click);
            // 
            // nCmd3
            // 
            this.nCmd3.Properties.Text = "Office 2007 Black";
            this.nCmd3.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.nMenuCommand_Click);
            // 
            // nCmd4
            // 
            this.nCmd4.Checked = true;
            this.nCmd4.Properties.Text = "Office 2007 Blue";
            this.nCmd4.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.nMenuCommand_Click);
            // 
            // nCmd5
            // 
            this.nCmd5.Properties.Text = "Orange";
            this.nCmd5.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.nMenuCommand_Click);
            // 
            // nCmd6
            // 
            this.nCmd6.Properties.Text = "Mac OS";
            this.nCmd6.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.nMenuCommand_Click);
            // 
            // nCommand1
            // 
            this.nCommand1.Commands.AddRange(new Nevron.UI.WinForm.Controls.NCommand[] {
            this.nCmd2_1,
            this.nCmd2_2,
            this.nCmd2_3,
            this.nCmd2_4,
            this.nCmd2_5,
            this.nCmd2_6,
            this.nCmd2_7,
            this.nCmd2_8});
            this.nCommand1.Properties.Text = "Form主题";
            // 
            // nCmd2_1
            // 
            this.nCmd2_1.Checked = true;
            this.nCmd2_1.Properties.Text = "默认";
            this.nCmd2_1.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.FormCommand_Click);
            // 
            // nCmd2_2
            // 
            this.nCmd2_2.Properties.Text = "Simple";
            this.nCmd2_2.Properties.TooltipText = "";
            this.nCmd2_2.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.FormCommand_Click);
            // 
            // nCmd2_3
            // 
            this.nCmd2_3.Properties.Text = "VistaSlate";
            this.nCmd2_3.Properties.TooltipText = "";
            this.nCmd2_3.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.FormCommand_Click);
            // 
            // nCmd2_4
            // 
            this.nCmd2_4.Properties.Text = "VistaRoyal";
            this.nCmd2_4.Properties.TooltipText = "";
            this.nCmd2_4.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.FormCommand_Click);
            // 
            // nCmd2_5
            // 
            this.nCmd2_5.Properties.Text = "OpusAlpha";
            this.nCmd2_5.Properties.TooltipText = "";
            this.nCmd2_5.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.FormCommand_Click);
            // 
            // nCmd2_6
            // 
            this.nCmd2_6.Properties.Text = "Inspirat";
            this.nCmd2_6.Properties.TooltipText = "";
            this.nCmd2_6.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.FormCommand_Click);
            // 
            // nCmd2_7
            // 
            this.nCmd2_7.Properties.Text = "Office2007Blue";
            this.nCmd2_7.Properties.TooltipText = "";
            this.nCmd2_7.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.FormCommand_Click);
            // 
            // nCmd2_8
            // 
            this.nCmd2_8.Properties.Text = "Office2007Aqua";
            this.nCmd2_8.Properties.TooltipText = "";
            this.nCmd2_8.Click += new Nevron.UI.WinForm.Controls.CommandEventHandler(this.FormCommand_Click);
            // 
            // nCommand5
            // 
            this.nCommand5.Properties.Text = "更换密码";
            // 
            // nCommand2
            // 
            this.nCommand2.Properties.Text = "注销";
            // 
            // nDockingPanel3
            // 
            this.nDockingPanel3.Controls.Add(this.sysTreeView);
            this.nDockingPanel3.Location = new System.Drawing.Point(1, 24);
            this.nDockingPanel3.Name = "nDockingPanel3";
            this.nDockingPanel3.Size = new System.Drawing.Size(198, 813);
            this.nDockingPanel3.TabIndex = 1;
            this.nDockingPanel3.Text = "系统菜单";
            // 
            // sysTreeView
            // 
            this.sysTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sysTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sysTreeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sysTreeView.Location = new System.Drawing.Point(0, 0);
            this.sysTreeView.Name = "sysTreeView";
            this.sysTreeView.Size = new System.Drawing.Size(198, 813);
            this.sysTreeView.TabIndex = 0;
            this.sysTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.nTreeView1_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 900);
            this.Controls.Add(this.nStatusBar1);
            this.Name = "MainForm";
            this.Text = "可罗门鞋商销售平台管理端";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nDockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStatusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStatusBarPanel2)).EndInit();
            this.nDockingPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nCommandBarsManager1)).EndInit();
            this.nDockingPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private Tony.Controls.Winform.WinFormPager winFormPager1;
        private Nevron.UI.WinForm.Docking.NDockManager nDockManager1;
        private Nevron.UI.WinForm.Controls.NStatusBar nStatusBar1;
        private Nevron.UI.WinForm.Controls.NStatusBarPanel nStatusBarPanel1;
        private Nevron.UI.WinForm.Controls.NStatusBarPanel LoginStatus;
        private Nevron.UI.WinForm.Docking.NDockingPanel nDockingPanel1;
        private Nevron.UI.WinForm.Controls.NCommandBarsManager nCommandBarsManager1;
        private Nevron.UI.WinForm.Controls.NMenuBar nMenuBar1;
        private Nevron.UI.WinForm.Docking.NDockingPanel nDockingPanel3;
        private Nevron.UI.WinForm.Controls.NCommand nMenuCommand;
        private Nevron.UI.WinForm.Controls.NCommand nCommand5;
        private Nevron.UI.WinForm.Controls.NCommand nCommand2;
        private Nevron.UI.WinForm.Controls.NTextBox nTextBox1;
        private Nevron.UI.WinForm.Controls.NCommand nCommand3;
        private Nevron.UI.WinForm.Controls.NCommand nCmd1;
        private Nevron.UI.WinForm.Controls.NCommand nCmd2;
        private Nevron.UI.WinForm.Controls.NCommand nCmd3;
        private Nevron.UI.WinForm.Controls.NCommand nCmd4;
        private Nevron.UI.WinForm.Controls.NCommand nCmd5;
        private Nevron.UI.WinForm.Controls.NCommand nCmd6;
        private Nevron.UI.WinForm.Controls.NTreeView sysTreeView;
        private Nevron.UI.WinForm.Controls.NCommand nCommand1;
        private Nevron.UI.WinForm.Controls.NCommand nCmd2_1;
        private Nevron.UI.WinForm.Controls.NCommand nCmd2_2;
        private Nevron.UI.WinForm.Controls.NCommand nCmd2_3;
        private Nevron.UI.WinForm.Controls.NCommand nCmd2_4;
        private Nevron.UI.WinForm.Controls.NCommand nCmd2_5;
        private Nevron.UI.WinForm.Controls.NCommand nCmd2_6;
        private Nevron.UI.WinForm.Controls.NCommand nCmd2_7;
        private Nevron.UI.WinForm.Controls.NCommand nCmd2_8;
        private Nevron.UI.WinForm.Controls.NStatusBarPanel nStatusBarPanel2;



    }
}

