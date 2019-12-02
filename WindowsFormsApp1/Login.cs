using System;
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
                    txtPwd.Text = "";
                    return;
                }
                else
                {
                    string mysql = string.Format("SELECT Level FROM [User] WHERE Username='{0}' AND Password='{1}'",
                        userName, password);
                    string level = mydb.Returnafield(mysql);
                    this.Hide();
                    Form myform = new Main(level);
                    myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                    myform.ShowDialog();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
