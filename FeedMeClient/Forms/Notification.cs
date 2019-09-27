using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedMeClient.Forms
{
    public partial class Notification : Form
    {
        public Notification(string notifMessage, NotifType type)
        {
            InitializeComponent();

            switch(type)
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
                    BackColor = Color.FromArgb(255,221,0);
                    pictureBox1.Image = Properties.Resources.warning;
                    break;
            }
            MessageLabel.Text = notifMessage;
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            TopMost = true;
            NotifStartTimer.Enabled = true;
            
        }

        private void NotifStartTimer_Tick(object sender, EventArgs e)
        {
            NotifOpacityTimer.Enabled = true;
            NotifStartTimer.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = Opacity - 0.01;

            if (Opacity == 0.01)
            {
                this.Close();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public enum NotifType
    {
        success, error, information, warning
    }
}
