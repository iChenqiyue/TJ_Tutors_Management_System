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
    public partial class Users_All : Form
    {
        public Users_All()
        {
            InitializeComponent();
        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        CCTRS ctrs = new CCTRS();
        CmbDataGridview cmbd = new CmbDataGridview();
        private void Users_All_Load(object sender, EventArgs e)
        {
            
            ctrs.ColorDataGridView(dgv_users);
            
            cmbd.bind(dgv_users, "SELECT * FROM [User]", "User");
            dgv_users.Columns[0].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form myform = new Users_Add(1);
            myform.Show();
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            cmbd.bind(dgv_users, "SELECT * FROM [User]", "User");
        }

        private void btn_revise_Click(object sender, EventArgs e)
        {
            string username = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
            string password = dgv_users.SelectedRows[0].Cells[2].Value.ToString();
            string level = dgv_users.SelectedRows[0].Cells[3].Value.ToString();
            Form myform = new Users_Add(2,username,password,level);
            myform.Show();
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            cmbd.bind(dgv_users, "SELECT * FROM [User]", "User");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            try
            {
                if (dgv_users.SelectedRows.Count > 0)
                {
                    result = MessageBox.Show("是否删除选中项？", "操作提示",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        CommDB mydb = new CommDB();
                        string mysql = "DELETE FROM [User] WHERE Username = '" +
                            dgv_users.SelectedRows[0].Cells[1].Value.ToString() + "'";
                        mydb.ExecuteNonQuery(mysql);
                        MessageBox.Show("删除成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cmbd.bind(dgv_users, "SELECT * FROM [User]", "User");
        }

        private void btn_cannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string username = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
            string password = dgv_users.SelectedRows[0].Cells[2].Value.ToString();
            string level = dgv_users.SelectedRows[0].Cells[3].Value.ToString();
            Form myform = new Users_Add(2, username, password, level);
            myform.Show();
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            cmbd.bind(dgv_users, "SELECT * FROM [User]", "User");
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            try
            {
                if (dgv_users.SelectedRows.Count > 0)
                {
                    result = MessageBox.Show("是否删除选中项？", "操作提示",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        CommDB mydb = new CommDB();
                        string mysql = "DELETE FROM [User] WHERE Username = '" +
                            dgv_users.SelectedRows[0].Cells[1].Value.ToString() + "'";
                        mydb.ExecuteNonQuery(mysql);
                        MessageBox.Show("删除成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cmbd.bind(dgv_users, "SELECT * FROM [User]", "User");
        }

        private void dgv_users_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgv_users.SelectedRows[0].Selected = false;
                dgv_users.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
