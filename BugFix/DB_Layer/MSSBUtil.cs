using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace BugFix.DB_Layer
{
    public class MSSBUtil
    {
        SqlConnection SQLCON = new SqlConnection();
        public DataTable SQLTable = new DataTable();

        public MSSBUtil()
        {
            SQLCON.ConnectionString = ConfigurationManager.ConnectionStrings["MyConString"].ConnectionString;
        }
    }
}