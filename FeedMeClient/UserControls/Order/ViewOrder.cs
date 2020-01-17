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

            MessageBox.Show("Items Happened");

            #region Iterating Through DataTable

            List<string> CatList = new List<string>();

            OrderInfo OI = FeedMeLogic.Server.ConfirmOrder.GetSpecificOrder(OrderID);

            TotalCostLabel.Text = $"Total Price: £{OI.TotalPrice}";

            foreach (ItemModel Items in OI.Items)
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

                OrderInfo OrderItem = ConfirmOrder.GetSpecificOrder(ViewOrderLabel.Tag.ToString());

                foreach (ItemModel Item in OrderItem.Items)
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
            }

            #endregion Iterating Through DataTable
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            
        }

        private void OrderIDLabel_TextChanged(object sender, EventArgs e)
        {
            string orderID = OrderIDLabel.Text.Remove(0, 9);
            Console.WriteLine($"THE ORDER ID IS {orderID} OKAYT");
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
    }
}
