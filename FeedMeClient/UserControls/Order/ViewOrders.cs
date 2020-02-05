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
        }

        public void GenerateControls()
        {
            #region Initializing Variables

            Size EmptySize = new Size(0, 0);
            Size orderPanelSize = new Size(660, 94);
            Size StatusSize = new Size(300, 21);

            Point VendorLoc = new Point(264, 10);
            Point DeliveryStartLoc = new Point(41, 49);
            Point DeliveryEndLoc = new Point(334, 49);



            Font DefaultFont = new Font("Nirmala UI", 12, FontStyle.Regular);
            Font TextFont = new Font("Nirmala UI", 14, FontStyle.Regular);

            #endregion Initializing Variables

            List<OrderInfo> OIList = GetOrders();

            if (OIList.Count == 0)
            {
                return;
            }

            foreach (OrderInfo Order in OIList)
            {
                string VendorStr = $"Vendor: {Order.VendorName}";
                string DeliveryStartStr = $"Date Purchased: {Order.StartPurchase}";
                string DeliveryEndStr = $"Date Delivered: {Order.EndPurchase}";

                string PanelName = "ObjPanelName";

                Panel vendorPanelObject = GenControls.AddPanel(PanelName, Color.White, orderPanelSize);

                Label VendorTitleLabel = GenControls.AddLabel(VendorStr, VendorStr, VendorLoc, TextFont, Color.Black, Color.Transparent, StatusSize, false);
                Label DeliveryStartLabel = GenControls.AddLabel(DeliveryStartStr, DeliveryStartStr, DeliveryStartLoc, TextFont, Color.Black, Color.Transparent, StatusSize, false);
                Label DeliveryEndLabel = GenControls.AddLabel(DeliveryEndStr, DeliveryEndStr, DeliveryEndLoc, TextFont, Color.Black, Color.Transparent, StatusSize, false);

                Control[] controlArray = new Control[] { VendorTitleLabel, DeliveryStartLabel, DeliveryEndLabel };

                foreach (Control curControl in controlArray)
                {
                    //Add Event Handlers Below
                    curControl.Click += new EventHandler(OpenOrder);
                    curControl.MouseMove += new MouseEventHandler(CursorChangeArgs);
                    vendorPanelObject.Controls.Add(curControl);
                    curControl.Tag = Order.OrderID.ToString();
                }

                OrderFlowPanel.Controls.Add(vendorPanelObject);
                vendorPanelObject.Click += new EventHandler(OpenOrder);
                vendorPanelObject.MouseMove += new MouseEventHandler(CursorChangeArgs);
                vendorPanelObject.Tag = Order.OrderID.ToString();
            }
        }

        private void CursorChangeArgs(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void OpenOrder(object sender, EventArgs e)
        {
            Form CurrentForm = FindForm(); //returns the Current Form Object that the Control is on
            UserControl userControl = CurrentForm.Controls.Find("ViewOrder1", true).OfType<UserControl>().SingleOrDefault(); //Searched for the Order Control

            Control Con = (Control)sender;

            Label TitleLabel = userControl.Controls.Find("OrderIDLabel", true).OfType<Label>().SingleOrDefault(); // Searched for the Title Label inside the Order Control
            TitleLabel.Text = $"OrderID: {Con.Tag.ToString()}";
            TitleLabel.Tag = Con.Tag; //Sets Vendor Title To Vendor that was just selected
            //TitleLabel.Tag = ""

            userControl.BringToFront();
        }

        private List<OrderInfo> GetOrders()
        {
            List<OrderInfo> OI = ConfirmOrder.GetCustomerOrders(Forms.Authentication.LoginForm.ClientInfo.UserID.ToString());

            return OI;
        }
    }
}
