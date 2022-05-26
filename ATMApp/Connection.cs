using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ATMApp
{
    class Connection
    {
        public SqlConnection getConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=DESKTOP-B46N893;Initial Catalog=ATMAPP;Integrated Security=True";
            return Conn;
        }
    }
}
