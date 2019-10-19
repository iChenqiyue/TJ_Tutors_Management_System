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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void 家教信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查询修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Tutors_Add();
            myform.ShowDialog();
        }
    }
}
