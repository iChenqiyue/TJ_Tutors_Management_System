using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TJ_Tutors_Management_System
{
    class Integral
    {
        public void Add(string reception,string state)
        {
            CommDB mydb = new CommDB();           
            string mysql = "SELECT 本月业务积分 FROM [Workers] WHERE 姓名='" + reception + "'";
            float month = float.Parse(mydb.Returnafield(mysql));
            month += standard(state);
            mysql = "SELECT 累计业务积分 FROM [Workers] WHERE 姓名='" + reception + "'";
            float sum = float.Parse(mydb.Returnafield(mysql));
            sum += standard(state);
            mysql = string.Format("UPDATE [Workers] SET 本月业务积分='{0}',累计业务积分='{1}' WHERE 姓名='{2}'", month, sum,reception);
            mydb.ExecuteNonQuery(mysql);
        }
        public float standard(string state)
        {
            if (state == "接入")
                return 0.5f;
            else if (state == "已接")
                return 1;
            else if (state == "换人")
                return 1;
            else if (state == "不请")
                return 0.5f;
            else if (state == "缴费")
                return 1;
            else if (state == "待接")
                return 1;
            else if (state == "重请")
                return 0.5f;
            else {
                return 0;
            }
        }
    }
}
