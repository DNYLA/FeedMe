using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedMeLogic.Controls
{
    public partial class ViewReviews : UserControl
    {
        public ViewReviews()
        {
            InitializeComponent();
        }

        public void GeneratControls(string vendorID)
        {
            #region Initializing Variables

            Size EmptySize = new Size(0, 0);


            Size panelSize = new Size(638, 100);
            Point DeliveryStartLoc = new Point(41, 49);
            Point DeliveryEndLoc = new Point(334, 49);

            Point statisLoc = new Point(14, 9);
            Point nameLoc = new Point(285, 9);
            Point ratingLoc = new Point(532, 9);
            Point messageLoc = new Point(249, 39);
            Point dateLoc = new Point(14, 70);

            Font DefaultFont = new Font("Nirmala UI", 12, FontStyle.Regular);
            Font TextFont = new Font("Nirmala UI", 12, FontStyle.Regular);

            #endregion Initializing Variables

            DataTable dt = Server.ReviewHandler.GetReviews(vendorID);

            foreach (DataRow review in dt.Rows)
            {
                string name = review[5].ToString() + " " + review[6].ToString();
                string rating = "Rating " + review[4].ToString();
                string reviewMessage = review[3].ToString();
                string date = "Date: "+ review[2].ToString();
                string status = "Status: " + review[0].ToString();

                string PanelName = "ObjPanelName";

                Panel vendorPanelObject = GenControls.AddPanel(PanelName, Color.White, panelSize);

                Label NameLabel = GenControls.AddLabel(name, name, nameLoc, TextFont, Color.Black, Color.Transparent, EmptySize, true);
                Label RatingLabel = GenControls.AddLabel(rating, rating, ratingLoc, TextFont, Color.Black, Color.Transparent, EmptySize, true);
                Label ReviewLabel = GenControls.AddLabel("reviewMsg", reviewMessage, messageLoc, TextFont, Color.Black, Color.Transparent, EmptySize, true);
                Label DateLabel = GenControls.AddLabel(date, date, dateLoc, TextFont, Color.Black, Color.Transparent, EmptySize, true);
                Label StatusLabel = GenControls.AddLabel(status, status, statisLoc, TextFont, Color.Black, Color.Transparent, EmptySize, true);

                Control[] controlArray = new Control[] { NameLabel, RatingLabel, ReviewLabel, DateLabel, StatusLabel };

                foreach (Control curControl in controlArray)
                {
                    vendorPanelObject.Controls.Add(curControl);
                }

                reviewFlowPanel.Controls.Add(vendorPanelObject);
                //decimal val = decimal.Round(Server.ReviewHandler.CalculateRating(vendorIDLabel.Text), 2, MidpointRounding.AwayFromZero);
                //TotalRatingLabel.Text = $"Rating:  {val.ToString()}";
            }
        }

        private void orderIDLabel_TextChanged(object sender, EventArgs e)
        {
            GeneratControls(vendorIDLabel.Text);
            
        }
    }
}
