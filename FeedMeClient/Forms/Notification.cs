using System;
using System.Drawing;
using System.Windows.Forms;

namespace FeedMeClient.Forms
{
    /// <summary>
    /// Form Which is used to create Custom notifications over the built in MessageBoxes.
    /// </summary>
    public partial class Notification : Form
    {
        #region Initiaizling Components
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
        #endregion


        #region Event Handlers

        #region Timer Handlers
        private void NotifStartTimer_Tick(object sender, EventArgs e)
        {
            //Starts Timer for Changing Opacity & Also Disables Current Timer
            NotifOpacityTimer.Enabled = true;
            NotifStartTimer.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Changes Opacity
            Opacity = Opacity - 0.01;

            //Closes Form After Changing Opacity to 1%
            if (Opacity < 0.05)
            {
                Close();
            }
        }

        #endregion

        #region Other Handlers
        private void Notification_Load(object sender, EventArgs e)
        {
            //On Load Center & Also Start Timer
            CenterToScreen();
            TopMost = true;
            NotifStartTimer.Enabled = true;

        }



        private void Label2_Click(object sender, EventArgs e)
        {
            //Closes Form If X is Clicked
            Close();
        }
        #endregion

        #endregion
    }

    #region Notification Enum
    //Enum for Different Error Types
    public enum NotifType
    {
        success, error, information, warning
    }
    #endregion
}
