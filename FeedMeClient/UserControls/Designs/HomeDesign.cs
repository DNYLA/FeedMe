using System;
using System.Windows.Forms;

namespace FeedMeClient.UserControls.Designs
{
    public partial class HomeDesign : UserControl
    {
        public HomeDesign()
        {
            InitializeComponent();
        }

        private void HomeDesign_Load(object sender, EventArgs e)
        {
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
        }
    }
}
