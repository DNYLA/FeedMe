using FeedMeLogic;
using FeedMeNetworking.Serialization;
using System;
using System.Windows.Forms;

namespace FeedMeVendorUI.Forms.Authentication
{
    public partial class LoginForm : FeedMeVendorTemplate
    {
        public static VendorInfo VendorDetails = new VendorInfo(); //Make the Client Info Object Public so other user controls can access it.

        #region Initializing

        public static VendorInfo StoreInfo = new VendorInfo();

        public LoginForm()
        {
            InitializeComponent();
        }

        #endregion Initializing

        #region Methods

        //Other Methods Were moved over to the server

        private void CheckDetails()
        {
            if (VendorDetails.VendorID != -1)
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

        #endregion Methods

        #region Event Handlers

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm RF = new RegisterForm();
            RF.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Object OJ = FeedMeLogic.Server.AuthenticationHandler.AuthenticateLogin(UsernameTextBox.Text, PasswordTextBox.Text, 1);
            VendorDetails = (VendorInfo)OJ;
            CheckDetails();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            FeedMeLogic.Server.ServerConnection.InitiailizeConnection();
        }

        #endregion Event Handlers

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            object OJ = FeedMeLogic.Server.AuthenticationHandler.AuthenticateLogin(UsernameTextBox.Text, PasswordTextBox.Text, 1);
            VendorDetails = (VendorInfo)OJ; //Re-Serialize
            CheckDetails();
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {
            FeedMeLogic.Server.ServerConnection.InitiailizeConnection();
        }
    }
}