namespace TJ_Tutors_Management_System
{
    partial class Tutors_Track
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
            this.dgv_track = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_prepared = new System.Windows.Forms.Button();
            this.btn_nopayment = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_track)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_track
            // 
            this.dgv_track.AllowUserToAddRows = false;
            this.dgv_track.AllowUserToDeleteRows = false;
            this.dgv_track.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_track.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_track.Location = new System.Drawing.Point(12, 94);
            this.dgv_track.Name = "dgv_track";
            this.dgv_track.ReadOnly = true;
            this.dgv_track.RowTemplate.Height = 27;
            this.dgv_track.Size = new System.Drawing.Size(1246, 513);
            this.dgv_track.TabIndex = 0;
            this.dgv_track.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_track_CellMouseDown);
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
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(831, 28);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(137, 39);
            this.btn_no.TabIndex = 6;
            this.btn_no.Text = "未派出家教";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_prepared
            // 
            this.btn_prepared.Location = new System.Drawing.Point(543, 28);
            this.btn_prepared.Name = "btn_prepared";
            this.btn_prepared.Size = new System.Drawing.Size(137, 39);
            this.btn_prepared.TabIndex = 5;
            this.btn_prepared.Text = "待接家教";
            this.btn_prepared.UseVisualStyleBackColor = true;
            this.btn_prepared.Click += new System.EventHandler(this.btn_prepared_Click);
            // 
            // btn_nopayment
            // 
            this.btn_nopayment.Location = new System.Drawing.Point(233, 28);
            this.btn_nopayment.Name = "btn_nopayment";
            this.btn_nopayment.Size = new System.Drawing.Size(137, 39);
            this.btn_nopayment.TabIndex = 4;
            this.btn_nopayment.Text = "管理费未清家教";
            this.btn_nopayment.UseVisualStyleBackColor = true;
            this.btn_nopayment.Click += new System.EventHandler(this.btn_nopayment_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_quit.Location = new System.Drawing.Point(831, 632);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(137, 39);
            this.btn_quit.TabIndex = 13;
            this.btn_quit.Text = "取消/退出";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(543, 632);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(137, 39);
            this.btn_check.TabIndex = 12;
            this.btn_check.Text = "查看家教信息";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(233, 632);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(137, 39);
            this.btn_refresh.TabIndex = 14;
            this.btn_refresh.Text = "刷新表格";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Tutors_Track
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btn_quit;
            this.ClientSize = new System.Drawing.Size(1270, 699);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_prepared);
            this.Controls.Add(this.btn_nopayment);
            this.Controls.Add(this.dgv_track);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Tutors_Track";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "家长信息跟踪";
            this.Load += new System.EventHandler(this.Tutors_Track_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_track)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_track;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_prepared;
        private System.Windows.Forms.Button btn_nopayment;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.Button btn_refresh;
        /*     private System.Windows.Forms.DataGridViewTextBoxColumn 家长编号DataGridViewTextBoxColumn;
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
    }
}