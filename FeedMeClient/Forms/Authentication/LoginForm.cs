using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeedMeClient.Functions.Data;

namespace FeedMeClient.Forms.Authentication
{
    public partial class LoginForm : Forms.FeedMeMainForm
    {
        #region Initializing
        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private string[] GetHashData()
        {
            string SQLQuery = ($"SELECT * FROM users WHERE username = '{UsernameTextBox.Text}'");
            DataTable SQLResults = DAL.ExecCommand(SQLQuery);
            string[] HashData = new string[2];
            HashData[0] = "-1";
            HashData[1] = "Invalid";
            if (SQLResults.Rows.Count > 0)
            {
                HashData[0] = SQLResults.Rows[0]["password"].ToString();
                HashData[1] = SQLResults.Rows[0]["salt"].ToString();
                return HashData;
            }

            return HashData;
        }

        private void AuthenticateLogin()
        {
            string[] HashData = GetHashData(); //INDEX 0: Stored Password Hash; INDEX 1: Stored Salt;

            if (HashData[0] == "-1")
            {
                MessageBox.Show("Username is Invalid!");
                return;
            }

            string CurrentHash = HashPass.ConfirmHash(PasswordTextBox.Text, HashData[1]);
            Console.WriteLine(CurrentHash);
            Console.WriteLine(HashData[0]);
            if (CurrentHash == HashData[0])
            {
                MessageBox.Show("Successfully Logged In");
                MainMenu MainMenuForm = new MainMenu();
                MainMenuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }
        #endregion

        #region Event Handlers
        private void NoAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register RF = new Register();
            RF.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            AuthenticateLogin();
        }
        #endregion

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
