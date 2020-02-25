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

            List<string> ItemList = new List<string>();

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

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow Item in ItemsList.Rows)
            {
                string orderStatus = $"16 Items:"; //hard Coded right now change later
                string ItemName = Item[2].ToString();
                string ItemPrice = "£" + Item[5].ToString();

                Panel catPanel = GenControls.AddPanel(ItemName, Color.White, catPanelSize);
                PictureBox catImage = GenControls.AddPictureBox(ItemName, emptyLoc, picBoxSize);
                catImage.ImageLocation = "https://p.sbond.co/dansite/img/Categories/download.jpg";
                catImage.SizeMode = PictureBoxSizeMode.CenterImage;

                Label ItemNameLabel = GenControls.AddLabel(ItemName, ItemName, ItemNameLoc, DefaultFont, Color.Black, Color.Transparent, EmptySize, true);
                Label ItemPriceLabel = GenControls.AddLabel(ItemName, ItemPrice, catAmmLoc, catAmmFont, Color.Black, Color.Transparent, EmptySize, true);
                //Label orderPriceLabel = GenControls.AddLabel(PriceText + "Rating", PriceText, PriceLoc, DefaultFont, Color.Black, Color.Transparent, EmptySize, true);
                //Label orderStatusLabel = GenControls.AddLabel(orderStatus + "Rating", orderStatus, StatusLoc, DefaultFont, Color.Black, Color.Transparent, StatusSize, false);

                Control[] controlArray = new Control[] { catImage, ItemNameLabel, ItemPriceLabel };

                foreach (Control curControl in controlArray)
                {
                    //Add Event Handlers Below
                    curControl.Click += new EventHandler(OpenOrder);
                    curControl.MouseMove += new MouseEventHandler(CursorChangeArgs);
                    catPanel.Controls.Add(curControl);
                    curControl.Tag = ItemName;
                }

                flowLayoutPanel1.Controls.Add(catPanel);

                flowLayoutPanel1.Click += new EventHandler(OpenOrder);
                flowLayoutPanel1.MouseMove += new MouseEventHandler(CursorChangeArgs);
                flowLayoutPanel1.Tag = ItemName;
            }
        }

        private void CursorChangeArgs(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void OpenOrder(object sender, EventArgs e)
        {
            //Form CurrentForm = FindForm(); //returns the Current Form Object that the Control is on
            //UserControl userControl = CurrentForm.Controls.Find("ItemViewer1", true).OfType<UserControl>().SingleOrDefault(); //Searched for the Order Control

            //Control Con = (Control)sender;

            //Label TitleLabel = userControl.Controls.Find("CategoryNameLabel", true).OfType<Label>().SingleOrDefault(); // Searched for the Title Label inside the Order Control
            //TitleLabel.Text = Con.Text;

            //userControl.BringToFront();
        }

        private void CategoryNameLabel_TextChanged(object sender, EventArgs e)
        {
            ShowItems();
        }
    }
}
