namespace TJ_Tutors_Management_System
{
    partial class Tutors_All_Inform
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
            this.dgv_tutors_all = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_cannel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutors_all)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_tutors_all
            // 
            this.dgv_tutors_all.AllowUserToAddRows = false;
            this.dgv_tutors_all.AllowUserToDeleteRows = false;
            this.dgv_tutors_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tutors_all.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_tutors_all.Location = new System.Drawing.Point(12, 12);
            this.dgv_tutors_all.Name = "dgv_tutors_all";
            this.dgv_tutors_all.ReadOnly = true;
            this.dgv_tutors_all.RowTemplate.Height = 27;
            this.dgv_tutors_all.Size = new System.Drawing.Size(1246, 585);
            this.dgv_tutors_all.TabIndex = 0;
            this.dgv_tutors_all.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_tutors_all_CellMouseDown);
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
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(255, 631);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(137, 39);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "查看家长信息";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(565, 631);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(137, 39);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "刷新表格";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_cannel
            // 
            this.btn_cannel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cannel.Location = new System.Drawing.Point(853, 631);
            this.btn_cannel.Name = "btn_cannel";
            this.btn_cannel.Size = new System.Drawing.Size(137, 39);
            this.btn_cannel.TabIndex = 3;
            this.btn_cannel.Text = "取消/退出";
            this.btn_cannel.UseVisualStyleBackColor = true;
            this.btn_cannel.Click += new System.EventHandler(this.btn_cannel_Click);
            // 
            // Tutors_All_Inform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btn_cannel;
            this.ClientSize = new System.Drawing.Size(1270, 699);
            this.Controls.Add(this.btn_cannel);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.dgv_tutors_all);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Tutors_All_Inform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "家长一览表";
            this.Load += new System.EventHandler(this.Tutors_All_Inform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutors_all)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tutors_all;
  /*      private System.Windows.Forms.DataGridViewTextBoxColumn 家长编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 打印编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 接待人DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 接入时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家长称呼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系方式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家教地址简单DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家教地址详细DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年级科目DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学员性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家教价格DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家教时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教员要求性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教员要求地域DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教员要求年级DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教员要求专业DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教员要求其他DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家教状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重要备注DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 缴费状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 缴费时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教员编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进行状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 经办时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 经办人DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否缴费DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn;*/
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_cannel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
    }
}