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
    
    public partial class Workers_Inquire : Form
    {

        string mystr = "SELECT * FROM [Workers]";
        private void btn_check_Click(object sender, EventArgs e)
        {
            if (dgv_inquire.SelectedRows.Count > 0)
            {
                string ID = dgv_inquire.SelectedRows[0].Cells[1].Value.ToString();
                string name = dgv_inquire.SelectedRows[0].Cells[2].Value.ToString();
                string sex = dgv_inquire.SelectedRows[0].Cells[3].Value.ToString();
                string student_num = dgv_inquire.SelectedRows[0].Cells[4].Value.ToString();
                string subject = dgv_inquire.SelectedRows[0].Cells[5].Value.ToString();
                string phone = dgv_inquire.SelectedRows[0].Cells[6].Value.ToString();
                string position = dgv_inquire.SelectedRows[0].Cells[7].Value.ToString();
                string month = dgv_inquire.SelectedRows[0].Cells[8].Value.ToString();
                string sum = dgv_inquire.SelectedRows[0].Cells[9].Value.ToString();
                Workers_Revise myform = new Workers_Revise(ID, name, sex, student_num, subject, phone, position, month, sum);
                myform.Owner = this;
                myform.SetTop += new SetTop3Handle(myform_SetTop3);
                myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                myform.Show();
            }
        }
        void myform_SetTop3()
        {
            CmbDataGridview cmbd = new CmbDataGridview();
            cmbd.bind(dgv_inquire,mystr, "Workers");
        }
        public Workers_Inquire()
        {
            InitializeComponent();
        }

        private void Workers_Revise_Load(object sender, EventArgs e)
        {
            CmbDataGridview cmbdgv = new CmbDataGridview();
            CCTRS ctr = new CCTRS();
            ctr.ColorDataGridView(dgv_inquire);
            string tb = "Workers";
            cmbdgv.bind(dgv_inquire,mystr, tb);
            for (int i = 1; i < dgv_inquire.ColumnCount; i++)
            {
                dgv_inquire.Columns[i].ReadOnly = true;
            }
            dgv_inquire.Columns[0].ReadOnly = false;
            dgv_inquire.Columns[1].Visible = false;
            dgv_inquire.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                            result = MessageBox.Show("是否删除选中项？", "操作提示",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        }
                        if (result == DialogResult.Yes)
                        {
                            CommDB mydb = new CommDB();
                            string mysql = "DELETE FROM [Workers] WHERE ID = '" +
                                dgv_inquire.Rows[i].Cells[1].Value.ToString() + "'";
                            mydb.ExecuteNonQuery(mysql);

                        }
                    }
                }
                if (n != 0)
                {
                    MessageBox.Show("删除成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cmbd.bind(dgv_inquire,mystr,"Workers");
                }
                if (dgv_inquire.SelectedRows.Count > 0 && n == 0)
                {
                    result = MessageBox.Show("是否删除选中项？", "操作提示",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        CommDB mydb = new CommDB();
                        string mysql = "DELETE FROM [Workers] WHERE ID = '" +
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
            
            cmbd.bind(dgv_inquire,mystr, "Workers");
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_inquire.SelectedRows.Count > 0)
            {
                string ID = dgv_inquire.SelectedRows[0].Cells[1].Value.ToString();
                string name = dgv_inquire.SelectedRows[0].Cells[2].Value.ToString();
                string sex = dgv_inquire.SelectedRows[0].Cells[3].Value.ToString();
                string student_num = dgv_inquire.SelectedRows[0].Cells[4].Value.ToString();
                string subject = dgv_inquire.SelectedRows[0].Cells[5].Value.ToString();
                string phone = dgv_inquire.SelectedRows[0].Cells[6].Value.ToString();
                string position = dgv_inquire.SelectedRows[0].Cells[7].Value.ToString();
                string month= dgv_inquire.SelectedRows[0].Cells[8].Value.ToString();
                string sum= dgv_inquire.SelectedRows[0].Cells[9].Value.ToString();
                Workers_Revise myform = new Workers_Revise(ID,name, sex, student_num, subject, phone, position,month,sum);
                myform.Owner = this;
                myform.SetTop += new SetTop3Handle(myform_SetTop3);
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
                        int number = int.Parse(dgv_inquire.SelectedRows[0].Cells[1].Value.ToString());
                        number--;
                        string mysql = "DELETE FROM [Workers] WHERE ID = '" +
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
            cmbd.bind(dgv_inquire, mystr, "Workers");
        }

        private void dgv_inquire_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgv_inquire.SelectedRows[0].Selected = false;
                dgv_inquire.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
