using FeedMeNetworking.Serialization;
using System.Windows.Forms;

namespace FeedMeVendorUI.Forms.Authentication
{
    public partial class RegisterForm : FeedMeVendorTemplate
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, System.EventArgs e)
        {

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

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            if (!CheckPassword())
            {
                return;
            }

            VendorInfo VendorInformation = new VendorInfo
            {
                Name = vendorNameBox.Text,
                Description = vendorDescBox.Text,
                Address = AddressBox.Text,
                Email = EmailBox.Text,
                PhoneNo = PhoneNumber.Text,

                //Add Hashing Or Encryption on password Client Side
                Password = PasswordBox.Text
            };

            string[] HashData = FeedMeLogic.Data.HashPass.HashPassword(VendorInformation.Password);

            VendorInformation.Password = HashData[0];
            VendorInformation.Salt = HashData[1];

            int response = FeedMeLogic.Server.AuthenticationHandler.RegisterVendor(VendorInformation);

            if (response == 0)
            {
                MessageBox.Show("Duplicate Username");
            }
            else if (response == 1)
            {
                MessageBox.Show("Successfully Registered! You Can Now Login");
            }
            else
            {
                MessageBox.Show("Undiagnosed Error!");
            }
        }

        private void NoAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}