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
    public delegate void UpDateHandle2(string state,string time); //定义委托  
     
    public partial class Tutors_management : Form
    {
        public UpDateHandle2 UpDate2;

        string parent_num1, print_num1, tutors_num1, tutors_name1, state1, time1, principal1,
            ID, ID2, remarks1, tempstate;
        bool flag = false,flag2=false;
        CommDB mydb = new CommDB();//

        private void cbo_tutors_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        

        private void cbo_tutors_num_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag2 == true)//初始化完成
           {
                tutors_num1 = cbo_tutors_num.Text.Trim();
                if (tutors_num1 == "")
                {
                    txt_tutors_name.Text = "";
                    return;
                }
                else
                {
                    string mysql = "SELECT 姓名 FROM [Tutors] WHERE 教员编号 = '" + tutors_num1 + "'";
                    tutors_name1 = mydb.Returnafield(mysql);
                    mysql = string.Format("SELECT * FROM [Parents-Tutors] WHERE 打印编号='{0}' AND 教员编号='{1}'", print_num1, tutors_num1);
                    int i = mydb.Rownum(mysql);
                    if (i > 0)//该家教经手过这份家教
                    {
                        mysql = string.Format("SELECT ID FROM [Parents-Tutors] WHERE ID="
                            + "(SELECT MAX(ID) FROM [Parents-Tutors] WHERE 打印编号='{0}' AND 教员编号='{1}')", print_num1, tutors_num1);//找到最新一条该教员关于该份家教的ID
                        ID = mydb.Returnafield(mysql);
                        txt_tutors_name.Text = tutors_name1;
                        mysql = "SELECT 经办状态 FROM [Parents-Tutors] WHERE ID= '" + ID + "'";
                        state1 = mydb.Returnafield(mysql);
                        string[] state = state1.Split(' ');
                        cbo_state.SelectedItem = state.Last();
                        tempstate = state.Last();
                        mysql = "SELECT 经办人 FROM [Parents-Tutors] WHERE ID= '" + ID + "'";
                        principal1 = mydb.Returnafield(mysql);
                        mysql = "SELECT 经办时间 FROM [Parents-Tutors] WHERE ID= '" + ID + "'";
                        time1 = mydb.Returnafield(mysql);
                        mysql = "SELECT 处理备注 FROM [Parents-Tutors] WHERE ID= '" + ID + "'";
                        remarks1 = mydb.Returnafield(mysql);
                        txt_remark.Text = remarks1;
                        flag = true;//记录存在
                    }
                }
            }
        }

        private void dt_time_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_inquire_Click(object sender, EventArgs e)
        {
            Students_Inquire myform = new Students_Inquire(2);
            myform.UpDate3 += new UpDateHandle3(myform_UpDate3);
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }
        void myform_UpDate3(string num,string name)
        {
            cbo_tutors_num.Text = num;
            txt_tutors_name.Text = name;
        }
        private void cbo_principal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Tutors_management(string parent_num, string print_num)
        {
            InitializeComponent();
            parent_num1 = parent_num;
            print_num1 = print_num;            
            
        }
        public Tutors_management(string parent_num, string print_num,string tutors_num, string tutors_name, 
            string state, string time,string principal, string remarks,string tutors_state)
        {
            InitializeComponent();
            parent_num1 = parent_num;
            print_num1 = print_num;
            tutors_num1 = tutors_num;
            tutors_name1 = tutors_name;
            state1 = state;
            remarks1 = remarks;
            time1 = time;
            principal1 = principal;
            cbo_tutors_state.SelectedItem = tutors_state;
        }
        private void Tutors_management_Load(object sender, EventArgs e)
        {
            CmbClass cmbc = new CmbClass();
            cmbc.cboDataBind(cbo_principal, "SELECT distinct 姓名 FROM [Workers]", "Workers", "姓名");
            cbo_principal.SelectedItem = null;
            txt_printnum.Text = print_num1;
            string mysql = string.Format("SELECT distinct 教员编号 FROM [Parents-Tutors] WHERE 家长编号='{0}' " +
                "AND 打印编号='{1}'", parent_num1, print_num1);
            cmbc.cboDataBind(cbo_tutors_num, mysql, "Parents-Tutors", "教员编号");
            flag2 = true;
            if (tutors_num1 != "")
                cbo_tutors_num.Text = tutors_num1;    
        }

        private void btn_cannel_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            
            if (cbo_principal.Text == "")
            {
                MessageBox.Show("请选择经办人！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(cbo_tutors_state.SelectedItem==null)
            {
                MessageBox.Show("请选择家教状态！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            remarks1 = txt_remark.Text.Trim();

            DialogResult result = MessageBox.Show("确认办理？", "操作提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                
                    state1 += " " + cbo_state.Text;
                    principal1 += " " + cbo_principal.Text;
                    time1 += " " + dt_time.Value.ToString("yyyy/MM/dd");
             
                    string mysql = string.Format("UPDATE [Parents] SET 家教状态='{0}',经办时间='{1}' WHERE " +
                    "ID='{2}'", cbo_tutors_state.Text, dt_time.Value.ToString("yyyy/MM/dd"),ID);
                 
                try
                {
                    mydb.ExecuteNonQuery(mysql);
                    MessageBox.Show("办理成功！请注意修改缴费状态！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    mysql = string.Format("INSERT INTO [Responsibility] (家长编号,打印编号,经办状态,经办时间,经办人,处理备注) " +
                        "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                        parent_num1, print_num1, cbo_state.Text, dt_time.Value.ToString("yyyy/MM/dd"), cbo_principal.Text,
                        txt_remark.Text.Trim());
                    mydb.ExecuteNonQuery(mysql);                    
                    Integral itg = new Integral();
                    itg.Add(cbo_principal.Text, cbo_state.Text);
                    
                        if (((tempstate=="接入"||tempstate == "换人" || tempstate == "不请" || tempstate == "重请")
                        && (cbo_state.Text == "已接" || cbo_state.Text == "待接"))||flag==false)
                        {
                            state1 = cbo_state.Text;

                            time1 = dt_time.Value.ToString("yyyy/MM/dd");

                            principal1 = cbo_principal.Text;

                            mysql = string.Format("INSERT INTO [Parents-Tutors] (家长编号,打印编号,经办状态,经办时间,经办人," +
                            "处理备注,教员编号,教员姓名) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", parent_num1, print_num1, state1,
                            time1, principal1, txt_remark.Text.Trim(), cbo_tutors_num.Text.Trim(),txt_tutors_name.Text.Trim());
                        
                            
                    }
                        else if(flag==true)
                        {

                            mysql = string.Format("UPDATE [Parents-Tutors] SET 经办状态='{0}',经办时间='{1}',经办人='{2}',处理备注='{3}'" +
                                "WHERE ID='{4}'", state1, time1, principal1, txt_remark.Text.Trim(), ID);
                        }
                    else { }
                    mydb.ExecuteNonQuery(mysql);
                    mysql = string.Format("SELECT ID FROM [Tutors-Parents] WHERE 教员编号='{0}' AND 打印编号='{1}' "
                    , cbo_tutors_num.Text.Trim(), print_num1);//查询该教员是否有接手记录
                    int  i = mydb.Rownum(mysql);
                    if (i > 0)
                    {
                        mysql = string.Format("SELECT ID FROM [Tutors-Parents] WHERE ID= " +
                    "(SELECT MAX(ID) FROM [Tutors-Parents] WHERE 教员编号='{0}' AND 打印编号='{1}') "//找到最新一条的记录
                , cbo_tutors_num.Text.Trim(), print_num1);
                        ID2 = mydb.Returnafield(mysql);
                        mysql = string.Format("UPDATE [Tutors-Parents] SET 家长编号='{0}',打印编号='{1}',经办状态='{2}',经办时间='{3}',经办人='{4}',处理备注='{5}'" +
                                "WHERE ID='{6}'", parent_num1,print_num1, state1, time1, principal1, txt_remark.Text.Trim(), ID2);

                    }
                    else
                    {
                        mysql = string.Format("INSERT INTO [Tutors-Parents] (家长编号,打印编号,经办状态,经办时间,经办人," +
                        "处理备注,教员编号) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", parent_num1, print_num1, state1,
                        time1, principal1, txt_remark.Text.Trim(),cbo_tutors_num.Text.Trim());
                    }
                    mydb.ExecuteNonQuery(mysql);
                    this.Close();
                    UpDate2(cbo_tutors_state.SelectedItem.ToString(), dt_time.Value.ToString("yyyy/MM/dd"));
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void txt_tutors_num_Leave(object sender, EventArgs e)
        {

        }

        private void txt_student_num_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
