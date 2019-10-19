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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string password = txtPwd.Text;
            CommDB mydb = new CommDB();
            string mystr;
            mystr = string.Format("select * from [User] where Username='{0}' and Password='{1}'", userName, password);
            try
            {
                int i = mydb.Rownum(mystr);
                if (i == 0)
                {
                    MessageBox.Show("您输入的用户名或密码错误！请重试", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    this.Hide();
                    Form myform = new Main();
                    myform.ShowDialog();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
