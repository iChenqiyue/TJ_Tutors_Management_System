namespace TJ_Tutors_Management_System
{
    partial class Tutors_Inquire
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
            this.lbl_parentnum = new System.Windows.Forms.Label();
            this.txt_parentnum = new System.Windows.Forms.TextBox();
            this.txt_adr = new System.Windows.Forms.TextBox();
            this.lbl_adr = new System.Windows.Forms.Label();
            this.txt_printnum = new System.Windows.Forms.TextBox();
            this.lbl_printnum = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.btn_inquire = new System.Windows.Forms.Button();
            this.dgv_inquire = new System.Windows.Forms.DataGridView();
            this.ColCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inquire)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_parentnum
            // 
            this.lbl_parentnum.AutoSize = true;
            this.lbl_parentnum.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_parentnum.Location = new System.Drawing.Point(312, 33);
            this.lbl_parentnum.Name = "lbl_parentnum";
            this.lbl_parentnum.Size = new System.Drawing.Size(93, 20);
            this.lbl_parentnum.TabIndex = 0;
            this.lbl_parentnum.Text = "家长编号";
            // 
            // txt_parentnum
            // 
            this.txt_parentnum.Location = new System.Drawing.Point(437, 34);
            this.txt_parentnum.Name = "txt_parentnum";
            this.txt_parentnum.Size = new System.Drawing.Size(100, 25);
            this.txt_parentnum.TabIndex = 1;
            // 
            // txt_adr
            // 
            this.txt_adr.Location = new System.Drawing.Point(437, 95);
            this.txt_adr.Name = "txt_adr";
            this.txt_adr.Size = new System.Drawing.Size(100, 25);
            this.txt_adr.TabIndex = 3;
            // 
            // lbl_adr
            // 
            this.lbl_adr.AutoSize = true;
            this.lbl_adr.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_adr.Location = new System.Drawing.Point(312, 94);
            this.lbl_adr.Name = "lbl_adr";
            this.lbl_adr.Size = new System.Drawing.Size(114, 20);
            this.lbl_adr.TabIndex = 2;
            this.lbl_adr.Text = "地址中含有";
            // 
            // txt_printnum
            // 
            this.txt_printnum.Location = new System.Drawing.Point(857, 34);
            this.txt_printnum.Name = "txt_printnum";
            this.txt_printnum.Size = new System.Drawing.Size(100, 25);
            this.txt_printnum.TabIndex = 5;
            // 
            // lbl_printnum
            // 
            this.lbl_printnum.AutoSize = true;
            this.lbl_printnum.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_printnum.Location = new System.Drawing.Point(732, 33);
            this.lbl_printnum.Name = "lbl_printnum";
            this.lbl_printnum.Size = new System.Drawing.Size(93, 20);
            this.lbl_printnum.TabIndex = 4;
            this.lbl_printnum.Text = "打印编号";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(857, 95);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 25);
            this.txt_phone.TabIndex = 7;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_phone.Location = new System.Drawing.Point(732, 94);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(93, 20);
            this.lbl_phone.TabIndex = 6;
            this.lbl_phone.Text = "联系方式";
            // 
            // btn_inquire
            // 
            this.btn_inquire.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_inquire.ForeColor = System.Drawing.Color.Black;
            this.btn_inquire.Location = new System.Drawing.Point(558, 50);
            this.btn_inquire.Name = "btn_inquire";
            this.btn_inquire.Size = new System.Drawing.Size(159, 53);
            this.btn_inquire.TabIndex = 8;
            this.btn_inquire.Text = "查询家教信息";
            this.btn_inquire.UseVisualStyleBackColor = true;
            this.btn_inquire.Click += new System.EventHandler(this.btn_inquire_Click);
            // 
            // dgv_inquire
            // 
            this.dgv_inquire.AllowUserToAddRows = false;
            this.dgv_inquire.AllowUserToDeleteRows = false;
            this.dgv_inquire.AllowUserToResizeColumns = false;
            this.dgv_inquire.AllowUserToResizeRows = false;
            this.dgv_inquire.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgv_inquire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inquire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheck});
            this.dgv_inquire.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_inquire.Location = new System.Drawing.Point(12, 144);
            this.dgv_inquire.Name = "dgv_inquire";
            this.dgv_inquire.RowTemplate.Height = 27;
            this.dgv_inquire.Size = new System.Drawing.Size(1243, 465);
            this.dgv_inquire.TabIndex = 9;
            this.dgv_inquire.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_inquire_CellContentClick);
            this.dgv_inquire.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_inquire_CellMouseClick);
            this.dgv_inquire.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_inquire_CellMouseDown);
            this.dgv_inquire.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_inquire_CellValueChanged);
            this.dgv_inquire.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_inquire_Scroll);
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
            // btn_check
            // 
            this.btn_check.ForeColor = System.Drawing.Color.Black;
            this.btn_check.Location = new System.Drawing.Point(316, 639);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(172, 39);
            this.btn_check.TabIndex = 10;
            this.btn_check.Text = "查看/修改家长信息";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_quit.ForeColor = System.Drawing.Color.Black;
            this.btn_quit.Location = new System.Drawing.Point(1025, 639);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(172, 39);
            this.btn_quit.TabIndex = 11;
            this.btn_quit.Text = "退出";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(558, 639);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(172, 39);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "删除家长信息";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(65, 639);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(172, 39);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "新增家长信息";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_refresh.Location = new System.Drawing.Point(785, 639);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(172, 39);
            this.btn_refresh.TabIndex = 14;
            this.btn_refresh.Text = "刷新表格";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Tutors_Inquire
            // 
            this.AcceptButton = this.btn_inquire;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btn_quit;
            this.ClientSize = new System.Drawing.Size(1270, 699);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_inquire);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.txt_printnum);
            this.Controls.Add(this.lbl_printnum);
            this.Controls.Add(this.txt_adr);
            this.Controls.Add(this.lbl_adr);
            this.Controls.Add(this.txt_parentnum);
            this.Controls.Add(this.lbl_parentnum);
            this.Controls.Add(this.dgv_inquire);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tutors_Inquire";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "家教信息";
            this.Load += new System.EventHandler(this.Tutors_Inquire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inquire)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_parentnum;
        private System.Windows.Forms.TextBox txt_parentnum;
        private System.Windows.Forms.TextBox txt_adr;
        private System.Windows.Forms.Label lbl_adr;
        private System.Windows.Forms.TextBox txt_printnum;
        private System.Windows.Forms.Label lbl_printnum;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Button btn_inquire;
        private System.Windows.Forms.DataGridView dgv_inquire;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCheck;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_refresh;
    }
}