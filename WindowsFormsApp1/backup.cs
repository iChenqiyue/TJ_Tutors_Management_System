using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace TJ_Tutors_Management_System
{
    public partial class backup : Form
    {
        class getSqlConnection
        {
            string sql = System.Configuration.ConfigurationManager.
                ConnectionStrings["myconnstring"].ToString();
            SqlConnection conn;
            public SqlConnection GetCon()
            {
                conn = new SqlConnection(sql);
                conn.Open();
                return conn;
            }
        }
        public backup()
        {
            InitializeComponent();
        }


        private void backup_Load(object sender, EventArgs e)
        {

        }

        private void btn_open1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        private void SleepT()
        {
            for (int i = 0; i < 500; i++)
            {
                System.Threading.Thread.Sleep(10);
               
            }
        }
        private void btn_backup_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (txtPath.Text != "")
                {
                    getSqlConnection geCon = new getSqlConnection();
                    SqlConnection con = geCon.GetCon();
                    string strBacl = "backup database TJ_Tutors_System to disk='" + txtPath.Text.Trim() + "\\" + txtName.Text.Trim() + ".bak'";
                    SqlCommand Cmd = new SqlCommand(strBacl, con);
                    
                    if (Cmd.ExecuteNonQuery() != 0)
                    {
                        
                        MessageBox.Show("数据备份成功！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                       
                        MessageBox.Show("数据备份失败！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("请填写备份的正确位置及文件名！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }// end 
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void btn_open2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "txt files (*.bak)|*.bak|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textPaht.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (textPaht.Text != "")
            {
                getSqlConnection geCon = new getSqlConnection();
                SqlConnection con = geCon.GetCon();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                //连接的数据库是master,所以要初始化新的连接字符串
                string DateStr = "Data Source=.;Initial Catalog=master;Integrated Security=True";
                SqlConnection conn = new SqlConnection(DateStr);
                conn.Open();
                //-------------------杀掉所有连接 db_CSManage 数据库的进程--------------
                // string sql = " SELECT spid FROM master..sysprocesses WHERE dbid=db_id('" + strDBName + "')";
                string strSQL = "select spid from master..sysprocesses where dbid=db_id( 'TJ_Tutors_System') ";//读取连接当前数据库的进程
                SqlDataAdapter Da = new SqlDataAdapter(strSQL, conn);
                DataTable spidTable = new DataTable();
                Da.Fill(spidTable);
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = conn;
                for (int iRow = 0; iRow <= spidTable.Rows.Count - 1; iRow++)
                {
                    Cmd.CommandText = "kill " + spidTable.Rows[iRow][0].ToString(); //强行关闭用户进程 
                    Cmd.ExecuteNonQuery();
                }
                conn.Close();
                conn.Dispose();
                //--------------------------------------------------------------------
                SqlConnection sqlcon = new SqlConnection(DateStr);
                sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand("backup database TJ_Tutors_System to disk='" + textPaht.Text.Trim() + "' restore database TJ_Tutors_System from disk='" + textPaht.Text.Trim() + "' WITH REPLACE", sqlcon);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();
                MessageBox.Show("数据还原成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("为了必免数据丢失，在数据库还原后将关闭整个系统。");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("请选择备份文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_open3_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_out_Click(object sender, EventArgs e)
        {           
            ExportToExcel ete = new ExportToExcel();
            string cbo = "";
            if (cbo_out.Text == "家长信息")
                cbo = "Parents";
            else if (cbo_out.Text == "家长-家教")
                cbo = "Parents-Tutors";
            else if (cbo_out.Text == "家教-家长")
                cbo = "Tutors-Parents";
            else if (cbo_out.Text == "教员信息")
                cbo = "Tutors";
            else if (cbo_out.Text == "工作人员信息")
                cbo = "Workers";
            else if (cbo_out.Text == "责任认定")
                cbo = "Responsibility";
            else { };
            ete.ExportExcel("default.xlsx", cbo);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
