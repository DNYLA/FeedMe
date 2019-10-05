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
using FeedMeClient.Functions.Server;
using FeedMeSerialization;

namespace FeedMeClient.Forms.Authentication
{
    public partial class LoginForm : Forms.FeedMeMainForm
    {
        public static UserInfo ClientInfo = new UserInfo();

        #region Initializing
        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        //Other Methods Were moved over to the server


        private void CheckDetails()
        {
            if (ClientInfo.UserID != -1)
            {
                Notification NotifForm = new Notification("Successfully Logged In", NotifType.success);
                NotifForm.Show();
                MainMenu MainMenuForm = new MainMenu();
                MainMenuForm.Show();
                this.Hide();
            }
            else
            {
                Notification NotifForm = new Notification("Invalid Credentials ", NotifType.error);
                NotifForm.Show();
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
            ClientInfo = AuthenticationHandler.AuthenticateLogin(UsernameTextBox.Text, PasswordTextBox.Text);
            CheckDetails();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ServerConnection.InitiailizeConnection();
        }
        #endregion
    }
}
