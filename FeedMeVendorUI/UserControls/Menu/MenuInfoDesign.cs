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
using FeedMeLogic.Vendor;

namespace FeedMeVendorUI.UserControls.Menu
{
    public partial class MenuInfoDesign : UserControl
    {
        public MenuInfoDesign()
        {
            InitializeComponent();
        }

        private void MenuInfoDesign_Load(object sender, EventArgs e)
        {
            if (!ServerConnection.Connected)
            {
                return;
            }
        }

        private List<string> GetCategories(string vendorID, out int itemAmm)
        {
            DataTable MenuTable = StoreMenuInfo.GetMenuInfo(vendorID); //This Returns all Items from the server
            List<string> DuplicateCategoryList = new List<string>(); 
            foreach (DataRow Item in MenuTable.Rows)
            {
                DuplicateCategoryList.Add(Item[3].ToString());
            }

            itemAmm = MenuTable.Rows.Count;

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
            Size catPanelSize = new Size(219, 135);
            Size picBoxSize = new Size(134, 21);
            Size catNameSize = new Size(134, 21);
            Size catAmmSize = new Size(134, 21);

            Point OrderLoc = new Point(65, 10);
            Point CustomerLoc = new Point(55, 37);
            Point PriceLoc = new Point(55, 65);
            Point StatusLoc = new Point(40, 89);

            Font DefaultFont = new Font("Nirmala UI", 12, FontStyle.Regular);
            Font OrderFont = new Font("Nirmala UI", 14, FontStyle.Bold);

        }
    }
}
