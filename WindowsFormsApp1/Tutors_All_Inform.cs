using System;
using System.Windows.Forms;

namespace TJ_Tutors_Management_System
{
    public partial class Tutors_All_Inform : Form
    {
        public Tutors_All_Inform()
        {
            InitializeComponent();
        }
        CmbDataGridview cmbd = new CmbDataGridview();
        CCTRS ctr = new CCTRS();
        private void Tutors_All_Inform_Load(object sender, EventArgs e)
        {
       
            ctr.ColorDataGridView(dgv_tutors_all);            
            string mystr = "SELECT ID,家长编号,打印编号,家长称呼,联系方式," +
                    "年级科目,学员性别,家教状态,经办时间,家教价格,家教时间,家教地址详细,重要备注,缴费状态,缴费时间 FROM [Parents] ORDER BY 经办时间 DESC";
            cmbd.bind(dgv_tutors_all, mystr,"Parents");
            dgv_tutors_all.Columns[0].Visible = false;
            dgv_tutors_all.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            
                if (dgv_tutors_all.SelectedRows.Count > 0)
                {
                string ID = dgv_tutors_all.SelectedRows[0].Cells[0].Value.ToString();
                string parent_num = dgv_tutors_all.SelectedRows[0].Cells[1].Value.ToString();
                string print_num = dgv_tutors_all.SelectedRows[0].Cells[2].Value.ToString();
                string parent_name = dgv_tutors_all.SelectedRows[0].Cells[3].Value.ToString();
                string phone = dgv_tutors_all.SelectedRows[0].Cells[4].Value.ToString();
                string grade_subject = dgv_tutors_all.SelectedRows[0].Cells[5].Value.ToString();
                string student_sex = dgv_tutors_all.SelectedRows[0].Cells[6].Value.ToString();
                string tutors_state = dgv_tutors_all.SelectedRows[0].Cells[7].Value.ToString();
                string time = dgv_tutors_all.SelectedRows[0].Cells[8].Value.ToString();
                string tutors_price = dgv_tutors_all.SelectedRows[0].Cells[9].Value.ToString();
                string tutors_time = dgv_tutors_all.SelectedRows[0].Cells[10].Value.ToString();
                string dadd = dgv_tutors_all.SelectedRows[0].Cells[11].Value.ToString();
                string important_mark = dgv_tutors_all.SelectedRows[0].Cells[12].Value.ToString();
                string payment_state = dgv_tutors_all.SelectedRows[0].Cells[13].Value.ToString();
                string payment_time = dgv_tutors_all.SelectedRows[0].Cells[14].Value.ToString();
                Tutors_check myform = new Tutors_check(ID, parent_num, print_num, parent_name, phone, grade_subject, student_sex,
                    tutors_state, time, tutors_price, tutors_time, dadd, important_mark, payment_state, payment_time);
                    myform.Owner = this;
                myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                myform.Show();
                }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            
            string mystr = "SELECT ID,家长编号,打印编号,家长称呼,联系方式," +
                    "年级科目,学员性别,家教状态,经办时间,家教价格,家教时间,家教地址详细,重要备注,缴费状态,缴费时间 FROM [Parents] ORDER BY 经办时间 DESC";
            cmbd.bind(dgv_tutors_all, mystr, "Parents");
            dgv_tutors_all.Columns[0].Visible = false;
        }

        private void btn_cannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_tutors_all_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgv_tutors_all.SelectedRows[0].Selected = false;
                dgv_tutors_all.Rows[e.RowIndex].Selected = true;
            }
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_tutors_all.SelectedRows.Count > 0)
            {
                string ID = dgv_tutors_all.SelectedRows[0].Cells[0].Value.ToString();
                string parent_num = dgv_tutors_all.SelectedRows[0].Cells[1].Value.ToString();
                string print_num = dgv_tutors_all.SelectedRows[0].Cells[2].Value.ToString();
                string parent_name = dgv_tutors_all.SelectedRows[0].Cells[3].Value.ToString();
                string phone = dgv_tutors_all.SelectedRows[0].Cells[4].Value.ToString();
                string grade_subject = dgv_tutors_all.SelectedRows[0].Cells[5].Value.ToString();
                string student_sex = dgv_tutors_all.SelectedRows[0].Cells[6].Value.ToString();
                string tutors_state = dgv_tutors_all.SelectedRows[0].Cells[7].Value.ToString();
                string time = dgv_tutors_all.SelectedRows[0].Cells[8].Value.ToString();
                string tutors_price = dgv_tutors_all.SelectedRows[0].Cells[9].Value.ToString();
                string tutors_time = dgv_tutors_all.SelectedRows[0].Cells[10].Value.ToString();
                string dadd = dgv_tutors_all.SelectedRows[0].Cells[11].Value.ToString();
                string important_mark = dgv_tutors_all.SelectedRows[0].Cells[12].Value.ToString();
                string payment_state = dgv_tutors_all.SelectedRows[0].Cells[13].Value.ToString();
                string payment_time = dgv_tutors_all.SelectedRows[0].Cells[14].Value.ToString();
                Tutors_check myform = new Tutors_check(ID, parent_num, print_num, parent_name, phone, grade_subject, student_sex,
                    tutors_state, time, tutors_price, tutors_time, dadd, important_mark, payment_state, payment_time);
                myform.Owner = this;
                myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                myform.Show();
            }
        }
    }
}
