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
    public delegate void UpDateHandle3(string num1, string name1); //定义委托    
    public partial class Students_Inquire : Form
    {
        CmbDataGridview cmbdgv = new CmbDataGridview();
        CCTRS ctr = new CCTRS();
        public UpDateHandle3 UpDate3;
        int level1, selectnum, p = 0;
        string num1,name1;
        public Students_Inquire(int level)
        {
            InitializeComponent();
            level1 = level;
        }
        string mystr = "SELECT * FROM [Tutors] ORDER BY 教员编号 DESC";
        private void Students_Inquire_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                if (level1 == 2)
                    删除ToolStripMenuItem.Visible = false;
                if (level1 == 1)
                    选择此家教ToolStripMenuItem.Visible = false;
                

                ctr.ColorDataGridView(dgv_inquire);
                string tb = "Tutors";

                cmbdgv.bind(dgv_inquire, mystr, tb);
                for (int i = 1; i < dgv_inquire.ColumnCount; i++)
                {
                    dgv_inquire.Columns[i].ReadOnly = true;
                }
                dgv_inquire.Columns[0].ReadOnly = false;
                dgv_inquire.Columns[1].Visible = false;
                dgv_inquire.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void inquire() {
            if (txt_student_num.Text == "" && txt_tutors_name.Text == "" && txt_tutors_num.Text == "" && txt_phone.Text == "")
            {
                CmbDataGridview cmbd = new CmbDataGridview();
                cmbd.bind(dgv_inquire, mystr, "Tutors");
                return;
            }
            CommDB mydb = new CommDB();
            string mysql = "", tempstr = "";
            if (txt_tutors_num.Text != "")
                tempstr = "教员编号 Like '%" + txt_tutors_num.Text.Trim() + "%'";
            if (txt_tutors_name.Text != "")
            {
                if (tempstr == "")
                    tempstr = "姓名 Like '%" + txt_tutors_name.Text.Trim() + "%'";
                else
                    tempstr += " AND 姓名 Like '%" + txt_tutors_name.Text.Trim() + "%'";
            }
            if (txt_student_num.Text != "")
            {
                if (tempstr == "")
                    tempstr = "学号 Like '%" + txt_student_num.Text.Trim() + "%'";
                else
                    tempstr += " AND 学号 Like '%" + txt_student_num.Text.Trim() + "%'";
            }
            if (txt_phone.Text != "")
            {
                if (tempstr == "")
                    tempstr = "联系方式 Like '%" + txt_phone.Text.Trim() + "%'";
                else
                    tempstr += " AND 联系方式 Like '%" + txt_phone.Text.Trim() + "%'";
            }
            if (tempstr == "")
                mysql = "SELECT * FROM [Tutors] ORDER BY 教员编号";
            else
                mysql += "SELECT * FROM [Tutors] WHERE " + tempstr+ " ORDER BY 教员编号 DESC";
            DataSet mydataset = mydb.ExecuteQuery(mysql, "Tutors");
            dgv_inquire.DataSource = mydataset.Tables["Tutors"];
        }
        private void btn_inquire_Click(object sender, EventArgs e)
        {
            inquire();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (dgv_inquire.SelectedRows.Count > 0)
            {
                selectnum = dgv_inquire.CurrentRow.Index;
                string ID = dgv_inquire.SelectedRows[0].Cells[1].Value.ToString();
                string tutors_num = dgv_inquire.SelectedRows[0].Cells[2].Value.ToString();
                string tutors_name = dgv_inquire.SelectedRows[0].Cells[3].Value.ToString();
                string student_num = dgv_inquire.SelectedRows[0].Cells[4].Value.ToString();
                string grade_subject = dgv_inquire.SelectedRows[0].Cells[5].Value.ToString();
                string tutors_degree = dgv_inquire.SelectedRows[0].Cells[6].Value.ToString();
                string sex = dgv_inquire.SelectedRows[0].Cells[7].Value.ToString();
                string phone = dgv_inquire.SelectedRows[0].Cells[8].Value.ToString();
                string place = dgv_inquire.SelectedRows[0].Cells[9].Value.ToString();
                string blacklist = dgv_inquire.SelectedRows[0].Cells[10].Value.ToString();
                string imprisonment = dgv_inquire.SelectedRows[0].Cells[11].Value.ToString();
                string remarks = dgv_inquire.SelectedRows[0].Cells[12].Value.ToString();
                Students_Revise myform = new Students_Revise(ID, tutors_num, tutors_name, student_num, grade_subject,
                    tutors_degree, sex, phone, place, blacklist, imprisonment, remarks);
                myform.SetTop += new SetTop2Handle(myform_SetTop2);
                myform.Owner = this;
                myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                myform.Show();
            }
        }
        void myform_SetTop2()
        {
            if (txt_student_num.Text == "" && txt_tutors_name.Text == "" && txt_phone.Text == "" && txt_tutors_num.Text == "")
            {
                CmbDataGridview cmbd = new CmbDataGridview();
                cmbd.bind(dgv_inquire, mystr, "Tutors");
            }
            else
                inquire();
            dgv_inquire.SelectedRows[0].Selected = false;
            dgv_inquire.Rows[selectnum].Selected = true;
            dgv_inquire.FirstDisplayedScrollingRowIndex = p;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CmbDataGridview cmbd = new CmbDataGridview();
            DialogResult result = DialogResult.No;
            int n = 0;
            try
            {
                for (int i = 0; i < dgv_inquire.Rows.Count; i++)
                {
                    if ((bool)dgv_inquire.Rows[i].Cells[0].EditedFormattedValue == true) //判断该复选框是否被选中 
                    {
                        n++;
                        if (n == 1)
                        {
                            result = MessageBox.Show("是否删除勾选项？", "操作提示",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        }
                        if (result == DialogResult.Yes)
                        {
                            CommDB mydb = new CommDB();
                            string mysql = "DELETE FROM [Tutors] WHERE ID = '" +
                                dgv_inquire.Rows[i].Cells[1].Value.ToString() + "'";
                            mydb.ExecuteNonQuery(mysql);

                        }
                    }
                }
                if (n != 0)
                {
                    MessageBox.Show("删除成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cmbd.bind(dgv_inquire, mystr, "Tutors");
                }
                if (dgv_inquire.SelectedRows.Count > 0 && n == 0)
                {
                    result = MessageBox.Show("是否删除选中项？", "操作提示",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        CommDB mydb = new CommDB();
                        string mysql = "DELETE FROM [Tutors] WHERE ID = '" +
                            dgv_inquire.SelectedRows[0].Cells[1].Value.ToString() + "'";
                        mydb.ExecuteNonQuery(mysql);
                        MessageBox.Show("删除成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            cmbd.bind(dgv_inquire, mystr, "Tutors");
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_inquire_Scroll(object sender, ScrollEventArgs e)
        {
            p = e.NewValue;
        }

        private void dgv_inquire_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgv_inquire.SelectedRows[0].Selected = false;
                dgv_inquire.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string tb = "Tutors";

            cmbdgv.bind(dgv_inquire, mystr, tb);
            for (int i = 1; i < dgv_inquire.ColumnCount; i++)
            {
                dgv_inquire.Columns[i].ReadOnly = true;
            }
            dgv_inquire.Columns[0].ReadOnly = false;
            dgv_inquire.Columns[1].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Students_Add myform = new Students_Add();
            myform.SetTop += new SetTop2Handle(myform_SetTop2);
            myform.Owner = this;
            myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            myform.Show();
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_inquire.SelectedRows.Count > 0)
            {
                selectnum = dgv_inquire.CurrentRow.Index;
                string ID = dgv_inquire.SelectedRows[0].Cells[1].Value.ToString();
                string tutors_num = dgv_inquire.SelectedRows[0].Cells[2].Value.ToString();
                string tutors_name = dgv_inquire.SelectedRows[0].Cells[3].Value.ToString();
                string student_num = dgv_inquire.SelectedRows[0].Cells[4].Value.ToString();
                string grade_subject = dgv_inquire.SelectedRows[0].Cells[5].Value.ToString();
                string tutors_degree = dgv_inquire.SelectedRows[0].Cells[6].Value.ToString();
                string sex = dgv_inquire.SelectedRows[0].Cells[7].Value.ToString();
                string phone = dgv_inquire.SelectedRows[0].Cells[8].Value.ToString();
                string place = dgv_inquire.SelectedRows[0].Cells[9].Value.ToString();
                string blacklist = dgv_inquire.SelectedRows[0].Cells[10].Value.ToString();
                string imprisonment = dgv_inquire.SelectedRows[0].Cells[11].Value.ToString();
                string remarks = dgv_inquire.SelectedRows[0].Cells[12].Value.ToString();
                Students_Revise myform = new Students_Revise(ID, tutors_num, tutors_name, student_num, grade_subject,
                    tutors_degree, sex, phone, place, blacklist, imprisonment, remarks);
                myform.SetTop += new SetTop2Handle(myform_SetTop2);
                myform.Owner = this;
                myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                myform.Show();
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            try
            {
                if (dgv_inquire.SelectedRows.Count > 0)
                {
                    result = MessageBox.Show("是否删除选中项？", "操作提示",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        CommDB mydb = new CommDB();
                        string mysql = "DELETE FROM [Tutors] WHERE ID = '" +
                            dgv_inquire.SelectedRows[0].Cells[1].Value.ToString() + "'";
                        mydb.ExecuteNonQuery(mysql);
                        MessageBox.Show("删除成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            CmbDataGridview cmbd = new CmbDataGridview();
            cmbd.bind(dgv_inquire, mystr, "Tutors");
        }

        private void 选择此家教ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = dgv_inquire.SelectedRows[0].Cells[2].Value.ToString();
                string mysql = "SELECT 是否黑名单 FROM [Tutors] WHERE 教员编号='" + num1 + "'";
                CommDB mydb = new CommDB();
                string flag = mydb.Returnafield(mysql);
                if (flag == "是")
                {
                    MessageBox.Show("此教员已被列入黑名单！请重新选择！","操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    name1 = dgv_inquire.SelectedRows[0].Cells[3].Value.ToString();
                    UpDate3(num1, name1);
                    this.Close();
                }
    }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            CmbDataGridview cmbd = new CmbDataGridview();
        }
    }
}
