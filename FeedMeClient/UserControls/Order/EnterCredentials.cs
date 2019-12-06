using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeedMeNetworking.Serialization;
using FeedMeNetworking.Models;

namespace FeedMeClient.UserControls.Order
{
    public partial class EnterCredentials : UserControl
    {
        public EnterCredentials()
        {
            InitializeComponent();
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            OrderInfo order = new OrderInfo();

            List<ItemModel> itemList = FeedMeLogic.Server.ServerConnection.ItemList;


            order.Card = AddItemDetails();
            order.Items = itemList;
            order.TotalPrice = GetTotalPrice(itemList);
            order.VendorID = order.Items[0].VendorID;

            FeedMeLogic.Server.ConfirmOrder.SendOrder(order, Forms.Authentication.LoginForm.ClientInfo);
        }

        private decimal GetTotalPrice(List<ItemModel> items)
        {
            decimal price = 0;
            foreach(ItemModel item in items)
            {
                price += item.TotalPrice;
            }

            return price;
        }

        private CardModel AddItemDetails()
        {
            CardModel cardDetails = new CardModel();

            cardDetails.CardNum = CardNoBox.Text;
            cardDetails.ExpiryDate = MonthExpiry + "/" + YearExpiry;
            cardDetails.CVC = SecCode.Text;
            cardDetails.Address = AddressTbox.Text;
            cardDetails.ExtraDetails = ExtraTbox.Text;
            cardDetails.Email = Forms.Authentication.LoginForm.ClientInfo.Email;

            return cardDetails;
    }

        private void EnterCredentials_Load(object sender, EventArgs e)
        {
            MonthExpiry.SelectedIndex = 0;
            YearExpiry.SelectedIndex = 0;

        }
    }
}
