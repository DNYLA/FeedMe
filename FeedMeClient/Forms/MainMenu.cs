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
        //Initializing Variables used globaly WITHIN the Class
        bool menuClosed = false;
        int curIndicatorWidth;
        private const int CLOSED_PANEL_WDITH = 80;
        private const int OPENED_PANEL_WIDTH = 139;
        String[] MenuButtonNames = new string[3];

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Button[] MenuButtonArray = new Button[] { HomeButton, SearchButton, ProfileButton };

            //Everything written Below can be easily edited using the Designer but Coding it in below ensure that if i edit the Menu Bar in the future
            //It will still function correctly and any new buttons or sizes i add will also work.

            //Setting MenuIndicator Height & Location
            MenuIndicatorPanel.Height = HomeButton.Height;
            MenuIndicatorPanel.Location = new Point(0, HomeButton.Location.Y);

            int IterationLength = MenuButtonArray.Length;


            for (int i = 0; i < IterationLength; i++)
            {
                //Set Each Buttons Location Manually
                MenuButtonArray[i].Location = new Point(MenuIndicatorPanel.Location.X + MenuIndicatorPanel.Width, MenuButtonArray[i].Location.Y);
                MenuButtonNames[i] = MenuButtonArray[i].Text;
            }

            //Set Width Of Bar Panel
            SideMenuPanel.Width = MenuIndicatorPanel.Width + HomeButton.Width + 1;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Button[] MenuButtonArray = new Button[] { HomeButton, SearchButton, ProfileButton }; // Coppied from Above not making it a Global Variable to prevent any changes

            if (menuClosed)
            {
                while (SideMenuPanel.Width != OPENED_PANEL_WIDTH)
                {
                    if (MenuIndicatorPanel.Width != 15)
                    {
                        MenuIndicatorPanel.Width = MenuIndicatorPanel.Width + 1;
                    }

                    
                    SideMenuPanel.Width = SideMenuPanel.Width + 1;
                    System.Threading.Thread.Sleep(10);

                    //Add User Control ReSizing Below
                    menuClosed = false;
                }

                for (int i = 0; i < 3; i++)
                {
                    OpenButton(MenuButtonArray[i], MenuButtonNames[i]);
                }

                MenuIndicatorPanel.BackColor = Color.DodgerBlue;
            }
            else
            {
                while (SideMenuPanel.Width != CLOSED_PANEL_WDITH)
                {
                    if (MenuIndicatorPanel.Width != 5)
                    {
                        MenuIndicatorPanel.Width = MenuIndicatorPanel.Width - 1;
                    }
                    SideMenuPanel.Width = SideMenuPanel.Width - 1;
                    System.Threading.Thread.Sleep(10);

                    //Add User Control ReSizing Below
                    menuClosed = true;
                }

                for (int i = 0; i < 3; i++)
                {
                    CloseButton(MenuButtonArray[i]);
                }

                MenuIndicatorPanel.BackColor = Color.Blue;
            }

        }

        private void OpenButton(Button ButtonObject, string ButtonName)
        {
            ButtonObject.Width = SideMenuPanel.Width + 5;
            ButtonObject.Text = ButtonName;
            ButtonObject.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonObject.Location = new Point(MenuIndicatorPanel.Location.X + 12, ButtonObject.Location.Y);
        }

        private void CloseButton(Button ButtonObject)
        {
            ButtonObject.Width = SideMenuPanel.Width;
            ButtonObject.Text = "";
            ButtonObject.ImageAlign = ContentAlignment.MiddleCenter;
            ButtonObject.Location = new Point(MenuIndicatorPanel.Location.X + 3, ButtonObject.Location.Y);
        }

    }
}
