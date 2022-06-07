using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMApp
{
    public partial class Withdraw : Form
    {

        string accNum = Login.AccNumber;
        int availBalance;

        public Withdraw()
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


        private void Withdraw_Load(object sender, EventArgs e)
        {
            Balance bl = new Balance();
            string myBalance = bl.getBalance();
            AvailBalanceTxt.Text = "AVAILABLE BALANCE: Rp."+ myBalance;
            availBalance = Convert.ToInt32(myBalance);
        }

        private void WdBtn_Click(object sender, EventArgs e)
        {
            if(AmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }else if(Convert.ToInt32(AmountTb.Text) <= 0)
            {
                MessageBox.Show("Enter a Valid Amount");
            }else if(Convert.ToInt32(AmountTb.Text) > availBalance)
            {
                MessageBox.Show("Balance Cannot be negative");
            }
            else
            {
                try
                {
                    SqlConnection conn = Connection.getConn();
                    conn.Open();
                    int newBalance = availBalance - Convert.ToInt32(AmountTb.Text);
                    string query = "update AccountTbl set Balance='" + newBalance + "' where Accnum= '" + accNum + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw !");
                    conn.Close();

                    MiniStatement miniStat = new MiniStatement();
                    miniStat.addTransaction(AmountTb.Text, "WithDraw");

                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AmountTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
