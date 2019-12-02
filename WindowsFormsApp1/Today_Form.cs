using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TJ_Tutors_Management_System
{
    public partial class Today_Form : Form
    {
        public Today_Form()
        {
            InitializeComponent();
        }
        CommDB mydb = new CommDB();
        private void Today_Form_Load(object sender, EventArgs e)
        {
            CCTRS ctr = new CCTRS();
            ctr.ColorDataGridView(dgv_form);
            string mysql = "SELECT 打印编号,学员性别,年级科目,家教地址简单 as 家教地址,家教时间,concat((CASE WHEN 教员要求性别='' THEN NULL ELSE concat(教员要求性别,' ') END),"
+"(CASE WHEN 教员要求地域 = '' THEN '' ELSE concat(教员要求地域, ' ') END),"
+"(CASE WHEN 教员要求年级 = '' THEN '' ELSE concat(教员要求年级, ' ') END),"
+"(CASE WHEN 教员要求专业 = '' THEN '' ELSE concat(教员要求专业, ' ') END),"
+"(CASE WHEN 教员要求其他 = '' THEN '' ELSE concat(教员要求其他, ' ') END)) as 教员要求 FROM [Parents] WHERE 家教状态='接入' OR 家教状态='换人' OR 家教状态='重请' " +
                "ORDER BY 打印编号 DESC";
            DataSet mydataset = mydb.ExecuteQuery(mysql, "Parents");
            dgv_form.DataSource = mydataset.Tables["Parents"];
            dgv_form.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btn_cannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_form_Click(object sender, EventArgs e)
        {
            ExportToExcel ete = new ExportToExcel();
            ete.ExportExcel("default.xlsx", dgv_form);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string mysql = "SELECT 打印编号,学员性别,年级科目,家教地址简单 as 家教地址,家教时间,concat((CASE WHEN 教员要求性别='' THEN NULL ELSE concat(教员要求性别,' ') END),"
+ "(CASE WHEN 教员要求地域 = '' THEN '' ELSE concat(教员要求地域, ' ') END),"
+ "(CASE WHEN 教员要求年级 = '' THEN '' ELSE concat(教员要求年级, ' ') END),"
+ "(CASE WHEN 教员要求专业 = '' THEN '' ELSE concat(教员要求专业, ' ') END),"
+ "(CASE WHEN 教员要求其他 = '' THEN '' ELSE concat(教员要求其他, ' ') END)) as 教员要求 FROM [Parents] WHERE 家教状态='接入' OR 家教状态='换人' OR 家教状态='重请' " +
                "ORDER BY 打印编号 DESC";
            DataSet mydataset = mydb.ExecuteQuery(mysql, "Parents");
            dgv_form.DataSource = mydataset.Tables["Parents"];
        }
    }
}
