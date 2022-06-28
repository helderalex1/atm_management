using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class RegisterPage : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\2190785\Documents\gitrepo\atm_management\atm\atm_db.mdf;Integrated Security=True");
        public RegisterPage()
        {
            InitializeComponent();
        }
        private void LoginPageBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void RegistAccountBtn_Click(object sender, EventArgs e)
        {
            if(RegistNameTextBox.Text != null || RegistEmailTextBox.Text != null || RegistPinTextBox != null)
            {
                try
                {
                    sqlConnection.Open();
                    String query = "insert into Users values('" +RegistNameTextBox.Text.ToString() + "','" + RegistEmailTextBox.Text.ToString() + "','" +
                        RegistPinTextBox.Text.ToString() + "','" + 0 + "'," + 0 + ")";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
                catch(SqlException Ex)
                {
                    MessageBox.Show(Ex.Message);
                    sqlConnection.Close();
                }
            }
        }
    }
}
