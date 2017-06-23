namespace Tony.Controls.Winform
{
    partial class WinFormPager
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormPager));
            this.lblPager = new System.Windows.Forms.Label();
            this.lbPre = new System.Windows.Forms.Label();
            this.txtToPageIndex = new System.Windows.Forms.TextBox();
            this.lbEnd = new System.Windows.Forms.Label();
            this.imglstPager = new System.Windows.Forms.ImageList(this.components);
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToPageIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPager
            // 
            this.lblPager.AutoSize = true;
            this.lblPager.Location = new System.Drawing.Point(13, 11);
            this.lblPager.Name = "lblPager";
            this.lblPager.Size = new System.Drawing.Size(287, 12);
            this.lblPager.TabIndex = 0;
            this.lblPager.Text = "总共{0}条记录,当前第{1}页,共{2}页,每页{3}条记录";
            // 
            // lbPre
            // 
            this.lbPre.AutoSize = true;
            this.lbPre.Location = new System.Drawing.Point(464, 10);
            this.lbPre.Name = "lbPre";
            this.lbPre.Size = new System.Drawing.Size(17, 12);
            this.lbPre.TabIndex = 5;
            this.lbPre.Text = "第";
            // 
            // txtToPageIndex
            // 
            this.txtToPageIndex.Location = new System.Drawing.Point(487, 6);
            this.txtToPageIndex.Name = "txtToPageIndex";
            this.txtToPageIndex.Size = new System.Drawing.Size(58, 21);
            this.txtToPageIndex.TabIndex = 6;
            this.txtToPageIndex.Text = "1";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(548, 10);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(17, 12);
            this.lbEnd.TabIndex = 7;
            this.lbEnd.Text = "页";
            // 
            // imglstPager
            // 
            this.imglstPager.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstPager.ImageStream")));
            this.imglstPager.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstPager.Images.SetKeyName(0, "first.gif");
            this.imglstPager.Images.SetKeyName(1, "prev.gif");
            this.imglstPager.Images.SetKeyName(2, "next.gif");
            this.imglstPager.Images.SetKeyName(3, "last.gif");
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(420, 5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(35, 23);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(382, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(344, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 23);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(306, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(35, 23);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "条数据";
            // 
            // TotalSize
            // 
            this.TotalSize.Location = new System.Drawing.Point(663, 5);
            this.TotalSize.Name = "TotalSize";
            this.TotalSize.Size = new System.Drawing.Size(58, 21);
            this.TotalSize.TabIndex = 10;
            this.TotalSize.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "每页";
            // 
            // btnToPageIndex
            // 
            this.btnToPageIndex.Location = new System.Drawing.Point(571, 4);
            this.btnToPageIndex.Name = "btnToPageIndex";
            this.btnToPageIndex.Size = new System.Drawing.Size(44, 23);
            this.btnToPageIndex.TabIndex = 8;
            this.btnToPageIndex.Text = "跳转";
            this.btnToPageIndex.UseVisualStyleBackColor = true;
            this.btnToPageIndex.Click += new System.EventHandler(this.btnToPageIndex_Click);
            // 
            // WinFormPager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnToPageIndex);
            this.Controls.Add(this.lbEnd);
            this.Controls.Add(this.txtToPageIndex);
            this.Controls.Add(this.lbPre);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblPager);
            this.Name = "WinFormPager";
            this.Size = new System.Drawing.Size(839, 31);
            this.Load += new System.EventHandler(this.WinFormPager_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WinFormPager_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WinFormPager_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPager;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lbPre;
        private System.Windows.Forms.TextBox txtToPageIndex;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.ImageList imglstPager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToPageIndex;
    }
}
