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
    public partial class Tutors_check : Form
    {
        string ID1, parent_num1, print_num1, parent_name1, phone1, grade_subject1, student_sex1,
                    tutors_state1, time1, tutors_price1, tutors_time1, dadd1, important_mark1,
         payment_state1, payment_time1;

        private void dgv_tutors_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgv_tutors.SelectedRows[0].Selected = false;
                dgv_tutors.Rows[e.RowIndex].Selected = true;
            }
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_tutors.SelectedRows.Count > 0)
            {
                string tutors_num = dgv_tutors.SelectedRows[0].Cells[0].Value.ToString();
                if (tutors_num != "")
                {
                    string mysql = "SELECT 姓名 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string tutors_name = mydb.Returnafield(mysql);
                    mysql = "SELECT 学号 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string student_num = mydb.Returnafield(mysql);
                    mysql = "SELECT 院系专业 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string grade_subject = mydb.Returnafield(mysql);
                    mysql = "SELECT 在读学位 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string tutors_degree = mydb.Returnafield(mysql);
                    mysql = "SELECT 性别 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string sex = mydb.Returnafield(mysql);
                    mysql = "SELECT 联系方式 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string phone = mydb.Returnafield(mysql);
                    mysql = "SELECT 生源地 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string place = mydb.Returnafield(mysql);
                    mysql = "SELECT 是否黑名单 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string blacklist = mydb.Returnafield(mysql);
                    mysql = "SELECT 相关说明及监禁期 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string imprisonment = mydb.Returnafield(mysql);
                    mysql = "SELECT 重要备注 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string remarks = mydb.Returnafield(mysql);
                    Students_check myform = new Students_check(tutors_num, tutors_name, student_num, grade_subject,
                        tutors_degree, sex, phone, place, blacklist, imprisonment, remarks);
                    myform.Owner = this;
                    myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                    myform.Show();
                }
            }

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (dgv_tutors.SelectedRows.Count > 0)
            {
                string tutors_num = dgv_tutors.SelectedRows[0].Cells[0].Value.ToString();
                if (tutors_num != "") 
                {
                    string mysql = "SELECT 姓名 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string tutors_name = mydb.Returnafield(mysql);
                    mysql = "SELECT 学号 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string student_num = mydb.Returnafield(mysql);
                    mysql = "SELECT 院系专业 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string grade_subject = mydb.Returnafield(mysql);
                    mysql = "SELECT 在读学位 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string tutors_degree = mydb.Returnafield(mysql);
                    mysql = "SELECT 性别 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string sex = mydb.Returnafield(mysql);
                    mysql = "SELECT 联系方式 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string phone = mydb.Returnafield(mysql);
                    mysql = "SELECT 生源地 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string place = mydb.Returnafield(mysql);
                    mysql = "SELECT 是否黑名单 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string blacklist = mydb.Returnafield(mysql);
                    mysql = "SELECT 相关说明及监禁期 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string imprisonment = mydb.Returnafield(mysql);
                    mysql = "SELECT 重要备注 FROM [Tutors] WHERE 教员编号='" + tutors_num + "'";
                    string remarks = mydb.Returnafield(mysql);
                    Students_check myform = new Students_check(tutors_num, tutors_name, student_num, grade_subject,
                        tutors_degree, sex, phone, place, blacklist, imprisonment, remarks);
                    myform.Owner = this;
                    myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                    myform.Show();
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CommDB mydb = new CommDB();
        private void Tutors_check_Load(object sender, EventArgs e)
        {
            CmbClass cmbc = new CmbClass();
            cmbc.cboDataBind(cbo_reception, "SELECT distinct 姓名 FROM [Workers]", "Workers", "姓名");
            CmbDataGridview cmbd = new CmbDataGridview();
            CCTRS ctr = new CCTRS();
            ctr.ColorDataGridView(dgv_tutors);
            string mystr = "SELECT 教员编号,教员姓名,经办状态,经办时间,经办人,处理备注 FROM [Parents-Tutors] WHERE " +
                "打印编号='"+print_num1+"'"+ " ORDER BY 经办时间 DESC";
            cmbd.bind(dgv_tutors, mystr, "Parents-Tutors");
            dgv_tutors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_tutors.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txt_parent_num.Text = parent_num1;
            txt_print_num.Text = print_num1;
            mystr = "SELECT 接入时间 FROM [Parents] WHERE ID='" + ID1 + "'";
            dt_recepiton_time.Text = mydb.Returnafield(mystr);
            txt_parent_name.Text = parent_name1;
            txt_phone.Text = phone1;
            mystr = "SELECT 家教地址简单 FROM [Parents] WHERE ID='" + ID1 + "'";
            txt_sadd.Text = mydb.Returnafield(mystr);
            txt_dadd.Text = dadd1;
            txt_grade_subject.Text = grade_subject1;
            if (student_sex1 == "男")
                rdo_man.Checked = true;
            if (student_sex1 == "女")
                rdo_woman.Checked = true;
            txt_tutor_price.Text = tutors_price1;
            txt_tutor_time.Text = tutors_time1;
            mystr = "SELECT 接待人 FROM [Parents] WHERE ID='" + ID1 + "'";
            cbo_reception.Text = mydb.Returnafield(mystr);
            mystr = "SELECT 教员要求性别 FROM [Parents] WHERE ID='" + ID1 + "'";
            cbo_sex.SelectedItem = mydb.Returnafield(mystr);
            mystr = "SELECT 教员要求地域 FROM [Parents] WHERE ID='" + ID1 + "'";
            txt_place.Text = mydb.Returnafield(mystr);
            mystr = "SELECT 教员要求年级 FROM [Parents] WHERE ID='" + ID1 + "'";
            txt_grade.Text = mydb.Returnafield(mystr);
            mystr = "SELECT 教员要求专业 FROM [Parents] WHERE ID='" + ID1 + "'";
            txt_subject.Text = mydb.Returnafield(mystr);
            mystr = "SELECT 教员要求其他 FROM [Parents] WHERE ID='" + ID1 + "'";
            txt_other_requests.Text = mydb.Returnafield(mystr);
            //       string[] tutors_state = tutors_state1.Split(' ');
            //     cbo_tutor_state.SelectedItem = tutors_state.Last();
            cbo_tutor_state.SelectedItem = tutors_state1;
            txt_important_remarks.Text = important_mark1;
            cbo_payment_state.SelectedItem = payment_state1;
            dt_payment_time.Text = payment_time1;
            if (cbo_payment_state.SelectedItem.ToString() == "待缴" || cbo_payment_state.SelectedItem.ToString() == "无需缴纳")
            {
                
                dt_payment_time.Enabled = false;
            }
            if (cbo_payment_state.SelectedItem.ToString() == "已缴")
            {
                
                dt_payment_time.Enabled = true;
            }
        
        }

        public Tutors_check(string ID, string parent_num, string print_num, string parent_name, string phone,
            string grade_subject, string student_sex, string tutors_state, string time, string tutors_price,
            string tutors_time, string dadd, string important_mark, string payment_state, string payment_time)
        {
            InitializeComponent();
            ID1 = ID;
            parent_num1 = parent_num;
            print_num1 = print_num;
            parent_name1 = parent_name;
            phone1 = phone;
            dadd1 = dadd;
            time1 = time;
            grade_subject1 = grade_subject;
            student_sex1 = student_sex;
            tutors_price1 = tutors_price;
            tutors_time1 = tutors_time;
            tutors_state1 = tutors_state;
            important_mark1 = important_mark;
            payment_state1 = payment_state;
            payment_time1 = payment_time;
        }
    }
}
