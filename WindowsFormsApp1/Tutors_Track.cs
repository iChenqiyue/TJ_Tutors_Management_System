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
    public partial class Tutors_Track : Form
    {
        public Tutors_Track()
        {
            InitializeComponent();
        }
        CmbDataGridview cmbdgv = new CmbDataGridview();
        CCTRS ctr = new CCTRS();
        string mystr = "SELECT ID,家长编号,打印编号,家长称呼,联系方式," +
                                "年级科目,学员性别,家教状态,经办时间,家教价格,家教时间,家教地址详细,重要备注,缴费状态,缴费时间 FROM [Parents]";
        private void Tutors_Track_Load(object sender, EventArgs e)
        {
            
            ctr.ColorDataGridView(dgv_track);
            
            cmbdgv.bind(dgv_track,mystr, "Parents");
            dgv_track.Columns[0].Visible = false;
            dgv_track.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btn_nopayment_Click(object sender, EventArgs e)
        {
            CommDB mydb = new CommDB();
            string mysql = "SELECT ID,家长编号,打印编号,家长称呼,联系方式," +
                                "年级科目,学员性别,家教状态,经办时间,家教价格,家教时间,家教地址详细,重要备注,缴费状态,缴费时间 FROM [Parents] WHERE 缴费状态='待缴' ORDER BY 经办时间 DESC";
            DataSet mydataset = mydb.ExecuteQuery(mysql, "Parents");
            dgv_track.DataSource = mydataset.Tables["Parents"];
        }

        private void btn_prepared_Click(object sender, EventArgs e)
        {
            CommDB mydb = new CommDB();
            string mysql = "SELECT ID,家长编号,打印编号,家长称呼,联系方式," +
                                "年级科目,学员性别,家教状态,经办时间,家教价格,家教时间,家教地址详细,重要备注,缴费状态,缴费时间 FROM [Parents] WHERE 家教状态='待接' ORDER BY 经办时间 DESC";
            DataSet mydataset = mydb.ExecuteQuery(mysql, "Parents");
            dgv_track.DataSource = mydataset.Tables["Parents"];
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            CommDB mydb = new CommDB();
            string mysql = "SELECT ID,家长编号,打印编号,家长称呼,联系方式," +
                                "年级科目,学员性别,家教状态,经办时间,家教价格,家教时间,家教地址详细,重要备注,缴费状态,缴费时间 FROM [Parents] WHERE 家教状态='接入' OR 家教状态='换人' OR 家教状态='重请' " +
                "ORDER BY 经办时间 DESC";
            DataSet mydataset = mydb.ExecuteQuery(mysql, "Parents");
            dgv_track.DataSource = mydataset.Tables["Parents"];
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (dgv_track.SelectedRows.Count > 0)
            {
                string ID = dgv_track.SelectedRows[0].Cells[0].Value.ToString();
                string parent_num = dgv_track.SelectedRows[0].Cells[1].Value.ToString();
                string print_num = dgv_track.SelectedRows[0].Cells[2].Value.ToString();
                string parent_name = dgv_track.SelectedRows[0].Cells[3].Value.ToString();
                string phone = dgv_track.SelectedRows[0].Cells[4].Value.ToString();
                string grade_subject = dgv_track.SelectedRows[0].Cells[5].Value.ToString();
                string student_sex = dgv_track.SelectedRows[0].Cells[6].Value.ToString();
                string tutors_state = dgv_track.SelectedRows[0].Cells[7].Value.ToString();
                string time = dgv_track.SelectedRows[0].Cells[8].Value.ToString();
                string tutors_price = dgv_track.SelectedRows[0].Cells[9].Value.ToString();
                string tutors_time = dgv_track.SelectedRows[0].Cells[10].Value.ToString();
                string dadd = dgv_track.SelectedRows[0].Cells[11].Value.ToString();
                string important_mark = dgv_track.SelectedRows[0].Cells[12].Value.ToString();
                string payment_state = dgv_track.SelectedRows[0].Cells[13].Value.ToString();
                string payment_time = dgv_track.SelectedRows[0].Cells[14].Value.ToString();
                Tutors_check myform = new Tutors_check(ID, parent_num, print_num, parent_name, phone, grade_subject, student_sex,
                    tutors_state, time, tutors_price, tutors_time, dadd, important_mark, payment_state, payment_time);
                myform.Owner = this;
                myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                myform.Show();
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgv_track_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgv_track.SelectedRows[0].Selected = false;
                dgv_track.Rows[e.RowIndex].Selected = true;
            }
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_track.SelectedRows.Count > 0)
            {
                string ID = dgv_track.SelectedRows[0].Cells[0].Value.ToString();
                string parent_num = dgv_track.SelectedRows[0].Cells[1].Value.ToString();
                string print_num = dgv_track.SelectedRows[0].Cells[2].Value.ToString();
                string parent_name = dgv_track.SelectedRows[0].Cells[3].Value.ToString();
                string phone = dgv_track.SelectedRows[0].Cells[4].Value.ToString();
                string grade_subject = dgv_track.SelectedRows[0].Cells[5].Value.ToString();
                string student_sex = dgv_track.SelectedRows[0].Cells[6].Value.ToString();
                string tutors_state = dgv_track.SelectedRows[0].Cells[7].Value.ToString();
                string time = dgv_track.SelectedRows[0].Cells[8].Value.ToString();
                string tutors_price = dgv_track.SelectedRows[0].Cells[9].Value.ToString();
                string tutors_time = dgv_track.SelectedRows[0].Cells[10].Value.ToString();
                string dadd = dgv_track.SelectedRows[0].Cells[11].Value.ToString();
                string important_mark = dgv_track.SelectedRows[0].Cells[12].Value.ToString();
                string payment_state = dgv_track.SelectedRows[0].Cells[13].Value.ToString();
                string payment_time = dgv_track.SelectedRows[0].Cells[14].Value.ToString();
                Tutors_check myform = new Tutors_check(ID, parent_num, print_num, parent_name, phone, grade_subject, student_sex,
                    tutors_state, time, tutors_price, tutors_time, dadd, important_mark, payment_state, payment_time);
                myform.Owner = this;
                myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                myform.Show();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cmbdgv.bind(dgv_track, mystr, "Parents");
            dgv_track.Columns[0].Visible = false;
        }
    }
    }
