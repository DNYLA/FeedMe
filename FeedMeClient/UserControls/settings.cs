using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeedMeNetworking.Serialization;

namespace FeedMeClient.UserControls
{
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateInfo();
            LoadInfo();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            if (!FeedMeLogic.Server.ServerConnection.Connected)
            {
                return;
            }
        }

        public void LoadInfo()
        {
            int userID = Forms.Authentication.LoginForm.ClientInfo.UserID;
            UserInfo userDetails = FeedMeLogic.Server.UserHandler.GetUserInfo(userID);
            nameTbox.Text = userDetails.Username;
            fNameTbox.Text = userDetails.FirstName;
            lNameTBox.Text = userDetails.LastName;
            emailTBox.Text = userDetails.Email;
            pcodeTBox.Text = userDetails.Postcode;
            AddTBox.Text = userDetails.Address;
            Forms.Authentication.LoginForm.ClientInfo = userDetails; //This Updates the user Details which is used globally

        }

        public void UpdateInfo()
        {
            UserInfo UI = new UserInfo();
            UI.UserID = Forms.Authentication.LoginForm.ClientInfo.UserID;
            UI.Username = nameTbox.Text;
            UI.FirstName = fNameTbox.Text;
            UI.LastName = lNameTBox.Text;
            UI.Email = emailTBox.Text;
            UI.Postcode = pcodeTBox.Text;
            UI.Address = AddTBox.Text;
            FeedMeLogic.Server.UserHandler.UpdateUserInfo(UI);
        }
    }
}
