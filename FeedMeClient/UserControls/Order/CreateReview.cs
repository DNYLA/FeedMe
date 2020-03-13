using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedMeClient.UserControls.Order
{
    public partial class CreateReview : UserControl
    {
        private string orderID;
        public CreateReview()
        {
            InitializeComponent();
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            string orderID = orderIDT.Text.Remove(0, 9);
            string message = MessageTBox.Text;
            string rating = RatingCBox.SelectedItem.ToString();
            rating = rating.Substring(0, 1); //Returns first number which is rating.
            FeedMeLogic.Server.ReviewHandler.CreateReview(orderID, message, rating);
        }

        private void CreateReview_Load(object sender, EventArgs e)
        {
            RatingCBox.SelectedIndex = 0;
        }
    }
}
