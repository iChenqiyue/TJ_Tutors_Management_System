namespace TJ_Tutors_Management_System
{
    partial class Today_Form
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
            this.dgv_form = new System.Windows.Forms.DataGridView();
            this.btn_cannel = new System.Windows.Forms.Button();
            this.btn_form = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_form)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_form
            // 
            this.dgv_form.AllowUserToAddRows = false;
            this.dgv_form.AllowUserToDeleteRows = false;
            this.dgv_form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_form.Location = new System.Drawing.Point(12, 12);
            this.dgv_form.Name = "dgv_form";
            this.dgv_form.ReadOnly = true;
            this.dgv_form.RowTemplate.Height = 27;
            this.dgv_form.Size = new System.Drawing.Size(1204, 610);
            this.dgv_form.TabIndex = 0;
            // 
            // btn_cannel
            // 
            this.btn_cannel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cannel.Location = new System.Drawing.Point(899, 648);
            this.btn_cannel.Name = "btn_cannel";
            this.btn_cannel.Size = new System.Drawing.Size(137, 39);
            this.btn_cannel.TabIndex = 9;
            this.btn_cannel.Text = "取消/退出";
            this.btn_cannel.UseVisualStyleBackColor = true;
            this.btn_cannel.Click += new System.EventHandler(this.btn_cannel_Click);
            // 
            // btn_form
            // 
            this.btn_form.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_form.Location = new System.Drawing.Point(543, 648);
            this.btn_form.Name = "btn_form";
            this.btn_form.Size = new System.Drawing.Size(137, 39);
            this.btn_form.TabIndex = 8;
            this.btn_form.Text = "导出表格";
            this.btn_form.UseVisualStyleBackColor = true;
            this.btn_form.Click += new System.EventHandler(this.btn_form_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_refresh.Location = new System.Drawing.Point(170, 648);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(137, 39);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Today_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btn_cannel;
            this.ClientSize = new System.Drawing.Size(1228, 721);
            this.Controls.Add(this.btn_cannel);
            this.Controls.Add(this.btn_form);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dgv_form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Today_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "当日表格";
            this.Load += new System.EventHandler(this.Today_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_form)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_form;
    /*    private System.Windows.Forms.DataGridViewTextBoxColumn 打印编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年级科目DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学员性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家教价格DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家教时间DataGridViewTextBoxColumn;*/
        private System.Windows.Forms.Button btn_cannel;
        private System.Windows.Forms.Button btn_form;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}