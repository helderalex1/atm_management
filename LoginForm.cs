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
    public partial class LoginForm : Form
    {
        static string connectionstring;
        public static SqlConnection sqlConnection;
        public LoginForm()
        {
            InitializeComponent();
            connectionstring = System.IO.File.ReadAllText(@"C:\Users\2190785\Documents\gitrepo\connectionstring.txt");
            sqlConnection = new SqlConnection(connectionstring);
            this.UsernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterLogin);
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterLogin);
        }

        //Open register form
        private void PageRegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //Login access
        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                String sql = "Select id,name,email,username,balance,accountnumber from Users where username =@username and password=@password";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@password", passwordTextBox.Text);
                sqlCommand.ExecuteScalar();

                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    User.Name= dt.Rows[0]["name"].ToString();
                    User.Email = dt.Rows[0]["email"].ToString();
                    User.Username = dt.Rows[0]["username"].ToString();
                    User.Balance = decimal.Parse(dt.Rows[0]["balance"].ToString());
                    User.AccountNumber = (int)dt.Rows[0]["accountnumber"];
                    this.Hide();
                    OperationsForm operationsForm = new OperationsForm();
                    operationsForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect credentials");
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("Login failed error = " + sqlException.Message.ToString());
            }
            sqlConnection.Close();
        }
        private void CheckEnterLogin(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loginBtn_Click(sender, e);
            }
        }
    }
}
