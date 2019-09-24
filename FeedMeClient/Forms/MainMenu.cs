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
    public partial class MainMenu : FeedMeMainForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ButtonPanel.Height = button1.Height;
            ButtonPanel.Location = new Point(0, button1.Location.Y);

            //Set Each Buttons Location Manually
            button1.Location = new Point(ButtonPanel.Location.X + ButtonPanel.Width, button1.Location.Y);

            //Set Width Of Bar Panel
            panel1.Width = ButtonPanel.Width + button1.Width + 1;
        }
    }
}
