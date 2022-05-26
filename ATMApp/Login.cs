using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMApp
{
    public partial class Login : Form
    {
        Connection conn = new Connection();
        
        public Login()
        {
            InitializeComponent();
        }

        private void SignUpTxt_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Hide();
        }

        private void Xtxt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = conn.getConn();
            sqlconn.Open();
            string accNum = AccNumTb.Text;
            string pin = PinTb.Text;
            string query = $"select count(*) from AccountTbl where AccNum = '{accNum}' and PIN = {pin}";
            SqlDataAdapter sda = new SqlDataAdapter(query,sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
                sqlconn.Close();
            }
            else
            {
                MessageBox.Show("Wrong Account Number or PIN Code");
                AccNumTb.Text = "";
                PinTb.Text = "";
            }
            sqlconn.Close();
        }

        private void PinTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
