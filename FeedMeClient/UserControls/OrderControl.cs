using FeedMeLogic;
using FeedMeLogic.Data;
using FeedMeLogic.Server;
using FeedMeNetworking.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FeedMeClient.UserControls
{
    public partial class OrderControl : UserControl
    {
        /* STEPS TO COMPLETE ORDER CONTROL
         *[X] 1. Query The Database for the Item Types
         *   [X] a. Use The VendorID for the current Vendor/Store Selected (This is stored in the Tag of the Control)
         *   [X] b. Only Show the Item Types for the specific vendor
         *   [X] c. Remove any duplicate item types from the query using MIN
         * [X] 2. Generate & Add Item Types To Item Panel
         * [X] 3. Iterate using a for loop through the default/first Item Type Selected for Each Item inside
         * [X] 4. Add A Panel for each Item Inside and Fill The Item with the correct information/controls
         * [X] 5. Create Event Handlers & Add Them to the Correct Controls.
         * [X] 6. Make sure the Event Handler for Selecting an Item Type works Correctly & Generates a new List of Items
         * [] 7. Make the Place Order Button Re-Direct the User to the Checkout Control.
        */

        public OrderControl()
        {
            InitializeComponent();
        }

        #region Dynamic Generator Methods

        #region Generate Top Button Method

        private void GenerateTopButtons(int vendorID)
        {
            ButtonsFlowPanel.Controls.Clear();
            //Querying Database for Item Types
            string SQLQuery = ($@"SELECT MIN(Category)
                                FROM items
                                WHERE vendorID = {vendorID}
                                GROUP BY Category");
            DataTable QueryResults = DAL.ExecCommand(SQLQuery);

            //Initializing a List & Adding item Types to it.
            List<string> vendorItemTypes = new List<string>();

            foreach (DataRow Record in QueryResults.Rows)
            {
                vendorItemTypes.Add(Record[0].ToString());
            }

            //Initializing Property Variables
            Size ButtonSize = new Size(172, 56);
            Point buttonLocation = new Point(0, 0);
            Font buttonFont = new Font("Nirmala UI", 14, FontStyle.Regular);

            //Creating & Adding Button Control to User Control
            foreach (string Item in vendorItemTypes)
            {
                Button ItemTypeButton = GenControls.AddButton(Item, Item, buttonLocation, buttonFont, Color.Black, Color.White, ButtonSize, false);
                ItemTypeButton.Click += new EventHandler(PanelButtonClicked);
                ButtonsFlowPanel.Controls.Add(ItemTypeButton);
            }
        }

        #endregion Generate Top Button Method

        #region Generate Items Method

        private void GenerateItems(int vendorID, string itemType)
        {
            #region Initiaizling Variables & DataTable

            int ItemAmount;
            string ItemID, ItemType, ItemName, ItemDescription, ItemPrice;

            string SQLCommand = ($"SELECT * FROM items WHERE vendorID = {vendorID} AND Category = '{itemType}'");

            DataTable ItemResults = DAL.ExecCommand(SQLCommand);
            ItemAmount = ItemResults.Rows.Count;

            #endregion Initiaizling Variables & DataTable

            #region Initiaizling Common Variables for Dynamic Controls

            //Size & Location Variables
            Size EmptySize = new Size(0, 0);
            Size PanelSize = new Size(678, 133);
            Size DescSize = new Size(434, 78);
            Size PicBoxSize = new Size(124, 97);
            Size ButtonSize = new Size(25, 31);
            Size TextBoxSize = new Size(29, 22);

            Point EmptyLoc = new Point(0, 0);
            Point TitleLoc = new Point(278, 10);
            Point DescLoc = new Point(141, 41);
            Point PriceLoc = new Point(594, 22);
            Point PicBoxLoc = new Point(6, 22);
            Point RemoveItemLoc = new Point(584, 53);
            Point ItemAmountLoc = new Point(609, 55);
            Point AddItemLoc = new Point(639, 53);

            Font TitleFont = new Font("Nirmala UI", 12, FontStyle.Regular);
            Font ButtonFont = new Font("Nirmala UI", 12, FontStyle.Bold);
            Font PriceFont = new Font("Nirmala UI", 14, FontStyle.Regular);

            Color BlackColour = Color.Black;
            Color WhiteColour = Color.White;
            Color TransparentColour = Color.Transparent;
            Color DimGrayColour = Color.DimGray;

            #endregion Initiaizling Common Variables for Dynamic Controls

            #region Iterating Through DataTable

            //Getting Data From Table & Creating Controls
            foreach (DataRow Item in ItemResults.Rows)
            {
                #region Getting Item Information

                ItemID = Item[0].ToString();
                ItemName = Item[2].ToString();
                ItemType = Item[3].ToString();
                ItemDescription = Item[4].ToString();
                ItemPrice = Item[5].ToString();

                #endregion Getting Item Information

                #region Creating Dynamic Item Controls

                Panel ItemPanel = GenControls.AddPanel(ItemName, Color.White, PanelSize);

                Label TitleLabel = GenControls.AddLabel(ItemName + "Title", ItemName, TitleLoc, TitleFont, BlackColour, TransparentColour, EmptySize, true);
                Label DescLabel = GenControls.AddLabel(ItemName + "Desc", ItemDescription, DescLoc, TitleFont, Color.DarkGray, TransparentColour, DescSize, false);
                Label PriceLabel = GenControls.AddLabel(ItemName + "Price", "£" + ItemPrice, PriceLoc, PriceFont, Color.Maroon, Color.Transparent, EmptySize, true);
                Button RemoveButton = GenControls.AddButton(ItemName + "Remove", "-", RemoveItemLoc, ButtonFont, DimGrayColour, WhiteColour, ButtonSize, false);
                TextBox ItemAmountTBox = GenControls.AddTextBox(ItemName, "0", ItemID, ItemAmountLoc, TitleFont, BlackColour, WhiteColour, TextBoxSize);
                Button AddButton = GenControls.AddButton(ItemName + "Add", "+", AddItemLoc, ButtonFont, DimGrayColour, WhiteColour, ButtonSize, false);
                PictureBox ItemPictureBox = GenControls.AddPictureBox(ItemName, PicBoxLoc, PicBoxSize);

                ItemPictureBox.Image = FeedMeClient.Properties.Resources.ChickenBurger;

                #endregion Creating Dynamic Item Controls

                #region Adding to Form & Setting Event Handlers

                Control[] PanelControls = new Control[] { TitleLabel, DescLabel, PriceLabel, RemoveButton, ItemAmountTBox, AddButton, ItemPictureBox };

                foreach (Control CurrentItemControl in PanelControls)
                {
                    ItemPanel.Controls.Add(CurrentItemControl);
                }

                RemoveButton.Click += new EventHandler(ItemDecreased);
                AddButton.Click += new EventHandler(ItemIncreased);
                ItemAmountTBox.TextChanged += new EventHandler(ItemAmountChanged);
                ItemsFlowPanel.Controls.Add(ItemPanel);

                #endregion Adding to Form & Setting Event Handlers
            }

            #endregion Iterating Through DataTable
        }

        #endregion Generate Items Method

        #endregion Dynamic Generator Methods

        #region Helper Methods

        private DataRow getVendorDetails(string vendorName)
        {
            DataTable QueryResults = DAL.ExecCommand($"SELECT * FROM vendors WHERE Name = '{vendorName}'");
            Console.WriteLine(vendorName);
            DataRow VendorDetail = QueryResults.Rows[0];

            return VendorDetail;
        }

        #endregion Helper Methods

        #region Event Handlers

        #region Control Load Event

        private void OrderControl_Load(object sender, EventArgs e)
        {
            //Prevents Any Errors When Loading MainMenu Form in Design View
            if (!ServerConnection.Connected)
            {
                return;
            }

            GenerateTopButtons(2);
            GenerateItems(0, "Burgers");

            try
            {
            }
            catch
            {
                MessageBox.Show("Unexpected Error.");
            }
        }

        #endregion Control Load Event

        #region Other Events

        private void VendorTitleLabel_TextChanged(object sender, EventArgs e)
        {
            DataRow vendorInfo = getVendorDetails(VendorTitleLabel.Text);
            int vendorID = Convert.ToInt32(vendorInfo[0].ToString());
            //Clearing Flow Item Panels
            ButtonsFlowPanel.Controls.Clear();
            ItemsFlowPanel.Controls.Clear();

            //Adding New Controls to Flow Panels
            GenerateTopButtons(vendorID);

            Button FirstItemType = (Button)ButtonsFlowPanel.Controls[0];
            string ItemType = FirstItemType.Name.Substring(0, FirstItemType.Name.Length - 6); //Removes the "Button" part at the end of the name.

            GenerateItems(vendorID, ItemType);
        }

        private void PanelButtonClicked(object sender, EventArgs e)
        {
            Button ItemTypeButton = (Button)sender;

            DataRow vendorInfo = getVendorDetails(VendorTitleLabel.Text);
            int vendorID = Convert.ToInt32(vendorInfo[0]);

            ItemsFlowPanel.Controls.Clear();

            //Naming Scheme is Name + Button So removing the "Button" Part from the name is needed to get the item Type
            string ItemTypeName = ItemTypeButton.Name.Substring(0, ItemTypeButton.Name.Length - 6);
            Console.WriteLine(vendorID.ToString() + ItemTypeName);

            GenerateItems(vendorID, ItemTypeName);
        }

        #endregion Other Events

        #region Item Event Handlers

        private void ItemDecreased(object sender, EventArgs e)
        {
            Button decreaseButton = (Button)sender;

            //Need to Remove the "RemoveButton" at the end of the name and add "TextBox" instead.
            string TextBoxName = decreaseButton.Name.Substring(0, decreaseButton.Name.Length - 12);
            Console.WriteLine(TextBoxName);
            UpdateItemList(TextBoxName, false);
            TextBoxName = TextBoxName + "TBox";
            Console.WriteLine(TextBoxName);

            TextBox tb = Controls.Find(TextBoxName, true).OfType<TextBox>().SingleOrDefault();

            int tbIntVal = Convert.ToInt32(tb.Text);
            tbIntVal = tbIntVal - 1;
            tb.Text = tbIntVal.ToString();
            UpdateItemList(TextBoxName, false);
        }

        private void ItemIncreased(object sender, EventArgs e)
        {
            Button increaseButton = (Button)sender;

            //Need to Remove the "AddButton" at the end of the name and add "TextBox" instead.
            string TextBoxName = increaseButton.Name.Substring(0, increaseButton.Name.Length - 9);
            UpdateItemList(TextBoxName, true);
            Console.WriteLine(TextBoxName);
            TextBoxName = TextBoxName + "TBox";
            Console.WriteLine(TextBoxName);

            TextBox tb = Controls.Find(TextBoxName, true).OfType<TextBox>().SingleOrDefault();

            int tbIntVal = Convert.ToInt32(tb.Text);
            tbIntVal = tbIntVal + 1;
            tb.Text = tbIntVal.ToString();
        }

        private void UpdateItemList(string ItemName, bool increase)
        {
            DataTable Req = DAL.ExecCommand($"SELECT * FROM ITEMS WHERE ItemName = '{ItemName}'");
            bool alreadyAdded = false;

            DataRow vendorInfo = getVendorDetails(VendorTitleLabel.Text);
            int vendorID = Convert.ToInt32(vendorInfo[0].ToString());

            foreach (ItemModel Items in ServerConnection.ItemList)
            {
                if (Items.ItemID == Convert.ToInt32(Req.Rows[0][0]))
                {
                    if (increase)
                    {
                        Items.Quantity++;
                        Items.TotalPrice = Items.Quantity * Items.Price;
                    }
                    else
                    {
                        if (Items.Quantity <= 1)
                        {
                            ServerConnection.ItemList.Remove(Items);
                            return;
                        }
                        Items.Quantity--;
                        Items.TotalPrice = Items.Quantity * Items.Price;
                    }

                    alreadyAdded = true;
                }
            }

            if (!alreadyAdded)
            {
                ItemModel IA = new ItemModel
                {
                    ItemID = Convert.ToInt32(Req.Rows[0][0]),
                    VendorID = Convert.ToInt32(vendorID),
                    Name = Req.Rows[0][2].ToString(),
                    Price = Convert.ToInt32(Req.Rows[0][5]),
                    Quantity = 1
                };
                IA.TotalPrice = IA.Quantity * IA.Price;
                IA.Type = Req.Rows[0][3].ToString();

                ServerConnection.ItemList.Add(IA);
            }
        }

        private void UpdateItemList(int Change)
        {
            //if (ItemList.Count == 0)
            //{
            //}
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

        #endregion Item Event Handlers

        #endregion Event Handlers

        private void OrderButton_Click(object sender, EventArgs e)
        {
            DataRow vendorInfo = getVendorDetails(VendorTitleLabel.Text);
            string vendorName = vendorInfo[1].ToString();
            Form CurrentForm = FindForm(); //returns the Current Form Object that the Control is on
            UserControl userControl = CurrentForm.Controls.Find("reviewOrderControl", true).OfType<UserControl>().SingleOrDefault(); //Searched for the Order Control

            Label TitleLabel = userControl.Controls.Find("VendorLabel", true).OfType<Label>().SingleOrDefault(); // Searched for the Title Label inside the Order Control
            TitleLabel.Text = $"Order from {vendorName}"; //Sets Vendor Title To Vendor that was just selected

            userControl.BringToFront();
        }
    }
}