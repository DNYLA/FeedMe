using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeedMeLogic.Vendor;

namespace FeedMeVendorUI.UserControls.Menu
{
    //Called Edit Item But also allows you to edit Categories
    public partial class EditItem : UserControl
    {
        private string vendorID;

        public EditItem()
        {
            InitializeComponent();
        }

        private void EditItem_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateInfo(EditType edType)
        {
            vendorID = Forms.Authentication.LoginForm.VendorDetails.VendorID.ToString();

            

            if (edType == EditType.category)
            {
                UpdateCategory();
                EditCategoryPanel.BringToFront();
            }
            else
            {
                UpdateItemInfo();
                EditItemPanel.BringToFront();
            }
        }

        private void UpdateCategory()
        {
            string catName = ItemName.Text.Substring(0, ItemName.Text.Length - 9);
            EditCategoryTBox.Text = catName;

        }

        private void UpdateItemInfo()
        {
            string id = ItemName.Text;

            if (id.Contains("PicBox"))
            {
                id = id.Substring(0, id.Length - 6);
            }
            else // == "Label". No Other Possibilities
            {
                id = id.Substring(0, id.Length - 5);
            }

            DataTable dt = StoreMenuInfo.GetSpecificItem(vendorID, id);
            //ItemName.Text = dt.Rows[0][2].ToString();
            NameTBox.Text = dt.Rows[0][2].ToString();
            CategoryTBox.Text = dt.Rows[0][3].ToString();
            DescTBox.Text = dt.Rows[0][4].ToString();
            PriceTBox.Text = dt.Rows[0][5].ToString();
            EditItemPanel.BringToFront();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            StoreMenuInfo.EditItem(vendorID, ItemName.Text, NameTBox.Text, CategoryTBox.Text, DescTBox.Text, PriceTBox.Text);
            //ItemName.Text = NameTBox.Text;
        }

        private void UpdateCategory_Click(object sender, EventArgs e)
        {
            string oldName = ItemName.Text.Substring(0, ItemName.Text.Length - 9);
            string newCatName = EditCategoryTBox.Text;
            StoreMenuInfo.EditCategory(vendorID, oldName, newCatName);

            ItemName.Text = newCatName + " Category";
        }

        private void ItemName_TextChanged(object sender, EventArgs e)
        {
            if (ItemName.Text.EndsWith("Category"))
            {
                UpdateInfo(EditType.category);
            }
            else
            {
                UpdateInfo(EditType.item);
            }
        }
        private enum EditType
        {
            category, item
        }
    }


}
