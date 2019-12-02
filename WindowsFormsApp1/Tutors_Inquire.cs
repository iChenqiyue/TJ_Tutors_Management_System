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
    public partial class Tutors_Inquire : Form
    {
        int p = 0;
        int selectnum = 0;
        int tempselect = -100;
        string mystr = "SELECT ID,家长编号,打印编号,家长称呼,联系方式," +
                    "年级科目,学员性别,家教状态,经办时间,家教价格,家教时间,家教地址详细,重要备注,缴费状态,缴费时间 FROM [Parents] ORDER BY 打印编号 DESC";
        CommDB mydb = new CommDB();
        CmbDataGridview cmbdgv = new CmbDataGridview();
        CCTRS ctr = new CCTRS();
        string level;
        public Tutors_Inquire(string level1)
        {
            InitializeComponent();
            level = level1;
        }

        private void Tutors_Inquire_Load(object sender, EventArgs e)
        {

            

            ctr.ColorDataGridView(dgv_inquire);

            cmbdgv.bind(dgv_inquire, mystr, "Parents");
            for (int i = 1; i < dgv_inquire.ColumnCount; i++)
            {
                dgv_inquire.Columns[i].ReadOnly = true;
            }
            dgv_inquire.Columns[0].ReadOnly = false;
            dgv_inquire.Columns[1].Visible = false;
            dgv_inquire.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (level != "管理员")
            {
                删除ToolStripMenuItem.Visible = false;
            }

        }

        private void inquire()
        {
            if (txt_parentnum.Text == "" && txt_printnum.Text == "" && txt_adr.Text == "" && txt_phone.Text == "")
            {
                CmbDataGridview cmbd = new CmbDataGridview();
                cmbd.bind(dgv_inquire, mystr, "Parents");
                return;
            }
            CommDB mydb = new CommDB();
            string mysql = "", tempstr = "";
            if (txt_parentnum.Text != "")
                tempstr = "家长编号 Like '%" + txt_parentnum.Text.Trim() + "%'";
            if (txt_printnum.Text != "")
            {
                if (tempstr == "")
                    tempstr = "打印编号 Like '%" + txt_printnum.Text.Trim() + "%'";
                else
                    tempstr += " AND 打印编号 Like '%" + txt_printnum.Text.Trim() + "%'";
            }
            if (txt_adr.Text != "")
            {
                if (tempstr == "")
                    tempstr = "家教地址详细 Like '%" + txt_adr.Text.Trim() + "%'";
                else
                    tempstr += " AND 家教地址详细 Like '%" + txt_adr.Text.Trim() + "%'";
            }
            if (txt_phone.Text != "")
            {
                if (tempstr == "")
                    tempstr = "联系方式 Like '%" + txt_phone.Text.Trim() + "%'";
                else
                    tempstr += " AND 联系方式 Like '%" + txt_phone.Text.Trim() + "%'";
            }
            if (tempstr == "")
                mysql = "SELECT ID,家长编号,打印编号,家长称呼,联系方式," +
                    "年级科目,学员性别,家教状态,经办时间,家教价格,家教时间,家教地址详细,重要备注,缴费状态,缴费时间 FROM [Parents] ORDER BY 打印编号";
            else
                mysql += "SELECT ID,家长编号,打印编号,家长称呼,联系方式," +
                    "年级科目,学员性别,家教状态,经办时间,家教价格,家教时间,家教地址详细,重要备注,缴费状态,缴费时间 FROM [Parents] WHERE " + tempstr+ " ORDER BY 打印编号 DESC";
            DataSet mydataset = mydb.ExecuteQuery(mysql, "Parents");
            dgv_inquire.DataSource = mydataset.Tables["Parents"];
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
                string parent_num = dgv_inquire.SelectedRows[0].Cells[2].Value.ToString();
                string print_num = dgv_inquire.SelectedRows[0].Cells[3].Value.ToString();
                string parent_name = dgv_inquire.SelectedRows[0].Cells[4].Value.ToString();
                string phone = dgv_inquire.SelectedRows[0].Cells[5].Value.ToString();
                string grade_subject = dgv_inquire.SelectedRows[0].Cells[6].Value.ToString();
                string student_sex = dgv_inquire.SelectedRows[0].Cells[7].Value.ToString();
                string tutors_state = dgv_inquire.SelectedRows[0].Cells[8].Value.ToString();
                string time = dgv_inquire.SelectedRows[0].Cells[9].Value.ToString();
                string tutors_price = dgv_inquire.SelectedRows[0].Cells[10].Value.ToString();
                string tutors_time = dgv_inquire.SelectedRows[0].Cells[11].Value.ToString();
                string dadd = dgv_inquire.SelectedRows[0].Cells[12].Value.ToString();
                string important_mark = dgv_inquire.SelectedRows[0].Cells[13].Value.ToString();
                string payment_state = dgv_inquire.SelectedRows[0].Cells[14].Value.ToString();
                string payment_time = dgv_inquire.SelectedRows[0].Cells[15].Value.ToString();
                Form test = Application.OpenForms["Tutors_revise"];  //查找是否打开过about窗体 
                Tutors_revise myform = new Tutors_revise(level,ID, parent_num, print_num, parent_name, phone, grade_subject, student_sex,
                    tutors_state, time, tutors_price, tutors_time, dadd, important_mark, payment_state, payment_time);
                myform.SetTop += new SetTopHandle(myform_SetTop);
                myform.Owner = this;
                myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                myform.Show();

            }
        }
        void myform_SetTop()
        {
            if (txt_adr.Text == "" && txt_parentnum.Text == "" && txt_phone.Text == "" && txt_printnum.Text == "")
            {
                CmbDataGridview cmbd = new CmbDataGridview();
                cmbd.bind(dgv_inquire, mystr, "Parents");
            }
            else
                inquire();
            dgv_inquire.SelectedRows[0].Selected = false;
            dgv_inquire.Rows[selectnum].Selected = true;
            dgv_inquire.FirstDisplayedScrollingRowIndex = p;
        }
        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
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

                            string mysql = "DELETE FROM [Parents] WHERE ID = '" +
                                dgv_inquire.Rows[i].Cells[1].Value.ToString() + "'";
                            mydb.ExecuteNonQuery(mysql);
                        }
                    }

                }
                if (n != 0)
                {
                    MessageBox.Show("删除成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    cmbd.bind(dgv_inquire, mystr, "Parents");
                }
                if (dgv_inquire.SelectedRows.Count > 0 && n == 0)
                {
                    result = MessageBox.Show("是否删除选中项？", "操作提示",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        CommDB mydb = new CommDB();
                        string mysql = "DELETE FROM [Parents] WHERE ID = '" +
                            dgv_inquire.SelectedRows[0].Cells[1].Value.ToString() + "'";
                        mydb.ExecuteNonQuery(mysql);
                        MessageBox.Show("删除成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        cmbd.bind(dgv_inquire, mystr, "Parents");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void tableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        public static int i = 0;
        private void dgv_inquire_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /*  if(dgv_inquire.SelectedRows[i].Cells[0].EditedFormattedValue.ToString() == "1")
              {
                  dgv_inquire.SelectedRows[i].Selected = true;
              }*/
        }

        private void dgv_inquire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_inquire.SelectedRows.Count > 0)
            {
                selectnum = dgv_inquire.SelectedRows[0].Index;
                string ID = dgv_inquire.SelectedRows[0].Cells[1].Value.ToString();
                string parent_num = dgv_inquire.SelectedRows[0].Cells[2].Value.ToString();
                string print_num = dgv_inquire.SelectedRows[0].Cells[3].Value.ToString();
                string parent_name = dgv_inquire.SelectedRows[0].Cells[4].Value.ToString();
                string phone = dgv_inquire.SelectedRows[0].Cells[5].Value.ToString();
                string grade_subject = dgv_inquire.SelectedRows[0].Cells[6].Value.ToString();
                string student_sex = dgv_inquire.SelectedRows[0].Cells[7].Value.ToString();
                string tutors_state = dgv_inquire.SelectedRows[0].Cells[8].Value.ToString();
                string time = dgv_inquire.SelectedRows[0].Cells[9].Value.ToString();
                string tutors_price = dgv_inquire.SelectedRows[0].Cells[10].Value.ToString();
                string tutors_time = dgv_inquire.SelectedRows[0].Cells[11].Value.ToString();
                string dadd = dgv_inquire.SelectedRows[0].Cells[12].Value.ToString();
                string important_mark = dgv_inquire.SelectedRows[0].Cells[13].Value.ToString();
                string payment_state = dgv_inquire.SelectedRows[0].Cells[14].Value.ToString();
                string payment_time = dgv_inquire.SelectedRows[0].Cells[15].Value.ToString();
                if (selectnum != tempselect)
                {
                    tempselect = selectnum;
                    Tutors_revise myform = new Tutors_revise(level, ID, parent_num, print_num, parent_name, phone, grade_subject, student_sex,
tutors_state, time, tutors_price, tutors_time, dadd, important_mark, payment_state, payment_time);
                    myform.SetTop += new SetTopHandle(myform_SetTop);
                    myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                    myform.Owner = this;
                    myform.Show();
                }
                else
                {                   
                    Form test = Application.OpenForms["Tutors_revise"];  //查找是否打开过about窗体 
                    if ((test == null) || (test.IsDisposed)) //如果没有打开过
                    {
                        Tutors_revise myform = new Tutors_revise(level, ID, parent_num, print_num, parent_name, phone, grade_subject, student_sex,
                        tutors_state, time, tutors_price, tutors_time, dadd, important_mark, payment_state, payment_time);
                        myform.SetTop += new SetTopHandle(myform_SetTop);
                        myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        myform.Owner = this;
                        myform.Show();
                    }
                    else
                    {
                        test.Activate(); //如果已经打开过就让其获得焦点  
                        test.WindowState = FormWindowState.Normal;//使Form恢复正常窗体大小
                    }
                }
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
                        string mysql = "DELETE FROM [Parents] WHERE ID = '" +
                            dgv_inquire.SelectedRows[0].Cells[1].Value.ToString() + "'";
                        mydb.ExecuteNonQuery(mysql);
                        MessageBox.Show("删除成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        CmbDataGridview cmbd = new CmbDataGridview();
                        cmbd.bind(dgv_inquire, mystr, "Parents");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void dgv_inquire_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dgv_inquire_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgv_inquire.SelectedRows[0].Selected = false;
                dgv_inquire.Rows[e.RowIndex].Selected = true;
            }

        }

        private void dgv_inquire_Scroll(object sender, ScrollEventArgs e)
        {
            p = e.NewValue;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cmbdgv.bind(dgv_inquire, mystr, "Parents");
            for (int i = 1; i < dgv_inquire.ColumnCount; i++)
            {
                dgv_inquire.Columns[i].ReadOnly = true;
            }
            dgv_inquire.Columns[0].ReadOnly = false;
            dgv_inquire.Columns[1].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
                Form test = Application.OpenForms["Tutors_Add"];  //查找是否打开过about窗体 
                if ((test == null) || (test.IsDisposed)) //如果没有打开过
                {
                 Tutors_Add myform = new Tutors_Add();
             //   new_add myform = new new_add();
                myform.SetTop += new SetTopHandle(myform_SetTop);
                myform.Owner = this;
                myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                myform.Show();
            }
                else
                {
                    test.Activate(); //如果已经打开过就让其获得焦点  
                    test.WindowState = FormWindowState.Normal;//使Form恢复正常窗体大小
                }

            }
            
        }
    }

