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
using FeedMeNetworking.Serialization;
using FeedMeLogic.Server;

namespace FeedMeVendorUI.UserControls.Menu
{
    public partial class ViewOrder : UserControl
    {
        public ViewOrder()
        {
            InitializeComponent();
        }

        private void GenerateItemList(string OrderID)
        {
            #region Initiaizling Variables & DataTable

            string ItemID, ItemType, ItemName, ItemDescription, ItemTotalPrice, ItemQuantity;

            #endregion Initiaizling Variables & DataTable

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

            #endregion Initiaizling Common Variables for Dynamic Controls

            #region Iterating Through DataTable

            List<string> CatList = new List<string>();

            OrderInfo OI = FeedMeLogic.Server.ConfirmOrder.GetSpecificOrder(OrderID); //Gets Order From Server

            TotalCostLabel.Text = $"Total Price: £{OI.TotalPrice}";

            //Iterates through each Category & checks if it has already been selected.
            foreach (ItemModel Items in OI.Items)
            {
                if (!CatList.Contains(Items.Type))
                {
                    CatList.Add(Items.Type);
                }
            }

            //Iterates through each category
            foreach (string category in CatList)
            {
                Label TitleLabel = GenControls.AddLabel(category + "CatLabel", category, ItemCatLoc, ItemCatFont, BlackColour, TransparentColour, EmptySize, true);
                ItemPanel.Controls.Add(TitleLabel);

                OrderInfo OrderItem = ConfirmOrder.GetSpecificOrder(ViewOrderLabel.Tag.ToString());

                //Iterates through each item in The Order
                foreach (ItemModel Item in OrderItem.Items)
                {
                    //If the Item is in the Category it will be added underneath the category
                    if (Item.Type == category)
                    {
                        //Item Info
                        ItemID = Item.ItemID.ToString();
                        ItemType = Item.Type;
                        ItemQuantity = Item.Quantity.ToString();
                        ItemDescription = Item.Description;
                        ItemTotalPrice = Item.TotalPrice.ToString();
                        ItemName = Item.Name + " x" + ItemQuantity;

                        //Generating Label
                        Label ItemNameLabel = GenControls.AddLabel(ItemName + "NameLabel", ItemName, ItemNameLoc, ItemNameFont, Color.DarkGray, TransparentColour, ItemNameSize, false);
                        Label ItemPriceLabel = GenControls.AddLabel(ItemName + "Price", "£" + ItemTotalPrice, ItemPriceLoc, ItemNameFont, Color.Maroon, Color.Transparent, EmptySize, true);

                        //Adding Label to control
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
            }

            #endregion Iterating Through DataTable
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            
        }

        private void OrderIDLabel_TextChanged(object sender, EventArgs e)
        {
            string orderID = OrderIDLabel.Text.Remove(0, 9);
            GenerateItemList(orderID);
        }

        private void UpdateOrderStatus(string newStatus)
        {
            string orderID = OrderIDLabel.Text.Remove(0, 9);
            ConfirmOrder.UpdateOrderStatus(orderID, newStatus);
        }

        private void CookingButton_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Cooking");
        }

        private void DeliveringButton_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Delivering");
        }

        private void CompletedButton_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Completed");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Cancelled");
        }

        private void CreateReview_Click(object sender, EventArgs e)
        {
            Form CurrentForm = FindForm(); //returns the Current Form Object that the Control is on
            UserControl userControl = CurrentForm.Controls.Find("CreateReview1", true).OfType<UserControl>().SingleOrDefault(); //Searched for the Order Control

            Control Con = (Control)sender;

            Label OrderID = userControl.Controls.Find("orderIDT", true).OfType<Label>().SingleOrDefault(); // Searched for the OrderID Label inside the Order Control
            OrderID.Text = $"OrderID: {OrderIDLabel.Text}";

            userControl.BringToFront();
        }
    }
}
