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
    public partial class TransactionForm : Form
    {
        private static SqlConnection sqlConnection = LoginForm.sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataTable dt;
        private string query;
        public TransactionForm()
        {
            InitializeComponent();
            DisplayData();
        }
        public void DisplayData()
        {
            dt = new DataTable();
            sqlConnection.Open();
            query = "select (ROW_NUMBER() OVER(ORDER BY atransaction.id)) as Row, atransaction.FromAccountNumber," +
                "atransaction.ToAccountNumber,atransaction.Amount, type.Type,atransaction.Date from AccountTransaction " +
                "as atransaction inner join TransactionType as type on atransaction.Id = type.id where fromaccountnumber= " +
                "@accountnumber or fromaccountnumber=@accountnumber";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@count", 0);
            sqlCommand.Parameters.AddWithValue("@accountnumber", User.AccountNumber);
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
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
