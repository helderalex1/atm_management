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
    public partial class TransferForm : Form
    {
        private SqlConnection sqlConnection = LoginForm.sqlConnection;
        private SqlCommand sqlCommand;
        private string query;
        public TransferForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperationsForm operationsForm = new OperationsForm();
            operationsForm.Show();
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            try
            {
                query = "if(select balance from users where accountnumber = @fromaccountnumber) < 0" +
                    "update users set balance = balance - @value where accountnumber = @fromaccountnumber;" +
                    " update users set balance = balance + @value where accountnumber = @toaccountnumber;" +
                    " INSERT INTO AccountTransaction (FromAccountNumber,ToAccountNumber,Amount,Date,Type)" +
                    "VALUES(@fromaccountnumber,@toaccountnumber, @value, getdate(), @type)";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@value", amountTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@fromaccountnumber", User.AccountNumber);
                sqlCommand.Parameters.AddWithValue("@toaccountnumber", accountNumberTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@type", 5);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }
    }
}
