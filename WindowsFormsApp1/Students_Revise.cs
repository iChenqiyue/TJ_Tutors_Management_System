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
    public delegate void SetTop2Handle(); //定义委托  
    public partial class Students_Revise : Form
    {
        CommDB mydb = new CommDB();
        CmbClass cmbc = new CmbClass();
        string ID1,tutors_num1, tutors_name1, student_num1, grade_subject1,
                    tutors_degree1, sex1, phone1, place1, blacklist1, imprisonment1, remarks1;

        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_student_num_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_phone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            CmbDataGridview cmbd = new CmbDataGridview();            
            string mystr = "SELECT 家长编号,打印编号,经办状态,经办时间,经办人,处理备注 FROM [Tutors-Parents] WHERE " +
                "教员编号='" + tutors_num1 + "'"+ " ORDER BY (SELECT right(经办时间,10)) DESC";
            cmbd.bind(dgv_parents, mystr, "Tutors-Parents");
        }

        private void dgv_parents_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgv_parents.SelectedRows[0].Selected = false;
                dgv_parents.Rows[e.RowIndex].Selected = true;
            }
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_parents.SelectedRows.Count > 0)
            {
                string parents_num = dgv_parents.SelectedRows[0].Cells[0].Value.ToString();
                string print_num = dgv_parents.SelectedRows[0].Cells[1].Value.ToString();
                string mysql = "SELECT 接待人 FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string reception = mydb.Returnafield(mysql);
                mysql = "SELECT ID FROM [Parents] WHERE 打印编号='" + print_num + "'";
                string ID= mydb.Returnafield(mysql);
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
   

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_student_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_check_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("您确定要修改信息？", "操作提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
                return;
            if (result == DialogResult.OK)
            {
                if (txt_num.Text == "")
                {
                    MessageBox.Show("请输入教员编号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int i = mydb.Rownum("SELECT * FROM [Tutors] WHERE 教员编号='" + txt_num.Text.Trim() + "'");
                if (i > 0 && txt_num.Text.Trim() != tutors_num1)
                {
                    MessageBox.Show("该教员编号已存在，请重新输入教员编号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_num.Text = "";
                    return;
                }
                if (txt_student_name.Text == "")
                {
                    MessageBox.Show("请输入姓名！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_student_num.Text == "")
                {
                    MessageBox.Show("请输入学号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                i = mydb.Rownum("SELECT * FROM [Tutors] WHERE 学号='" + txt_student_num.Text.Trim() + "'");
                if (i > 0 && txt_student_num.Text.Trim() != student_num1)
                {
                    MessageBox.Show("该学号已存在，请重新输入学号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_student_num.Text = "";
                    return;
                }
                if (cbo_subject.Text == "")
                {
                    MessageBox.Show("请输入院系专业！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (cbo_degree.SelectedItem == null)
                {
                    MessageBox.Show("请选择在读学位！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_phone.Text == "")
                {
                    MessageBox.Show("请输入联系方式！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_phone.TextLength > 11)
                {
                    MessageBox.Show("联系方式不得超过11位！请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_phone.Text = "";
                    return;
                }
                i = mydb.Rownum("SELECT * FROM [Tutors] WHERE 联系方式='" + txt_phone.Text.Trim() + "'");
                if (i > 0 && txt_phone.Text.Trim() != phone1)
                {
                    MessageBox.Show("该联系方式已存在，请重新输入联系方式！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_phone.Text = "";
                    return;
                }
                if (txt_place.Text == "")
                {
                    MessageBox.Show("请输入生源地！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!rdo_man.Checked && !rdo_woman.Checked)
                {
                    MessageBox.Show("请选择性别！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string sex = "";
                if (rdo_man.Checked)
                    sex = rdo_man.Text;
                else
                    sex = rdo_woman.Text;
                string black = cbo_yesno.Text;
                string mysql = string.Format("UPDATE [Tutors] SET 姓名='{0}',学号='{1}',院系专业='{2}',在读学位='{3}'," +
                    "性别='{4}'," + "联系方式='{5}',生源地='{6}',是否黑名单='{7}',相关说明及监禁期='{8}'," +
                    "重要备注='{9}',教员编号='{10}' WHERE ID='{11}'" 
                   , txt_student_name.Text.Trim(), txt_student_num.Text.Trim(), cbo_subject.Text.Trim(), cbo_degree.Text, 
                    sex,txt_phone.Text.Trim(), txt_place.Text.Trim(),black,txt_imprisonment.Text.Trim(),
                    txt_important_remarks.Text.Trim(),txt_num.Text.Trim(),ID1);
                try
                {
                    mydb.ExecuteNonQuery(mysql);
                    MessageBox.Show("修改信息成功", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    SetTop();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Students_Revise_Load(object sender, EventArgs e)
        {
            CmbDataGridview cmbd = new CmbDataGridview();
            CCTRS ctr = new CCTRS();
            ctr.ColorDataGridView(dgv_parents);
            /*string mystr = "SELECT 家长编号,打印编号,经办状态,经办时间,经办人,处理备注 FROM [Tutors-Parents] WHERE " +
                "教员编号='" + tutors_num1 + "'"+ " ORDER BY (SELECT right(经办时间,10)) DESC";
            cmbd.bind(dgv_parents, mystr, "Tutors-Parents");*/
            string mystr = "SELECT 家长编号,打印编号,经办状态,经办时间,经办人,处理备注 FROM [Parents-tutors] WHERE " +
                "教员编号='" + tutors_num1 + "'" + " ORDER BY (SELECT right(经办时间,10)) DESC";
            cmbd.bind(dgv_parents, mystr, "Parents-tutors");
            dgv_parents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_parents.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txt_num.Text = tutors_num1;
            txt_student_name.Text = tutors_name1;
            txt_student_num.Text = student_num1;
            cmbc.cboDataBind(cbo_subject, "SELECT distinct 院系专业 FROM [Tutors]", "Tutors", "院系专业");
            cbo_subject.Text = grade_subject1;
            cbo_degree.Text = tutors_degree1;
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

        public SetTop2Handle SetTop;//定义委托实例 
        public Students_Revise(string ID,string tutors_num, string tutors_name, string student_num, string grade_subject,
            string tutors_degree, string sex, string phone, string place,string blacklist,string imprisonment,
            string remarks)
        {
            InitializeComponent();
            ID1 = ID;
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
    }
}
