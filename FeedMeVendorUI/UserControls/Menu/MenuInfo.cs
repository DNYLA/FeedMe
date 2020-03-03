using FeedMeLogic.Vendor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FeedMeVendorUI.UserControls.Menu
{
    public partial class MenuInfo : UserControl
    {
        private string vendorID;
        public static bool Opened = false;

        public MenuInfo()
        {
            InitializeComponent();
        }

        public void UpdateUI()
        {
            if (!Opened)
            {
                string venID = Forms.Authentication.LoginForm.VendorDetails.VendorID.ToString();
                LoadCategories(venID);
                Opened = true;
            }
        }

        private void MenuInfo_Load(object sender, EventArgs e)
        {
            if (!FeedMeLogic.Server.ServerConnection.Connected)
            {
                return;
            }
            vendorID = Forms.Authentication.LoginForm.VendorDetails.VendorID.ToString();
        }

        private void LoadCategories(string vendorID)
        {
            CatLBox.Items.Clear();
            DataTable MenuTable = StoreMenuInfo.GetMenuInfo(vendorID);
            List<string> CategoryList = new List<string>();
            foreach (DataRow Item in MenuTable.Rows)
            {
                CategoryList.Add(Item[3].ToString());
            }

            List<string> NewCatList = CategoryList.Distinct().ToList();
            CategoryList.Sort();
            foreach (string Item in CategoryList)
            {
                CatLBox.Items.Add(Item);
            }
            CatLBox.SelectedIndex = 0;
            AddItems();
        }

        private void AddItems()
        {
            string currentCat = CatLBox.SelectedItem.ToString();
            DataTable ItemInfo = StoreMenuInfo.GetItemList(vendorID, currentCat);

            ItemLBox.Items.Clear();

            foreach (DataRow Item in ItemInfo.Rows)
            {
                ItemLBox.Items.Add(Item[2].ToString());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
        }

        private void EditCatButton_Click(object sender, EventArgs e)
        {
            string oldName = CatLBox.SelectedItem.ToString();
            StoreMenuInfo.EditCategory(vendorID, oldName, CatNameTbox.Text);
        }

        private void CatLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItems();
        }

        private void EditItemButton_Click(object sender, EventArgs e)
        {
        }
    }
}