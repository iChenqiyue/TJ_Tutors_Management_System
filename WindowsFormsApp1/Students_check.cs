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
    public partial class Students_check : Form
    {
        string tutors_num1, tutors_name1, student_num1, grade_subject1,
                    tutors_degree1, sex1, phone1, place1, blacklist1, imprisonment1, remarks1;

        private void dgv_parents_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgv_parents.SelectedRows[0].Selected = false;
                dgv_parents.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btn_parents_Click(object sender, EventArgs e)
        {
            if (dgv_parents.SelectedRows.Count > 0)
            {
                string parents_num = dgv_parents.SelectedRows[0].Cells[0].Value.ToString();
                string print_num = dgv_parents.SelectedRows[0].Cells[1].Value.ToString();
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

        CommDB mydb = new CommDB();
        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_parents.SelectedRows.Count > 0)
            {
                string parents_num = dgv_parents.SelectedRows[0].Cells[0].Value.ToString();
                string print_num = dgv_parents.SelectedRows[0].Cells[1].Value.ToString();
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

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Students_check(string tutors_num, string tutors_name, string student_num, string grade_subject,
            string tutors_degree, string sex, string phone, string place, string blacklist, string imprisonment, 
            string remarks)
        {
            InitializeComponent();
            tutors_num1 = tutors_num;
            tutors_name1 = tutors_name;
            student_num1 = student_num;
            grade_subject1 = grade_subject;
            tutors_degree1 = tutors_degree;
            sex1 = sex;
            phone1 = phone;
            place1 = place;
            blacklist1 = blacklist;
            imprisonment1 = imprisonment;
            remarks1 = remarks;
        }

        private void Students_check_Load(object sender, EventArgs e)
        {
            CmbDataGridview cmbd = new CmbDataGridview();
            CCTRS ctr = new CCTRS();
            ctr.ColorDataGridView(dgv_parents);
            /*string mystr = "SELECT 家长编号,打印编号,经办状态,经办时间,经办人,处理备注 FROM [Tutors-Parents] WHERE " +
                "教员编号='" + tutors_num1 + "' ORDER BY 经办时间 DESC";
            cmbd.bind(dgv_parents, mystr, "Tutors-Parents");*/
            string mystr = "SELECT 家长编号,打印编号,经办状态,经办时间,经办人,处理备注 FROM [Parents-Tutors] WHERE " +
                "教员编号='" + tutors_num1 + "' ORDER BY 经办时间 DESC";
            cmbd.bind(dgv_parents, mystr, "Parents-Tutors");
            dgv_parents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_parents.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; txt_num.Text = tutors_num1;
            txt_student_name.Text = tutors_name1;
            txt_student_num.Text = student_num1;
            txt_subject.Text = grade_subject1;
            cbo_degree.SelectedItem = tutors_degree1;
            if (sex1 == "男")
                rdo_man.Checked = true;
            if (sex1 == "女")
                rdo_woman.Checked = true;
            txt_phone.Text = phone1;
            txt_place.Text = place1;
            if (blacklist1 == "是")
                cbo_yesno.SelectedItem = "是";
            if (blacklist1 == "否")
                cbo_yesno.SelectedItem = "否";
            txt_imprisonment.Text = imprisonment1;
            txt_important_remarks.Text = remarks1;
        }
    }
}
