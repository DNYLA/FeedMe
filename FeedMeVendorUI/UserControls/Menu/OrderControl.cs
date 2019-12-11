using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using FeedMeNetworking.Serialization;
using FeedMeLogic;
using FeedMeLogic.Server;

namespace FeedMeVendorUI.UserControls.Menu
{
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        private void OrderControl_Load(object sender, EventArgs e)
        {
            if (!ServerConnection.Connected)
            {
                return;
            }
            GenerateControls();
        }

        private List<OrderInfo> GetUpdates()
        {
            List<OrderInfo> OrderInfo = new List<OrderInfo>();
            Task UpdateThread = new Task(() =>
            {
                OrderInfo = CheckForOrders();
            });
            UpdateThread.Start();

            UpdateThread.Wait();

            return OrderInfo;
        }

        private List<OrderInfo> CheckForOrders()
        {
            Console.WriteLine(Forms.Authentication.LoginForm.VendorDetails.VendorID);
            return FeedMeLogic.Server.ConfirmOrder.CheckForOrders(Forms.Authentication.LoginForm.VendorDetails.VendorID);
        }

        private void GenerateControls()
        {
            #region Initializing Variables
            Size EmptySize = new Size(0, 0);
            Size vendorPanelSize = new Size(219, 135);
            Size StatusSize = new Size(134, 21);

            Point OrderLoc = new Point(65, 10);
            Point CustomerLoc = new Point(55, 37);
            Point PriceLoc = new Point(55, 65);
            Point StatusLoc = new Point(40, 89);

            Font DefaultFont = new Font("Nirmala UI", 12, FontStyle.Regular);
            Font OrderFont = new Font("Nirmala UI", 14, FontStyle.Bold);
            #endregion



            List<OrderInfo> OIList = GetUpdates();
            if (OIList.Count == 0)
            {
                return;
            }

            foreach (OrderInfo Order in OIList)
            {

                string orderText = "Order";
                string customerName = $"Customer: {Order.CustomerName}";
                string PriceText = $"Price: {Order.TotalPrice.ToString()}";
                string orderStatus = "Status: Processing";

                Panel vendorPanelObject = GenControls.AddPanel(orderText, Color.White, vendorPanelSize);

                Label orderTitleLabel = GenControls.AddLabel(orderText, orderText, OrderLoc, OrderFont, Color.Black, Color.Transparent, EmptySize, true);
                Label orderCustLabel = GenControls.AddLabel(customerName, customerName, CustomerLoc, DefaultFont, Color.Black, Color.Transparent, EmptySize, true);
                Label orderPriceLabel = GenControls.AddLabel(PriceText + "Rating", PriceText, PriceLoc, DefaultFont, Color.Black, Color.Transparent, EmptySize, true);
                Label orderStatusLabel = GenControls.AddLabel(orderStatus + "Rating", orderStatus, StatusLoc, DefaultFont, Color.Black, Color.Transparent, StatusSize, false);
            

                Control[] controlArray = new Control[] { orderTitleLabel, orderCustLabel, orderPriceLabel, orderStatusLabel };


                foreach (Control curControl in controlArray)
                {
                    //Add Event Handlers Below
                    //curControl.Click += new EventHandler(OpenVendor);
                    //curControl.MouseMove += new MouseEventHandler(CursorChangeArgs);
                    vendorPanelObject.Controls.Add(curControl);

                }

                OrdersFlowPanel.Controls.Add(vendorPanelObject);
                //vendorPanelObject.Click += new EventHandler(OpenVendor);
                //vendorPanelObject.MouseMove += new MouseEventHandler(CursorChangeArgs);
            }
        }
    }
}
