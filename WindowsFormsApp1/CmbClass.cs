using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
namespace TJ_Tutors_Management_System
{
    class CmbClass
    {
        #region 绑定数据至ComboBox
        public  void cboDataBind(ComboBox cbo, string cmdText,  string tb,string DisplayFied)
        {
            CommDB mydb = new CommDB();
            DataSet mydataset;
//            string mystr = "SELECT distinct 接待人 FROM [Table]";
            mydataset = mydb.ExecuteQuery(cmdText, tb);
            cbo.DataSource = mydataset.Tables[tb];
            cbo.DisplayMember = DisplayFied;
        }
        #endregion
        #region 获得ComboBox所选项的ValueField
        public  int selectedValue(ComboBox cbo)
        {
            if (cbo.SelectedIndex > -1 && cbo.SelectedValue.ToString() !=
                "System.Data.DataRowView")
                return int.Parse(cbo.SelectedValue.ToString());
            return -1;
        }
        #endregion
    }
}
