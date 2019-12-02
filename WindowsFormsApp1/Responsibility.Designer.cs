namespace TJ_Tutors_Management_System
{
    partial class Responsibility
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
            this.dgv_responsibility = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看家教信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cannel = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.txt_print_num = new System.Windows.Forms.TextBox();
            this.lbl_print_num = new System.Windows.Forms.Label();
            this.txt_parentnum = new System.Windows.Forms.TextBox();
            this.lbl_parentnum = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_responsibility)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_responsibility
            // 
            this.dgv_responsibility.AllowUserToAddRows = false;
            this.dgv_responsibility.AllowUserToDeleteRows = false;
            this.dgv_responsibility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_responsibility.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_responsibility.Location = new System.Drawing.Point(45, 12);
            this.dgv_responsibility.Name = "dgv_responsibility";
            this.dgv_responsibility.ReadOnly = true;
            this.dgv_responsibility.RowTemplate.Height = 27;
            this.dgv_responsibility.Size = new System.Drawing.Size(612, 336);
            this.dgv_responsibility.TabIndex = 0;
            this.dgv_responsibility.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_responsibility_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看家教信息ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 28);
            // 
            // 查看家教信息ToolStripMenuItem
            // 
            this.查看家教信息ToolStripMenuItem.Name = "查看家教信息ToolStripMenuItem";
            this.查看家教信息ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.查看家教信息ToolStripMenuItem.Text = "查看家长信息";
            this.查看家教信息ToolStripMenuItem.Click += new System.EventHandler(this.查看家教信息ToolStripMenuItem_Click);
            // 
            // btn_cannel
            // 
            this.btn_cannel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cannel.Location = new System.Drawing.Point(450, 556);
            this.btn_cannel.Name = "btn_cannel";
            this.btn_cannel.Size = new System.Drawing.Size(172, 39);
            this.btn_cannel.TabIndex = 14;
            this.btn_cannel.Text = "取消/退出";
            this.btn_cannel.UseVisualStyleBackColor = true;
            this.btn_cannel.Click += new System.EventHandler(this.btn_cannel_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(108, 556);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(172, 39);
            this.btn_check.TabIndex = 13;
            this.btn_check.Text = "查询信息";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // txt_print_num
            // 
            this.txt_print_num.Location = new System.Drawing.Point(340, 437);
            this.txt_print_num.Name = "txt_print_num";
            this.txt_print_num.Size = new System.Drawing.Size(139, 25);
            this.txt_print_num.TabIndex = 18;
            // 
            // lbl_print_num
            // 
            this.lbl_print_num.AutoSize = true;
            this.lbl_print_num.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_print_num.Location = new System.Drawing.Point(215, 436);
            this.lbl_print_num.Name = "lbl_print_num";
            this.lbl_print_num.Size = new System.Drawing.Size(93, 20);
            this.lbl_print_num.TabIndex = 17;
            this.lbl_print_num.Text = "打印编号";
            // 
            // txt_parentnum
            // 
            this.txt_parentnum.Location = new System.Drawing.Point(340, 379);
            this.txt_parentnum.Name = "txt_parentnum";
            this.txt_parentnum.Size = new System.Drawing.Size(139, 25);
            this.txt_parentnum.TabIndex = 16;
            // 
            // lbl_parentnum
            // 
            this.lbl_parentnum.AutoSize = true;
            this.lbl_parentnum.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_parentnum.Location = new System.Drawing.Point(215, 378);
            this.lbl_parentnum.Name = "lbl_parentnum";
            this.lbl_parentnum.Size = new System.Drawing.Size(93, 20);
            this.lbl_parentnum.TabIndex = 15;
            this.lbl_parentnum.Text = "家长编号";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_time.Location = new System.Drawing.Point(215, 494);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(93, 20);
            this.lbl_time.TabIndex = 19;
            this.lbl_time.Text = "经办时间";
            this.toolTip1.SetToolTip(this.lbl_time, "具体某天(例):2019-03-03\r\n某月份(例):2019-03");
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(340, 495);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(139, 25);
            this.txt_time.TabIndex = 20;
            this.txt_time.TextChanged += new System.EventHandler(this.txt_time_TextChanged);
            // 
            // Responsibility
            // 
            this.AcceptButton = this.btn_check;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btn_cannel;
            this.ClientSize = new System.Drawing.Size(699, 628);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.txt_print_num);
            this.Controls.Add(this.lbl_print_num);
            this.Controls.Add(this.txt_parentnum);
            this.Controls.Add(this.lbl_parentnum);
            this.Controls.Add(this.btn_cannel);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.dgv_responsibility);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Responsibility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "责任认定表";
            this.Load += new System.EventHandler(this.Responsibility_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_responsibility)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_responsibility;
        private System.Windows.Forms.Button btn_cannel;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox txt_print_num;
        private System.Windows.Forms.Label lbl_print_num;
        private System.Windows.Forms.TextBox txt_parentnum;
        private System.Windows.Forms.Label lbl_parentnum;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看家教信息ToolStripMenuItem;
    }
}