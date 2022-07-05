using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm.cash_machine_operations
{
    public partial class DepositForm : Form
    {
        private static SqlConnection sqlConnection = LoginForm.sqlConnection;
        public DepositForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperationsForm operationsForm = new OperationsForm();
            operationsForm.Show();
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            if (int.Parse(amountTextBox.Text) % 5 != 0)
            {
                MessageBox.Show("Incorrect amount");
            }
            else
            {
                try
                {
                    String query = "Update Users set balance = balance + @balance where username = @username;Select balance from users where username = @username ";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@balance", decimal.Parse(amountTextBox.Text));
                    sqlCommand.Parameters.AddWithValue("@username", User.Username);
                    sqlConnection.Open();
                    User.Balance = decimal.Parse(sqlCommand.ExecuteScalar().ToString());
                    MessageBox.Show(amountTextBox.Text + "€ were deposited!");
                }
                catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.ToString());
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
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
}
}
