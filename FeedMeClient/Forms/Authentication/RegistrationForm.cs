using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeedMeClient.Functions;

namespace FeedMeClient.Forms.Authentication
{
    public partial class RegistrationForm : FeedMeMainForm
    {
        #region Initializing
        public RegistrationForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void UpdateUI()
        {
            //Fix this later on
            PasswordBox.FocusColor = Color.Red;
            PasswordBox.BaseColor = Color.Red;
            PasswordBox.ForeColor = Color.Red;

            ConfirmPasswordBox.FocusColor = Color.Red;
            ConfirmPasswordBox.BaseColor = Color.Red;
            ConfirmPasswordBox.ForeColor = Color.Red;
            if (PasswordBox.Text != ConfirmPasswordBox.Text)
            {
                PasswordBox.FocusColor = Color.Red;
                PasswordBox.BaseColor = Color.Red;

                ConfirmPasswordBox.FocusColor = Color.Red;
                ConfirmPasswordBox.BaseColor = Color.Red;
            }
        }

        private bool CheckPassword()
        {
            if (PasswordBox.Text != ConfirmPasswordBox.Text)
            {
                MessageBox.Show("Passwords Don't Match!");
                return false;
            }
            return true;
        }

        private void RegisterUser()
        {


            if (!CheckPassword())
            {
                return; //Returning Nothing just stops the function
            }

            //Store User Info In Variables
            string Name = FirstNameBox.Text + " " + LastNameBox.Text;
            string Email = EmailBox.Text; //Add a Method To Authenticate Email (E.G Check if Email Includes @ sign) later
            string Username = UsernameBox.Text;
            string[] HashedPasswordData = Functions.Data.HashPass.HashPassword(PasswordBox.Text); //INDEX 0: Hashed Password; INDEX 1: Salt;

            string SQLQuery = $"INSERT INTO users (Name, Email, username, password, salt) VALUES ('{Name}', '{Email}', '{Username}', '{HashedPasswordData[0]}', '{HashedPasswordData[1]}')";
            Functions.Data.DAL.ExecCommand(SQLQuery);
            MessageBox.Show("Successfully Registered"); // Add Error Handling Later.

        }
        #endregion

        #region Event Handlers

        #region Password UI Handlers
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void ConfirmPasswordBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void ConfirmPasswordBox_Enter(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void ConfirmPasswordBox_Leave(object sender, EventArgs e)
        {
            UpdateUI();
        }
        #endregion

        #region Other Handlers
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void NoAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LoginForm LF = new LoginForm();
            LF.Show();
        }
        #endregion

        #endregion
    }
}
