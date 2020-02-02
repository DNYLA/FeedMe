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

            Point catNameLoc = new Point(85, 93);
            Point catAmmLoc = new Point(168, 115);

            Font DefaultFont = new Font("Nirmala UI", 14, FontStyle.Bold);
            Font OrderFont = new Font("Nirmala UI", 10, FontStyle.Regular);

            int

        }
    }
}
