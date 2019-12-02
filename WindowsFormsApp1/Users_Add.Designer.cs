namespace TJ_Tutors_Management_System
{
    partial class Users_Add
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
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_level = new System.Windows.Forms.Label();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_cannel = new System.Windows.Forms.Button();
            this.cbo_level = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(117, 64);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(52, 15);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "用户名";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(233, 54);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(123, 25);
            this.txt_user.TabIndex = 1;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(117, 134);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 15);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "密  码";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(233, 131);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(123, 25);
            this.txt_password.TabIndex = 3;
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Location = new System.Drawing.Point(117, 205);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(53, 15);
            this.lbl_level.TabIndex = 4;
            this.lbl_level.Text = "级  别";
            // 
            // btn_yes
            // 
            this.btn_yes.Location = new System.Drawing.Point(89, 287);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(101, 42);
            this.btn_yes.TabIndex = 6;
            this.btn_yes.Text = "确认";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_cannel
            // 
            this.btn_cannel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cannel.Location = new System.Drawing.Point(255, 287);
            this.btn_cannel.Name = "btn_cannel";
            this.btn_cannel.Size = new System.Drawing.Size(101, 42);
            this.btn_cannel.TabIndex = 7;
            this.btn_cannel.Text = "取消";
            this.btn_cannel.UseVisualStyleBackColor = true;
            this.btn_cannel.Click += new System.EventHandler(this.btn_cannel_Click);
            // 
            // cbo_level
            // 
            this.cbo_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_level.FormattingEnabled = true;
            this.cbo_level.Items.AddRange(new object[] {
            "操作员",
            "管理员"});
            this.cbo_level.Location = new System.Drawing.Point(235, 202);
            this.cbo_level.Name = "cbo_level";
            this.cbo_level.Size = new System.Drawing.Size(121, 23);
            this.cbo_level.TabIndex = 8;
            // 
            // Users_Add
            // 
            this.AcceptButton = this.btn_yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cannel;
            this.ClientSize = new System.Drawing.Size(469, 370);
            this.Controls.Add(this.cbo_level);
            this.Controls.Add(this.btn_cannel);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.lbl_level);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Users_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户添加/修改";
            this.Load += new System.EventHandler(this.Users_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_cannel;
        private System.Windows.Forms.ComboBox cbo_level;
    }
}