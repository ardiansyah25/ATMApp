using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATMApp
{
    public partial class Balance : Form
    {
        string balance;
        string accNum = Login.AccNumber;

        public Balance()
        {
            InitializeComponent();
        }

        private void BackTxt_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        public string getBalance()
        {
            SqlConnection conn = Connection.getConn();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + accNum + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balance = dt.Rows[0][0].ToString();
            conn.Close();
            return balance;
        }

        private void Balance_Load(object sender, EventArgs e)
        {
           
            getBalance();

            AccNumTxt.Text = accNum;
            BalanceTxt.Text = "Rp." + balance;
        }

        private void ExitTxt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
