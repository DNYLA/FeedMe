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
            Thread UpdateThread = new Thread(() =>
            {
                CheckForOrders();
            });
        }

        private void CheckForOrders()
        {
            FeedMeLogic.Server.ConfirmOrder.CheckForOrders(Forms.Authentication.LoginForm.VendorDetails.VendorID);
        }
    }
}
