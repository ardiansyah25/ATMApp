using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ATMApp
{
    public partial class Account : Form
    {

        public Account()
        {
            InitializeComponent();
        }
       
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = Connection.getConn();

            int bal = 0;
            if(AccNumTb.Text == "" ||NameTb.Text == "" || FaNameTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "" || OccupationTb.Text == "" || PinTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "insert into AccountTbl values('" + AccNumTb.Text + "','" + NameTb.Text + "','" + FaNameTb.Text + "','" + DobDate.Value.Date + "','" + PhoneTb.Text + "','" + AddressTb.Text + "','" + EducationCb.SelectedItem.ToString() + "','" + OccupationTb.Text + "','" + PinTb.Text + "','" + bal + "')";
                    SqlCommand cmd = new SqlCommand(query,Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully !");
                    Conn.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LogoutTxt_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Xtxt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
