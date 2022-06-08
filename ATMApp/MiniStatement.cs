using System;
using System.Data;
using System.Data.SqlClient;
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

        public void addTransaction(string amount, string type)
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
        private void populate()
        {
            conn.Open();
            string query = "select * from TransactionTbl where AccNum = '"+accNum +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MiniSDgv.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void BackTxt_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void ExitTxt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiniStatement_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
