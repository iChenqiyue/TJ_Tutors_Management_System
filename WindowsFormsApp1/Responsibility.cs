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
    public partial class Responsibility : Form
    {
        public Responsibility()
        {
            InitializeComponent();
        }
        CommDB mydb = new CommDB();
        string mystr = "SELECT 家长编号,打印编号,经办状态,经办时间,经办人,处理备注 FROM [Responsibility] ORDER BY 经办时间 DESC";
        private void Responsibility_Load(object sender, EventArgs e)
        {
            CmbDataGridview cmbd = new CmbDataGridview();
            CCTRS ctr = new CCTRS();
            ctr.ColorDataGridView(dgv_responsibility);
            cmbd.bind(dgv_responsibility, mystr, "Responsibility");
            dgv_responsibility.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (txt_parentnum.Text.Trim() == "" && txt_print_num.Text.Trim() == "" && txt_time.Text.Trim() == "")
            {
                CmbDataGridview cmbd = new CmbDataGridview();
                cmbd.bind(dgv_responsibility, mystr, "Responsibility");
                return;
            }
            
            string mysql = "", tempstr = "";
            if (txt_parentnum.Text != "")
                tempstr = "家长编号 Like '%" + txt_parentnum.Text.Trim() + "%'";
            if (txt_print_num.Text != "")
            {
                if (tempstr == "")
                    tempstr = "打印编号 Like '%" + txt_print_num.Text.Trim() + "%'";
                else
                    tempstr += " AND 打印编号 Like '%" + txt_print_num.Text.Trim() + "%'";
            }
            if (txt_time.Text != "")
            {
                if (tempstr == "")
                    tempstr = "经办时间 Like '%" + txt_time.Text.Trim() + "%'";
                else
                    tempstr += " AND 经办时间 Like '%" + txt_time.Text.Trim() + "%'";
            }
            if (tempstr == "")
                mysql = "SELECT 家长编号,打印编号,经办状态,经办时间,经办人,处理备注 FROM [Responsibility] ORDER BY 经办时间 DESC";
            else
                mysql += "SELECT 家长编号,打印编号,经办状态,经办时间,经办人,处理备注 FROM [Responsibility] WHERE " + tempstr + " ORDER BY 经办时间 DESC";
            DataSet mydataset = mydb.ExecuteQuery(mysql, "Responsibility");
            dgv_responsibility.DataSource = mydataset.Tables["Responsibility"];
        }

        private void btn_cannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_responsibility_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgv_responsibility.SelectedRows[0].Selected = false;
                dgv_responsibility.Rows[e.RowIndex].Selected = true;
            }
        }

        private void 查看家教信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_responsibility.SelectedRows.Count > 0)
            {
                string parents_num = dgv_responsibility.SelectedRows[0].Cells[0].Value.ToString();
                string print_num = dgv_responsibility.SelectedRows[0].Cells[1].Value.ToString();
                string mysql = "SELECT 接待人 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string reception = mydb.Returnafield(mysql);
                mysql = "SELECT ID FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string ID = mydb.Returnafield(mysql);
                mysql = "SELECT 接入时间 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string reception_time = mydb.Returnafield(mysql);
                mysql = "SELECT 家长称呼 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string parents_name = mydb.Returnafield(mysql);
                mysql = "SELECT 联系方式 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string phone = mydb.Returnafield(mysql);
                mysql = "SELECT 家教地址简单 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string sadd = mydb.Returnafield(mysql);
                mysql = "SELECT 家教地址详细 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string dadd = mydb.Returnafield(mysql);
                mysql = "SELECT 年级科目 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string grade_subject = mydb.Returnafield(mysql);
                mysql = "SELECT 学员性别 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string student_sex = mydb.Returnafield(mysql);
                mysql = "SELECT 家教价格 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string tutors_price = mydb.Returnafield(mysql);
                mysql = "SELECT 家教时间 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string tutors_time = mydb.Returnafield(mysql);
                mysql = "SELECT 教员要求性别 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string sex = mydb.Returnafield(mysql);
                mysql = "SELECT 教员要求地域 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string place = mydb.Returnafield(mysql);
                mysql = "SELECT 教员要求年级 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string grade = mydb.Returnafield(mysql);
                mysql = "SELECT 教员要求专业 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string subject = mydb.Returnafield(mysql);
                mysql = "SELECT 教员要求其他 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string others = mydb.Returnafield(mysql);
                mysql = "SELECT 家教状态 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string tutors_state = mydb.Returnafield(mysql);
                mysql = "SELECT 经办时间 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string time = mydb.Returnafield(mysql);
                mysql = "SELECT 重要备注 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string remarks = mydb.Returnafield(mysql);
                mysql = "SELECT 缴费状态 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string payment_state = mydb.Returnafield(mysql);
                mysql = "SELECT 缴费时间 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string payment_time = mydb.Returnafield(mysql);
                Tutors_check myform = new Tutors_check(ID, parents_num, print_num, parents_name, phone, grade_subject, student_sex,
                    tutors_state, time, tutors_price, tutors_time, dadd, remarks, payment_state, payment_time);
                myform.Owner = this;
                myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                myform.Show();
            }
        }
    }
}
