using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FeedMeClient.Forms
{
    /// <summary>
    /// The FeedMeMainForm Is a Basic Template which Most (If Not All) Forms will use to keep the same look. This saves time & also makes sure all forms
    /// have the same basic look.
    /// </summary>
    public partial class FeedMeMainForm : Form
    {
        #region Move Window Method

        //No Border Styled Forms Don't include a functions/Form which allows you to move the window
        //Credit To: https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable/1592924
        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion Move Window Method

        #region Load Event

        public FeedMeMainForm()
        {
            InitializeComponent();
            //If I Decide to add A Dark/Light Theme System The Colours Below will be used
            //Dark Back Color: 2D2D30
            //Light Back Color: D2D2CF (Current)
        }

        private void FeedMeMainForm_Load(object sender, EventArgs e)
        {
            ReSizeTitle();
        }

        #endregion Load Event

        #region Button Click Events

        private void TopPanelCloseButton_Click(object sender, EventArgs e)
        {
            //Add a check to See if Its Main Form and then either Application.Exit || Form.Close
            if (Name == "MainMenu" || Name == "LoginForm" || Name == "Register")
            {
                FeedMeLogic.Server.ServerConnection.CloseConnection();
                Application.Exit();
            }
            else
            {
                Close();
            }
        }

        private void TopPanelMaximizeButton_Click(object sender, EventArgs e)
        {
            //Maximizes Form. If already Maximized it will return to normal
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            ReSizeTitle();
        }

        private void TopPanelMinimizeButton_Click(object sender, EventArgs e)
        {
            //Minimizes Form to background
            WindowState = FormWindowState.Minimized;
        }

        #endregion Button Click Events

        #region Protected Override Events

        //All Of these Events are used to ReDraw Title in Designer View
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ReSizeTitle();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            ReSizeTitle();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ReSizeTitle();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            ReSizeTitle();
        }

        #endregion Protected Override Events

        #region Move Window Events

        //Need to Check Events For Top Panel && The Title Label
        private void TopBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            ReSizeTitle();
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            ReSizeTitle();
        }

        #endregion Move Window Events

        #region Form Helpers

        /// <summary>
        /// Simple Function Which positions the Title Label in the "Centre" of the screen. Its Called On Maximized/Minimized && On Form Load
        /// </summary>
        private void ReSizeTitle()
        {
            TitleLabel.Text = "FeedMe - " + Text;
            TitleLabel.Left = ((TopBarPanel.ClientSize.Width - TitleLabel.Width) / 2) + 0;
            TitleLabel.Top = ((TopBarPanel.ClientSize.Height - TitleLabel.Height) / 2);
        }

        #endregion Form Helpers
    }
}