using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeedMeLogic;
using FeedMeLogic.Vendor;

namespace FeedMeVendorUI.UserControls.Menu
{
    public partial class ItemViewer : UserControl
    {
        public ItemViewer()
        {
            InitializeComponent();
        }

        private DataTable GetItems(string vendorID)
        {
            string currentCat = CategoryNameLabel.Text;
            DataTable ItemInfo = StoreMenuInfo.GetItemList(vendorID, currentCat);

            return ItemInfo;
        }

        public void ShowItems()
        {
            Size EmptySize = new Size(0, 0);
            Size catPanelSize = new Size(228, 136);
            Size picBoxSize = new Size(228, 79);
            Size catNameSize = new Size(82, 25);
            Size catAmmSize = new Size(57, 17);

            Point emptyLoc = new Point(0, 0);
            Point ItemNameLoc = new Point(85, 93);
            Point catAmmLoc = new Point(155, 110);

            Font DefaultFont = new Font("Nirmala UI", 11, FontStyle.Bold);
            Font catAmmFont = new Font("Nirmala UI", 10, FontStyle.Regular);

            DataTable ItemsList = GetItems(Forms.Authentication.LoginForm.VendorDetails.VendorID.ToString());

            EditCategory.Click += new EventHandler(OpenEditorCat);
            EditCategory.MouseMove += new MouseEventHandler(CursorChangeArgs);

            Panel EditCategoryPanel = EditCategory;

            flowLayoutPanel1.Controls.Clear();
        
            foreach (DataRow Item in ItemsList.Rows)
            {
                string orderStatus = $"16 Items:"; //hard Coded right now change later
                string ItemName = Item[2].ToString();
                string ItemPrice = "£" + Item[5].ToString();
                string ItemID = Item[0].ToString();

                Panel catPanel = GenControls.AddPanel(ItemName, Color.White, catPanelSize);
                PictureBox catImage = GenControls.AddPictureBox(ItemID, emptyLoc, picBoxSize);
                catImage.ImageLocation = "https://p.sbond.co/dansite/img/Categories/download.jpg";
                catImage.SizeMode = PictureBoxSizeMode.CenterImage;

                Label ItemNameLabel = GenControls.AddLabel(ItemID, ItemName, ItemNameLoc, DefaultFont, Color.Black, Color.Transparent, EmptySize, true);
                Label ItemPriceLabel = GenControls.AddLabel(ItemID, ItemPrice, catAmmLoc, catAmmFont, Color.Black, Color.Transparent, EmptySize, true);

                Control[] controlArray = new Control[] { catImage, ItemNameLabel, ItemPriceLabel };

                foreach (Control curControl in controlArray)
                {
                    //Add Event Handlers Below
                    curControl.Click += new EventHandler(OpenEditor);
                    curControl.MouseMove += new MouseEventHandler(CursorChangeArgs);
                    catPanel.Controls.Add(curControl);
                    curControl.Tag = (string)ItemID; //Store the ItemID so it can be referenced later on
                }
                catPanel.Tag = (string)ItemID;
                flowLayoutPanel1.Controls.Add(catPanel);
                flowLayoutPanel1.Controls.Add(EditCategoryPanel);

            }
        }

        private void CursorChangeArgs(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void OpenEditor(object sender, EventArgs e)
        {
            Form CurrentForm = FindForm(); //returns the Current Form Object that the Control is on
            UserControl userControl = CurrentForm.Controls.Find("EditItem1", true).OfType<UserControl>().SingleOrDefault(); //Searched for the Order Control

            Control Con = (Control)sender;

            Label TitleLabel = userControl.Controls.Find("ItemName", true).OfType<Label>().SingleOrDefault(); // Searched for the Title Label inside the Order Control
            TitleLabel.Text = Con.Name;

            //Label itemID = userControl.Controls.Find("ItemID", true).OfType<Label>().SingleOrDefault(); // Searched for the Title Label inside the Order Control
            //itemID.Text = (string)Con.Tag;
            
            userControl.BringToFront();
        }

        private void OpenEditorCat(object sender, EventArgs e)
        {
            Form CurrentForm = FindForm(); //returns the Current Form Object that the Control is on
            UserControl userControl = CurrentForm.Controls.Find("EditItem1", true).OfType<UserControl>().SingleOrDefault(); //Searched for the Order Control

            Control Con = (Control)sender;

            Label TitleLabel = userControl.Controls.Find("ItemName", true).OfType<Label>().SingleOrDefault(); // Searched for the Title Label inside the Order Control
            TitleLabel.Text = CategoryNameLabel.Text + " Category";

            userControl.BringToFront();
        }

        private void CategoryNameLabel_TextChanged(object sender, EventArgs e)
        {
            ShowItems();
        }
    }
}
