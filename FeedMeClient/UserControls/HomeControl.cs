using FeedMeLogic;
using FeedMeLogic.Server;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FeedMeClient.UserControls
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        #region Obsolete

        [Obsolete("Master Generator Updated which doesn't require this function anymore.")]
        private void ControlGenerator(int CurrentGen, int HighGen)
        {
            /*
             * RULES/MATH INVOLVED
             * YOU CAN ONLY GENERATE A MAX OF 4 PANELS WITHOUT CUTTING A PANEL IN HALF
             * When The user scrolls down you need to generate the next four panels BUT
             * if their are only 3 more panels instead of 4 there will be a Out of Index ERROR
             * to stop this you need to use the curGenLow & curGenHigh Variables to determine what
             * values must be .
             *
             */
            try
            {
                MasterGenerator();
                CurrentGen = 4;
                HighGen = 7;
            }
            catch
            {
            }
        }

        #endregion Obsolete

        #region Event Handlers

        private void HomeControl_Load(object sender, EventArgs e)
        {
            //Prevents Any Errors When Loading MainMenu Form in Design View
            if (!ServerConnection.Connected)
            {
                return;
            }

            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;

            MasterGenerator();
        }

        private void CursorChangeArgs(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void OpenVendor(object sender, EventArgs e)
        {
            #region Initializing Variables

            Control PanelControl = (Control)sender; //Not Specifying if it is a Button, Label ETC because it can be any.
            int VendorNameLen = PanelControl.Name.Length;
            string PanelName = PanelControl.Name;
            int LenToRemove = 0;

            #endregion Initializing Variables

            #region Removing Label Ending

            //Cant Use a Switch Statement since The expression can always be different
            if (PanelName.EndsWith("DescLabel")) //DescLabel has to be before "Label" otherwise it will be ignored
            {
                LenToRemove = 9;
            }
            else if (PanelName.EndsWith("Panel") || PanelName.EndsWith("Label"))
            {
                LenToRemove = 5;
                Console.WriteLine(PanelName);
                Console.WriteLine(PanelControl.Name);
            }
            else if (PanelName.EndsWith("RatingLabel"))
            {
                LenToRemove = 11;
            }
            else if (PanelName.EndsWith("PostCodeLabel"))
            {
                LenToRemove = 13;
            }
            else
            {
                LenToRemove = 6;
            }

            #endregion Removing Label Ending

            #region Finding & Setting Order User Control Info

            string VendorName = PanelControl.Name.Substring(0, VendorNameLen - LenToRemove); //Removing "Label" From Label Name
            Form CurrentForm = FindForm(); //returns the Current Form Object that the Control is on
            UserControl userControl = CurrentForm.Controls.Find("OrderControl", true).OfType<UserControl>().SingleOrDefault(); //Searched for the Order Control

            Label TitleLabel = userControl.Controls.Find("VendorTitleLabel", true).OfType<Label>().SingleOrDefault(); // Searched for the Title Label inside the Order Control
            TitleLabel.Text = VendorName; //Sets Vendor Title To Vendor that was just selected
            //TitleLabel.Tag = ""

            userControl.BringToFront();

            #endregion Finding & Setting Order User Control Info
        }

        #endregion Event Handlers

        public void GenerateCon()
        {
            MasterGenerator();
        }

        #region Dynamic Control Generator Method

        private void MasterGenerator()
        {
            string vendorID, vendorName, vendorDescription, vendorPostcode, vendorRating;

            string SQLQuery = "SELECT * FROM vendors";
            using (DataTable DataResults = FeedMeLogic.Data.DAL.ExecCommand(SQLQuery))
            {
                int vendorAmount = DataResults.Rows.Count;
                VendorAmountLabel.Text = string.Format("There are currently {0} restraunts/food places near you", vendorAmount.ToString()); //Updates Text to Match No of Vendors

                #region Initiaizling Location & Size For Controls

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

                Font DefaultFont = new Font("Nirmala UI", 12, FontStyle.Regular);
                Font TitleFont = new Font("Nirmala UI", 14, FontStyle.Bold);

                #endregion Initiaizling Location & Size For Controls

                //string DefaultFnt = "Nirmala UI";

                int maxGen = vendorAmount;

                #region Iterating Through Each Vendor

                for (int i = 0; i < maxGen; i++)
                {
                    #region Getting Variables

                    vendorID = DataResults.Rows[i][0].ToString();
                    vendorName = DataResults.Rows[i][1].ToString();
                    vendorDescription = DataResults.Rows[i][2].ToString();
                    vendorPostcode = ("(" + DataResults.Rows[i][4].ToString() + ")");
                    //vendorRating = DataResults.Rows[i][6].ToString();
                    vendorRating = "⭐⭐⭐⭐⭐";

                    #endregion Getting Variables

                    #region Creating & Adding Event Handlers To Each Control

                    Panel vendorPanelObject = GenControls.AddPanel(vendorName, Color.White, vendorPanelSize);

                    Label vendorTitleLabel = GenControls.AddLabel(vendorName, vendorName, TitleLoc, TitleFont, Color.Black, Color.Transparent, TitleSize, true);
                    Label vendorDescLabel = GenControls.AddLabel(vendorName + "Desc", vendorDescription, DescLoc, DefaultFont, Color.Black, Color.Transparent, DescSize, false);

                    RatingLoc = new Point(vendorTitleLabel.Location.X + vendorTitleLabel.Width - 15, vendorTitleLabel.Location.Y);
                    Label vendorRatingLabel = GenControls.AddLabel(vendorName + "Rating", vendorRating, RatingLoc, DefaultFont, Color.Black, Color.Transparent, RatingSize, true);

                    PostcodeLoc = new Point(vendorRatingLabel.Location.X + vendorRatingLabel.Width - 15, vendorRatingLabel.Location.Y);
                    Label vendorPostcodeLabel = GenControls.AddLabel(vendorName + "PostCode", vendorPostcode, PostcodeLoc, DefaultFont, Color.LightGray, Color.Transparent, PostcodeSize, true);

                    PictureBox vendorPictureBox = GenControls.AddPictureBox(vendorName, PictureBoxLoc, PictureBoxSize);

                    Control[] controlArray = new Control[] { vendorTitleLabel, vendorDescLabel, vendorRatingLabel, vendorPostcodeLabel, vendorPictureBox };

                    foreach (Control curControl in controlArray)
                    {
                        //Add Event Handlers Below
                        curControl.Click += new EventHandler(OpenVendor);
                        curControl.MouseMove += new MouseEventHandler(CursorChangeArgs);
                        vendorPanelObject.Controls.Add(curControl);
                    }

                    VendorsFlowPanel.Controls.Add(vendorPanelObject);
                    vendorPanelObject.Click += new EventHandler(OpenVendor);
                    vendorPanelObject.MouseMove += new MouseEventHandler(CursorChangeArgs);

                    #endregion Creating & Adding Event Handlers To Each Control
                }

                #endregion Iterating Through Each Vendor
            }
        }

        #endregion Dynamic Control Generator Method
    }
}