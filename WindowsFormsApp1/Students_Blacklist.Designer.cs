namespace TJ_Tutors_Management_System
{
    partial class Students_Blacklist
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
            this.dgv_blacklist = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cannel = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_blacklist)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_blacklist
            // 
            this.dgv_blacklist.AllowUserToAddRows = false;
            this.dgv_blacklist.AllowUserToDeleteRows = false;
            this.dgv_blacklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_blacklist.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_blacklist.Location = new System.Drawing.Point(182, 33);
            this.dgv_blacklist.Name = "dgv_blacklist";
            this.dgv_blacklist.ReadOnly = true;
            this.dgv_blacklist.RowTemplate.Height = 27;
            this.dgv_blacklist.Size = new System.Drawing.Size(892, 580);
            this.dgv_blacklist.TabIndex = 20;
            this.dgv_blacklist.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_blacklist_CellMouseDown);
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
            this.btn_cannel.Location = new System.Drawing.Point(938, 632);
            this.btn_cannel.Name = "btn_cannel";
            this.btn_cannel.Size = new System.Drawing.Size(137, 39);
            this.btn_cannel.TabIndex = 25;
            this.btn_cannel.Text = "取消/退出";
            this.btn_cannel.UseVisualStyleBackColor = true;
            this.btn_cannel.Click += new System.EventHandler(this.btn_cannel_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(569, 632);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(137, 39);
            this.btn_refresh.TabIndex = 24;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(182, 632);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(137, 39);
            this.btn_check.TabIndex = 23;
            this.btn_check.Text = "查看教员信息";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // Students_Blacklist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btn_cannel;
            this.ClientSize = new System.Drawing.Size(1270, 699);
            this.Controls.Add(this.btn_cannel);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.dgv_blacklist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Students_Blacklist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教员黑名单";
            this.Load += new System.EventHandler(this.Students_Blacklist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_blacklist)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_blacklist;
        private System.Windows.Forms.Button btn_cannel;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
    }
}