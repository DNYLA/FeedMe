using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
        }
    }
}
