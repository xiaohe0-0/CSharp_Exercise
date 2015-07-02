using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class DBServer
    {
        public DataTable GetCon(string tab, int num)
        {
            string sql = string.Format(@"select * from {0} where ID={1}", tab, num);
            DBHelper dbh = new DBHelper();
            return dbh.GetDataSet(sql);
        }

        public DataTable GetCount(string tab)
        {
            string sql = string.Format(@"select count(*) from {0}", tab);
            DBHelper dbh = new DBHelper();
            return dbh.GetDataSet(sql);
        }
    }
}
