namespace TJ_Tutors_Management_System
{
    partial class Students_all
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
            this.dgv_all = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cannel = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_all
            // 
            this.dgv_all.AllowUserToAddRows = false;
            this.dgv_all.AllowUserToDeleteRows = false;
            this.dgv_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_all.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_all.Location = new System.Drawing.Point(216, 33);
            this.dgv_all.Name = "dgv_all";
            this.dgv_all.ReadOnly = true;
            this.dgv_all.RowTemplate.Height = 27;
            this.dgv_all.Size = new System.Drawing.Size(892, 580);
            this.dgv_all.TabIndex = 19;
            this.dgv_all.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_all_CellMouseDown);
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
            // btn_cannel
            // 
            this.btn_cannel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cannel.Location = new System.Drawing.Point(929, 634);
            this.btn_cannel.Name = "btn_cannel";
            this.btn_cannel.Size = new System.Drawing.Size(137, 39);
            this.btn_cannel.TabIndex = 22;
            this.btn_cannel.Text = "取消/退出";
            this.btn_cannel.UseVisualStyleBackColor = true;
            this.btn_cannel.Click += new System.EventHandler(this.btn_cannel_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(596, 634);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(137, 39);
            this.btn_refresh.TabIndex = 21;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(216, 634);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(137, 39);
            this.btn_check.TabIndex = 20;
            this.btn_check.Text = "查看教员信息";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // Students_all
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btn_cannel;
            this.ClientSize = new System.Drawing.Size(1270, 699);
            this.Controls.Add(this.btn_cannel);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.dgv_all);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Students_all";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教员一览表";
            this.Load += new System.EventHandler(this.Students_all_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_all;
        private System.Windows.Forms.Button btn_cannel;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        /*      private System.Windows.Forms.DataGridViewTextBoxColumn 教员编号DataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn 院系专业DataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn 在读学位DataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn 联系方式DataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn 生源地DataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn 是否黑名单DataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn 相关说明及监禁期DataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn 重要备注DataGridViewTextBoxColumn;*/
    }
}