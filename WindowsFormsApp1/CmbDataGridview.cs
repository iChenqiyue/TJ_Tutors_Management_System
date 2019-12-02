using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace TJ_Tutors_Management_System
{
    class CmbDataGridview
    {
        public string GetID(DataGridView dgv,string colName,string ID,DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int ClickIndex = e.RowIndex;
                if (dgv.Rows[ClickIndex].Cells[colName].EditedFormattedValue.ToString() == "True")
                {
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        if (i != ClickIndex)
                            dgv.Rows[i].Cells[colName].Value = 0;
                    }

                    return dgv.Rows[ClickIndex].Cells[ID].Value.ToString();
                }
                else
                    return "false";
            }
            return "false";
        }
        public void bind(DataGridView dgv,string mystr,string tb)//绑定数据的自定义方法
        {           
            CommDB mydb = new CommDB();
            DataSet mydataset = mydb.ExecuteQuery(mystr, tb);
            dgv.DataSource = mydataset.Tables[tb];
        }
        public DataSet updatedata(string sql,string tname)
        {
            /*      DataTable DT = new DataTable();
              SqlDataAdapter SDA = new SqlDataAdapter();
                 string DateStr = "Data Source=.;Initial Catalog=master;Integrated Security=True";
                 SqlConnection conn = new SqlConnection(DateStr);
                 SqlCommand SCD = new SqlCommand("select * from tables", conn);
             SDA.SelectCommand = SCD;
                  SDA.Fill(DT);
                 SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                 SDA.Update(DT);*/
            string mystr = System.Configuration.ConfigurationManager.
               ConnectionStrings["myconnstring"].ToString();
            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = mystr;
            myconn.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sql,myconn);
            DataSet myds = new DataSet();
            myda.Fill(myds, tname);
            myda.Update(myds);
            myconn.Close();
            return myds;



        }
    }
}
