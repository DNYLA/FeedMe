using System.Drawing;
using System.Windows.Forms;

namespace FeedMeLogic
{
    /// <summary>
    /// Generate Controls is a Class Which allows you to Dynamically Create Different Objects/Controls which can be added to a UI.
    /// </summary>
    public class GenControls
    {
        #region Dynamic Control Methods

        #region Panel Method

        public static Panel AddPanel(string panelName, Color panelColour, Size panelSize)
        {
            Panel panelObject = new Panel
            {
                Name = panelName + "Panel",
                BackColor = panelColour,
                Size = panelSize,
                TabIndex = 0,
                Font = new Font("Nirmala UI", 14),
                Margin = new Padding(8, 5, 5, 5)
            };

            return panelObject;
        }

        #endregion Panel Method

        #region Label Method

        public static Label AddLabel(string labelName, string labelText, Point labelLocation, Font labelFont, Color labelForeColor, Color labelBackColor, Size labelSize, bool autoSize)
        {
            Label labelObject = new Label
            {
                //Set Properties
                Name = labelName + "Label",
                Text = labelText,

                ForeColor = labelForeColor,
                BackColor = labelBackColor,

                Font = labelFont
            };

            if (!autoSize)
            {
                labelObject.Size = labelSize;
            }
            else
            {
                labelObject.AutoSize = true;
            }

            labelObject.Location = labelLocation;
            labelObject.TextAlign = ContentAlignment.MiddleCenter;
            labelObject.Margin = new Padding(5);

            return labelObject;
        }

        #endregion Label Method

        #region PictureBox Method

        public static PictureBox AddPictureBox(string picBoxName, Point picBoxLocation, Size picBoxSize)
        {
            PictureBox picBoxObject = new PictureBox
            {
                //Setting Properties
                Name = picBoxName + "PicBox",
                //Image = FeedMeClient.Properties.Resources.Pizza_Express, //This is Temporary until i Set up the Server. The Image won't even be handled in this function;

                Location = picBoxLocation,
                Size = picBoxSize,

                SizeMode = PictureBoxSizeMode.Zoom
            };

            return picBoxObject;
        }

        #endregion PictureBox Method

        #region Button Method

        //To Shorten the Amount of paramters i decided to make it so you have to build the Font variable as one instead of three seperate paramters for font.
        public static Button AddButton(string buttonName, string buttonText, Point buttonLocation, Font buttonFont, Color buttonForeColor, Color buttonBackColor, Size buttonSize, bool autoSize)
        {
            Button buttonObject = new Button
            {
                Name = buttonName + "Button",
                Text = buttonText,
                Location = buttonLocation,
                Font = buttonFont,
                ForeColor = buttonForeColor,
                BackColor = buttonBackColor,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(5)
            };

            if (!autoSize)
            {
                buttonObject.Size = buttonSize;
            }
            else
            {
                buttonObject.AutoSize = true;
            }

            buttonObject.Location = buttonLocation;
            buttonObject.FlatAppearance.BorderSize = 1;

            return buttonObject;
        }

        #endregion Button Method

        #region TextBox Method

        public static TextBox AddTextBox(string TextBoxName, string TextBoxText, string TextBoxTag, Point TextBoxLocation, Font TextBoxFont, Color BoxForeColor, Color BoxBackColor, Size TextBoxSize)
        {
            TextBox textBoxObject = new TextBox
            {
                Name = TextBoxName + "TBox",
                Text = TextBoxText,
                ForeColor = BoxForeColor,
                BackColor = BoxBackColor,
                Tag = TextBoxTag,
                Font = TextBoxFont,
                Size = TextBoxSize,
                Location = TextBoxLocation,
                BorderStyle = BorderStyle.None,
                TextAlign = HorizontalAlignment.Center,
                Margin = new Padding(5)
            };

            return textBoxObject;
        }

        #endregion TextBox Method

        #endregion Dynamic Control Methods
    }
}