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
    public partial class FastCash : Form
    {
        string accNum = Login.AccNumber;
        int availBalance;
        public FastCash()
        {
            InitializeComponent();
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

        private void FastCash_Load(object sender, EventArgs e)
        {
            Balance bl = new Balance();
            string myBalance = bl.getBalance();
            AvailableBalanceTxt.Text = "AVAILABLE BALANCE: Rp." + myBalance;
            availBalance = Convert.ToInt32(myBalance);
        }

        private void UpdateBalance(int fastCashBalance)
        {
            try
            {
                SqlConnection conn = Connection.getConn();
                conn.Open();
                int newBalance = availBalance - Convert.ToInt32(fastCashBalance);
                string query = "update AccountTbl set Balance='" + newBalance + "' where Accnum= '" + accNum + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success Withdraw !");
                conn.Close();

                MiniStatement miniStat = new MiniStatement();
                miniStat.addTransaction(Convert.ToString(fastCashBalance) , "FastCash");

                Home home = new Home();
                home.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Fc100Btn_Click(object sender, EventArgs e)
        {
            if(availBalance < 100)
            {
                MessageBox.Show("Your Balance Not Enough");
            }
            else
            {
                UpdateBalance(100);
            }
        }

        private void Fc500Btn_Click(object sender, EventArgs e)
        {
            if (availBalance < 500)
            {
                MessageBox.Show("Your Balance Not Enough");
            }
            else
            {
                UpdateBalance(500);
            }
        }

        private void Fc1000Btn_Click(object sender, EventArgs e)
        {
            if (availBalance < 1000)
            {
                MessageBox.Show("Your Balance Not Enough");
            }
            else
            {
                UpdateBalance(1000);
            }
        }

        private void Fc2000Btn_Click(object sender, EventArgs e)
        {
            if (availBalance < 2000)
            {
                MessageBox.Show("Your Balance Not Enough");
            }
            else
            {
                UpdateBalance(2000);
            }
        }

        private void Fc5000Btn_Click(object sender, EventArgs e)
        {
            if (availBalance < 5000)
            {
                MessageBox.Show("Your Balance Not Enough");
            }
            else
            {
                UpdateBalance(5000);
            }
        }

        private void Fc10000Btn_Click(object sender, EventArgs e)
        {
            if (availBalance < 10000)
            {
                MessageBox.Show("Your Balance Not Enough");
            }
            else
            {
                UpdateBalance(10000);
            }
        }
    }
}
