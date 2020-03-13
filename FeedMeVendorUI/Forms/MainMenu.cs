using System;
using System.Drawing;
using System.Windows.Forms;

namespace FeedMeVendorUI.Forms
{
    public partial class MainMenu : FeedMeVendorTemplate
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            orderControl1.BringToFront();
            UpdatePointer(sender);
        }

        private void Items_Click(object sender, EventArgs e)
        {
            categoroyViewer1.BringToFront();
            categoroyViewer1.ShowCategories();
            //menuInfo1.BringToFront();
            //menuInfo1.UpdateUI();
            UpdatePointer(sender);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            SelectedPanel.Width = HomeButton.Width - 10;
            SelectedPanel.Location = new Point(HomeButton.Location.X + 6, 42);
            orderControl1.BringToFront();
        }

        #region UI Helpers

        private void UpdatePointer(object buttonObject)
        {
            Button currentButton = (Button)buttonObject;
            SelectedPanel.Width = currentButton.Width - 10;
            SelectedPanel.Location = new Point(currentButton.Location.X + 4, 42);
        }

        #endregion UI Helpers

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            UpdatePointer(sender);
            storeInfo1.BringToFront();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            storeInfo1.BringToFront();
            storeInfo1.UpdateUI();
            UpdatePointer(sender);
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            viewReviews1.BringToFront();

            viewReviews1.GeneratControls(Authentication.LoginForm.VendorDetails.VendorID.ToString());
            UpdatePointer(sender);
        }
    }
}