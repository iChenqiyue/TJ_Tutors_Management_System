namespace TJ_Tutors_Management_System
{
    partial class Students_Revise
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
            this.components = new System.ComponentModel.Container();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.txt_important_remarks = new System.Windows.Forms.TextBox();
            this.lbl_important_remarks = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.cbo_degree = new System.Windows.Forms.ComboBox();
            this.lbl_degree = new System.Windows.Forms.Label();
            this.rdo_woman = new System.Windows.Forms.RadioButton();
            this.rdo_man = new System.Windows.Forms.RadioButton();
            this.lbl_student_sex = new System.Windows.Forms.Label();
            this.txt_place = new System.Windows.Forms.TextBox();
            this.lbl_place = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.txt_student_num = new System.Windows.Forms.TextBox();
            this.lbl_student_num = new System.Windows.Forms.Label();
            this.txt_student_name = new System.Windows.Forms.TextBox();
            this.lbl_student_name = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_blacklist = new System.Windows.Forms.Label();
            this.lbl_imprisonment = new System.Windows.Forms.Label();
            this.txt_imprisonment = new System.Windows.Forms.TextBox();
            this.cbo_yesno = new System.Windows.Forms.ComboBox();
            this.dgv_parents = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_parents = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cbo_subject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parents)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_quit
            // 
            this.btn_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_quit.Location = new System.Drawing.Point(624, 660);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(120, 39);
            this.btn_quit.TabIndex = 27;
            this.btn_quit.Text = "取消/退出";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(244, 660);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(120, 39);
            this.btn_check.TabIndex = 26;
            this.btn_check.Text = "确认修改信息";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // txt_important_remarks
            // 
            this.txt_important_remarks.Location = new System.Drawing.Point(180, 289);
            this.txt_important_remarks.Multiline = true;
            this.txt_important_remarks.Name = "txt_important_remarks";
            this.txt_important_remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_important_remarks.Size = new System.Drawing.Size(564, 56);
            this.txt_important_remarks.TabIndex = 19;
            // 
            // lbl_important_remarks
            // 
            this.lbl_important_remarks.AutoSize = true;
            this.lbl_important_remarks.Location = new System.Drawing.Point(57, 292);
            this.lbl_important_remarks.Name = "lbl_important_remarks";
            this.lbl_important_remarks.Size = new System.Drawing.Size(67, 15);
            this.lbl_important_remarks.TabIndex = 18;
            this.lbl_important_remarks.Text = "重要备注";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(180, 223);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(200, 25);
            this.txt_phone.TabIndex = 15;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress_1);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(57, 226);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(67, 15);
            this.lbl_phone.TabIndex = 14;
            this.lbl_phone.Text = "联系电话";
            // 
            // cbo_degree
            // 
            this.cbo_degree.DisplayMember = "姓名";
            this.cbo_degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_degree.FormattingEnabled = true;
            this.cbo_degree.Items.AddRange(new object[] {
            "本科",
            "硕士",
            "博士"});
            this.cbo_degree.Location = new System.Drawing.Point(180, 159);
            this.cbo_degree.Name = "cbo_degree";
            this.cbo_degree.Size = new System.Drawing.Size(200, 23);
            this.cbo_degree.TabIndex = 10;
            this.cbo_degree.ValueMember = "姓名";
            // 
            // lbl_degree
            // 
            this.lbl_degree.AutoSize = true;
            this.lbl_degree.Location = new System.Drawing.Point(57, 162);
            this.lbl_degree.Name = "lbl_degree";
            this.lbl_degree.Size = new System.Drawing.Size(67, 15);
            this.lbl_degree.TabIndex = 9;
            this.lbl_degree.Text = "在读学位";
            // 
            // rdo_woman
            // 
            this.rdo_woman.AutoSize = true;
            this.rdo_woman.Location = new System.Drawing.Point(629, 160);
            this.rdo_woman.Name = "rdo_woman";
            this.rdo_woman.Size = new System.Drawing.Size(43, 19);
            this.rdo_woman.TabIndex = 12;
            this.rdo_woman.TabStop = true;
            this.rdo_woman.Text = "女";
            this.rdo_woman.UseVisualStyleBackColor = true;
            // 
            // rdo_man
            // 
            this.rdo_man.AutoSize = true;
            this.rdo_man.Location = new System.Drawing.Point(548, 162);
            this.rdo_man.Name = "rdo_man";
            this.rdo_man.Size = new System.Drawing.Size(43, 19);
            this.rdo_man.TabIndex = 12;
            this.rdo_man.TabStop = true;
            this.rdo_man.Text = "男";
            this.rdo_man.UseVisualStyleBackColor = true;
            // 
            // lbl_student_sex
            // 
            this.lbl_student_sex.AutoSize = true;
            this.lbl_student_sex.Location = new System.Drawing.Point(421, 162);
            this.lbl_student_sex.Name = "lbl_student_sex";
            this.lbl_student_sex.Size = new System.Drawing.Size(37, 15);
            this.lbl_student_sex.TabIndex = 11;
            this.lbl_student_sex.Text = "性别";
            // 
            // txt_place
            // 
            this.txt_place.Location = new System.Drawing.Point(544, 223);
            this.txt_place.Name = "txt_place";
            this.txt_place.Size = new System.Drawing.Size(200, 25);
            this.txt_place.TabIndex = 17;
            // 
            // lbl_place
            // 
            this.lbl_place.AutoSize = true;
            this.lbl_place.Location = new System.Drawing.Point(421, 226);
            this.lbl_place.Name = "lbl_place";
            this.lbl_place.Size = new System.Drawing.Size(52, 15);
            this.lbl_place.TabIndex = 16;
            this.lbl_place.Text = "生源地";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(421, 94);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(67, 15);
            this.lbl_subject.TabIndex = 7;
            this.lbl_subject.Text = "院系专业";
            // 
            // txt_student_num
            // 
            this.txt_student_num.Location = new System.Drawing.Point(180, 91);
            this.txt_student_num.Name = "txt_student_num";
            this.txt_student_num.Size = new System.Drawing.Size(200, 25);
            this.txt_student_num.TabIndex = 6;
            this.txt_student_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_student_num_KeyPress_1);
            // 
            // lbl_student_num
            // 
            this.lbl_student_num.AutoSize = true;
            this.lbl_student_num.Location = new System.Drawing.Point(57, 94);
            this.lbl_student_num.Name = "lbl_student_num";
            this.lbl_student_num.Size = new System.Drawing.Size(37, 15);
            this.lbl_student_num.TabIndex = 5;
            this.lbl_student_num.Text = "学号";
            // 
            // txt_student_name
            // 
            this.txt_student_name.Location = new System.Drawing.Point(544, 27);
            this.txt_student_name.Name = "txt_student_name";
            this.txt_student_name.Size = new System.Drawing.Size(200, 25);
            this.txt_student_name.TabIndex = 4;
            // 
            // lbl_student_name
            // 
            this.lbl_student_name.AutoSize = true;
            this.lbl_student_name.Location = new System.Drawing.Point(421, 30);
            this.lbl_student_name.Name = "lbl_student_name";
            this.lbl_student_name.Size = new System.Drawing.Size(67, 15);
            this.lbl_student_name.TabIndex = 3;
            this.lbl_student_name.Text = "教员姓名";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(180, 27);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(200, 25);
            this.txt_num.TabIndex = 2;
            this.txt_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_KeyPress);
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(57, 30);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(67, 15);
            this.lbl_num.TabIndex = 1;
            this.lbl_num.Text = "教员编号";
            // 
            // lbl_blacklist
            // 
            this.lbl_blacklist.AutoSize = true;
            this.lbl_blacklist.Location = new System.Drawing.Point(57, 374);
            this.lbl_blacklist.Name = "lbl_blacklist";
            this.lbl_blacklist.Size = new System.Drawing.Size(82, 15);
            this.lbl_blacklist.TabIndex = 20;
            this.lbl_blacklist.Text = "是否黑名单";
            // 
            // lbl_imprisonment
            // 
            this.lbl_imprisonment.AutoSize = true;
            this.lbl_imprisonment.Location = new System.Drawing.Point(36, 418);
            this.lbl_imprisonment.Name = "lbl_imprisonment";
            this.lbl_imprisonment.Size = new System.Drawing.Size(127, 15);
            this.lbl_imprisonment.TabIndex = 22;
            this.lbl_imprisonment.Text = "相关说明及监禁期";
            // 
            // txt_imprisonment
            // 
            this.txt_imprisonment.Location = new System.Drawing.Point(180, 415);
            this.txt_imprisonment.Multiline = true;
            this.txt_imprisonment.Name = "txt_imprisonment";
            this.txt_imprisonment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_imprisonment.Size = new System.Drawing.Size(564, 56);
            this.txt_imprisonment.TabIndex = 23;
            // 
            // cbo_yesno
            // 
            this.cbo_yesno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_yesno.FormattingEnabled = true;
            this.cbo_yesno.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cbo_yesno.Location = new System.Drawing.Point(180, 371);
            this.cbo_yesno.Name = "cbo_yesno";
            this.cbo_yesno.Size = new System.Drawing.Size(113, 23);
            this.cbo_yesno.TabIndex = 21;
            // 
            // dgv_parents
            // 
            this.dgv_parents.AllowUserToAddRows = false;
            this.dgv_parents.AllowUserToDeleteRows = false;
            this.dgv_parents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parents.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_parents.Location = new System.Drawing.Point(60, 484);
            this.dgv_parents.Name = "dgv_parents";
            this.dgv_parents.ReadOnly = true;
            this.dgv_parents.RowTemplate.Height = 27;
            this.dgv_parents.Size = new System.Drawing.Size(684, 166);
            this.dgv_parents.TabIndex = 24;
            this.dgv_parents.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_parents_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.查看ToolStripMenuItem.Text = "查看";
            this.查看ToolStripMenuItem.Click += new System.EventHandler(this.查看ToolStripMenuItem_Click);
            // 
            // btn_parents
            // 
            this.btn_parents.Location = new System.Drawing.Point(60, 660);
            this.btn_parents.Name = "btn_parents";
            this.btn_parents.Size = new System.Drawing.Size(120, 39);
            this.btn_parents.TabIndex = 25;
            this.btn_parents.Text = "查看家长信息";
            this.btn_parents.UseVisualStyleBackColor = true;
            this.btn_parents.Click += new System.EventHandler(this.btn_parents_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(435, 660);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(120, 39);
            this.btn_refresh.TabIndex = 28;
            this.btn_refresh.Text = "表格刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cbo_subject
            // 
            this.cbo_subject.FormattingEnabled = true;
            this.cbo_subject.Location = new System.Drawing.Point(544, 91);
            this.cbo_subject.Name = "cbo_subject";
            this.cbo_subject.Size = new System.Drawing.Size(200, 23);
            this.cbo_subject.TabIndex = 8;
            // 
            // Students_Revise
            // 
            this.AcceptButton = this.btn_check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_quit;
            this.ClientSize = new System.Drawing.Size(800, 755);
            this.Controls.Add(this.cbo_subject);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_parents);
            this.Controls.Add(this.dgv_parents);
            this.Controls.Add(this.cbo_yesno);
            this.Controls.Add(this.txt_imprisonment);
            this.Controls.Add(this.lbl_imprisonment);
            this.Controls.Add(this.lbl_blacklist);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.txt_important_remarks);
            this.Controls.Add(this.lbl_important_remarks);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.cbo_degree);
            this.Controls.Add(this.lbl_degree);
            this.Controls.Add(this.rdo_woman);
            this.Controls.Add(this.rdo_man);
            this.Controls.Add(this.lbl_student_sex);
            this.Controls.Add(this.txt_place);
            this.Controls.Add(this.lbl_place);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.txt_student_num);
            this.Controls.Add(this.lbl_student_num);
            this.Controls.Add(this.txt_student_name);
            this.Controls.Add(this.lbl_student_name);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Students_Revise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Students_Revise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parents)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox txt_important_remarks;
        private System.Windows.Forms.Label lbl_important_remarks;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.ComboBox cbo_degree;
        private System.Windows.Forms.Label lbl_degree;
        private System.Windows.Forms.RadioButton rdo_woman;
        private System.Windows.Forms.RadioButton rdo_man;
        private System.Windows.Forms.Label lbl_student_sex;
        private System.Windows.Forms.TextBox txt_place;
        private System.Windows.Forms.Label lbl_place;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.TextBox txt_student_num;
        private System.Windows.Forms.Label lbl_student_num;
        private System.Windows.Forms.TextBox txt_student_name;
        private System.Windows.Forms.Label lbl_student_name;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_blacklist;
        private System.Windows.Forms.Label lbl_imprisonment;
        private System.Windows.Forms.TextBox txt_imprisonment;
        private System.Windows.Forms.ComboBox cbo_yesno;
        private System.Windows.Forms.DataGridView dgv_parents;
        private System.Windows.Forms.Button btn_parents;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ComboBox cbo_subject;
    }
}