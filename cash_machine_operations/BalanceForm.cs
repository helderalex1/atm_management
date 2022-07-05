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
    public partial class BalanceForm : Form
    {
        private SqlConnection sqlConnection = LoginForm.sqlConnection;
        public BalanceForm()
        {
            InitializeComponent();
            getUserData();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OperationsForm operationsForm = new OperationsForm();
            operationsForm.Show();
        }

        private void getUserData()
        {
            try
            {
                sqlConnection.Open();
                string query = "select name,accountnumber,balance from users where username=@username";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", User.Username);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        nameLabel.Text = sqlDataReader.GetString(0);
                        accountNumberLabel.Text = sqlDataReader.GetInt32(1).ToString();
                        balanceLabel.Text = sqlDataReader.GetDecimal(2).ToString() + "€";
                    }
                }
            }catch(SqlException sqlException)
            {
                MessageBox.Show(sqlException.Message);
            }
            sqlConnection.Close();
           /* nameLabel.Text = "1";
            accountNumberLabel.Text = "1";
            balanceLabel.Text = MainForm.balance.ToString();*/
        }
    }
}
