using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedMeClient.Forms
{
    public partial class MainMenu : FeedMeMainForm
    {
        //Initializing Variables used globaly WITHIN the Class
        private bool menuClosed = false;

        private const int CLOSED_PANEL_WDITH = 80;
        private const int OPENED_PANEL_WIDTH = 139;
        private readonly string[] MenuButtonNames = new string[4];

        //
        public MainMenu()
        {
            InitializeComponent(); //Initiaizling Stuff
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            HomeControl.BringToFront(); //Brings Vendor List Control to Front
            Button[] MenuButtonArray = new Button[] { HomeButton, SearchButton, OrdersButton, adminButton };

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
            Task ThreadMenu = new Task(() =>
            {
                //Slow Down Animation When approaching Button.
                Button[] MenuButtonArray = new Button[] { HomeButton, SearchButton, OrdersButton, adminButton }; // Coppied from Above not making it a Global Variable to prevent any changes

                if (menuClosed)
                {
                    while (SideMenuPanel.Width < OPENED_PANEL_WIDTH)
                    {
                        MethodInvoker updateIt = delegate
                       {
                           SideMenuPanel.Width += 1;
                       };
                        SideMenuPanel.BeginInvoke(updateIt);
                        //Add User Control ReSizing Below
                        //Adding a Panel & Then Docking it to the centre removes the need to resize controls as it is handled within the docking.
                        MethodInvoker UiThread = delegate
                         {
                             if (MenuIndicatorPanel.Width > 15)
                             {
                                 MenuIndicatorPanel.Width += 1;
                                 System.Threading.Thread.Sleep(30);
                             }
                             else
                             {
                                 MenuIndicatorPanel.BackColor = Color.DodgerBlue;
                                 System.Threading.Thread.Sleep(10);
                             }
                         };
                        MenuIndicatorPanel.BeginInvoke(UiThread);
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        OpenButton(MenuButtonArray[i], MenuButtonNames[i]);
                    }

                    OpenButton(SettingsButton, "    Settings");

                    menuClosed = false;
                }
                else
                {
                    while (SideMenuPanel.Width > CLOSED_PANEL_WDITH)
                    {
                        MethodInvoker updateIt = delegate
                       {
                           SideMenuPanel.Width -= 1;
                       };
                        SideMenuPanel.BeginInvoke(updateIt);
                        Application.DoEvents();
                        if (MenuIndicatorPanel.Width != 5)
                        {
                            MethodInvoker updateIt2 = delegate
                            {
                                MenuIndicatorPanel.Width -= 1;
                            };
                            MenuIndicatorPanel.BeginInvoke(updateIt2);
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(30);
                        }
                        else
                        {
                            MenuIndicatorPanel.BackColor = Color.Blue;
                            System.Threading.Thread.Sleep(10);
                        }

                        //Add User Control ReSizing Below
                    }

                    menuClosed = true;

                    for (int i = 0; i < 3; i++)
                    {
                        CloseButton(MenuButtonArray[i]);
                    }
                    CloseButton(SettingsButton);
                }
            });
            ThreadMenu.Start();
        }

        private void AnimateIndicator(Button ButtonObject)
        {
            while (MenuIndicatorPanel.Location.Y != ButtonObject.Location.Y)
            {
                if (MenuIndicatorPanel.Location.Y > ButtonObject.Location.Y)
                {
                    MenuIndicatorPanel.Location = new Point(MenuIndicatorPanel.Location.X, MenuIndicatorPanel.Location.Y - 1);
                    System.Threading.Thread.Sleep(10);
                }
                else
                {
                    MenuIndicatorPanel.Location = new Point(MenuIndicatorPanel.Location.X, MenuIndicatorPanel.Location.Y + 1);
                    System.Threading.Thread.Sleep(10);
                }
            }
        }

        private void OpenButton(Button ButtonObject, string ButtonName)
        {
            MethodInvoker updateIt2 = delegate
            {
                Application.DoEvents();
                ButtonObject.Width = SideMenuPanel.Width + 5;
                ButtonObject.Text = ButtonName;
                ButtonObject.ImageAlign = ContentAlignment.MiddleLeft;
                ButtonObject.Location = new Point(MenuIndicatorPanel.Location.X + 12, ButtonObject.Location.Y);
            };
            MenuIndicatorPanel.BeginInvoke(updateIt2);
        }

        private void CloseButton(Button ButtonObject)
        {
            MethodInvoker updateIt2 = delegate
            {
                ButtonObject.Width = SideMenuPanel.Width;
                ButtonObject.Text = "";
                ButtonObject.ImageAlign = ContentAlignment.MiddleCenter;
                ButtonObject.Location = new Point(MenuIndicatorPanel.Location.X + 3, ButtonObject.Location.Y);
            };
            MenuIndicatorPanel.BeginInvoke(updateIt2);
            Application.DoEvents();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Button ButtonObject = (Button)sender;
            AnimateIndicator(ButtonObject);
            HomeControl.BringToFront();
            HomeControl.GenerateCon();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Button ButtonObject = (Button)sender;
            AnimateIndicator(ButtonObject);
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Button ButtonObject = (Button)sender;
            AnimateIndicator(ButtonObject);
            viewOrders1.BringToFront();
            viewOrders1.GenerateControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button ButtonObject = (Button)sender;
            AnimateIndicator(ButtonObject);
            viewRefunds1.BringToFront();
            viewRefunds1.GenerateControls();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            settings1.BringToFront();
            settings1.LoadInfo();
        }
    }
}