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
    public partial class Users_Add : Form
    {
        int num1;
        string user1, password1, level1;
        public Users_Add(int num)
        {
            
            InitializeComponent();
            num1 = num;
        }
        public Users_Add(int num,string user,string password,string level)
        {
            InitializeComponent();
            num1 = num;
            user1 = user;
            password1 = password;
            level1 = level;
        }
        CommDB mydb = new CommDB();

        private void btn_cannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            string mysql="";
            if (txt_user.Text == "")
            {
                MessageBox.Show("请输入用户名！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (num1 == 1)
            {
                mysql = "SELECT * FROM [User] WHERE Username='" + txt_user.Text.Trim() + "'";
                int i = mydb.Rownum(mysql);
                if (i > 0)
                {
                    MessageBox.Show("该用户名已存在！请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (txt_password.Text == "")
            {
                MessageBox.Show("请输入密码！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(num1==1)
            mysql = string.Format("INSERT INTO [User] (Username,Password,Level) VALUES ('{0}','{1}','{2}')",
                txt_user.Text.Trim(), txt_password.Text.Trim(), cbo_level.Text);
            if (num1 == 2)
                mysql = string.Format("UPDATE [User] SET Password='{0}',level='{1}' WHERE Username='{2}'",
                    txt_password.Text.Trim(), cbo_level.Text, txt_user.Text.Trim());
            try
            {
                mydb.ExecuteNonQuery(mysql);
                if (num1 == 1)
                {
                    MessageBox.Show("添加成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txt_password.Text = "";
                    txt_user.Text = "";
                    this.Close();
                }
                if (num1 == 2)
                {
                    MessageBox.Show("修改成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
    }

        private void Users_Add_Load(object sender, EventArgs e)
        {
            if (num1 == 2)
            {
                txt_user.Text = user1;
                txt_user.Enabled = false;
                txt_password.Text = password1;
                cbo_level.SelectedItem = level1;
            }
        }
    }
}
