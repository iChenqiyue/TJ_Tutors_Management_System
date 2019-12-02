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
    public delegate void SetTop3Handle(); //定义委托  
    public partial class Workers_Revise : Form
    {
        string ID1,name1, sex1, student_num1, subject1, phone1, position1,month1,sum1;
        CommDB mydb = new CommDB();

        private void txt_month_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_sum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        CmbClass cmbc = new CmbClass();
        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_student_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Workers_Revise_Load(object sender, EventArgs e)
        {
            txt_name.Text = name1;
            if (sex1 == "男")
                rdo_man.Checked = true;
            if (sex1 == "女")
                rdo_woman.Checked = true;
            txt_student_num.Text = student_num1;
            cbo_subject.Text = subject1;
            cmbc.cboDataBind(cbo_subject, "SELECT distinct 院系专业 FROM [Workers]", "Workers", "院系专业");
            txt_phone.Text = phone1;
            txt_position.Text = position1;
            txt_month.Text = month1;
            txt_sum.Text = sum1;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要修改信息？", "操作提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
                return;
            if (result == DialogResult.OK)
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("请输入工作人员姓名！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!rdo_man.Checked && !rdo_woman.Checked)
                {
                    MessageBox.Show("请选择性别！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_student_num.Text == "")
                {
                    MessageBox.Show("请输入学号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int i = mydb.Rownum("SELECT * FROM [Workers] WHERE 学号='" + txt_student_num.Text.Trim() + "'");
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
                i = mydb.Rownum("SELECT * FROM [Workers] WHERE 联系方式='" + txt_phone.Text.Trim() + "'");
                if (i > 0 && txt_phone.Text.Trim() != phone1)
                {
                    MessageBox.Show("该联系方式已存在，请重新输入联系方式！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_phone.Text = "";
                    return;
                }
                if (txt_month.Text == "")
                {
                    MessageBox.Show("请输入本月业务积分！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_sum.Text == "")
                {
                    MessageBox.Show("请输入累计业务积分！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string sex;
                if (rdo_man.Checked)
                    sex = rdo_man.Text;
                else
                    sex = rdo_woman.Text;
                string mysql = string.Format("UPDATE [Workers] SET 姓名='{0}',性别='{1}',学号='{2}',院系专业='{3}'," +
                    "联系方式='{4}'," + "职位='{5}',本月业务积分='{6}',累计业务积分='{7}' WHERE ID='{8}'", txt_name.Text.Trim(), sex, txt_student_num.Text.Trim(),
                    cbo_subject.Text.Trim(), txt_phone.Text.Trim(), txt_position.Text.Trim(),txt_month.Text.Trim(),
                    txt_sum.Text.Trim(),ID1);
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
        public SetTop3Handle SetTop;//定义委托实例 
        public Workers_Revise(string ID,string name, string sex, string student_num, string subject, string phone,
            string position,string month,string sum)
        {
            InitializeComponent();
            ID1 = ID;
            name1 = name;
            sex1 = sex;
            student_num1 = student_num;
            subject1 = subject;
            phone1 = phone;
            position1 = position;
            month1 = month;
            sum1 = sum;
        }
    }
}
