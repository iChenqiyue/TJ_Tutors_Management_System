namespace TJ_Tutors_Management_System
{
    partial class Tutors_Add
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
            this.lbl_parent_num = new System.Windows.Forms.Label();
            this.txt_parent_num = new System.Windows.Forms.TextBox();
            this.txt_print_num = new System.Windows.Forms.TextBox();
            this.lbl_print_num = new System.Windows.Forms.Label();
            this.lbl_reception = new System.Windows.Forms.Label();
            this.cbo_reception = new System.Windows.Forms.ComboBox();
            this.lbl_recepiton_time = new System.Windows.Forms.Label();
            this.dt_recepiton_time = new System.Windows.Forms.DateTimePicker();
            this.lbl_parent_name = new System.Windows.Forms.Label();
            this.txt_parent_name = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_sadd = new System.Windows.Forms.TextBox();
            this.lbl_sadd = new System.Windows.Forms.Label();
            this.txt_tutor_price = new System.Windows.Forms.TextBox();
            this.lbl_tutor_price = new System.Windows.Forms.Label();
            this.txt_tutor_time = new System.Windows.Forms.TextBox();
            this.lbl_tutor_time = new System.Windows.Forms.Label();
            this.txt_dadd = new System.Windows.Forms.TextBox();
            this.lbl_dadd = new System.Windows.Forms.Label();
            this.txt_grade_subject = new System.Windows.Forms.TextBox();
            this.lbl_grade_subject = new System.Windows.Forms.Label();
            this.lbl_student_sex = new System.Windows.Forms.Label();
            this.rdo_man = new System.Windows.Forms.RadioButton();
            this.rdo_woman = new System.Windows.Forms.RadioButton();
            this.grp_tutor_request = new System.Windows.Forms.GroupBox();
            this.txt_other_requests = new System.Windows.Forms.TextBox();
            this.lbl_other_requests = new System.Windows.Forms.Label();
            this.cbo_sex = new System.Windows.Forms.ComboBox();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.txt_place = new System.Windows.Forms.TextBox();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_grade = new System.Windows.Forms.Label();
            this.lbl_place = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_tutor_request = new System.Windows.Forms.Label();
            this.lbl_tutor_state = new System.Windows.Forms.Label();
            this.lbl_important_remarks = new System.Windows.Forms.Label();
            this.cbo_tutor_state = new System.Windows.Forms.ComboBox();
            this.txt_important_remarks = new System.Windows.Forms.TextBox();
            this.lbl_payment_state = new System.Windows.Forms.Label();
            this.cbo_payment_state = new System.Windows.Forms.ComboBox();
            this.lbl_payment_time = new System.Windows.Forms.Label();
            this.dt_payment_time = new System.Windows.Forms.DateTimePicker();
            this.btnyes = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.grp_tutor_request.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_parent_num
            // 
            this.lbl_parent_num.AutoSize = true;
            this.lbl_parent_num.Location = new System.Drawing.Point(51, 25);
            this.lbl_parent_num.Name = "lbl_parent_num";
            this.lbl_parent_num.Size = new System.Drawing.Size(67, 15);
            this.lbl_parent_num.TabIndex = 0;
            this.lbl_parent_num.Text = "家长编号";
            this.lbl_parent_num.Click += new System.EventHandler(this.家教编号_Click);
            // 
            // txt_parent_num
            // 
            this.txt_parent_num.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_parent_num.Location = new System.Drawing.Point(174, 22);
            this.txt_parent_num.Name = "txt_parent_num";
            this.txt_parent_num.Size = new System.Drawing.Size(200, 25);
            this.txt_parent_num.TabIndex = 1;
            // 
            // txt_print_num
            // 
            this.txt_print_num.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_print_num.Location = new System.Drawing.Point(538, 22);
            this.txt_print_num.Name = "txt_print_num";
            this.txt_print_num.Size = new System.Drawing.Size(200, 25);
            this.txt_print_num.TabIndex = 3;
            // 
            // lbl_print_num
            // 
            this.lbl_print_num.AutoSize = true;
            this.lbl_print_num.Location = new System.Drawing.Point(415, 25);
            this.lbl_print_num.Name = "lbl_print_num";
            this.lbl_print_num.Size = new System.Drawing.Size(67, 15);
            this.lbl_print_num.TabIndex = 2;
            this.lbl_print_num.Text = "打印编号";
            // 
            // lbl_reception
            // 
            this.lbl_reception.AutoSize = true;
            this.lbl_reception.Location = new System.Drawing.Point(51, 74);
            this.lbl_reception.Name = "lbl_reception";
            this.lbl_reception.Size = new System.Drawing.Size(52, 15);
            this.lbl_reception.TabIndex = 4;
            this.lbl_reception.Text = "接待人";
            // 
            // cbo_reception
            // 
            this.cbo_reception.DisplayMember = "接待人";
            this.cbo_reception.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_reception.FormattingEnabled = true;
            this.cbo_reception.Location = new System.Drawing.Point(174, 71);
            this.cbo_reception.Name = "cbo_reception";
            this.cbo_reception.Size = new System.Drawing.Size(200, 23);
            this.cbo_reception.TabIndex = 5;
            this.cbo_reception.ValueMember = "接待人";
            this.cbo_reception.SelectedIndexChanged += new System.EventHandler(this.cbo_reception_SelectedIndexChanged);
            // 
            // lbl_recepiton_time
            // 
            this.lbl_recepiton_time.AutoSize = true;
            this.lbl_recepiton_time.Location = new System.Drawing.Point(415, 74);
            this.lbl_recepiton_time.Name = "lbl_recepiton_time";
            this.lbl_recepiton_time.Size = new System.Drawing.Size(67, 15);
            this.lbl_recepiton_time.TabIndex = 6;
            this.lbl_recepiton_time.Text = "接入时间";
            // 
            // dt_recepiton_time
            // 
            this.dt_recepiton_time.CustomFormat = "";
            this.dt_recepiton_time.Location = new System.Drawing.Point(538, 67);
            this.dt_recepiton_time.Name = "dt_recepiton_time";
            this.dt_recepiton_time.Size = new System.Drawing.Size(200, 25);
            this.dt_recepiton_time.TabIndex = 7;
            // 
            // lbl_parent_name
            // 
            this.lbl_parent_name.AutoSize = true;
            this.lbl_parent_name.Location = new System.Drawing.Point(51, 122);
            this.lbl_parent_name.Name = "lbl_parent_name";
            this.lbl_parent_name.Size = new System.Drawing.Size(67, 15);
            this.lbl_parent_name.TabIndex = 8;
            this.lbl_parent_name.Text = "家长称呼";
            // 
            // txt_parent_name
            // 
            this.txt_parent_name.Location = new System.Drawing.Point(174, 119);
            this.txt_parent_name.Name = "txt_parent_name";
            this.txt_parent_name.Size = new System.Drawing.Size(200, 25);
            this.txt_parent_name.TabIndex = 9;
            // 
            // txt_phone
            // 
            this.txt_phone.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_phone.Location = new System.Drawing.Point(538, 119);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(200, 25);
            this.txt_phone.TabIndex = 11;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(415, 122);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(67, 15);
            this.lbl_phone.TabIndex = 10;
            this.lbl_phone.Text = "联系方式";
            // 
            // txt_sadd
            // 
            this.txt_sadd.Location = new System.Drawing.Point(174, 165);
            this.txt_sadd.Name = "txt_sadd";
            this.txt_sadd.Size = new System.Drawing.Size(200, 25);
            this.txt_sadd.TabIndex = 13;
            // 
            // lbl_sadd
            // 
            this.lbl_sadd.AutoSize = true;
            this.lbl_sadd.Location = new System.Drawing.Point(51, 168);
            this.lbl_sadd.Name = "lbl_sadd";
            this.lbl_sadd.Size = new System.Drawing.Size(127, 15);
            this.lbl_sadd.TabIndex = 12;
            this.lbl_sadd.Text = "家教地址（简单）";
            // 
            // txt_tutor_price
            // 
            this.txt_tutor_price.Location = new System.Drawing.Point(174, 264);
            this.txt_tutor_price.Name = "txt_tutor_price";
            this.txt_tutor_price.Size = new System.Drawing.Size(200, 25);
            this.txt_tutor_price.TabIndex = 22;
            // 
            // lbl_tutor_price
            // 
            this.lbl_tutor_price.AutoSize = true;
            this.lbl_tutor_price.Location = new System.Drawing.Point(51, 267);
            this.lbl_tutor_price.Name = "lbl_tutor_price";
            this.lbl_tutor_price.Size = new System.Drawing.Size(67, 15);
            this.lbl_tutor_price.TabIndex = 21;
            this.lbl_tutor_price.Text = "家教价格";
            // 
            // txt_tutor_time
            // 
            this.txt_tutor_time.Location = new System.Drawing.Point(538, 241);
            this.txt_tutor_time.Multiline = true;
            this.txt_tutor_time.Name = "txt_tutor_time";
            this.txt_tutor_time.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_tutor_time.Size = new System.Drawing.Size(200, 58);
            this.txt_tutor_time.TabIndex = 24;
            // 
            // lbl_tutor_time
            // 
            this.lbl_tutor_time.AutoSize = true;
            this.lbl_tutor_time.Location = new System.Drawing.Point(415, 267);
            this.lbl_tutor_time.Name = "lbl_tutor_time";
            this.lbl_tutor_time.Size = new System.Drawing.Size(67, 15);
            this.lbl_tutor_time.TabIndex = 23;
            this.lbl_tutor_time.Text = "家教时间";
            // 
            // txt_dadd
            // 
            this.txt_dadd.Location = new System.Drawing.Point(538, 152);
            this.txt_dadd.Multiline = true;
            this.txt_dadd.Name = "txt_dadd";
            this.txt_dadd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_dadd.Size = new System.Drawing.Size(200, 58);
            this.txt_dadd.TabIndex = 15;
            // 
            // lbl_dadd
            // 
            this.lbl_dadd.AutoSize = true;
            this.lbl_dadd.Location = new System.Drawing.Point(415, 168);
            this.lbl_dadd.Name = "lbl_dadd";
            this.lbl_dadd.Size = new System.Drawing.Size(127, 15);
            this.lbl_dadd.TabIndex = 14;
            this.lbl_dadd.Text = "家教地址（详细）";
            // 
            // txt_grade_subject
            // 
            this.txt_grade_subject.Location = new System.Drawing.Point(174, 213);
            this.txt_grade_subject.Name = "txt_grade_subject";
            this.txt_grade_subject.Size = new System.Drawing.Size(200, 25);
            this.txt_grade_subject.TabIndex = 17;
            // 
            // lbl_grade_subject
            // 
            this.lbl_grade_subject.AutoSize = true;
            this.lbl_grade_subject.Location = new System.Drawing.Point(51, 216);
            this.lbl_grade_subject.Name = "lbl_grade_subject";
            this.lbl_grade_subject.Size = new System.Drawing.Size(67, 15);
            this.lbl_grade_subject.TabIndex = 16;
            this.lbl_grade_subject.Text = "年级科目";
            // 
            // lbl_student_sex
            // 
            this.lbl_student_sex.AutoSize = true;
            this.lbl_student_sex.Location = new System.Drawing.Point(415, 216);
            this.lbl_student_sex.Name = "lbl_student_sex";
            this.lbl_student_sex.Size = new System.Drawing.Size(67, 15);
            this.lbl_student_sex.TabIndex = 18;
            this.lbl_student_sex.Text = "学员性别";
            // 
            // rdo_man
            // 
            this.rdo_man.AutoSize = true;
            this.rdo_man.Location = new System.Drawing.Point(542, 216);
            this.rdo_man.Name = "rdo_man";
            this.rdo_man.Size = new System.Drawing.Size(43, 19);
            this.rdo_man.TabIndex = 19;
            this.rdo_man.TabStop = true;
            this.rdo_man.Text = "男";
            this.rdo_man.UseVisualStyleBackColor = true;
            // 
            // rdo_woman
            // 
            this.rdo_woman.AutoSize = true;
            this.rdo_woman.Location = new System.Drawing.Point(638, 214);
            this.rdo_woman.Name = "rdo_woman";
            this.rdo_woman.Size = new System.Drawing.Size(43, 19);
            this.rdo_woman.TabIndex = 20;
            this.rdo_woman.TabStop = true;
            this.rdo_woman.Text = "女";
            this.rdo_woman.UseVisualStyleBackColor = true;
            // 
            // grp_tutor_request
            // 
            this.grp_tutor_request.Controls.Add(this.txt_other_requests);
            this.grp_tutor_request.Controls.Add(this.lbl_other_requests);
            this.grp_tutor_request.Controls.Add(this.cbo_sex);
            this.grp_tutor_request.Controls.Add(this.txt_grade);
            this.grp_tutor_request.Controls.Add(this.txt_subject);
            this.grp_tutor_request.Controls.Add(this.txt_place);
            this.grp_tutor_request.Controls.Add(this.lbl_subject);
            this.grp_tutor_request.Controls.Add(this.lbl_grade);
            this.grp_tutor_request.Controls.Add(this.lbl_place);
            this.grp_tutor_request.Controls.Add(this.lbl_sex);
            this.grp_tutor_request.Controls.Add(this.lbl_tutor_request);
            this.grp_tutor_request.Location = new System.Drawing.Point(54, 313);
            this.grp_tutor_request.Name = "grp_tutor_request";
            this.grp_tutor_request.Size = new System.Drawing.Size(684, 263);
            this.grp_tutor_request.TabIndex = 25;
            this.grp_tutor_request.TabStop = false;
            this.grp_tutor_request.Text = "家教要求";
            // 
            // txt_other_requests
            // 
            this.txt_other_requests.Location = new System.Drawing.Point(141, 174);
            this.txt_other_requests.Multiline = true;
            this.txt_other_requests.Name = "txt_other_requests";
            this.txt_other_requests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_other_requests.Size = new System.Drawing.Size(486, 68);
            this.txt_other_requests.TabIndex = 36;
            // 
            // lbl_other_requests
            // 
            this.lbl_other_requests.AutoSize = true;
            this.lbl_other_requests.Location = new System.Drawing.Point(34, 177);
            this.lbl_other_requests.Name = "lbl_other_requests";
            this.lbl_other_requests.Size = new System.Drawing.Size(67, 15);
            this.lbl_other_requests.TabIndex = 35;
            this.lbl_other_requests.Text = "其他要求";
            // 
            // cbo_sex
            // 
            this.cbo_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sex.FormattingEnabled = true;
            this.cbo_sex.Items.AddRange(new object[] {
            "",
            "一定女生",
            "一定男生",
            "最好女生",
            "最好男生"});
            this.cbo_sex.Location = new System.Drawing.Point(210, 69);
            this.cbo_sex.Name = "cbo_sex";
            this.cbo_sex.Size = new System.Drawing.Size(143, 23);
            this.cbo_sex.TabIndex = 28;
            // 
            // txt_grade
            // 
            this.txt_grade.Location = new System.Drawing.Point(210, 128);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(143, 25);
            this.txt_grade.TabIndex = 32;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(484, 128);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(143, 25);
            this.txt_subject.TabIndex = 34;
            // 
            // txt_place
            // 
            this.txt_place.Location = new System.Drawing.Point(484, 69);
            this.txt_place.Name = "txt_place";
            this.txt_place.Size = new System.Drawing.Size(143, 25);
            this.txt_place.TabIndex = 30;
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(409, 131);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(37, 15);
            this.lbl_subject.TabIndex = 33;
            this.lbl_subject.Text = "专业";
            // 
            // lbl_grade
            // 
            this.lbl_grade.AutoSize = true;
            this.lbl_grade.Location = new System.Drawing.Point(138, 131);
            this.lbl_grade.Name = "lbl_grade";
            this.lbl_grade.Size = new System.Drawing.Size(37, 15);
            this.lbl_grade.TabIndex = 31;
            this.lbl_grade.Text = "年级";
            // 
            // lbl_place
            // 
            this.lbl_place.AutoSize = true;
            this.lbl_place.Location = new System.Drawing.Point(409, 72);
            this.lbl_place.Name = "lbl_place";
            this.lbl_place.Size = new System.Drawing.Size(37, 15);
            this.lbl_place.TabIndex = 29;
            this.lbl_place.Text = "地域";
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(138, 72);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(37, 15);
            this.lbl_sex.TabIndex = 27;
            this.lbl_sex.Text = "性别";
            // 
            // lbl_tutor_request
            // 
            this.lbl_tutor_request.AutoSize = true;
            this.lbl_tutor_request.Location = new System.Drawing.Point(34, 56);
            this.lbl_tutor_request.Name = "lbl_tutor_request";
            this.lbl_tutor_request.Size = new System.Drawing.Size(67, 15);
            this.lbl_tutor_request.TabIndex = 26;
            this.lbl_tutor_request.Text = "教员要求";
            // 
            // lbl_tutor_state
            // 
            this.lbl_tutor_state.AutoSize = true;
            this.lbl_tutor_state.Location = new System.Drawing.Point(51, 592);
            this.lbl_tutor_state.Name = "lbl_tutor_state";
            this.lbl_tutor_state.Size = new System.Drawing.Size(67, 15);
            this.lbl_tutor_state.TabIndex = 37;
            this.lbl_tutor_state.Text = "家教状态";
            // 
            // lbl_important_remarks
            // 
            this.lbl_important_remarks.AutoSize = true;
            this.lbl_important_remarks.Location = new System.Drawing.Point(51, 635);
            this.lbl_important_remarks.Name = "lbl_important_remarks";
            this.lbl_important_remarks.Size = new System.Drawing.Size(67, 15);
            this.lbl_important_remarks.TabIndex = 39;
            this.lbl_important_remarks.Text = "重要备注";
            this.lbl_important_remarks.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbo_tutor_state
            // 
            this.cbo_tutor_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tutor_state.FormattingEnabled = true;
            this.cbo_tutor_state.Items.AddRange(new object[] {
            "接入",
            "已接",
            "待接",
            "换人",
            "不请",
            "重请"});
            this.cbo_tutor_state.Location = new System.Drawing.Point(174, 589);
            this.cbo_tutor_state.Name = "cbo_tutor_state";
            this.cbo_tutor_state.Size = new System.Drawing.Size(187, 23);
            this.cbo_tutor_state.TabIndex = 38;
            // 
            // txt_important_remarks
            // 
            this.txt_important_remarks.Location = new System.Drawing.Point(174, 632);
            this.txt_important_remarks.Multiline = true;
            this.txt_important_remarks.Name = "txt_important_remarks";
            this.txt_important_remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_important_remarks.Size = new System.Drawing.Size(564, 107);
            this.txt_important_remarks.TabIndex = 40;
            // 
            // lbl_payment_state
            // 
            this.lbl_payment_state.AutoSize = true;
            this.lbl_payment_state.Location = new System.Drawing.Point(51, 758);
            this.lbl_payment_state.Name = "lbl_payment_state";
            this.lbl_payment_state.Size = new System.Drawing.Size(67, 15);
            this.lbl_payment_state.TabIndex = 41;
            this.lbl_payment_state.Text = "缴费状态";
            // 
            // cbo_payment_state
            // 
            this.cbo_payment_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_payment_state.FormattingEnabled = true;
            this.cbo_payment_state.Items.AddRange(new object[] {
            "免管理费",
            "无需缴纳",
            "待缴",
            "已缴"});
            this.cbo_payment_state.Location = new System.Drawing.Point(174, 758);
            this.cbo_payment_state.Name = "cbo_payment_state";
            this.cbo_payment_state.Size = new System.Drawing.Size(187, 23);
            this.cbo_payment_state.TabIndex = 42;
            this.cbo_payment_state.SelectedIndexChanged += new System.EventHandler(this.cbo_payment_state_SelectedIndexChanged);
            // 
            // lbl_payment_time
            // 
            this.lbl_payment_time.AutoSize = true;
            this.lbl_payment_time.Location = new System.Drawing.Point(415, 761);
            this.lbl_payment_time.Name = "lbl_payment_time";
            this.lbl_payment_time.Size = new System.Drawing.Size(67, 15);
            this.lbl_payment_time.TabIndex = 43;
            this.lbl_payment_time.Text = "缴费时间";
            // 
            // dt_payment_time
            // 
            this.dt_payment_time.Location = new System.Drawing.Point(538, 754);
            this.dt_payment_time.Name = "dt_payment_time";
            this.dt_payment_time.Size = new System.Drawing.Size(200, 25);
            this.dt_payment_time.TabIndex = 44;
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(378, 806);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(141, 39);
            this.btnyes.TabIndex = 45;
            this.btnyes.Text = "确认新增家教";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // btnclose
            // 
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Location = new System.Drawing.Point(597, 806);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(141, 39);
            this.btnclose.TabIndex = 46;
            this.btnclose.Text = "取消/退出";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Tutors_Add
            // 
            this.AcceptButton = this.btnyes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(782, 917);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnyes);
            this.Controls.Add(this.dt_payment_time);
            this.Controls.Add(this.lbl_payment_time);
            this.Controls.Add(this.cbo_payment_state);
            this.Controls.Add(this.lbl_payment_state);
            this.Controls.Add(this.txt_important_remarks);
            this.Controls.Add(this.cbo_tutor_state);
            this.Controls.Add(this.lbl_important_remarks);
            this.Controls.Add(this.lbl_tutor_state);
            this.Controls.Add(this.grp_tutor_request);
            this.Controls.Add(this.rdo_woman);
            this.Controls.Add(this.rdo_man);
            this.Controls.Add(this.lbl_student_sex);
            this.Controls.Add(this.txt_grade_subject);
            this.Controls.Add(this.lbl_grade_subject);
            this.Controls.Add(this.txt_dadd);
            this.Controls.Add(this.lbl_dadd);
            this.Controls.Add(this.txt_tutor_time);
            this.Controls.Add(this.lbl_tutor_time);
            this.Controls.Add(this.txt_tutor_price);
            this.Controls.Add(this.lbl_tutor_price);
            this.Controls.Add(this.txt_sadd);
            this.Controls.Add(this.lbl_sadd);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.txt_parent_name);
            this.Controls.Add(this.lbl_parent_name);
            this.Controls.Add(this.dt_recepiton_time);
            this.Controls.Add(this.lbl_recepiton_time);
            this.Controls.Add(this.cbo_reception);
            this.Controls.Add(this.lbl_reception);
            this.Controls.Add(this.txt_print_num);
            this.Controls.Add(this.lbl_print_num);
            this.Controls.Add(this.txt_parent_num);
            this.Controls.Add(this.lbl_parent_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Tutors_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增家教信息";
            this.Load += new System.EventHandler(this.Tutors_Add_Load);
            this.grp_tutor_request.ResumeLayout(false);
            this.grp_tutor_request.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_parent_num;
        private System.Windows.Forms.TextBox txt_parent_num;
        private System.Windows.Forms.TextBox txt_print_num;
        private System.Windows.Forms.Label lbl_print_num;
        private System.Windows.Forms.Label lbl_reception;
        private System.Windows.Forms.ComboBox cbo_reception;
        private System.Windows.Forms.Label lbl_recepiton_time;
        private System.Windows.Forms.DateTimePicker dt_recepiton_time;
        private System.Windows.Forms.Label lbl_parent_name;
        private System.Windows.Forms.TextBox txt_parent_name;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_sadd;
        private System.Windows.Forms.Label lbl_sadd;
        private System.Windows.Forms.TextBox txt_tutor_price;
        private System.Windows.Forms.Label lbl_tutor_price;
        private System.Windows.Forms.TextBox txt_tutor_time;
        private System.Windows.Forms.Label lbl_tutor_time;
        private System.Windows.Forms.TextBox txt_dadd;
        private System.Windows.Forms.Label lbl_dadd;
        private System.Windows.Forms.TextBox txt_grade_subject;
        private System.Windows.Forms.Label lbl_grade_subject;
        private System.Windows.Forms.Label lbl_student_sex;
        private System.Windows.Forms.RadioButton rdo_man;
        private System.Windows.Forms.RadioButton rdo_woman;
        private System.Windows.Forms.GroupBox grp_tutor_request;
        private System.Windows.Forms.Label lbl_tutor_request;
        private System.Windows.Forms.TextBox txt_other_requests;
        private System.Windows.Forms.Label lbl_other_requests;
        private System.Windows.Forms.ComboBox cbo_sex;
        private System.Windows.Forms.TextBox txt_grade;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.TextBox txt_place;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_grade;
        private System.Windows.Forms.Label lbl_place;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_tutor_state;
        private System.Windows.Forms.Label lbl_important_remarks;
        private System.Windows.Forms.ComboBox cbo_tutor_state;
        private System.Windows.Forms.TextBox txt_important_remarks;
        private System.Windows.Forms.Label lbl_payment_state;
        private System.Windows.Forms.ComboBox cbo_payment_state;
        private System.Windows.Forms.Label lbl_payment_time;
        private System.Windows.Forms.DateTimePicker dt_payment_time;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Button btnclose;
    }
}