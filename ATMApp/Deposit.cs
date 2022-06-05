using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ATMApp
{
    public partial class Deposit : Form
    {

        int oldBalance;
        string accNum = Login.AccNumber;

        public Deposit()
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

        private void depositTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
         
            if(AmountTb.Text == "" || Convert.ToInt32(AmountTb.Text) <= 0)
            {
                MessageBox.Show("Enter The Amount to Deposit");
            }
            else
            {
                try
                {
                    SqlConnection conn = Connection.getConn();
                    conn.Open();
                    int newBalance = oldBalance + Convert.ToInt32(AmountTb.Text);
                    string query = "update AccountTbl set Balance='"+newBalance+"' where Accnum= '"+accNum+"' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Deposit !");
                    conn.Close();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            Balance bl = new Balance();
            oldBalance = Convert.ToInt32(bl.getBalance());
        }
    }
}
