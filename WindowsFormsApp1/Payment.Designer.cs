namespace TJ_Tutors_Management_System
{
    partial class Payment
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
            this.btn_cannel = new System.Windows.Forms.Button();
            this.btn_yes = new System.Windows.Forms.Button();
            this.cbo_principal = new System.Windows.Forms.ComboBox();
            this.lbl_principal = new System.Windows.Forms.Label();
            this.dt_payment_time = new System.Windows.Forms.DateTimePicker();
            this.lbl_payment_time = new System.Windows.Forms.Label();
            this.cbo_state = new System.Windows.Forms.ComboBox();
            this.lbl_state = new System.Windows.Forms.Label();
            this.txt_print_num = new System.Windows.Forms.TextBox();
            this.lbl_print_num = new System.Windows.Forms.Label();
            this.txt_parent_num = new System.Windows.Forms.TextBox();
            this.lbl_parent_num = new System.Windows.Forms.Label();
            this.dt_time = new System.Windows.Forms.DateTimePicker();
            this.lbl_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cannel
            // 
            this.btn_cannel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cannel.Location = new System.Drawing.Point(366, 444);
            this.btn_cannel.Name = "btn_cannel";
            this.btn_cannel.Size = new System.Drawing.Size(120, 40);
            this.btn_cannel.TabIndex = 44;
            this.btn_cannel.Text = "取消";
            this.btn_cannel.UseVisualStyleBackColor = true;
            this.btn_cannel.Click += new System.EventHandler(this.btn_cannel_Click);
            // 
            // btn_yes
            // 
            this.btn_yes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_yes.Location = new System.Drawing.Point(174, 444);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(120, 40);
            this.btn_yes.TabIndex = 43;
            this.btn_yes.Text = "确认";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // cbo_principal
            // 
            this.cbo_principal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_principal.FormattingEnabled = true;
            this.cbo_principal.Location = new System.Drawing.Point(286, 351);
            this.cbo_principal.Name = "cbo_principal";
            this.cbo_principal.Size = new System.Drawing.Size(197, 23);
            this.cbo_principal.TabIndex = 37;
            // 
            // lbl_principal
            // 
            this.lbl_principal.AutoSize = true;
            this.lbl_principal.Location = new System.Drawing.Point(171, 354);
            this.lbl_principal.Name = "lbl_principal";
            this.lbl_principal.Size = new System.Drawing.Size(52, 15);
            this.lbl_principal.TabIndex = 33;
            this.lbl_principal.Text = "经办人";
            // 
            // dt_payment_time
            // 
            this.dt_payment_time.Location = new System.Drawing.Point(286, 222);
            this.dt_payment_time.Name = "dt_payment_time";
            this.dt_payment_time.Size = new System.Drawing.Size(200, 25);
            this.dt_payment_time.TabIndex = 32;
            // 
            // lbl_payment_time
            // 
            this.lbl_payment_time.AutoSize = true;
            this.lbl_payment_time.Location = new System.Drawing.Point(171, 229);
            this.lbl_payment_time.Name = "lbl_payment_time";
            this.lbl_payment_time.Size = new System.Drawing.Size(67, 15);
            this.lbl_payment_time.TabIndex = 31;
            this.lbl_payment_time.Text = "缴费时间";
            // 
            // cbo_state
            // 
            this.cbo_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_state.FormattingEnabled = true;
            this.cbo_state.Items.AddRange(new object[] {
            "无需缴费",
            "待缴",
            "已缴"});
            this.cbo_state.Location = new System.Drawing.Point(286, 158);
            this.cbo_state.Name = "cbo_state";
            this.cbo_state.Size = new System.Drawing.Size(200, 23);
            this.cbo_state.TabIndex = 30;
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(171, 158);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(67, 15);
            this.lbl_state.TabIndex = 29;
            this.lbl_state.Text = "缴费状态";
            // 
            // txt_print_num
            // 
            this.txt_print_num.Location = new System.Drawing.Point(286, 96);
            this.txt_print_num.Name = "txt_print_num";
            this.txt_print_num.ReadOnly = true;
            this.txt_print_num.Size = new System.Drawing.Size(200, 25);
            this.txt_print_num.TabIndex = 26;
            // 
            // lbl_print_num
            // 
            this.lbl_print_num.AutoSize = true;
            this.lbl_print_num.Location = new System.Drawing.Point(171, 99);
            this.lbl_print_num.Name = "lbl_print_num";
            this.lbl_print_num.Size = new System.Drawing.Size(67, 15);
            this.lbl_print_num.TabIndex = 25;
            this.lbl_print_num.Text = "打印编号";
            // 
            // txt_parent_num
            // 
            this.txt_parent_num.Location = new System.Drawing.Point(286, 36);
            this.txt_parent_num.Name = "txt_parent_num";
            this.txt_parent_num.ReadOnly = true;
            this.txt_parent_num.Size = new System.Drawing.Size(200, 25);
            this.txt_parent_num.TabIndex = 24;
            // 
            // lbl_parent_num
            // 
            this.lbl_parent_num.AutoSize = true;
            this.lbl_parent_num.Location = new System.Drawing.Point(171, 39);
            this.lbl_parent_num.Name = "lbl_parent_num";
            this.lbl_parent_num.Size = new System.Drawing.Size(67, 15);
            this.lbl_parent_num.TabIndex = 23;
            this.lbl_parent_num.Text = "家长编号";
            // 
            // dt_time
            // 
            this.dt_time.Location = new System.Drawing.Point(286, 286);
            this.dt_time.Name = "dt_time";
            this.dt_time.Size = new System.Drawing.Size(200, 25);
            this.dt_time.TabIndex = 46;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(171, 293);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(67, 15);
            this.lbl_time.TabIndex = 45;
            this.lbl_time.Text = "经办时间";
            // 
            // Payment
            // 
            this.AcceptButton = this.btn_yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cannel;
            this.ClientSize = new System.Drawing.Size(682, 508);
            this.Controls.Add(this.dt_time);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_cannel);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.cbo_principal);
            this.Controls.Add(this.lbl_principal);
            this.Controls.Add(this.dt_payment_time);
            this.Controls.Add(this.lbl_payment_time);
            this.Controls.Add(this.cbo_state);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.txt_print_num);
            this.Controls.Add(this.lbl_print_num);
            this.Controls.Add(this.txt_parent_num);
            this.Controls.Add(this.lbl_parent_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "缴费界面";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cannel;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.ComboBox cbo_principal;
        private System.Windows.Forms.Label lbl_principal;
        private System.Windows.Forms.DateTimePicker dt_payment_time;
        private System.Windows.Forms.Label lbl_payment_time;
        private System.Windows.Forms.ComboBox cbo_state;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.TextBox txt_print_num;
        private System.Windows.Forms.Label lbl_print_num;
        private System.Windows.Forms.TextBox txt_parent_num;
        private System.Windows.Forms.Label lbl_parent_num;
        private System.Windows.Forms.DateTimePicker dt_time;
        private System.Windows.Forms.Label lbl_time;
    }
}