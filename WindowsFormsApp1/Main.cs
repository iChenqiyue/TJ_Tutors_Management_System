using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TJ_Tutors_Management_System
{
    public delegate void SetPos(int ipos, string vinfo);//代理

    public partial class Main : Form
    {
        public SetPos setp;
        string level1;
        public Main(string level)
        {
            InitializeComponent();
            level1 = level;
        }

        
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (level1 == "操作员")
            {
                menuStrip1.Items["部员系统管理ToolStripMenuItem"].Enabled = false;
            }            
        }

        private void 家教信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查询修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Tutors_Inquire(level1);
            myform.MdiParent = this;
            myform.BackColor=System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

   /*     private void 新增家教信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Tutors_Add();
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }*/

        private void 查询修改教员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Students_Inquire(1);
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            
            myform.Show();
        }

        private void 查看所有家教信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Tutors_All_Inform();
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }

        private void 家教信息追踪ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Tutors_Track();
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();

        }

        private void 当日表格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Today_Form();
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }

   /*     private void 新增教员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Students_Add();
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }*/

        private void 查看所有教员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Students_all();
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }

        private void 教员黑名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Students_Blacklist();
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }

        private void 查看修改工作人员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Workers_Inquire();
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }

        private void 新增工作人员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Workers_Add();
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }

        private void 责任认定表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Responsibility();
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }

        private void 家教部工作流程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath+"//家教部工作流程.pdf");
            
        }

        private void 家教部制度规范ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + "//家教部制度规范.pdf");
        }

        private void 家教价格查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + "//家教价格表.pdf");
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Users_All();
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }
        
        private void 数据库备份还原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new backup();
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }

        private void 系统使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + "//同济家教服务中心数据系统使用说明.pdf");
        }

        private void 系统负责人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Operator();
            myform.MdiParent = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = System.DateTime.Today.ToLongDateString() + " " + System.DateTime.Now.ToShortTimeString();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            QYForm QY = new QYForm(this);//实例化一个 QYForm 窗体 并把 当前窗体传过去 (这样可以当 QY 窗体使用完毕后，在调用当前窗体，而无需在 实例化一个 当前窗体.)
            QY.Show();//显示QY窗体（也就是 区域窗体）
        }
    }
}
