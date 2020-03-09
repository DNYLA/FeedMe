using FeedMeNetworking.Serialization;
using System;
using System.Windows.Forms;

namespace FeedMeClient.Forms.Authentication
{
    public partial class LoginForm : Forms.FeedMeMainForm
    {
        public static UserInfo ClientInfo = new UserInfo(); //Make the Client Info Object Public so other user controls can access it.

        #region Initializing

        public LoginForm()
        {
            InitializeComponent();
        }

        #endregion Initializing

        #region Methods

        //Other Methods Were moved over to the server

        /// <summary>
        /// Checks if the users information is valid or not
        /// </summary>
        private void CheckDetails()
        {
            if (ClientInfo.UserID != -1)
            {
                Notification NotifForm = new Notification("Successfully Logged In", NotifType.success);
                NotifForm.Show();
                MessageBox.Show("Hey");

                MainMenu MainMenuForm = new MainMenu();
                MainMenuForm.Show();
                Hide();
            }
            else
            {
                Notification NotifForm = new Notification("Invalid Credentials ", NotifType.error);
                NotifForm.Show();
            }
        }

        #endregion Methods

        #region Event Handlers

        private void NoAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Opens Registration Form
            Register RF = new Register();
            RF.Show();
            Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Contacts server to authenticate login
            ClientInfo = (UserInfo)FeedMeLogic.Server.AuthenticationHandler.AuthenticateLogin(UsernameTextBox.Text, PasswordTextBox.Text, 0);
            CheckDetails();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            FeedMeLogic.Server.ServerConnection.InitiailizeConnection();
        }

        #endregion Event Handlers

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    string url = "https://p.sbond.co/dansite/upload.php";
        //    string pagesource = string.Empty;
        //    using (WebClient client = new WebClient())
        //    {
        //        try
        //        {
        //            NameValueCollection postData = new NameValueCollection()
        //            {
        //                { "destfile", "destfile" },  //order: {"parameter name", "parameter value"}
        //            };

        //            // client.UploadValues returns page's source as byte array (byte[])
        //            // so it must be transformed into a string
        //            client.UploadValues(url, postData);

        //            MessageBox.Show(pagesource);
        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("Unable To Connect to Server...");
        //        }
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    System.Net.WebClient Client = new System.Net.WebClient();

        //    Client.Headers.Add("Content-Type", "binary/octet-stream");

        //    Client.UploadString("https://p.sbond.co/dansite/test.php", "POST",
        //                                      @"Test");

        //    byte[] result = Client.UploadFile("https://p.sbond.co/dansite/test.php", "POST",
        //                                      @"maxresdefault.jpg");

        //    string s = System.Text.Encoding.UTF8.GetString(result, 0, result.Length);
        //    MessageBox.Show(s);
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //create WebClient object
        //        WebClient client = new WebClient();
        //        string myFile = @"maxresdefault.jpg";
        //        client.Credentials = CredentialCache.DefaultCredentials;
        //        client.UploadFile(@"https://p.sbond.co/dansite/images/", "PUT", myFile);
        //        client.Dispose();
        //    }
        //    catch (Exception err)
        //    {
        //        MessageBox.Show(err.Message);
        //    }
        //}
    }
}