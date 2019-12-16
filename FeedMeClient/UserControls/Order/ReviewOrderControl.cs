using FeedMeLogic;
using FeedMeLogic.Server;
using FeedMeNetworking.Serialization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FeedMeClient.UserControls.Order
{
    public partial class ReviewOrderControl : UserControl
    {
        public ReviewOrderControl()
        {
            InitializeComponent();
        }

        private void ReviewOrderControl_Load(object sender, EventArgs e)
        {
            //Prevents Any Errors When Loading MainMenu Form in Design View
            if (!ServerConnection.Connected)
            {
                return;
            }

            GenerateItemList();
        }

        private void GenerateItemList()
        {
            #region Initiaizling Variables & DataTable
            string ItemID, ItemType, ItemName, ItemDescription, ItemTotalPrice, ItemQuantity;

            #endregion

            #region Initiaizling Common Variables for Dynamic Controls
            //Size & Location Variables
            Size EmptySize = new Size(0, 0);
            Size PanelSize = new Size(590, 451);
            Size ItemNameSize = new Size(200, 21);
            Size ItemCatSize = new Size(150, 21);
            Size ItemPriceSize = new Size(100, 21);

            Point EmptyLoc = new Point(0, 0);
            Point ItemNameLoc = new Point(134, 35);
            Point ItemCatLoc = new Point(115, 14);
            Point ItemPriceLoc = new Point(492, 35);

            Font ItemNameFont = new Font("Nirmala UI", 12, FontStyle.Regular);
            Font ItemCatFont = new Font("Nirmala UI", 12, FontStyle.Bold);
            Font PriceFont = new Font("Nirmala UI", 14, FontStyle.Regular);

            Color BlackColour = Color.Black;
            Color WhiteColour = Color.White;
            Color TransparentColour = Color.Transparent;
            Color DimGrayColour = Color.DimGray;
            #endregion
            MessageBox.Show("Items Happened");

            #region Iterating Through DataTable
            List<string> CatList = new List<string>();
            foreach (ItemModel Items in ServerConnection.ItemList)
            {
                if (!CatList.Contains(Items.Type))
                {
                    CatList.Add(Items.Type);
                }
            }

            foreach (string category in CatList)
            {
                Label TitleLabel = GenControls.AddLabel(category + "CatLabel", category, ItemCatLoc, ItemCatFont, BlackColour, TransparentColour, EmptySize, true);
                ItemPanel.Controls.Add(TitleLabel);
                foreach (ItemModel Item in ServerConnection.ItemList)
                {
                    if (Item.Type == category)
                    {
                        ItemID = Item.ItemID.ToString();
                        ItemType = Item.Type;
                        ItemQuantity = Item.Quantity.ToString();
                        ItemDescription = Item.Description;
                        ItemTotalPrice = Item.TotalPrice.ToString();
                        ItemName = Item.Name + " x" + ItemQuantity;

                        Label ItemNameLabel = GenControls.AddLabel(ItemName + "NameLabel", ItemName, ItemNameLoc, ItemNameFont, Color.DarkGray, TransparentColour, ItemNameSize, false);
                        Label ItemPriceLabel = GenControls.AddLabel(ItemName + "Price", "£" + ItemTotalPrice, ItemPriceLoc, ItemNameFont, Color.Maroon, Color.Transparent, EmptySize, true);

                        ItemPanel.Controls.Add(ItemNameLabel);
                        ItemPanel.Controls.Add(ItemPriceLabel);

                        ItemNameLoc = new Point(ItemNameLoc.X, ItemNameLoc.Y + 22);
                        ItemPriceLoc = new Point(ItemPriceLoc.X, ItemPriceLoc.Y + 22);
                    }
                }

                ItemCatLoc = new Point(ItemCatLoc.X, ItemNameLoc.Y + 25);
                ItemNameLoc = new Point(ItemNameLoc.X, ItemNameLoc.Y + 25 + 22);
                ItemPriceLoc = new Point(ItemPriceLoc.X, ItemPriceLoc.Y + 25 + 22);
            }

            //Getting Data From Table & Creating Controls
            foreach (ItemModel Item in ServerConnection.ItemList)
            {
                #region Getting Item Information

                #endregion



                #region Creating Dynamic Item Controls

                #endregion
            }
            #endregion
        }

        public static void StartChange()
        {

        }

        private void ItemDecreased(object sender, EventArgs e)
        {
            Button decreaseButton = (Button)sender;

            //Need to Remove the "RemoveButton" at the end of the name and add "TextBox" instead.
            string TextBoxName = decreaseButton.Name.Substring(0, decreaseButton.Name.Length - 12);
            Console.WriteLine(TextBoxName);
            TextBoxName = TextBoxName + "TBox";
            Console.WriteLine(TextBoxName);

            TextBox tb = Controls.Find(TextBoxName, true).OfType<TextBox>().SingleOrDefault();

            int tbIntVal = Convert.ToInt32(tb.Text);
            tbIntVal = tbIntVal - 1;
            tb.Text = tbIntVal.ToString();
        }

        private void ItemIncreased(object sender, EventArgs e)
        {
            Button increaseButton = (Button)sender;

            //Need to Remove the "AddButton" at the end of the name and add "TextBox" instead.
            string TextBoxName = increaseButton.Name.Substring(0, increaseButton.Name.Length - 9);
            Console.WriteLine(TextBoxName);
            TextBoxName = TextBoxName + "TBox";
            Console.WriteLine(TextBoxName);

            TextBox tb = Controls.Find(TextBoxName, true).OfType<TextBox>().SingleOrDefault();

            int tbIntVal = Convert.ToInt32(tb.Text);
            tbIntVal = tbIntVal + 1;
            tb.Text = tbIntVal.ToString();
        }

        private void ItemAmountChanged(object sender, EventArgs e)
        {
            //Once Vendor App Is Done Add An option to Allow Vendors to Set a Limit instead of forcing it to 10.
            TextBox ItemAmountTextBox = (TextBox)sender;
            if ((ItemAmountTextBox.Text != "")) //Prevents an error if the user backspaces to enter another value E.G user tries to enter 2. 0 >> Backspace >> "" >> "2" but instead user would get ERROR
            {

                try
                {
                    int ItemAmountInt = Convert.ToInt32(ItemAmountTextBox.Text);
                    if (ItemAmountInt < 0)
                    {
                        ItemAmountInt = 0;
                        ItemAmountTextBox.Text = ItemAmountInt.ToString();
                    }

                    if (ItemAmountInt > 10)
                    {
                        ItemAmountInt = 10;
                        ItemAmountTextBox.Text = ItemAmountInt.ToString();
                    }
                }
                catch (Exception)
                {
                    ItemAmountTextBox.Text = "0";
                }

            }
        }

        private void VendorAmountLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void VendorLabel_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Yeet Skeet Peet Leet");
            GenerateItemList();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Form CurrentForm = FindForm(); //returns the Current Form Object that the Control is on
            UserControl userControl = CurrentForm.Controls.Find("enterCredentials1", true).OfType<UserControl>().SingleOrDefault(); //Searched for the Order Control
            userControl.BringToFront();
        }
    }
}
