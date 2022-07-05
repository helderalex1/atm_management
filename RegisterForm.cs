using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class RegisterPage : Form
    {
        private static SqlConnection sqlConnection = LoginForm.sqlConnection;
        public RegisterPage()
        {
            InitializeComponent();
            this.registEmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterRegister);
            this.registNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterRegister);
            this.registUsernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterRegister);
            this.registPasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterRegister);
        }

        //Open login form
        private void LoginPageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm mainPage = new LoginForm();
            mainPage.Show();
        }

        //Function to registry account
        private void RegistAccountBtn_Click(object sender, EventArgs e)
        {
            if(registNameTextBox.Text.Length >= 3 & registUsernameTextBox.Text.Length >= 3 && registEmailTextBox.Text.Length >= 3
                && registPasswordTextBox.Text.Length >= 3)
            {
                try
                {
                    String query = "insert into Users (name,email,username,password,accountnumber) values (@name ,@email , @username, @password,@accountnumber)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@name", registNameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@email", registEmailTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@username", registUsernameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@password", registPasswordTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@accountnumber", GenerateAccountNumber());
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    string credentialsFile = @"C:\Users\2190785\Documents\gitrepo\credentials.txt";
                    if (File.Exists(credentialsFile))
                    {
                        string[] lines = File.ReadAllLines(credentialsFile);
                        List<string> credentials = new List<string>();
                        foreach (string line in lines)
                        {
                            credentials.Add(line);
                        }
                        MailMessage email = new MailMessage();
                        email.From = new MailAddress(credentials[0]);
                        email.To.Add(registEmailTextBox.Text);
                        //email.To.Add(RegistEmailTextBox.Text.ToString();
                        email.Subject = "Test";
                        email.Body = "test";
                        using (SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587))
                        {
                            smtp.Credentials = new System.Net.NetworkCredential(credentials[0], credentials[1]);
                            smtp.EnableSsl = true;
                            smtp.Send(email);
                        }
                    }
                    else
                    {
                        MessageBox.Show("File error");
                    }
                }
                catch(SqlException Ex)
                {
                    MessageBox.Show(Ex.Message);
                    sqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Some field is empty or don't have 3 Character");
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void CheckEnterRegister(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                RegistAccountBtn_Click(sender, e);
            }
        }
        //generate account number for regist
        private int GenerateAccountNumber()
        {
            string query = "select AccountNumber from users";
            int accountGeneratedNumber = 0;
            List<int> accountNumberList = new List<int>();
            int i = 0;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    accountNumberList.Add(sqlDataReader.GetInt32(0));
                    i++;
                }
                do
                {
                    accountGeneratedNumber = new Random().Next(100000000, 999999999);
                } while (accountNumberList.Contains(accountGeneratedNumber));
                MessageBox.Show(accountGeneratedNumber.ToString());
            }
            sqlConnection.Close();
            return accountGeneratedNumber;
        }
    }
}
