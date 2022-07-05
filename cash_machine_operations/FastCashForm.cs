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
    public partial class FastCashForm : Form
    {
        private static SqlConnection sqlConnection = LoginForm.sqlConnection;
        public FastCashForm()
        {
            InitializeComponent();
        }

        private void FastCashBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string query = "if (select balance from users where username = @username)>= @value " +
                "update users set balance = balance - @value where username = @username " +
                "else select 'Unavailable balance'";
            int value = 0;
            try
            {
                switch (button.Name.ToString())
                {
                    case "tenFastCashBtn":
                        value = 10;
                        break;
                    case "twentyFastCashBtn":
                        value = 20;
                        break;
                    case "fortyFastCashBtn":
                        value = 40;
                        break;
                    case "sixtyFastCashBtn":
                        value = 60;
                        break;
                    case "eightyFastCashBtn":
                        value = 80;
                        break;
                    case "oneHundredFastCashBtn":
                        value = 100;
                        break;
                    default:
                        MessageBox.Show("Error on fast cash try again");
                        break;
                }
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", User.Username);
                sqlCommand.Parameters.AddWithValue("@value", value);
                sqlConnection.Open();
                if (sqlCommand.ExecuteScalar() != null)
                {
                    MessageBox.Show(sqlCommand.ExecuteScalar().ToString());
                }
                else
                {
                    MessageBox.Show(value + "€ were withdrawn with success");
                }

            }
            catch(SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message);
            }
            sqlConnection.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperationsForm operationsForm = new OperationsForm();
            operationsForm.Show();
        }
    }
}
