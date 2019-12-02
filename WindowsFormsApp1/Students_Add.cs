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
    public partial class Students_Add : Form
    {
        public SetTop2Handle SetTop;//定义委托实例 
        public Students_Add()
        {
            InitializeComponent();
        }
        CommDB mydb = new CommDB();
        CmbClass cmbc = new CmbClass();
        private void btn_check_Click(object sender, EventArgs e)
        {

            if (txt_num.Text == "")
            {
                MessageBox.Show("请输入教员编号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int i = mydb.Rownum("SELECT * FROM [Tutors] WHERE 教员编号='" + txt_num.Text.Trim() + "'");
            if (i > 0)
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
            if (!rdo_man.Checked && !rdo_woman.Checked)
            {
                MessageBox.Show("请选择性别！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (i > 0)
            {
                MessageBox.Show("该联系方式已存在，请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_phone.Text = "";
                return;
            }
            if (txt_place.Text == "")
            {
                MessageBox.Show("请输入生源地！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            string sex;
            if (rdo_man.Checked)
                sex = rdo_man.Text;
            else
                sex = rdo_woman.Text;
            string mysql;
            mysql = string.Format("INSERT INTO [Tutors] (教员编号,姓名,学号,院系专业,在读学位,性别,联系方式,生源地," +
                "重要备注,是否黑名单) VALUES " + "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                txt_num.Text.Trim(), txt_student_name.Text.Trim(), txt_student_num.Text.Trim(), cbo_subject.Text.Trim(),
                cbo_degree.Text, sex, txt_phone.Text.Trim(), txt_place.Text.Trim(), txt_important_remarks.Text.Trim(),
                "否");
            try
            {
                mydb.ExecuteNonQuery(mysql);
                MessageBox.Show("添加信息成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                i = mydb.Rownum("SELECT * FROM [Subject] WHERE 专业='" +cbo_subject.Text.Trim() + "'");
                if (i == 0)
                {
                    mysql = "INSERT INTO [Subject] (专业) VALUES ('" + cbo_subject.Text.Trim() + "')";
                    mydb.ExecuteNonQuery(mysql);
                }
                SetTop();
                txt_student_name.Text = "";
                txt_student_num.Text = "";                
                cbo_degree.SelectedItem = null;
                rdo_man.Checked = false;
                rdo_woman.Checked = false;
                txt_phone.Text = "";
                txt_place.Text = "";
                txt_important_remarks.Text = "";
                cmbc.cboDataBind(cbo_subject, "SELECT distinct 院系专业 FROM [Tutors]", "Tutors", "院系专业");
                cbo_subject.Text = "";
                mysql = "SELECT MAX(教员编号) FROM [Tutors]";
                int tutors_num = int.Parse(mydb.Returnafield(mysql));
                tutors_num++;
                txt_num.Text = tutors_num.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void 新增教员信息_Load(object sender, EventArgs e)
        {
            cbo_degree.SelectedItem = null;
            cmbc.cboDataBind(cbo_subject, "SELECT distinct 院系专业 FROM [Tutors]", "Tutors", "院系专业");
            cbo_subject.Text = "";
            string mysql = "SELECT MAX(教员编号) FROM [Tutors]";
            int tutors_num = int.Parse(mydb.Returnafield(mysql));
            tutors_num++;
            txt_num.Text = tutors_num.ToString();
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

        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
