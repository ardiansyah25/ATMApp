using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMApp
{
    public partial class ChangePincs : Form
    {

        string accNum = Login.AccNumber;

        public ChangePincs()
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

        private void NewPinTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ConfirmPinTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ChangePinBtn_Click(object sender, EventArgs e)
        {
            if (NewPinTb.Text == "" || ConfirmPinTb.Text == "")
            {
                MessageBox.Show("Enter And Confirm new Pin");
            }
            else if(ConfirmPinTb.Text != NewPinTb.Text)
            {
                MessageBox.Show("Pin Not Match !");
            }
            else
            {
                try
                {
                    SqlConnection conn = Connection.getConn();
                    conn.Open();
                    string query = "update AccountTbl set PIN='" + NewPinTb.Text + "' where Accnum= '" + accNum + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin Successfully Updated !");
                    conn.Close();
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
