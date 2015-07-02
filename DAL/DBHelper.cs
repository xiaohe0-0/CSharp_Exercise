using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public class DBHelper
    {
        //数据库连接
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|//DB//Exercise.accdb";
        private OleDbConnection conn;
        private OleDbDataAdapter oda = new OleDbDataAdapter();
        //private OleDbCommand cmd;
        private DataSet myds;

        /// <summary>
        /// 得到数据
        /// </summary>
        public DataTable GetDataSet(string sql)
        {
            using (conn = new OleDbConnection(connStr))
            {
                myds = new DataSet();
                oda = new OleDbDataAdapter(sql, conn);
                oda.Fill(myds);
                return myds.Tables[0];
            }
        }

    }
}
