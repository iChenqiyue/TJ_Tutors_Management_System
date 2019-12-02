namespace TJ_Tutors_Management_System
{
    partial class Users_All
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
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_revise = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cannel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_users
            // 
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_users.Location = new System.Drawing.Point(168, 12);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.RowTemplate.Height = 27;
            this.dgv_users.Size = new System.Drawing.Size(291, 313);
            this.dgv_users.TabIndex = 0;
            this.dgv_users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_users_CellContentClick);
            this.dgv_users.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_users_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 52);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
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
            this.btn_delete.Location = new System.Drawing.Point(319, 367);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(110, 39);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_revise
            // 
            this.btn_revise.Location = new System.Drawing.Point(187, 367);
            this.btn_revise.Name = "btn_revise";
            this.btn_revise.Size = new System.Drawing.Size(110, 39);
            this.btn_revise.TabIndex = 14;
            this.btn_revise.Text = "修改";
            this.btn_revise.UseVisualStyleBackColor = true;
            this.btn_revise.Click += new System.EventHandler(this.btn_revise_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(52, 367);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 39);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cannel
            // 
            this.btn_cannel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cannel.Location = new System.Drawing.Point(461, 367);
            this.btn_cannel.Name = "btn_cannel";
            this.btn_cannel.Size = new System.Drawing.Size(110, 39);
            this.btn_cannel.TabIndex = 16;
            this.btn_cannel.Text = "退出";
            this.btn_cannel.UseVisualStyleBackColor = true;
            this.btn_cannel.Click += new System.EventHandler(this.btn_cannel_Click);
            // 
            // Users_All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cannel;
            this.ClientSize = new System.Drawing.Size(595, 435);
            this.Controls.Add(this.btn_cannel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_revise);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Users_All";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.Users_All_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_revise;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cannel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}