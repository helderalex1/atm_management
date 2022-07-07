using atm.cash_machine_operations;
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

namespace atm
{
    public partial class OperationsForm : Form
    {
        private static SqlConnection sqlConnection = LoginForm.sqlConnection;
        public OperationsForm()
        {
            InitializeComponent();
        }
        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm mainForm = new LoginForm();
            mainForm.Show();
        }

        private void fastcashBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FastCashForm fastCashForm = new FastCashForm();
            fastCashForm.Show();
        }

        private void OperationsBtn_Click(object sender, EventArgs e)
        {
            Form form = null;
            Button button = sender as Button;
            switch (button.Name.ToString())
            {
                case "depositBtn":
                    form = new DepositForm();
                    break;
                case "withdrawBtn":
                    form = new WithdrawForm();
                    break;
                case "fastcashBtn":
                    form = new FastCashForm();
                    break;
                case "transactionBtn":
                    form = new TransactionForm();
                    break;
                case "transferBtn":
                    form=new TransferForm();
                    break;
                case "balanceBtn":
                    form = new BalanceForm();
                    break;
                default:
                    MessageBox.Show("Error on operation selected try again");
                    break;
            }
            this.Hide(); 
            form.Show();
        }
    }
}
