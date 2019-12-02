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
    public partial class Workers_Add : Form
    {
        public Workers_Add()
        {
            InitializeComponent();
        }
        CommDB mydb = new CommDB();
        CmbClass cmbc = new CmbClass();
        private void btn_check_Click(object sender, EventArgs e)
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
            if (i > 0)
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
            i = mydb.Rownum("SELECT * FROM [Workers] WHERE 联系方式='" + txt_phone.Text.Trim() + "'");
            if (txt_phone.TextLength > 11)
            {
                MessageBox.Show("联系方式不得超过11位！请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_phone.Text = "";
                return;
            }
            if (i > 0)
            {
                MessageBox.Show("该联系方式已存在，请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_phone.Text = "";
                return;
            }
            string sex;
            if (rdo_man.Checked)
                sex = rdo_man.Text;
            else
                sex = rdo_woman.Text;
            string mysql;
            mysql = string.Format("INSERT INTO [Workers] (姓名,性别,学号,院系专业,联系方式,职位) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}')", txt_name.Text.Trim(), sex, txt_student_num.Text.Trim(),
                cbo_subject.Text.Trim(), txt_phone.Text.Trim(), txt_position.Text.Trim());
            try
            {
                mydb.ExecuteNonQuery(mysql);
                MessageBox.Show("添加信息成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                i = mydb.Rownum("SELECT * FROM [Subject] WHERE 专业='" + cbo_subject.Text.Trim() + "'");
                if (i == 0)
                {
                    mysql = "INSERT INTO [Subject] (专业) VALUES ('" + cbo_subject.Text.Trim() + "')";
                    mydb.ExecuteNonQuery(mysql);
                }
                cmbc.cboDataBind(cbo_subject, "SELECT distinct 院系专业 FROM [Workers]", "Workers", "院系专业");
                txt_name.Text = "";
                rdo_man.Checked = false;
                rdo_woman.Checked = false;
                txt_student_num.Text = "";
                cbo_subject.Text = "";
                txt_phone.Text = "";
                txt_position.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

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

        private void Workers_Add_Load(object sender, EventArgs e)
        {
            cmbc.cboDataBind(cbo_subject, "SELECT distinct 院系专业 FROM [Workers]", "Workers", "院系专业");
            cbo_subject.Text = "";
        }
    }
}
