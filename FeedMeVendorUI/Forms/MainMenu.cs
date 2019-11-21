using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            menuInfo1.BringToFront();
            UpdatePointer(sender);
        }

        private void Items_Click(object sender, EventArgs e)
        {
            UpdatePointer(sender);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            SelectedPanel.Width = HomeButton.Width - 10;
            SelectedPanel.Location = new Point(HomeButton.Location.X + 6, 42);

            menuInfo1.BringToFront();
        }

        #region UI Helpers
        private void UpdatePointer(object buttonObject)
        {
            Button currentButton = (Button)buttonObject;
            SelectedPanel.Width = currentButton.Width - 10;
            SelectedPanel.Location = new Point(currentButton.Location.X + 4, 42);
        }
        #endregion

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            UpdatePointer(sender);
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            storeInfo1.BringToFront();
            UpdatePointer(sender);
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            UpdatePointer(sender);
        }
    }
}
