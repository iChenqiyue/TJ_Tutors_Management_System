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
    public delegate void UpDateHandle(string dt,string state); //定义委托  
    
    public partial class Payment : Form
    {
        public UpDateHandle UpDate;
        //定义委托实例 
        string parent_num1, print_num1,state1;
        CommDB mydb = new CommDB();
        private void btn_yes_Click(object sender, EventArgs e)
        {
            string dt = dt_payment_time.Value.ToString("yyyy/MM/dd HH:mm");
            if (cbo_principal.Text == "")
            {
                MessageBox.Show("请选择经办人！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string reception = cbo_principal.Text;
            string mysql;
            mysql = string.Format("UPDATE [Parents] SET 缴费状态='已缴',缴费时间='{0}',经办时间='{1}',经办人='{2}' " +
                "WHERE 打印编号='{3}'",
                dt, dt_time.Value, reception,txt_print_num.Text.Trim());
            try
            {
                mydb.ExecuteNonQuery(mysql);
                MessageBox.Show("缴费成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mysql=string.Format("INSERT INTO [Responsibility] (家长编号,打印编号,经办状态,经办时间,经办人) VALUES " +
                    "('{0}','{1}','{2}','{3}','{4}')", parent_num1, print_num1, "缴费", dt_time.Value, cbo_principal.Text);
                mydb.ExecuteNonQuery(mysql);
                
                string state = "已缴";
                UpDate(dt_payment_time.Value.ToString("yyyy/MM/dd"), state);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txt_parent_num.Text = parent_num1;
            txt_print_num.Text = print_num1;
            cbo_state.SelectedItem = "已缴";
            cbo_state.Enabled = false;
            CmbClass cmbc = new CmbClass();
            cmbc.cboDataBind(cbo_principal, "SELECT distinct 姓名 FROM [Workers]", "Workers", "姓名");
            cbo_principal.SelectedItem = null;
        }

        private void btn_cannel_Click(object sender, EventArgs e)
        {
            this.Close();
            string dt = dt_payment_time.Value.ToString();
            string state = state1;
            UpDate(dt,state);
        }
        
        public Payment(string parent_num,string print_num,string state)
        {
            InitializeComponent();
            parent_num1 = parent_num;
            print_num1 = print_num;
            state1 = state;
        }
    }
}
