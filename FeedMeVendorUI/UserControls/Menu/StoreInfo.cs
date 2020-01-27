using FeedMeNetworking.Serialization;
using System;
using System.Data;
using System.Windows.Forms;

namespace FeedMeVendorUI.UserControls.Menu
{
    public partial class StoreInfo : UserControl
    {
        public StoreInfo()
        {
            InitializeComponent();
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        public void UpdateUI()
        {
            LoadInfo();
        }

        private void StoreInfo_Load(object sender, EventArgs e)
        {
            if (!FeedMeLogic.Server.ServerConnection.Connected)
            {
                return;
            }
        }

        private void LoadInfo()
        {
            string vendorID = Forms.Authentication.LoginForm.VendorDetails.VendorID.ToString();
            DataTable StoreInfo = FeedMeLogic.Vendor.StoreMenuInfo.GetStoreInfo(vendorID);

            NameTBox.Text = StoreInfo.Rows[0][0].ToString();
            DescrTbox.Text = StoreInfo.Rows[0][1].ToString();
            AddressTbox.Text = StoreInfo.Rows[0][2].ToString();
            EmailTbox.Text = StoreInfo.Rows[0][3].ToString();
            PostCodeTbox.Text = StoreInfo.Rows[0][4].ToString();
            PhoneTbox.Text = StoreInfo.Rows[0][5].ToString();
            RatingTbox.Text = StoreInfo.Rows[0][6].ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            VendorInfo VI = new VendorInfo();
            VI.VendorID = Forms.Authentication.LoginForm.VendorDetails.VendorID;
            VI.Name = NameTBox.Text;
            VI.Description = DescrTbox.Text;
            VI.Address = AddressTbox.Text;
            VI.Email = EmailTbox.Text;
            VI.Postcode = PostCodeTbox.Text;
            VI.PhoneNo = PhoneTbox.Text;
            FeedMeLogic.Vendor.StoreMenuInfo StoreClass = new FeedMeLogic.Vendor.StoreMenuInfo();
            StoreClass.UpdateStoreInfo(VI);
        }
    }
}