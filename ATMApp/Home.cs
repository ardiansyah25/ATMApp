using System;
using System.Windows.Forms;

namespace ATMApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LogoutTxt_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.Show();
            this.Hide();
        }

        private void ExitTxt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AccNumTxt.Text = "Account Number: " + Login.AccNumber;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }

        private void ChangePinBtn_Click(object sender, EventArgs e)
        {
            ChangePincs changepin = new ChangePincs();
            changepin.Show();
            this.Hide();
        }

        private void WdBtn_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
            this.Hide();
        }

        private void FastCashBtn_Click(object sender, EventArgs e)
        {
            FastCash fastCash = new FastCash();
            fastCash.Show();
            this.Hide();
        }
    }
}
