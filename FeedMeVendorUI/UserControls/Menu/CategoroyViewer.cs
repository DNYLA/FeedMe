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
using FeedMeLogic.Server;

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

        public void ShowCategories()
        {
            Size EmptySize = new Size(0, 0);
            Size catPanelSize = new Size(228, 136);
            Size picBoxSize = new Size(228, 79);
            Size catNameSize = new Size(82, 25);
            Size catAmmSize = new Size(57, 17);

            Point emptyLoc = new Point(0, 0);
            Point catNameLoc = new Point(85, 93);
            Point catAmmLoc = new Point(168, 115);

            Font DefaultFont = new Font("Nirmala UI", 14, FontStyle.Bold);
            Font catAmmFont = new Font("Nirmala UI", 10, FontStyle.Regular);

            List<string> catList = GetCategories(Forms.Authentication.LoginForm.VendorDetails.VendorID.ToString());


            //AddCategory.Click += new EventHandler(OpenAddCat);
            AddCategory.MouseMove += new MouseEventHandler(CursorChangeArgs);
            Panel AddCatPanel = AddCategory;

            flowLayoutPanel1.Controls.Clear();
            foreach (string category in catList)
            {
                string orderStatus = $"16 Items:"; //hard Coded right now change later

                Panel catPanel = GenControls.AddPanel(category, Color.White, catPanelSize);
                PictureBox catImage = GenControls.AddPictureBox(category, emptyLoc, picBoxSize);

                //catImage.ImageLocation = ImageHandler.GetImage(ImageTypes.Avatar, )
                catImage.SizeMode = PictureBoxSizeMode.CenterImage;
                catImage.Name = category + "picBox";
                Label catTitleLabel = GenControls.AddLabel(category, category, catNameLoc, DefaultFont, Color.Black, Color.Transparent, EmptySize, true);
                Label catAmountLabel = GenControls.AddLabel(category, orderStatus, catAmmLoc, catAmmFont, Color.Black, Color.Transparent, EmptySize, true);
                //Label orderPriceLabel = GenControls.AddLabel(PriceText + "Rating", PriceText, PriceLoc, DefaultFont, Color.Black, Color.Transparent, EmptySize, true);
                //Label orderStatusLabel = GenControls.AddLabel(orderStatus + "Rating", orderStatus, StatusLoc, DefaultFont, Color.Black, Color.Transparent, StatusSize, false);

                Control[] controlArray = new Control[] { catImage, catTitleLabel, catAmountLabel };

                foreach (Control curControl in controlArray)
                {
                    //Add Event Handlers Below
                    curControl.Click += new EventHandler(OpenOrder);
                    curControl.MouseMove += new MouseEventHandler(CursorChangeArgs);
                    catPanel.Controls.Add(curControl);
                    curControl.Tag = category;
                }

                flowLayoutPanel1.Controls.Add(catPanel);
                flowLayoutPanel1.Controls.Add(AddCatPanel);

                flowLayoutPanel1.Click += new EventHandler(OpenOrder);
                flowLayoutPanel1.MouseMove += new MouseEventHandler(CursorChangeArgs);
                flowLayoutPanel1.Tag = category;
            }
        }

        private void CursorChangeArgs(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void OpenAddCat(object sender, EventArgs e)
        {
            Form CurrentForm = FindForm(); //returns the Current Form Object that the Control is on
            UserControl userControl = CurrentForm.Controls.Find("EditItem1", true).OfType<UserControl>().SingleOrDefault(); //Searched for the Order Control

            Control Con = (Control)sender;

            Label TitleLabel = userControl.Controls.Find("ItemName", true).OfType<Label>().SingleOrDefault(); // Searched for the Title Label inside the Order Control
            TitleLabel.Text = "Create New";

            userControl.BringToFront();
        }

        private void OpenOrder(object sender, EventArgs e)
        {
            Form CurrentForm = FindForm(); //returns the Current Form Object that the Control is on
            UserControl userControl = CurrentForm.Controls.Find("itemViewer1", true).OfType<UserControl>().SingleOrDefault(); //Searched for the Order Control

            Control Con = (Control)sender;

            Label TitleLabel = userControl.Controls.Find("CategoryNameLabel", true).OfType<Label>().SingleOrDefault(); // Searched for the Title Label inside the Order Control

            TitleLabel.Text = Con.Tag.ToString();

            userControl.BringToFront();
        }
    }
}
