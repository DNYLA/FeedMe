using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedMeVendorUI.UserControls.Menu
{
    public partial class MenuInfo : UserControl
    {
        public MenuInfo()
        {
            InitializeComponent();
        }

        private void MenuInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadCategories(int vendorID)
        {
            vendorID = 3;
            string SQLQuery = ($@"SELECT category FROM items
                                WHERE VendorID = {vendorID.ToString()}
                                GROUP BY category
                                ORDER BY category ASC; ");
            
        }
    }
}
