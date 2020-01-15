using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeedMeLogic.Server;
using FeedMeNetworking.Serialization;
using FeedMeLogic;

namespace FeedMeClient.UserControls.Order
{
    public partial class ViewOrders : UserControl
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            if (!ServerConnection.Connected)
            {
                return;
            }
            GenerateControls();
        }

        private void GenerateControls()
        {
            #region Initializing Variables

            Size EmptySize = new Size(0, 0);
            Size orderPanelSize = new Size(660, 125);
            Size StatusSize = new Size(134, 21);

            Point VendorLoc = new Point(264, 10);
            Point DeliveryTimeLoc = new Point(75, 44);
            Point TotalPriceLoc = new Point(283, 44);
            Point TotalItemsLoc = new Point(420, 44);
            Point DeliveryStartLoc = new Point(41, 85);
            Point DeliveryEndLoc = new Point(334, 85);



            Font DefaultFont = new Font("Nirmala UI", 12, FontStyle.Regular);
            Font TextFont = new Font("Nirmala UI", 14, FontStyle.Bold);

            #endregion Initializing Variables

            List<OrderInfo> OIList = GetOrders();

            if (OIList.Count == 0)
            {
                return;
            }

            foreach (OrderInfo Order in OIList)
            {
                string VendorStr = "Vendor: ";
                string DeliveryTimeStr = $"Delivery Time: {Order.CustomerName}";
                string TotalItemsStr = $"Total Items: {Order.TotalPrice.ToString()}";
                string TotalPriceStr = $"Total Price: {Order.TotalPrice.ToString()}";
                string DeliveryStartStr = "Date Purchased: Processing";
                string DeliveryEndStr = "Date Delivered: Processing";

                string PanelName = "ObjPanelName";

                Panel vendorPanelObject = GenControls.AddPanel(PanelName, Color.White, orderPanelSize);

                Label VendorTitleLabel = GenControls.AddLabel(VendorStr, VendorStr, VendorLoc, TextFont, Color.Black, Color.Transparent, EmptySize, true);
                Label DeliveryTimeLabel = GenControls.AddLabel(DeliveryTimeStr, DeliveryTimeStr, DeliveryTimeLoc, DefaultFont, Color.Black, Color.Transparent, EmptySize, true);
                Label TotalItemLabel = GenControls.AddLabel(TotalItemsStr, TotalItemsStr, TotalItemsLoc, DefaultFont, Color.Black, Color.Transparent, EmptySize, true);
                Label TotalPriceLabel = GenControls.AddLabel(TotalPriceStr, TotalPriceStr, TotalPriceLoc, DefaultFont, Color.Black, Color.Transparent, StatusSize, false);
                Label DeliveryStartLabel = GenControls.AddLabel(DeliveryStartStr, DeliveryStartStr, DeliveryStartLoc, DefaultFont, Color.Black, Color.Transparent, StatusSize, false);
                Label DeliveryEndLabel = GenControls.AddLabel(DeliveryEndStr, DeliveryEndStr, DeliveryEndLoc, DefaultFont, Color.Black, Color.Transparent, StatusSize, false);

                Control[] controlArray = new Control[] { VendorTitleLabel, DeliveryTimeLabel, TotalItemLabel, TotalPriceLabel, DeliveryStartLabel, DeliveryEndLabel };

                foreach (Control curControl in controlArray)
                {
                    //Add Event Handlers Below
                    //curControl.Click += new EventHandler(OpenOrder);
                    //curControl.MouseMove += new MouseEventHandler(CursorChangeArgs);
                    vendorPanelObject.Controls.Add(curControl);
                    curControl.Tag = Order.OrderID.ToString();
                }

                OrderFlowPanel.Controls.Add(vendorPanelObject);
                //vendorPanelObject.Click += new EventHandler(OpenOrder);
                //vendorPanelObject.MouseMove += new MouseEventHandler(CursorChangeArgs);
                //vendorPanelObject.Tag = Order.OrderID.ToString();
                //GenerateControls();
            }
        }

        private List<OrderInfo> GetOrders()
        {
            List<OrderInfo> OI = new List<OrderInfo>(); 
            for (int i = 0; i < 5; i++)
            {
                OrderInfo OX = new OrderInfo();
                OX.CustomerName = ("%%");
                OX.EndPurchase = DateTime.Parse("10/10/10 11:11:11");
                OX.StartPurchase = DateTime.Parse("10/10/10 11:11:11");
                OX.VendorID = 1;
                OI.Add(OX);
            }

            return OI;
        }
    }
}
