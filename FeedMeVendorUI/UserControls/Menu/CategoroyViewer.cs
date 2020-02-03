using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeedMeLogic.Vendor;
using FeedMeLogic;

namespace FeedMeVendorUI.UserControls.Menu
{
    public partial class CategoroyViewer : UserControl
    {
        public CategoroyViewer()
        {
            InitializeComponent();
        }

        private void CategoroyViewer_Load(object sender, EventArgs e)
        {

        }

        private List<string> GetCategories(string vendorID)
        {
            DataTable MenuTable = StoreMenuInfo.GetMenuInfo(vendorID); //This Returns all Items from the server
            List<string> DuplicateCategoryList = new List<string>();
            foreach (DataRow Item in MenuTable.Rows)
            {
                DuplicateCategoryList.Add(Item[3].ToString());
            }

            //itemAmm = MenuTable.Rows.Count;

            List<string> CategoryList = new List<string>();

            foreach (string category in DuplicateCategoryList)
            {
                if (!CategoryList.Contains(category))
                {
                    CategoryList.Add(category);
                }
            }

            return CategoryList;
        }

        private void ShowCategories()
        {
            Size EmptySize = new Size(0, 0);
            Size catPanelSize = new Size(228, 136);
            Size picBoxSize = new Size(225, 79);
            Size catNameSize = new Size(82, 25);
            Size catAmmSize = new Size(57, 17);

            Point emptyLoc = new Point(0, 0);
            Point catNameLoc = new Point(85, 93);
            Point catAmmLoc = new Point(168, 115);

            Font DefaultFont = new Font("Nirmala UI", 14, FontStyle.Bold);
            Font catAmmFont = new Font("Nirmala UI", 10, FontStyle.Regular);

            List<string> catList = GetCategories(Forms.Authentication.LoginForm.VendorDetails.VendorID.ToString());

            //foreach (string category in catList)
            //{
            //    string orderStatus = $"16 Items:"; //hard Coded right now change later

            //    Panel catPanel = GenControls.AddPanel("cat", Color.White, catPanelSize);
            //    PictureBox catImage = GenControls.AddPictureBox("catImg", emptyLoc, picBoxSize);

            //    Label catNameLabel = GenControls.AddLabel(orderText, orderText, OrderLoc, catAmmFont, Color.Black, Color.Transparent, EmptySize, true);
            //    Label catAmountLabel = GenControls.AddLabel(orderStatus, orderStatus, catAmmLoc, DefaultFont, Color.Black, Color.Transparent, EmptySize, true);
            //    Label orderPriceLabel = GenControls.AddLabel(PriceText + "Rating", PriceText, PriceLoc, DefaultFont, Color.Black, Color.Transparent, EmptySize, true);
            //    Label orderStatusLabel = GenControls.AddLabel(orderStatus + "Rating", orderStatus, StatusLoc, DefaultFont, Color.Black, Color.Transparent, StatusSize, false);

            //    Control[] controlArray = new Control[] { orderTitleLabel, orderCustLabel, orderPriceLabel, orderStatusLabel };

            //    foreach (Control curControl in controlArray)
            //    {
            //        //Add Event Handlers Below
            //        curControl.Click += new EventHandler(OpenOrder);
            //        curControl.MouseMove += new MouseEventHandler(CursorChangeArgs);
            //        itemPanel.Controls.Add(curControl);
            //        curControl.Tag = Order.OrderID.ToString();
            //    }

            //    if (status == "processing")
            //    {
            //        OrdersFlowPanel.Controls.Add(itemPanel);
            //    }
            //    else if (status == "Cooking")
            //    {
            //        CookingFlowPanel.Controls.Add(itemPanel);
            //    }
            //    else if (status == "Delivering")
            //    {
            //        DeliveryFlowPanel.Controls.Add(itemPanel);
            //    }

            //    itemPanel.Click += new EventHandler(OpenOrder);
            //    itemPanel.MouseMove += new MouseEventHandler(CursorChangeArgs);
            //    itemPanel.Tag = Order.OrderID.ToString();
            //    //GenerateControls();
            //}//
        }
    }
}
