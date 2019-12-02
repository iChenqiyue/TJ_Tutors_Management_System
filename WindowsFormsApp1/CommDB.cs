using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace TJ_Tutors_Management_System
{
    class CommDB
    {
        public CommDB() { }//默认构造函数
        //****************************************************************
        //返回SELECT语句执行后记录集中的行数
        //****************************************************************
        public int Rownum(string sql)
        {
            int i = 0;
            string mystr = System.Configuration.ConfigurationManager.
                ConnectionStrings["myconnstring"].ToString();
            //从App.config文件获取连接字符串
            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = mystr;
            myconn.Open();
            SqlCommand mycmd = new SqlCommand(sql, myconn);
            SqlDataReader myreader = mycmd.ExecuteReader();
            while (myreader.Read())//循环读取信息
                i++;
            myconn.Close();
            return i;//返回读取的行数
        }
        //****************************************************************
        //返回SELECT语句执行后唯一行的唯一字符段
        //****************************************************************
        public string Returnafield(string sql)
        {//sql参数指出SQL语句
            string fn;
            string mystr = System.Configuration.ConfigurationManager.
                ConnectionStrings["myconnstring"].ToString();
            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = mystr;
            myconn.Open();
            SqlCommand mycmd = new SqlCommand(sql, myconn);
            SqlDataReader myreader = mycmd.ExecuteReader();
            myreader.Read();
            fn = myreader[0].ToString().Trim();
            myconn.Close();
            return fn;//返回读取的数据
        }
        //****************************************************************
        //执行更新的SQL语句：
        //UPDATE 表名 SET 字段名 = value，字段名 = value WHERE 字段名 = value
        //DELETE FROM 表名 WHERE 字段名 = value
        //INSERT INTO 表名(字段名，字段名)values(value,value)
        //****************************************************************
        public void ExecuteNonQuery(string sql)
        {
            string mystr = System.Configuration.ConfigurationManager.
               ConnectionStrings["myconnstring"].ToString();
            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = mystr;
            myconn.Open();
            SqlCommand mycmd = new SqlCommand(sql, myconn);
            mycmd.ExecuteNonQuery();
            myconn.Close();
        }
        //****************************************************************
        //执行SELECT语句，返回DataSet对象
        //****************************************************************
        public DataSet ExecuteQuery(string sql, string tname)
        {
            string mystr = System.Configuration.ConfigurationManager.
               ConnectionStrings["myconnstring"].ToString();
            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = mystr;
            myconn.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sql, myconn);
            DataSet myds = new DataSet();
            myda.Fill(myds, tname);
            myconn.Close();
            return myds;
        }
        //****************************************************************
        //执行SELECT语句，返回聚合函数结果
        //****************************************************************
        public string ExecuteAggregateQuery(string sql)
        {
            string jg;
            string mystr = System.Configuration.ConfigurationManager.
              ConnectionStrings["myconnstring"].ToString();
            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = mystr;
            myconn.Open();
            SqlCommand mycmd = new SqlCommand(sql, myconn);
            mycmd.CommandText = sql;
            mycmd.Connection = myconn;
            jg = mycmd.ExecuteScalar().ToString();
            myconn.Close();
            return jg;
        }
        
    }
    public class TempData
    {
        public static int tag;
        public static string sql;
        public static string userlevel;
    }
}