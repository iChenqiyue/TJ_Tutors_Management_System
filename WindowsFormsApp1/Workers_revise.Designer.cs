namespace TJ_Tutors_Management_System
{
    partial class Workers_Revise
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
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_student_num = new System.Windows.Forms.TextBox();
            this.rdo_woman = new System.Windows.Forms.RadioButton();
            this.rdo_man = new System.Windows.Forms.RadioButton();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_position = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_student_num = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_month = new System.Windows.Forms.Label();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.cbo_subject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_quit
            // 
            this.btn_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_quit.Location = new System.Drawing.Point(470, 394);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(172, 39);
            this.btn_quit.TabIndex = 13;
            this.btn_quit.Text = "取消/退出";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(199, 394);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(172, 39);
            this.btn_check.TabIndex = 12;
            this.btn_check.Text = "确认修改信息";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(530, 253);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(153, 25);
            this.txt_position.TabIndex = 11;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(218, 253);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(153, 25);
            this.txt_phone.TabIndex = 9;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // txt_student_num
            // 
            this.txt_student_num.Location = new System.Drawing.Point(218, 155);
            this.txt_student_num.Name = "txt_student_num";
            this.txt_student_num.Size = new System.Drawing.Size(153, 25);
            this.txt_student_num.TabIndex = 5;
            this.txt_student_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_student_num_KeyPress);
            // 
            // rdo_woman
            // 
            this.rdo_woman.AutoSize = true;
            this.rdo_woman.Location = new System.Drawing.Point(612, 60);
            this.rdo_woman.Name = "rdo_woman";
            this.rdo_woman.Size = new System.Drawing.Size(43, 19);
            this.rdo_woman.TabIndex = 3;
            this.rdo_woman.TabStop = true;
            this.rdo_woman.Text = "女";
            this.rdo_woman.UseVisualStyleBackColor = true;
            // 
            // rdo_man
            // 
            this.rdo_man.AutoSize = true;
            this.rdo_man.Location = new System.Drawing.Point(530, 60);
            this.rdo_man.Name = "rdo_man";
            this.rdo_man.Size = new System.Drawing.Size(43, 19);
            this.rdo_man.TabIndex = 2;
            this.rdo_man.TabStop = true;
            this.rdo_man.Text = "男";
            this.rdo_man.UseVisualStyleBackColor = true;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(218, 59);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(153, 25);
            this.txt_name.TabIndex = 54;
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Location = new System.Drawing.Point(435, 256);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(37, 15);
            this.lbl_position.TabIndex = 10;
            this.lbl_position.Text = "职位";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(117, 256);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(67, 15);
            this.lbl_phone.TabIndex = 8;
            this.lbl_phone.Text = "联系方式";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(435, 158);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(67, 15);
            this.lbl_subject.TabIndex = 6;
            this.lbl_subject.Text = "院系专业";
            // 
            // lbl_student_num
            // 
            this.lbl_student_num.AutoSize = true;
            this.lbl_student_num.Location = new System.Drawing.Point(117, 158);
            this.lbl_student_num.Name = "lbl_student_num";
            this.lbl_student_num.Size = new System.Drawing.Size(37, 15);
            this.lbl_student_num.TabIndex = 4;
            this.lbl_student_num.Text = "学号";
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(435, 62);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(37, 15);
            this.lbl_sex.TabIndex = 1;
            this.lbl_sex.Text = "性别";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(117, 62);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(37, 15);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "姓名";
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Location = new System.Drawing.Point(101, 336);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(97, 15);
            this.lbl_month.TabIndex = 55;
            this.lbl_month.Text = "本月业务积分";
            // 
            // txt_month
            // 
            this.txt_month.Location = new System.Drawing.Point(218, 333);
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(153, 25);
            this.txt_month.TabIndex = 56;
            this.txt_month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_month_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 57;
            this.label2.Text = "累计业务积分";
            // 
            // txt_sum
            // 
            this.txt_sum.Location = new System.Drawing.Point(530, 333);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(153, 25);
            this.txt_sum.TabIndex = 58;
            this.txt_sum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sum_KeyPress);
            // 
            // cbo_subject
            // 
            this.cbo_subject.FormattingEnabled = true;
            this.cbo_subject.Location = new System.Drawing.Point(530, 155);
            this.cbo_subject.Name = "cbo_subject";
            this.cbo_subject.Size = new System.Drawing.Size(153, 23);
            this.cbo_subject.TabIndex = 59;
            // 
            // Workers_Revise
            // 
            this.AcceptButton = this.btn_check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_quit;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.cbo_subject);
            this.Controls.Add(this.txt_sum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_month);
            this.Controls.Add(this.lbl_month);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Workers_Revise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改工作人员信息";
            this.Load += new System.EventHandler(this.Workers_Revise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_student_num;
        private System.Windows.Forms.RadioButton rdo_woman;
        private System.Windows.Forms.RadioButton rdo_man;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_student_num;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_month;
        private System.Windows.Forms.TextBox txt_month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.ComboBox cbo_subject;
    }
}