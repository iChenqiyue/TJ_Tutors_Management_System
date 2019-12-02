namespace TJ_Tutors_Management_System
{
    partial class Workers_Inquire
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
            this.dgv_inquire = new System.Windows.Forms.DataGridView();
            this.ColCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inquire)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_inquire
            // 
            this.dgv_inquire.AllowUserToAddRows = false;
            this.dgv_inquire.AllowUserToDeleteRows = false;
            this.dgv_inquire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inquire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheck});
            this.dgv_inquire.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_inquire.Location = new System.Drawing.Point(61, 12);
            this.dgv_inquire.Name = "dgv_inquire";
            this.dgv_inquire.RowTemplate.Height = 27;
            this.dgv_inquire.Size = new System.Drawing.Size(692, 346);
            this.dgv_inquire.TabIndex = 0;
            this.dgv_inquire.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_inquire_CellMouseDown);
            // 
            // ColCheck
            // 
            this.ColCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColCheck.FalseValue = "0";
            this.ColCheck.HeaderText = "勾选";
            this.ColCheck.Name = "ColCheck";
            this.ColCheck.TrueValue = "1";
            this.ColCheck.Width = 43;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 52);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.查看ToolStripMenuItem.Text = "查看";
            this.查看ToolStripMenuItem.Click += new System.EventHandler(this.查看ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(323, 375);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(172, 39);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "删除信息";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_quit.Location = new System.Drawing.Point(578, 375);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(172, 39);
            this.btn_quit.TabIndex = 14;
            this.btn_quit.Text = "退出";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(61, 375);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(172, 39);
            this.btn_check.TabIndex = 13;
            this.btn_check.Text = "查看/修改信息";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // Workers_Inquire
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btn_quit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.dgv_inquire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Workers_Inquire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改工作人员信息";
            this.Load += new System.EventHandler(this.Workers_Revise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inquire)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_inquire;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCheck;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}