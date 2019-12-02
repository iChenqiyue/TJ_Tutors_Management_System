using System;
using System.Windows.Forms;

namespace TJ_Tutors_Management_System
{    
    public partial class Tutors_Add : Form
    {

        public Tutors_Add()
        {
            InitializeComponent();
        }

        private void 家教编号_Click(object sender, EventArgs e)
        {

        }
        public SetTopHandle SetTop;//定义委托实例 
        private void label2_Click(object sender, EventArgs e)
        {

        }
        CommDB mydb = new CommDB();
        private void btnyes_Click(object sender, EventArgs e)
        {
            if (txt_parent_num.Text == "")
            {
                MessageBox.Show("请输入家长编号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int i = mydb.Rownum("SELECT * FROM [Parents] WHERE 家长编号='" + txt_parent_num.Text.Trim() + "'AND 打印编号='" + txt_print_num.Text.Trim() + "'");
            if (i > 0)
            {
                MessageBox.Show("该家长编号已存在，请重新输入家长编号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_parent_num.Text = "";
                return;
            }
            if (txt_print_num.Text == "")
            {
                MessageBox.Show("请输入打印编号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            i = mydb.Rownum("SELECT * FROM [Parents] WHERE 打印编号='" + txt_print_num.Text.Trim() + "'");
            if (i > 0)
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

            string mysql;
            string reception = cbo_reception.Text;
            string student_sex = "";
            string payment_time = "";
            if (rdo_man.Checked)
                student_sex = rdo_man.Text;
            else
                student_sex = rdo_woman.Text;
            string sex;
            if (cbo_sex.SelectedItem == null)
                sex = "";
            else
                sex = cbo_sex.SelectedItem.ToString();
            string tutor_state = cbo_tutor_state.SelectedItem.ToString();
            string payment_state = cbo_payment_state.SelectedItem.ToString();
            string temptime = dt_recepiton_time.Value.ToString("yyyy/MM/dd");
            if (dt_payment_time.Enabled == true)
            {
                payment_time = dt_payment_time.Value.ToString();
                mysql = string.Format("INSERT INTO [Parents] (家长编号,打印编号,接待人,接入时间,家长称呼,联系方式," +
                    "家教地址简单,家教地址详细,年级科目,学员性别,家教价格,家教时间," +
                    "教员要求性别,教员要求地域,教员要求年级,教员要求专业,教员要求其他," +
                    "家教状态,重要备注,缴费状态,缴费时间,经办时间,进行状态) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'," +
                    "'{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}')",
                    txt_parent_num.Text.Trim(), txt_print_num.Text.Trim(), reception, dt_recepiton_time.Value,
                    txt_parent_name.Text.Trim(), txt_phone.Text.Trim(), txt_sadd.Text.Trim(), txt_dadd.Text.Trim(),
                    txt_grade_subject.Text.Trim(), student_sex, txt_tutor_price.Text.Trim(), txt_tutor_time.Text.Trim(),
                    sex, txt_place.Text.Trim(), txt_grade.Text.Trim(), txt_subject.Text.Trim(), txt_other_requests.Text.Trim(),
                    tutor_state, txt_important_remarks.Text.Trim(), payment_state, payment_time, temptime, "接入");
            }
            else
                mysql = string.Format("INSERT INTO [Parents] (家长编号,打印编号,接待人,接入时间,家长称呼,联系方式," +
                    "家教地址简单,家教地址详细,年级科目,学员性别,家教价格,家教时间," +
                    "教员要求性别,教员要求地域,教员要求年级,教员要求专业,教员要求其他," +
                    "家教状态,重要备注,缴费状态,经办时间,进行状态) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'," +
                    "'{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}')",
                    txt_parent_num.Text.Trim(), txt_print_num.Text.Trim(), reception, dt_recepiton_time.Value,
                    txt_parent_name.Text.Trim(), txt_phone.Text.Trim(), txt_sadd.Text.Trim(), txt_dadd.Text.Trim(),
                    txt_grade_subject.Text.Trim(), student_sex, txt_tutor_price.Text.Trim(), txt_tutor_time.Text.Trim(),
                    sex, txt_place.Text.Trim(), txt_grade.Text.Trim(), txt_subject.Text.Trim(), txt_other_requests.Text.Trim(),
                    tutor_state, txt_important_remarks.Text.Trim(), payment_state, temptime, "接入");
            try
            {
                mydb.ExecuteNonQuery(mysql);
                MessageBox.Show("添加家教信息成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mysql = string.Format("INSERT INTO [Responsibility] (家长编号,打印编号,经办状态,经办时间,经办人) VALUES ('{0}'," +
                    "'{1}','{2}','{3}','{4}')", txt_parent_num.Text.Trim(), txt_print_num.Text.Trim(),
                    tutor_state, temptime, reception);
                mydb.ExecuteNonQuery(mysql);
                Integral itg = new Integral();
                itg.Add(reception, tutor_state);
                mysql = string.Format("INSERT INTO [Parents-Tutors] (家长编号,打印编号,教员编号,教员姓名,经办状态,经办时间,经办人) VALUES ('{0}'," +
                              "'{1}','{2}','{3}','{4}','{5}','{6}')", txt_parent_num.Text.Trim(), txt_print_num.Text.Trim(), "", "",
                              tutor_state, temptime, reception);
                mydb.ExecuteNonQuery(mysql);

                txt_parent_name.Text = "";

                cbo_reception.SelectedItem = null;
                txt_phone.Text = "";
                txt_sadd.Text = "";
                txt_dadd.Text = "";
                txt_grade_subject.Text = "";
                txt_grade.Text = "";
                cbo_sex.SelectedItem = null;
                txt_other_requests.Text = "";
                rdo_man.Checked = false;
                rdo_woman.Checked = false;
                txt_tutor_price.Text = "";
                txt_tutor_time.Text = "";
                cbo_sex.Text = "";
                txt_place.Text = "";
                txt_grade.Text = "";
                txt_subject.Text = "";
                txt_important_remarks.Text = "";
                mysql = "SELECT MAX(家长编号) FROM [parents]";
                int parents_num = int.Parse(mydb.Returnafield(mysql));
                parents_num++;
                txt_parent_num.Text = parents_num.ToString();
                mysql = "SELECT MAX(打印编号) FROM [parents]";
                int print_num = int.Parse(mydb.Returnafield(mysql));
                print_num++;
                txt_print_num.Text = print_num.ToString();
                SetTop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cbo_reception_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tutors_Add_Load(object sender, EventArgs e)
        {
            CmbClass cmbc = new CmbClass();
            cmbc.cboDataBind(cbo_reception, "SELECT distinct 姓名 FROM [Workers]", "Workers", "姓名");
            cbo_reception.SelectedItem = null;
            cbo_tutor_state.SelectedItem = "接入";
            string mysql = "SELECT MAX(家长编号) FROM [parents]";
            int parents_num = int.Parse(mydb.Returnafield(mysql));
            parents_num++;
            txt_parent_num.Text = parents_num.ToString();
            mysql = "SELECT MAX(打印编号) FROM [parents]";
            int print_num = int.Parse(mydb.Returnafield(mysql));
            print_num++;
            txt_print_num.Text = print_num.ToString();
        }

        private void cbo_payment_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_payment_state.SelectedItem.ToString() == "待缴" || cbo_payment_state.SelectedItem.ToString() == "无需缴纳")
            {
                dt_payment_time.Enabled = false;
            }
            if (cbo_payment_state.SelectedItem.ToString() == "已缴")
            {
                dt_payment_time.Enabled = true;
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
