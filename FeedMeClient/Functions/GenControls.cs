using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedMeClient.Functions
{
    /// <summary>
    /// Generate Controls is a Class Which allows you to Dynamically Create Different Objects/Controls
    /// </summary>
    class GenControls
    {
        #region Dynamic Control Methods

        #region Panel Method
        public static Panel AddPanel(string panelName, Color panelColour, Size panelSize)
        {
            Panel panelObject = new Panel();

            panelObject.Name = panelName + "Panel";
            panelObject.BackColor = panelColour;
            panelObject.Size = panelSize;
            panelObject.TabIndex = 0;
            panelObject.Font = new Font("Nirmala UI", 14);
            panelObject.Margin = new Padding(8, 5, 5, 5);

            return panelObject;
        }
        #endregion

        #region Label Method
        public static Label AddLabel(string labelName, string labelText, Point labelLocation, string labelFont, int fontSize, FontStyle labelFontStyle, Color labelForeColor, Color labelBackColor, Size labelSize, bool autoSize)
        {
            Label labelObject = new Label();

            //Set Properties
            labelObject.Name = labelName + "Label";
            labelObject.Text = labelText;

            labelObject.ForeColor = labelForeColor;
            labelObject.BackColor = labelBackColor;

            labelObject.Font = new Font(labelFont, fontSize, labelFontStyle);

            if (!autoSize)
            {
                labelObject.Size = labelSize;
            }
            else
            {
                labelObject.AutoSize = false;
            }

            labelObject.Location = labelLocation;
            labelObject.TextAlign = ContentAlignment.MiddleCenter;
            labelObject.Margin = new Padding(5);

            return labelObject;
        }
        #endregion

        #region PictureBox Method
        public static PictureBox AddPictureBox(string picBoxName, Point picBoxLocation, Size picBoxSize)
        {
            PictureBox picBoxObject = new PictureBox();

            //Setting Properties
            picBoxObject.Name = picBoxName + "PicBox";
            picBoxObject.Image = FeedMeClient.Properties.Resources.Pizza_Express; //This is Temporary until i Set up the Server. The Image won't even be handled in this function;

            picBoxObject.Location = picBoxLocation;
            picBoxObject.Size = picBoxSize;

            picBoxObject.SizeMode = PictureBoxSizeMode.Zoom;



            return picBoxObject;
        }
        #endregion

        #endregion
    }
}
