namespace Nui.MallInfo.Winform
{
    partial class AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccount = new Nevron.UI.WinForm.Controls.NTextBox();
            this.txtName = new Nevron.UI.WinForm.Controls.NTextBox();
            this.txtPwd = new Nevron.UI.WinForm.Controls.NTextBox();
            this.txtEmail = new Nevron.UI.WinForm.Controls.NTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRoleName = new Nevron.UI.WinForm.Controls.NComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMemoText = new Nevron.UI.WinForm.Controls.NTextBox();
            this.nLineControl1 = new Nevron.UI.WinForm.Controls.NLineControl();
            this.nCancel = new Nevron.UI.WinForm.Controls.NButton();
            this.nSubmit = new Nevron.UI.WinForm.Controls.NButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new Nevron.UI.WinForm.Controls.NTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "账户密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户名称";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(106, 31);
            this.txtAccount.MaxLength = 50;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(198, 23);
            this.txtAccount.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(408, 31);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(106, 71);
            this.txtPwd.MaxLength = 20;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(198, 23);
            this.txtPwd.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 110);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(500, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email邮箱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "应用角色";
            // 
            // cmbRoleName
            // 
            this.cmbRoleName.Location = new System.Drawing.Point(106, 149);
            this.cmbRoleName.Name = "cmbRoleName";
            this.cmbRoleName.Size = new System.Drawing.Size(500, 22);
            this.cmbRoleName.TabIndex = 6;
            this.cmbRoleName.Text = "nComboBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "备   注";
            // 
            // txtMemoText
            // 
            this.txtMemoText.Location = new System.Drawing.Point(106, 189);
            this.txtMemoText.MaxLength = 200;
            this.txtMemoText.Multiline = true;
            this.txtMemoText.Name = "txtMemoText";
            this.txtMemoText.Size = new System.Drawing.Size(500, 69);
            this.txtMemoText.TabIndex = 7;
            // 
            // nLineControl1
            // 
            this.nLineControl1.Location = new System.Drawing.Point(-16, 269);
            this.nLineControl1.Name = "nLineControl1";
            this.nLineControl1.Size = new System.Drawing.Size(655, 2);
            this.nLineControl1.Text = "nLineControl1";
            // 
            // nCancel
            // 
            this.nCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nCancel.Location = new System.Drawing.Point(531, 283);
            this.nCancel.Name = "nCancel";
            this.nCancel.Size = new System.Drawing.Size(75, 25);
            this.nCancel.TabIndex = 9;
            this.nCancel.Text = "取消";
            this.nCancel.UseVisualStyleBackColor = false;
            // 
            // nSubmit
            // 
            this.nSubmit.Location = new System.Drawing.Point(436, 283);
            this.nSubmit.Name = "nSubmit";
            this.nSubmit.Size = new System.Drawing.Size(75, 25);
            this.nSubmit.TabIndex = 8;
            this.nSubmit.Text = "保存";
            this.nSubmit.UseVisualStyleBackColor = false;
            this.nSubmit.Click += new System.EventHandler(this.nSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "手机号码";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(408, 71);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(198, 23);
            this.txtPhone.TabIndex = 4;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 324);
            this.Controls.Add(this.nCancel);
            this.Controls.Add(this.nSubmit);
            this.Controls.Add(this.nLineControl1);
            this.Controls.Add(this.cmbRoleName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMemoText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddUser";
            this.Text = "新增用户";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Nevron.UI.WinForm.Controls.NTextBox txtAccount;
        private Nevron.UI.WinForm.Controls.NTextBox txtName;
        private Nevron.UI.WinForm.Controls.NTextBox txtPwd;
        private Nevron.UI.WinForm.Controls.NTextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Nevron.UI.WinForm.Controls.NComboBox cmbRoleName;
        private System.Windows.Forms.Label label6;
        private Nevron.UI.WinForm.Controls.NTextBox txtMemoText;
        private Nevron.UI.WinForm.Controls.NLineControl nLineControl1;
        private Nevron.UI.WinForm.Controls.NButton nCancel;
        private Nevron.UI.WinForm.Controls.NButton nSubmit;
        private System.Windows.Forms.Label label7;
        private Nevron.UI.WinForm.Controls.NTextBox txtPhone;



    }
}