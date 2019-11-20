using FeedMeSerialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedMeVendorUI.Forms.Authentication
{
    public partial class LoginForm : FeedMeVendorTemplate
    {
        public static VendorInfo StoreInfo = new VendorInfo();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CheckDetails()
        {

            //if (ClientInfo.UserID != -1)
            //{
            //    Notification NotifForm = new Notification("Successfully Logged In", NotifType.success);
            //    NotifForm.Show();
            //    MessageBox.Show("Hey");

            //    MainMenu MainMenuForm = new MainMenu();
            //    MainMenuForm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    Notification NotifForm = new Notification("Invalid Credentials ", NotifType.error);
            //    NotifForm.Show();
            //}
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            MainMenu MM = new MainMenu();
            MM.Show();
            this.Hide();
            StoreInfo = (VendorInfo)FeedMeLogic.Server.AuthenticationHandler.AuthenticateLogin(usernameTexbox.Text, PasswordTextbox.Text, 1);
            CheckDetails();
        }
    }
}
