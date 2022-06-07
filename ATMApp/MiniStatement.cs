using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATMApp
{
    public partial class MiniStatement : Form
    {

        string accNum = Login.AccNumber;
        SqlConnection conn = Connection.getConn();

        public MiniStatement()
        {
            InitializeComponent();
        }

        public void addTransaction(string amount,string type)
        {
            try
            {
                conn.Open();
                string query = "insert into TransactionTbl values('" + accNum + "','"+type+"','" + amount + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
