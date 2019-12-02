namespace TJ_Tutors_Management_System
{
    partial class Workers_Add
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_student_num = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.rdo_man = new System.Windows.Forms.RadioButton();
            this.rdo_woman = new System.Windows.Forms.RadioButton();
            this.txt_student_num = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.cbo_subject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(107, 71);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(37, 15);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "姓名";
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(425, 71);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(37, 15);
            this.lbl_sex.TabIndex = 2;
            this.lbl_sex.Text = "性别";
            // 
            // lbl_student_num
            // 
            this.lbl_student_num.AutoSize = true;
            this.lbl_student_num.Location = new System.Drawing.Point(107, 167);
            this.lbl_student_num.Name = "lbl_student_num";
            this.lbl_student_num.Size = new System.Drawing.Size(37, 15);
            this.lbl_student_num.TabIndex = 5;
            this.lbl_student_num.Text = "学号";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(425, 167);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(67, 15);
            this.lbl_subject.TabIndex = 7;
            this.lbl_subject.Text = "院系专业";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(107, 265);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(67, 15);
            this.lbl_phone.TabIndex = 9;
            this.lbl_phone.Text = "联系方式";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Location = new System.Drawing.Point(425, 265);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(37, 15);
            this.lbl_position.TabIndex = 11;
            this.lbl_position.Text = "职位";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(208, 68);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(153, 25);
            this.txt_name.TabIndex = 1;
            // 
            // rdo_man
            // 
            this.rdo_man.AutoSize = true;
            this.rdo_man.Location = new System.Drawing.Point(520, 69);
            this.rdo_man.Name = "rdo_man";
            this.rdo_man.Size = new System.Drawing.Size(43, 19);
            this.rdo_man.TabIndex = 3;
            this.rdo_man.TabStop = true;
            this.rdo_man.Text = "男";
            this.rdo_man.UseVisualStyleBackColor = true;
            // 
            // rdo_woman
            // 
            this.rdo_woman.AutoSize = true;
            this.rdo_woman.Location = new System.Drawing.Point(602, 69);
            this.rdo_woman.Name = "rdo_woman";
            this.rdo_woman.Size = new System.Drawing.Size(43, 19);
            this.rdo_woman.TabIndex = 4;
            this.rdo_woman.TabStop = true;
            this.rdo_woman.Text = "女";
            this.rdo_woman.UseVisualStyleBackColor = true;
            // 
            // txt_student_num
            // 
            this.txt_student_num.Location = new System.Drawing.Point(208, 164);
            this.txt_student_num.Name = "txt_student_num";
            this.txt_student_num.Size = new System.Drawing.Size(153, 25);
            this.txt_student_num.TabIndex = 6;
            this.txt_student_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_student_num_KeyPress);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(208, 262);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(153, 25);
            this.txt_phone.TabIndex = 10;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(520, 262);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(153, 25);
            this.txt_position.TabIndex = 12;
            // 
            // btn_quit
            // 
            this.btn_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_quit.Location = new System.Drawing.Point(460, 361);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(172, 39);
            this.btn_quit.TabIndex = 14;
            this.btn_quit.Text = "取消/退出";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(189, 361);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(172, 39);
            this.btn_check.TabIndex = 13;
            this.btn_check.Text = "确认新增工作人员";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // cbo_subject
            // 
            this.cbo_subject.FormattingEnabled = true;
            this.cbo_subject.Location = new System.Drawing.Point(520, 164);
            this.cbo_subject.Name = "cbo_subject";
            this.cbo_subject.Size = new System.Drawing.Size(153, 23);
            this.cbo_subject.TabIndex = 8;
            // 
            // Workers_Add
            // 
            this.AcceptButton = this.btn_check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_quit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_subject);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.txt_position);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_student_num);
            this.Controls.Add(this.rdo_woman);
            this.Controls.Add(this.rdo_man);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_position);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.lbl_student_num);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Workers_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增工作人员";
            this.Load += new System.EventHandler(this.Workers_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_student_num;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.RadioButton rdo_man;
        private System.Windows.Forms.RadioButton rdo_woman;
        private System.Windows.Forms.TextBox txt_student_num;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.ComboBox cbo_subject;
    }
}