using System.Drawing;
using System.Windows.Forms;

namespace FeedMeLogic
{
    public partial class Notification : Form
    {
        #region Initiaizling Components

        /// <summary>
        /// Constructor for the Notification Class
        /// </summary>
        /// <param name="notifMessage">The Message to be displayed</param>
        /// <param name="type">Notification Type is a custom Enum which includes the multiple notification type</param>
        public Notification(string notifMessage, NotifType type)
        {
            InitializeComponent();

            //Setting Background Colour & Icon Depending on NotifType
            switch (type)
            {
                case NotifType.success:
                    BackColor = Color.SeaGreen;
                    pictureBox1.Image = Properties.Resources.success;
                    break;

                case NotifType.error:
                    BackColor = Color.FromArgb(212, 53, 28);
                    pictureBox1.Image = Properties.Resources.error;
                    break;

                case NotifType.information:
                    BackColor = Color.FromArgb(29, 112, 184);
                    pictureBox1.Image = Properties.Resources.warning;
                    break;

                case NotifType.warning:
                    BackColor = Color.FromArgb(255, 221, 0);
                    pictureBox1.Image = Properties.Resources.warning;
                    break;
            }
            MessageLabel.Text = notifMessage; //Setting Notification Message
        }

        #endregion Initiaizling Components

        private void NotifOpacityTimer_Tick(object sender, System.EventArgs e)
        {
            //Changes Opacity
            Opacity = Opacity - 0.01;

            //Closes Form After Changing Opacity to 1%
            if (Opacity < 0.05)
            {
                Close();
            }
        }

        private void NotifStartTimer_Tick(object sender, System.EventArgs e)
        {
            //Starts Timer for Changing Opacity & Also Disables Current Timer
            NotifOpacityTimer.Enabled = true;
            NotifStartTimer.Enabled = false;
        }

        private void Notification_Load(object sender, System.EventArgs e)
        {
            //On Load Center & Also Start Timer
            CenterToScreen();
            TopMost = true;
            NotifStartTimer.Enabled = true;
        }

        private void Label2_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }

    #region Notification Enum

    //Enum for Different Error Types
    public enum NotifType
    {
        success, error, information, warning
    }

    #endregion Notification Enum
}