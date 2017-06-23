namespace Nui.MallInfo.Winform
{
    partial class AddRole
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRoleName = new Nevron.UI.WinForm.Controls.NTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripTion = new Nevron.UI.WinForm.Controls.NTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nCancel = new Nevron.UI.WinForm.Controls.NButton();
            this.nSubmit = new Nevron.UI.WinForm.Controls.NButton();
            this.nLineControl1 = new Nevron.UI.WinForm.Controls.NLineControl();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemoText = new Nevron.UI.WinForm.Controls.NTextBox();
            this.SuspendLayout();
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(100, 32);
            this.txtRoleName.MaxLength = 50;
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(394, 23);
            this.txtRoleName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "角色名称";
            // 
            // txtDescripTion
            // 
            this.txtDescripTion.Location = new System.Drawing.Point(100, 65);
            this.txtDescripTion.MaxLength = 200;
            this.txtDescripTion.Multiline = true;
            this.txtDescripTion.Name = "txtDescripTion";
            this.txtDescripTion.Size = new System.Drawing.Size(394, 69);
            this.txtDescripTion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "角色介绍";
            // 
            // nCancel
            // 
            this.nCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nCancel.Location = new System.Drawing.Point(429, 243);
            this.nCancel.Name = "nCancel";
            this.nCancel.Size = new System.Drawing.Size(75, 25);
            this.nCancel.TabIndex = 12;
            this.nCancel.Text = "取消";
            this.nCancel.UseVisualStyleBackColor = false;
            // 
            // nSubmit
            // 
            this.nSubmit.Location = new System.Drawing.Point(334, 243);
            this.nSubmit.Name = "nSubmit";
            this.nSubmit.Size = new System.Drawing.Size(75, 25);
            this.nSubmit.TabIndex = 11;
            this.nSubmit.Text = "保存";
            this.nSubmit.UseVisualStyleBackColor = false;
            this.nSubmit.Click += new System.EventHandler(this.nSubmit_Click);
            // 
            // nLineControl1
            // 
            this.nLineControl1.Location = new System.Drawing.Point(-118, 229);
            this.nLineControl1.Name = "nLineControl1";
            this.nLineControl1.Size = new System.Drawing.Size(655, 2);
            this.nLineControl1.Text = "nLineControl1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "备   注";
            // 
            // txtMemoText
            // 
            this.txtMemoText.Location = new System.Drawing.Point(100, 145);
            this.txtMemoText.MaxLength = 200;
            this.txtMemoText.Multiline = true;
            this.txtMemoText.Name = "txtMemoText";
            this.txtMemoText.Size = new System.Drawing.Size(394, 69);
            this.txtMemoText.TabIndex = 9;
            // 
            // AddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 288);
            this.Controls.Add(this.nCancel);
            this.Controls.Add(this.nSubmit);
            this.Controls.Add(this.nLineControl1);
            this.Controls.Add(this.txtMemoText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripTion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddRole";
            this.Text = "新增";
            this.Load += new System.EventHandler(this.AddRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Nevron.UI.WinForm.Controls.NTextBox txtRoleName;
        private System.Windows.Forms.Label label1;
        private Nevron.UI.WinForm.Controls.NTextBox txtDescripTion;
        private System.Windows.Forms.Label label6;
        private Nevron.UI.WinForm.Controls.NButton nCancel;
        private Nevron.UI.WinForm.Controls.NButton nSubmit;
        private Nevron.UI.WinForm.Controls.NLineControl nLineControl1;
        private System.Windows.Forms.Label label2;
        private Nevron.UI.WinForm.Controls.NTextBox txtMemoText;
    }
}