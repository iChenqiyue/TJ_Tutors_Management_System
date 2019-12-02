namespace TJ_Tutors_Management_System
{
    partial class Students_Inquire
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
            this.btn_inquire = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_tutors_name = new System.Windows.Forms.TextBox();
            this.lbl_tutors_name = new System.Windows.Forms.Label();
            this.txt_student_num = new System.Windows.Forms.TextBox();
            this.lbl_student_num = new System.Windows.Forms.Label();
            this.txt_tutors_num = new System.Windows.Forms.TextBox();
            this.lbl_tutors_num = new System.Windows.Forms.Label();
            this.dgv_inquire = new System.Windows.Forms.DataGridView();
            this.ColCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择此家教ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inquire)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_inquire
            // 
            this.btn_inquire.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_inquire.Location = new System.Drawing.Point(558, 48);
            this.btn_inquire.Name = "btn_inquire";
            this.btn_inquire.Size = new System.Drawing.Size(159, 53);
            this.btn_inquire.TabIndex = 17;
            this.btn_inquire.Text = "查询教员信息";
            this.btn_inquire.UseVisualStyleBackColor = true;
            this.btn_inquire.Click += new System.EventHandler(this.btn_inquire_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(857, 93);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 25);
            this.txt_phone.TabIndex = 16;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_phone.Location = new System.Drawing.Point(732, 92);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(93, 20);
            this.lbl_phone.TabIndex = 15;
            this.lbl_phone.Text = "联系方式";
            // 
            // txt_tutors_name
            // 
            this.txt_tutors_name.Location = new System.Drawing.Point(857, 32);
            this.txt_tutors_name.Name = "txt_tutors_name";
            this.txt_tutors_name.Size = new System.Drawing.Size(100, 25);
            this.txt_tutors_name.TabIndex = 14;
            // 
            // lbl_tutors_name
            // 
            this.lbl_tutors_name.AutoSize = true;
            this.lbl_tutors_name.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_tutors_name.Location = new System.Drawing.Point(732, 31);
            this.lbl_tutors_name.Name = "lbl_tutors_name";
            this.lbl_tutors_name.Size = new System.Drawing.Size(93, 20);
            this.lbl_tutors_name.TabIndex = 13;
            this.lbl_tutors_name.Text = "教员姓名";
            // 
            // txt_student_num
            // 
            this.txt_student_num.Location = new System.Drawing.Point(437, 93);
            this.txt_student_num.Name = "txt_student_num";
            this.txt_student_num.Size = new System.Drawing.Size(100, 25);
            this.txt_student_num.TabIndex = 12;
            // 
            // lbl_student_num
            // 
            this.lbl_student_num.AutoSize = true;
            this.lbl_student_num.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_student_num.Location = new System.Drawing.Point(312, 92);
            this.lbl_student_num.Name = "lbl_student_num";
            this.lbl_student_num.Size = new System.Drawing.Size(95, 20);
            this.lbl_student_num.TabIndex = 11;
            this.lbl_student_num.Text = "学    号";
            // 
            // txt_tutors_num
            // 
            this.txt_tutors_num.Location = new System.Drawing.Point(437, 32);
            this.txt_tutors_num.Name = "txt_tutors_num";
            this.txt_tutors_num.Size = new System.Drawing.Size(100, 25);
            this.txt_tutors_num.TabIndex = 10;
            // 
            // lbl_tutors_num
            // 
            this.lbl_tutors_num.AutoSize = true;
            this.lbl_tutors_num.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_tutors_num.Location = new System.Drawing.Point(312, 31);
            this.lbl_tutors_num.Name = "lbl_tutors_num";
            this.lbl_tutors_num.Size = new System.Drawing.Size(93, 20);
            this.lbl_tutors_num.TabIndex = 9;
            this.lbl_tutors_num.Text = "教员编号";
            // 
            // dgv_inquire
            // 
            this.dgv_inquire.AllowUserToAddRows = false;
            this.dgv_inquire.AllowUserToDeleteRows = false;
            this.dgv_inquire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inquire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheck});
            this.dgv_inquire.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_inquire.Location = new System.Drawing.Point(197, 139);
            this.dgv_inquire.Name = "dgv_inquire";
            this.dgv_inquire.RowTemplate.Height = 27;
            this.dgv_inquire.Size = new System.Drawing.Size(880, 475);
            this.dgv_inquire.TabIndex = 18;
            this.dgv_inquire.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_inquire_CellMouseDown);
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
            this.删除ToolStripMenuItem,
            this.选择此家教ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 76);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.查看ToolStripMenuItem.Text = "查看";
            this.查看ToolStripMenuItem.Click += new System.EventHandler(this.查看ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 选择此家教ToolStripMenuItem
            // 
            this.选择此家教ToolStripMenuItem.Name = "选择此家教ToolStripMenuItem";
            this.选择此家教ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.选择此家教ToolStripMenuItem.Text = "选择此家教";
            this.选择此家教ToolStripMenuItem.Click += new System.EventHandler(this.选择此家教ToolStripMenuItem_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_quit.Location = new System.Drawing.Point(994, 638);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(172, 39);
            this.btn_quit.TabIndex = 20;
            this.btn_quit.Text = "取消/退出";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(570, 638);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(172, 39);
            this.btn_check.TabIndex = 19;
            this.btn_check.Text = "查看/修改教员信息";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(785, 638);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(172, 39);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "删除教员信息";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(106, 638);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(172, 39);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "新增教员信息";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(340, 638);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(172, 39);
            this.btn_refresh.TabIndex = 23;
            this.btn_refresh.Text = "刷新表格";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Students_Inquire
            // 
            this.AcceptButton = this.btn_inquire;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btn_quit;
            this.ClientSize = new System.Drawing.Size(1270, 699);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.dgv_inquire);
            this.Controls.Add(this.btn_inquire);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.txt_tutors_name);
            this.Controls.Add(this.lbl_tutors_name);
            this.Controls.Add(this.txt_student_num);
            this.Controls.Add(this.lbl_student_num);
            this.Controls.Add(this.txt_tutors_num);
            this.Controls.Add(this.lbl_tutors_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Students_Inquire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看/修改教员信息";
            this.Load += new System.EventHandler(this.Students_Inquire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inquire)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_inquire;
        public System.Windows.Forms.TextBox txt_phone;
        public System.Windows.Forms.Label lbl_phone;
        public System.Windows.Forms.TextBox txt_tutors_name;
        public System.Windows.Forms.Label lbl_tutors_name;
        public System.Windows.Forms.TextBox txt_student_num;
        public System.Windows.Forms.Label lbl_student_num;
        public System.Windows.Forms.TextBox txt_tutors_num;
        public System.Windows.Forms.Label lbl_tutors_num;
        public System.Windows.Forms.DataGridView dgv_inquire;
        public System.Windows.Forms.Button btn_quit;
        public System.Windows.Forms.Button btn_check;
        public System.Windows.Forms.DataGridViewCheckBoxColumn ColCheck;
        public System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择此家教ToolStripMenuItem;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_refresh;
    }
}