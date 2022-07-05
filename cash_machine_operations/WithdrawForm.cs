using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm.cash_machine_operations
{
    public partial class WithdrawForm : Form
    {
        private static SqlConnection sqlConnection = LoginForm.sqlConnection;
        public WithdrawForm()
        {
            InitializeComponent();
            balanceLabel.Text = "Balance: " + User.Balance;
        }
        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(amountTextBox.Text) % 5 != 0)
            {
                MessageBox.Show("Incorrect amount");
            }
            else
            {
                try
                {
                    string query = "Update Users set balance = balance - @value where username = @username;Select balance from users where username = @username";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@value",amountTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@username",User.Username);
                    balanceLabel.Text = "Balance: " + sqlCommand.ExecuteScalar().ToString() + "€";
                }
                catch(SqlException sqlException) 
                { 
                    MessageBox.Show(sqlException.Message); 
                }
                sqlConnection.Close();
            }
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            OperationsForm operationsForm = new OperationsForm();
            this.Hide();
            operationsForm.Show();
        }
    }
}
