namespace TJ_Tutors_Management_System
{
    partial class backup
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
            this.btn_open1 = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textPaht = new System.Windows.Forms.TextBox();
            this.btn_open2 = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPaht = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_out = new System.Windows.Forms.Button();
            this.lbl_out = new System.Windows.Forms.Label();
            this.cbo_out = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_open1
            // 
            this.btn_open1.Location = new System.Drawing.Point(519, 34);
            this.btn_open1.Name = "btn_open1";
            this.btn_open1.Size = new System.Drawing.Size(103, 36);
            this.btn_open1.TabIndex = 0;
            this.btn_open1.Text = "打开";
            this.btn_open1.UseVisualStyleBackColor = true;
            this.btn_open1.Click += new System.EventHandler(this.btn_open1_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(288, 146);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(103, 36);
            this.btn_backup.TabIndex = 1;
            this.btn_backup.Text = "备份";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(288, 97);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(103, 36);
            this.btn_return.TabIndex = 2;
            this.btn_return.Text = "还原";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(194, 42);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(274, 25);
            this.txtPath.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(194, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 25);
            this.txtName.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textPaht
            // 
            this.textPaht.Location = new System.Drawing.Point(194, 49);
            this.textPaht.Name = "textPaht";
            this.textPaht.Size = new System.Drawing.Size(274, 25);
            this.textPaht.TabIndex = 5;
            // 
            // btn_open2
            // 
            this.btn_open2.Location = new System.Drawing.Point(519, 41);
            this.btn_open2.Name = "btn_open2";
            this.btn_open2.Size = new System.Drawing.Size(103, 36);
            this.btn_open2.TabIndex = 6;
            this.btn_open2.Text = "打开";
            this.btn_open2.UseVisualStyleBackColor = true;
            this.btn_open2.Click += new System.EventHandler(this.btn_open2_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(103, 45);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(67, 15);
            this.lblPath.TabIndex = 7;
            this.lblPath.Text = "备份路径";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(91, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 15);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "备份文件名称";
            // 
            // lblPaht
            // 
            this.lblPaht.AutoSize = true;
            this.lblPaht.Location = new System.Drawing.Point(91, 52);
            this.lblPaht.Name = "lblPaht";
            this.lblPaht.Size = new System.Drawing.Size(97, 15);
            this.lblPaht.TabIndex = 9;
            this.lblPaht.Text = "还原文件路径";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.btn_open1);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Controls.Add(this.btn_backup);
            this.groupBox1.Location = new System.Drawing.Point(61, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 207);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "备份";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textPaht);
            this.groupBox2.Controls.Add(this.btn_return);
            this.groupBox2.Controls.Add(this.lblPaht);
            this.groupBox2.Controls.Add(this.btn_open2);
            this.groupBox2.Location = new System.Drawing.Point(61, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 163);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "还原";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_out);
            this.groupBox3.Controls.Add(this.lbl_out);
            this.groupBox3.Controls.Add(this.cbo_out);
            this.groupBox3.Location = new System.Drawing.Point(61, 425);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 118);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "导出Excel";
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(519, 45);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(103, 36);
            this.btn_out.TabIndex = 14;
            this.btn_out.Text = "导出";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // lbl_out
            // 
            this.lbl_out.AutoSize = true;
            this.lbl_out.Location = new System.Drawing.Point(91, 56);
            this.lbl_out.Name = "lbl_out";
            this.lbl_out.Size = new System.Drawing.Size(97, 15);
            this.lbl_out.TabIndex = 1;
            this.lbl_out.Text = "导出文件类型";
            // 
            // cbo_out
            // 
            this.cbo_out.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_out.FormattingEnabled = true;
            this.cbo_out.Items.AddRange(new object[] {
            "家长信息",
            "教员信息",
            "家长-家教",
            "家教-家长",
            "工作人员信息",
            "责任认定"});
            this.cbo_out.Location = new System.Drawing.Point(194, 53);
            this.cbo_out.Name = "cbo_out";
            this.cbo_out.Size = new System.Drawing.Size(274, 23);
            this.cbo_out.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(349, 573);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(103, 36);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "退出";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库备份/还原";
            this.Load += new System.EventHandler(this.backup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_open1;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textPaht;
        private System.Windows.Forms.Button btn_open2;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPaht;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label lbl_out;
        private System.Windows.Forms.ComboBox cbo_out;
        private System.Windows.Forms.Button btn_close;
    }
}