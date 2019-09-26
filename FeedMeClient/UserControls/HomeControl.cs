using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeedMeClient.Functions.Data;
using FeedMeClient.Functions;

namespace FeedMeClient.UserControls
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;

            MasterGenerator();
        }

        private void OpenVendor(object sender, EventArgs e)
        {
            
        }

        private void CursorChangeArgs()
        {

        }


        private void MasterGenerator()
        {
            string vendorID, vendorName, vendorDescription, vendorPostcode, vendorRating;

            string SQLQuery = "SELECT * FROM vendors";
            DataTable DataResults = DAL.ExecCommand(SQLQuery);
            int vendorAmount = DataResults.Rows.Count;
            VendorAmountLabel.Text = String.Format("There are currently {0} restraunts/food places near you", vendorAmount.ToString()); //Updates Text to Match No of Vendors

            //Initializing Height & Location Variables (Information from Design Version)
            Size vendorPanelSize = new Size(711, 96);
            Size TitleSize = new Size(142, 30);
            Size DescSize = new Size(556, 47);
            Size RatingSize = new Size(80, 21);
            Size PostcodeSize = new Size(84, 21);
            Size PictureBoxSize = new Size(127, 86);

            Point TitleLoc = new Point(344, 5);
            Point DescLoc = new Point(146, 36);
            Point RatingLoc = new Point(485, 5);
            Point PostcodeLoc = new Point(567, 5);
            Point PictureBoxLoc = new Point(4, 5);

            string DefaultFnt = "Nirmala UI";

            int maxGen = vendorAmount;

            for (int i = 0; i < maxGen; i++)
            {
                vendorID = DataResults.Rows[i][0].ToString();
                vendorName = DataResults.Rows[i][1].ToString();
                vendorDescription = DataResults.Rows[i][2].ToString();
                vendorPostcode = ("(" + DataResults.Rows[i][4].ToString() + ")");
                //vendorRating = DataResults.Rows[i][6].ToString();
                vendorRating = "⭐⭐⭐⭐⭐";

                


                //COLOR WHITE
                //
                Panel vendorPanelObject = GenControls.AddPanel(vendorName, Color.White, vendorPanelSize);

                Label vendorTitleLabel = GenControls.AddLabel(vendorName, vendorName, TitleLoc, DefaultFnt, 14, FontStyle.Bold, Color.Black, Color.Transparent, TitleSize, true);
                Label vendorDescLabel = GenControls.AddLabel(vendorName + "Desc", vendorDescription, DescLoc, DefaultFnt, 12, FontStyle.Regular, Color.Black, Color.Transparent, DescSize, false);

                RatingLoc = new Point(vendorTitleLabel.Location.X + vendorTitleLabel.Width - 15, vendorTitleLabel.Location.Y);
                Label vendorRatingLabel = GenControls.AddLabel(vendorName + "Rating", vendorRating, RatingLoc, DefaultFnt, 12, FontStyle.Regular, Color.Black, Color.Transparent, RatingSize, true);

                PostcodeLoc = new Point(vendorRatingLabel.Location.X + vendorRatingLabel.Width - 15, vendorRatingLabel.Location.Y);
                Label vendorPostcodeLabel = GenControls.AddLabel(vendorName + "PostCode", vendorPostcode, PostcodeLoc, DefaultFnt, 12, FontStyle.Regular, Color.LightGray, Color.Transparent, PostcodeSize, true);

                PictureBox vendorPictureBox = GenControls.AddPictureBox(vendorName, PictureBoxLoc, PictureBoxSize);

                Control[] controlArray = new Control[] { vendorTitleLabel, vendorDescLabel, vendorRatingLabel, vendorPostcodeLabel, vendorPictureBox };

                

                foreach(Control curControl in controlArray)
                {
                    //Add Event Handlers Below


                    vendorPanelObject.Controls.Add(curControl);
                    
                }

                VendorsFlowPanel.Controls.Add(vendorPanelObject);


            }
        }
    }
}
