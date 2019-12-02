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
    public partial class Students_all : Form
    {
        public Students_all()
        {
            InitializeComponent();
        }
        CmbDataGridview cmbd = new CmbDataGridview();
        CCTRS ctr = new CCTRS();
        private void Students_all_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“systemDataSet7.Tutors”中。您可以根据需要移动或删除它。
            
            ctr.ColorDataGridView(dgv_all);            
            string mystr = "SELECT * FROM [Tutors] ORDER BY 教员编号 DESC";
            cmbd.bind(dgv_all, mystr,"Tutors");
            dgv_all.Columns[0].Visible = false;
            dgv_all.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (dgv_all.SelectedRows.Count > 0)
            {
                string tutors_num = dgv_all.SelectedRows[0].Cells[1].Value.ToString();
                string tutors_name = dgv_all.SelectedRows[0].Cells[2].Value.ToString();
                string student_num = dgv_all.SelectedRows[0].Cells[3].Value.ToString();
                string grade_subject = dgv_all.SelectedRows[0].Cells[4].Value.ToString();
                string tutors_degree = dgv_all.SelectedRows[0].Cells[5].Value.ToString();
                string sex = dgv_all.SelectedRows[0].Cells[6].Value.ToString();
                string phone = dgv_all.SelectedRows[0].Cells[7].Value.ToString();
                string place = dgv_all.SelectedRows[0].Cells[8].Value.ToString();
                string blacklist = dgv_all.SelectedRows[0].Cells[9].Value.ToString();
                string imprisonment = dgv_all.SelectedRows[0].Cells[10].Value.ToString();
                string remarks = dgv_all.SelectedRows[0].Cells[11].Value.ToString();
                Students_check myform = new Students_check(tutors_num, tutors_name, student_num, grade_subject,
                    tutors_degree, sex, phone, place,blacklist,imprisonment, remarks);
                myform.Owner = this;
                myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                myform.Show();
            }
        }

        private void btn_cannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_all.SelectedRows.Count > 0)
            {
                string tutors_num = dgv_all.SelectedRows[0].Cells[1].Value.ToString();
                string tutors_name = dgv_all.SelectedRows[0].Cells[2].Value.ToString();
                string student_num = dgv_all.SelectedRows[0].Cells[3].Value.ToString();
                string grade_subject = dgv_all.SelectedRows[0].Cells[4].Value.ToString();
                string tutors_degree = dgv_all.SelectedRows[0].Cells[5].Value.ToString();
                string sex = dgv_all.SelectedRows[0].Cells[6].Value.ToString();
                string phone = dgv_all.SelectedRows[0].Cells[7].Value.ToString();
                string place = dgv_all.SelectedRows[0].Cells[8].Value.ToString();
                string blacklist = dgv_all.SelectedRows[0].Cells[9].Value.ToString();
                string imprisonment = dgv_all.SelectedRows[0].Cells[10].Value.ToString();
                string remarks = dgv_all.SelectedRows[0].Cells[11].Value.ToString();
                Students_check myform = new Students_check(tutors_num, tutors_name, student_num, grade_subject,
                    tutors_degree, sex, phone, place, blacklist, imprisonment, remarks);
                myform.Owner = this;
                myform.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                myform.Show();
            }
        }

        private void dgv_all_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgv_all.SelectedRows[0].Selected = false;
                dgv_all.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string mystr = "SELECT * FROM [Tutors] ORDER BY 教员编号 DESC";
            cmbd.bind(dgv_all, mystr, "Tutors");
            dgv_all.Columns[0].Visible = false;
        }
    }
}
