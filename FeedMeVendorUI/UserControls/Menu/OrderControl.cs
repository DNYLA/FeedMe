using FeedMeLogic;
using FeedMeLogic.Server;
using FeedMeNetworking.Serialization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            GenerateControls("processing");
            GenerateControls("cooking");
            GenerateControls("Delivering");
        }

        private List<OrderInfo> GetUpdates(string status)
        {
            List<OrderInfo> OrderInfo = new List<OrderInfo>();
            Task UpdateThread = Task.Factory.StartNew(() =>
            {
                OrderInfo = CheckForOrders(status);
                Console.WriteLine("Getting Update");
            });
            Console.WriteLine("Getting Update V2");
            UpdateThread.Wait();
            Console.WriteLine("Getting Update V3");
            Console.WriteLine(OrderInfo.Count.ToString());
            return OrderInfo;
        }

        private List<OrderInfo> CheckForOrders(string status)
        {
            Console.WriteLine(Forms.Authentication.LoginForm.VendorDetails.VendorID);
            return FeedMeLogic.Server.ConfirmOrder.CheckForOrders(Forms.Authentication.LoginForm.VendorDetails.VendorID, status);
        }

        private void GenerateControls(string status)
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

            #endregion Initializing Variables

            List<OrderInfo> OIList = GetUpdates(status);

            if (OIList.Count == 0)
            {
                return;
            }

            foreach (OrderInfo Order in OIList)
            {
                string orderText = "Order";
                string customerName = $"Customer: {Order.CustomerName}";
                string PriceText = $"Price: {Order.TotalPrice.ToString()}";
                string orderStatus = $"Status: {status}";

                Panel vendorPanelObject = GenControls.AddPanel(orderText, Color.White, vendorPanelSize);

                Label orderTitleLabel = GenControls.AddLabel(orderText, orderText, OrderLoc, OrderFont, Color.Black, Color.Transparent, EmptySize, true);
                Label orderCustLabel = GenControls.AddLabel(customerName, customerName, CustomerLoc, DefaultFont, Color.Black, Color.Transparent, EmptySize, true);
                Label orderPriceLabel = GenControls.AddLabel(PriceText + "Rating", PriceText, PriceLoc, DefaultFont, Color.Black, Color.Transparent, EmptySize, true);
                Label orderStatusLabel = GenControls.AddLabel(orderStatus + "Rating", orderStatus, StatusLoc, DefaultFont, Color.Black, Color.Transparent, StatusSize, false);

                Control[] controlArray = new Control[] { orderTitleLabel, orderCustLabel, orderPriceLabel, orderStatusLabel };

                foreach (Control curControl in controlArray)
                {
                    //Add Event Handlers Below
                    curControl.Click += new EventHandler(OpenOrder);
                    curControl.MouseMove += new MouseEventHandler(CursorChangeArgs);
                    vendorPanelObject.Controls.Add(curControl);
                    curControl.Tag = Order.OrderID.ToString();
                }

                if (status == "processing")
                {
                    OrdersFlowPanel.Controls.Add(vendorPanelObject);
                }
                else if (status == "Cooking")
                {
                    CookingFlowPanel.Controls.Add(vendorPanelObject);
                }
                else if (status == "Delivering")
                {
                    DeliveryFlowPanel.Controls.Add(vendorPanelObject);
                }
                
                vendorPanelObject.Click += new EventHandler(OpenOrder);
                vendorPanelObject.MouseMove += new MouseEventHandler(CursorChangeArgs);
                vendorPanelObject.Tag = Order.OrderID.ToString();
                //GenerateControls();
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

        private void FlowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}