using System.Drawing;
using System.Windows.Forms;

namespace FeedMeLogic
{
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
    }

    #region Notification Enum
    //Enum for Different Error Types
    public enum NotifType
    {
        success, error, information, warning
    }
    #endregion
}
