namespace TJ_Tutors_Management_System
{
    partial class Tutors_management
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
            this.lbl_print_num = new System.Windows.Forms.Label();
            this.txt_printnum = new System.Windows.Forms.TextBox();
            this.lbl_tutors_num = new System.Windows.Forms.Label();
            this.txt_tutors_name = new System.Windows.Forms.TextBox();
            this.lbl_tutors_name = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.cbo_state = new System.Windows.Forms.ComboBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.dt_time = new System.Windows.Forms.DateTimePicker();
            this.lbl_principal = new System.Windows.Forms.Label();
            this.cbo_principal = new System.Windows.Forms.ComboBox();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.lbl_remark = new System.Windows.Forms.Label();
            this.cbo_tutors_state = new System.Windows.Forms.ComboBox();
            this.lbl_tutors_state = new System.Windows.Forms.Label();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_cannel = new System.Windows.Forms.Button();
            this.btn_inquire = new System.Windows.Forms.Button();
            this.cbo_tutors_num = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_print_num
            // 
            this.lbl_print_num.AutoSize = true;
            this.lbl_print_num.Location = new System.Drawing.Point(164, 41);
            this.lbl_print_num.Name = "lbl_print_num";
            this.lbl_print_num.Size = new System.Drawing.Size(67, 15);
            this.lbl_print_num.TabIndex = 0;
            this.lbl_print_num.Text = "打印编号";
            // 
            // txt_printnum
            // 
            this.txt_printnum.Location = new System.Drawing.Point(266, 38);
            this.txt_printnum.Name = "txt_printnum";
            this.txt_printnum.ReadOnly = true;
            this.txt_printnum.Size = new System.Drawing.Size(200, 25);
            this.txt_printnum.TabIndex = 1;
            // 
            // lbl_tutors_num
            // 
            this.lbl_tutors_num.AutoSize = true;
            this.lbl_tutors_num.Location = new System.Drawing.Point(164, 101);
            this.lbl_tutors_num.Name = "lbl_tutors_num";
            this.lbl_tutors_num.Size = new System.Drawing.Size(67, 15);
            this.lbl_tutors_num.TabIndex = 2;
            this.lbl_tutors_num.Text = "教员编号";
            // 
            // txt_tutors_name
            // 
            this.txt_tutors_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_tutors_name.Location = new System.Drawing.Point(266, 164);
            this.txt_tutors_name.Name = "txt_tutors_name";
            this.txt_tutors_name.Size = new System.Drawing.Size(200, 25);
            this.txt_tutors_name.TabIndex = 5;
            // 
            // lbl_tutors_name
            // 
            this.lbl_tutors_name.AutoSize = true;
            this.lbl_tutors_name.Location = new System.Drawing.Point(164, 167);
            this.lbl_tutors_name.Name = "lbl_tutors_name";
            this.lbl_tutors_name.Size = new System.Drawing.Size(67, 15);
            this.lbl_tutors_name.TabIndex = 4;
            this.lbl_tutors_name.Text = "教员姓名";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(164, 226);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(67, 15);
            this.lbl_state.TabIndex = 6;
            this.lbl_state.Text = "进行状态";
            // 
            // cbo_state
            // 
            this.cbo_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_state.FormattingEnabled = true;
            this.cbo_state.Items.AddRange(new object[] {
            "接入",
            "已接",
            "待接",
            "换人",
            "不请",
            "重请"});
            this.cbo_state.Location = new System.Drawing.Point(266, 226);
            this.cbo_state.Name = "cbo_state";
            this.cbo_state.Size = new System.Drawing.Size(200, 23);
            this.cbo_state.TabIndex = 7;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(164, 299);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(67, 15);
            this.lbl_time.TabIndex = 8;
            this.lbl_time.Text = "经办时间";
            // 
            // dt_time
            // 
            this.dt_time.Location = new System.Drawing.Point(266, 292);
            this.dt_time.Name = "dt_time";
            this.dt_time.Size = new System.Drawing.Size(200, 25);
            this.dt_time.TabIndex = 9;
            this.dt_time.ValueChanged += new System.EventHandler(this.dt_time_ValueChanged);
            // 
            // lbl_principal
            // 
            this.lbl_principal.AutoSize = true;
            this.lbl_principal.Location = new System.Drawing.Point(164, 357);
            this.lbl_principal.Name = "lbl_principal";
            this.lbl_principal.Size = new System.Drawing.Size(52, 15);
            this.lbl_principal.TabIndex = 10;
            this.lbl_principal.Text = "经办人";
            // 
            // cbo_principal
            // 
            this.cbo_principal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_principal.FormattingEnabled = true;
            this.cbo_principal.Location = new System.Drawing.Point(269, 354);
            this.cbo_principal.Name = "cbo_principal";
            this.cbo_principal.Size = new System.Drawing.Size(197, 23);
            this.cbo_principal.TabIndex = 15;
            this.cbo_principal.SelectedIndexChanged += new System.EventHandler(this.cbo_principal_SelectedIndexChanged);
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(269, 410);
            this.txt_remark.Multiline = true;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_remark.Size = new System.Drawing.Size(390, 85);
            this.txt_remark.TabIndex = 17;
            // 
            // lbl_remark
            // 
            this.lbl_remark.AutoSize = true;
            this.lbl_remark.Location = new System.Drawing.Point(164, 413);
            this.lbl_remark.Name = "lbl_remark";
            this.lbl_remark.Size = new System.Drawing.Size(37, 15);
            this.lbl_remark.TabIndex = 16;
            this.lbl_remark.Text = "备注";
            // 
            // cbo_tutors_state
            // 
            this.cbo_tutors_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tutors_state.FormattingEnabled = true;
            this.cbo_tutors_state.Items.AddRange(new object[] {
            "接入",
            "已接",
            "待接",
            "换人",
            "不请",
            "重请"});
            this.cbo_tutors_state.Location = new System.Drawing.Point(269, 517);
            this.cbo_tutors_state.Name = "cbo_tutors_state";
            this.cbo_tutors_state.Size = new System.Drawing.Size(197, 23);
            this.cbo_tutors_state.TabIndex = 19;
            // 
            // lbl_tutors_state
            // 
            this.lbl_tutors_state.AutoSize = true;
            this.lbl_tutors_state.Location = new System.Drawing.Point(164, 520);
            this.lbl_tutors_state.Name = "lbl_tutors_state";
            this.lbl_tutors_state.Size = new System.Drawing.Size(67, 15);
            this.lbl_tutors_state.TabIndex = 18;
            this.lbl_tutors_state.Text = "家教状态";
            // 
            // btn_yes
            // 
            this.btn_yes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_yes.Location = new System.Drawing.Point(167, 613);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(120, 40);
            this.btn_yes.TabIndex = 21;
            this.btn_yes.Text = "确认";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_cannel
            // 
            this.btn_cannel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cannel.Location = new System.Drawing.Point(359, 613);
            this.btn_cannel.Name = "btn_cannel";
            this.btn_cannel.Size = new System.Drawing.Size(120, 40);
            this.btn_cannel.TabIndex = 22;
            this.btn_cannel.Text = "取消";
            this.btn_cannel.UseVisualStyleBackColor = true;
            this.btn_cannel.Click += new System.EventHandler(this.btn_cannel_Click);
            // 
            // btn_inquire
            // 
            this.btn_inquire.Location = new System.Drawing.Point(502, 88);
            this.btn_inquire.Name = "btn_inquire";
            this.btn_inquire.Size = new System.Drawing.Size(120, 40);
            this.btn_inquire.TabIndex = 23;
            this.btn_inquire.Text = "教员查找";
            this.btn_inquire.UseVisualStyleBackColor = true;
            this.btn_inquire.Click += new System.EventHandler(this.btn_inquire_Click);
            // 
            // cbo_tutors_num
            // 
            this.cbo_tutors_num.FormattingEnabled = true;
            this.cbo_tutors_num.Location = new System.Drawing.Point(266, 98);
            this.cbo_tutors_num.Name = "cbo_tutors_num";
            this.cbo_tutors_num.Size = new System.Drawing.Size(200, 23);
            this.cbo_tutors_num.TabIndex = 24;
            this.cbo_tutors_num.SelectedIndexChanged += new System.EventHandler(this.cbo_tutors_num_SelectedIndexChanged);
            this.cbo_tutors_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_tutors_num_KeyPress);
            // 
            // Tutors_management
            // 
            this.AcceptButton = this.btn_yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cannel;
            this.ClientSize = new System.Drawing.Size(682, 719);
            this.Controls.Add(this.cbo_tutors_num);
            this.Controls.Add(this.btn_inquire);
            this.Controls.Add(this.btn_cannel);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.cbo_tutors_state);
            this.Controls.Add(this.lbl_tutors_state);
            this.Controls.Add(this.txt_remark);
            this.Controls.Add(this.lbl_remark);
            this.Controls.Add(this.cbo_principal);
            this.Controls.Add(this.lbl_principal);
            this.Controls.Add(this.dt_time);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.cbo_state);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.txt_tutors_name);
            this.Controls.Add(this.lbl_tutors_name);
            this.Controls.Add(this.lbl_tutors_num);
            this.Controls.Add(this.txt_printnum);
            this.Controls.Add(this.lbl_print_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Tutors_management";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "家教业务办理";
            this.Load += new System.EventHandler(this.Tutors_management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_print_num;
        private System.Windows.Forms.TextBox txt_printnum;
        private System.Windows.Forms.Label lbl_tutors_num;
        private System.Windows.Forms.TextBox txt_tutors_name;
        private System.Windows.Forms.Label lbl_tutors_name;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.ComboBox cbo_state;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.DateTimePicker dt_time;
        private System.Windows.Forms.Label lbl_principal;
        private System.Windows.Forms.ComboBox cbo_principal;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label lbl_remark;
        private System.Windows.Forms.ComboBox cbo_tutors_state;
        private System.Windows.Forms.Label lbl_tutors_state;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_cannel;
        private System.Windows.Forms.Button btn_inquire;
        private System.Windows.Forms.ComboBox cbo_tutors_num;
    }
}