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
    public delegate void SetTopHandle(); //定义委托    
    public partial class Tutors_revise : Form
    {
        public bool flag = false;
        public bool flag_return = false;
        string ID1, parent_num1, print_num1, parent_name1, phone1, grade_subject1, student_sex1,
                    tutors_state1, time1, tutors_price1, tutors_time1, dadd1, important_mark1,
        payment_state1, payment_time1, level1;

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            CmbDataGridview cmbd = new CmbDataGridview();
            string mystr = "SELECT ID,教员编号,教员姓名,经办状态,经办时间,经办人,处理备注 FROM [Parents-Tutors] WHERE " +
                "打印编号='" + print_num1 + "' ORDER BY (SELECT right(经办时间,10)) DESC";
            cmbd.bind(dgv_tutors, mystr, "Parents-Tutors");
            if (level1 == "管理员")
            {
                dgv_tutors.ReadOnly = false;
            }
            else
            {
                删除本条记录ToolStripMenuItem.Visible = false;
              //  修改本条记录ToolStripMenuItem.Visible = false;
            }
        }

        private void txt_parent_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_print_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_tutor_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void 家教业务办理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_tutors.SelectedRows.Count > 0)
            {
                string tutors_num = dgv_tutors.SelectedRows[0].Cells[1].Value.ToString();
                string tutors_name = dgv_tutors.SelectedRows[0].Cells[2].Value.ToString();
                string state1 = dgv_tutors.SelectedRows[0].Cells[3].Value.ToString();
                string time = dgv_tutors.SelectedRows[0].Cells[4].Value.ToString();
                string principal = dgv_tutors.SelectedRows[0].Cells[5].Value.ToString();
                string remarks = dgv_tutors.SelectedRows[0].Cells[6].Value.ToString();
                //      string[] state = state1.Split(' ');
                //       string tempstate = state.Last();               
                Tutors_management myform = new Tutors_management(parent_num1, print_num1, tutors_num,
                    tutors_name, state1, time, principal, remarks, tutors_state1);
                myform.UpDate2 += new UpDateHandle2(myform_UpDate2);
                myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                myform.Show();
            }
        }

        private void dgv_tutors_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgv_tutors.SelectedRows[0].Selected = false;
                dgv_tutors.Rows[e.RowIndex].Selected = true;
            }
        }

        private void 删除本条记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要删除本条信息？", "操作提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            if (result == DialogResult.OK)
            {
                string selectedid = dgv_tutors.SelectedRows[0].Cells[0].Value.ToString();
                string mysql = "DELETE FROM [Parents-Tutors] WHERE ID = '" +
                                selectedid + "'";
                mydb.ExecuteNonQuery(mysql);
                CmbDataGridview cmbd = new CmbDataGridview();
                string mystr = "SELECT ID,教员编号,教员姓名,经办状态,经办时间,经办人,处理备注 FROM [Parents-Tutors] WHERE " +
                    "打印编号='" + print_num1 + "' ORDER BY (SELECT right(经办时间,10)) DESC";
                cmbd.bind(dgv_tutors, mystr, "Parents-Tutors");
                MessageBox.Show("删除成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void 修改本条记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgv_tutors_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要修改本单元格内容？", "操作提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                CmbDataGridview cmbd = new CmbDataGridview();
                string mystr = "SELECT ID,教员编号,教员姓名,经办状态,经办时间,经办人,处理备注 FROM [Parents-Tutors] WHERE " +
                    "打印编号='" + print_num1 + "' ORDER BY (SELECT right(经办时间,10)) DESC";
                cmbd.bind(dgv_tutors, mystr, "Parents-Tutors");
                return;
            }
            if (result == DialogResult.OK)
            {
                string selectedid = dgv_tutors.SelectedRows[0].Cells[0].Value.ToString();
                string tutors_num = dgv_tutors.SelectedRows[0].Cells[1].Value.ToString();
                string tutors_name = dgv_tutors.SelectedRows[0].Cells[2].Value.ToString();
                string state1 = dgv_tutors.SelectedRows[0].Cells[3].Value.ToString();
                string time = dgv_tutors.SelectedRows[0].Cells[4].Value.ToString();
                string principal = dgv_tutors.SelectedRows[0].Cells[5].Value.ToString();
                string remarks = dgv_tutors.SelectedRows[0].Cells[6].Value.ToString();
                CommDB mydb = new CommDB();
                string mysql = string.Format("UPDATE [Parents-Tutors] SET 教员编号='{0}',教员姓名='{1}',经办状态='{2}',经办时间='{3}'," +
                                    "经办人='{4}',处理备注='{5}' WHERE ID='{6}'", tutors_num, tutors_name, state1, time, principal, remarks, selectedid);
                mydb.ExecuteNonQuery(mysql);
                MessageBox.Show("修改成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetTop();
            }
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_tutors.SelectedRows.Count > 0)
            {
                string tutors_num = dgv_tutors.SelectedRows[0].Cells[1].Value.ToString();
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

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (dgv_tutors.SelectedRows.Count > 0)
            {
                string tutors_num = dgv_tutors.SelectedRows[0].Cells[1].Value.ToString();
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

        private void cbo_payment_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == true)
            {
                if (flag_return == true)
                {
                    flag_return = false;
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("您确定要修改缴费状态？", "操作提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.Cancel)
                    {
                        flag_return = true;
                        cbo_payment_state.SelectedItem = payment_state1;
                        return;
                    }

                    if (result == DialogResult.OK)
                    {
                        if (cbo_payment_state.SelectedItem.ToString() == "待缴" || cbo_payment_state.SelectedItem.ToString() == "无需缴纳"|| cbo_payment_state.SelectedItem.ToString() == "免管理费")
                        {
                            string mysql = "UPDATE [Parents] SET 缴费状态='" + cbo_payment_state.SelectedItem.ToString() +
                                "',缴费时间=NULL WHERE 打印编号='" + txt_print_num.Text.Trim() + "'";
                            mydb.ExecuteNonQuery(mysql);
                            dt_payment_time.Enabled = false;
                            payment_state1 = cbo_payment_state.SelectedItem.ToString();
                        }
                        if (cbo_payment_state.SelectedItem.ToString() == "已缴")
                        {

                            dt_payment_time.Enabled = true;
                            Payment myform = new Payment(parent_num1, print_num1, payment_state1);
                            myform.UpDate += new UpDateHandle(myform_UpDate);
                            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                            myform.Show();
                            payment_state1 = "已缴";
                        }

                        MessageBox.Show("修改成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        SetTop();
                    }
                }
            }
        }
        void myform_UpDate(string dt, string state)/////这里要改！！！
        {
            dt_payment_time.Value = DateTime.Parse(dt);
            cbo_payment_state.SelectedItem = state;
            SetTop();
        }
        private void btn_management_Click(object sender, EventArgs e)
        {
            string payment_state = cbo_payment_state.Text;
            Tutors_management myform = new Tutors_management(parent_num1, print_num1);
            myform.UpDate2 += new UpDateHandle2(myform_UpDate2);
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }
        void myform_UpDate2(string state, string time)
        {
            tutors_state1 = state;
            cbo_tutor_state.SelectedItem = state;
            time1 = time;
            /*  string mysql = "SELECT 教员编号,教员姓名,经办状态,经办时间,经办人,处理备注 FROM [Parents-Tutors] WHERE " +
                  "打印编号='" + print_num1 + "' ORDER BY 经办时间 DESC";
              DataSet mydataset = mydb.ExecuteQuery(mysql, "Parents-Tutors");
              dgv_tutors.DataSource = mydataset.Tables["Parents-Tutors"];
              CCTRS ctr = new CCTRS();
              ctr.ColorDataGridView(dgv_tutors);*/
            CmbDataGridview cmbd = new CmbDataGridview();
            string mystr = "SELECT ID,教员编号,教员姓名,经办状态,经办时间,经办人,处理备注 FROM [Parents-Tutors] WHERE " +
                "打印编号='" + print_num1 + "' ORDER BY (SELECT right(经办时间,10)) DESC";
            cmbd.bind(dgv_tutors, mystr, "Parents-Tutors");
            mystr = "UPDATE [Parents] SET 家教状态='" + tutors_state1 + "' WHERE ID='" + ID1 + "'";
            mydb.ExecuteNonQuery(mystr);
            SetTop();
            if (level1 == "管理员")
            {
                dgv_tutors.ReadOnly = false;
            }
            SetTop();
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CommDB mydb = new CommDB();
        private void lbl_recepiton_time_Click(object sender, EventArgs e)
        {

        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要修改信息？", "操作提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
                return;
            if (result == DialogResult.OK)
            {
                if (txt_parent_num.Text == "")
                {
                    MessageBox.Show("请输入家长编号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                /*           int i = mydb.Rownum("SELECT * FROM [Parents] WHERE 家长编号='" + txt_parent_num.Text.Trim() + "'");
                           if (i > 0&&txt_parent_num.Text.Trim()!=parent_num1)
                           {
                               MessageBox.Show("该家长编号已存在，请重新输入家长编号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                               txt_parent_num.Text = "";
                               return;
                           }*/
                if (txt_print_num.Text == "")
                {
                    MessageBox.Show("请输入打印编号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int i = mydb.Rownum("SELECT * FROM [Parents] WHERE 打印编号='" + txt_print_num.Text.Trim() + "'");
                if (i > 0 && txt_print_num.Text.Trim() != print_num1)
                {
                    MessageBox.Show("该打印编号已存在，请重新输入打印编号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_print_num.Text = "";
                    return;
                }
                if (cbo_reception.SelectedItem == null)
                {
                    MessageBox.Show("请选择接待人！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_parent_name.Text == "")
                {
                    MessageBox.Show("请输入家长称呼！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (txt_sadd.Text == "")
                {
                    MessageBox.Show("请输入家教地址（简单）！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_dadd.Text == "")
                {
                    MessageBox.Show("请输入家教地址（详细）！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_grade_subject.Text == "")
                {
                    MessageBox.Show("请输入年级科目！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!rdo_man.Checked && !rdo_woman.Checked)
                {
                    MessageBox.Show("请选择学员性别！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_tutor_price.Text == "")
                {
                    MessageBox.Show("请输入家教价格！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_tutor_time.Text == "")
                {
                    MessageBox.Show("请输入家教时间！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (cbo_tutor_state.SelectedItem == null)
                {
                    MessageBox.Show("请选择家教状态！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (cbo_payment_state.SelectedItem == null)
                {
                    MessageBox.Show("请选择缴费状态！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string reception = cbo_reception.Text;
                string student_sex = "";
                //        string payment_time = "";
                if (rdo_man.Checked)
                    student_sex = rdo_man.Text;
                else
                    student_sex = rdo_woman.Text;
                string sex = cbo_sex.Text;
                string payment_state = cbo_payment_state.Text;
                string tutors_state1 = cbo_tutor_state.Text;
                /*               if (dt_payment_time.Enabled == true)
                               {
                                   payment_time = dt_payment_time.Value.ToString();
                                   mysql = string.Format("UPDATE [Parents] SET 打印编号='{0}',接待人='{1}',接入时间='{2}',家长称呼='{3}'," +
                                       "联系方式='{4}'," + "家教地址简单='{5}',家教地址详细='{6}',年级科目='{7}',学员性别='{8}'," +
                                       "家教价格='{9}'," + "家教时间='{10}'," + "教员要求性别='{11}',教员要求地域='{12}',教员要求年级='{13}'," +
                                       "教员要求专业='{14}',教员要求其他='{15}'," + "家教状态='{16}',重要备注='{17}',缴费状态='{18}'," +
                                       "缴费时间='{19}',家长编号='{20}',经办时间='{21}' WHERE ID='{22}'", txt_print_num.Text.Trim(), reception, dt_recepiton_time.Value,
                                       txt_parent_name.Text.Trim(), txt_phone.Text.Trim(), txt_sadd.Text.Trim(), txt_dadd.Text.Trim(),
                                       txt_grade_subject.Text.Trim(), student_sex, txt_tutor_price.Text.Trim(), txt_tutor_time.Text.Trim(),
                                       sex, txt_place.Text.Trim(), txt_grade.Text.Trim(), txt_subject.Text.Trim(), txt_other_requests.Text.Trim(),
                                       tutors_state1, txt_important_remarks.Text.Trim(), payment_state, payment_time,
                                       txt_parent_num.Text.Trim(),time1, ID1);
                               }
                               else
                               {
                                   mysql = string.Format("UPDATE [Parents] SET 打印编号='{0}',接待人='{1}',接入时间='{2}',家长称呼='{3}'," +
                                       "联系方式='{4}'," + "家教地址简单='{5}',家教地址详细='{6}',年级科目='{7}',学员性别='{8}'," +
                                       "家教价格='{9}'," + "家教时间='{10}'," + "教员要求性别='{11}',教员要求地域='{12}',教员要求年级='{13}'," +
                                       "教员要求专业='{14}',教员要求其他='{15}'," + "家教状态='{16}',重要备注='{17}',缴费状态='{18}'," +
                                       "家长编号='{19}',经办时间='{20}' WHERE ID='{21}'", txt_print_num.Text.Trim(), reception, dt_recepiton_time.Value,
                                       txt_parent_name.Text.Trim(), txt_phone.Text.Trim(), txt_sadd.Text.Trim(), txt_dadd.Text.Trim(),
                                       txt_grade_subject.Text.Trim(), student_sex, txt_tutor_price.Text.Trim(), txt_tutor_time.Text.Trim(),
                                       sex, txt_place.Text.Trim(), txt_grade.Text.Trim(), txt_subject.Text.Trim(), txt_other_requests.Text.Trim(),
                                       tutors_state1, txt_important_remarks.Text.Trim(), payment_state, 
                                       txt_parent_num.Text.Trim(),time1, ID1);
                               }*/
                string mysql = string.Format("UPDATE [Parents] SET 打印编号='{0}',接待人='{1}',接入时间='{2}',家长称呼='{3}'," +
                        "联系方式='{4}'," + "家教地址简单='{5}',家教地址详细='{6}',年级科目='{7}',学员性别='{8}'," +
                        "家教价格='{9}'," + "家教时间='{10}'," + "教员要求性别='{11}',教员要求地域='{12}',教员要求年级='{13}'," +
                        "教员要求专业='{14}',教员要求其他='{15}'," + "家教状态='{16}',重要备注='{17}',缴费状态='{18}'," +
                        "家长编号='{19}',经办时间='{20}' WHERE ID='{21}'", txt_print_num.Text.Trim(), reception, dt_recepiton_time.Value,
                        txt_parent_name.Text.Trim(), txt_phone.Text.Trim(), txt_sadd.Text.Trim(), txt_dadd.Text.Trim(),
                        txt_grade_subject.Text.Trim(), student_sex, txt_tutor_price.Text.Trim(), txt_tutor_time.Text.Trim(),
                        sex, txt_place.Text.Trim(), txt_grade.Text.Trim(), txt_subject.Text.Trim(), txt_other_requests.Text.Trim(),
                        tutors_state1, txt_important_remarks.Text.Trim(), payment_state, txt_parent_num.Text.Trim(), time1, ID1);
                try
                {
                    mydb.ExecuteNonQuery(mysql);
                    MessageBox.Show("修改家教信息成功", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // this.Close();
                    SetTop();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


        }

        private void Tutors_revise_Load(object sender, EventArgs e)
        {
            CmbClass cmbc = new CmbClass();
            cmbc.cboDataBind(cbo_reception, "SELECT distinct 姓名 FROM [Workers]", "Workers", "姓名");
            CmbDataGridview cmbd = new CmbDataGridview();
            CCTRS ctr = new CCTRS();
            ctr.ColorDataGridView(dgv_tutors);
            string mystr = "SELECT ID,教员编号,教员姓名,经办状态,经办时间,经办人,处理备注 FROM [Parents-Tutors] WHERE " +
                "打印编号='" + print_num1 + "' ORDER BY (SELECT right(经办时间,10)) DESC";
            cmbd.bind(dgv_tutors, mystr, "Parents-Tutors");
            dgv_tutors.Columns[0].Visible = false;
            dgv_tutors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_tutors.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
            flag = true;
            if (level1 == "管理员")
            {
                dgv_tutors.ReadOnly = false;
            }
            else
            {
                删除本条记录ToolStripMenuItem.Visible = false;
            }
        }
        public SetTopHandle SetTop;//定义委托实例 
        public Tutors_revise(string level, string ID, string parent_num, string print_num, string parent_name, string phone,
            string grade_subject, string student_sex, string tutors_state, string time, string tutors_price,
            string tutors_time, string dadd, string important_mark, string payment_state, string payment_time)
        {
            InitializeComponent();
            level1 = level;
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
