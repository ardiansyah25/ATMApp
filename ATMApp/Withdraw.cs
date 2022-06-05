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
    }
}
