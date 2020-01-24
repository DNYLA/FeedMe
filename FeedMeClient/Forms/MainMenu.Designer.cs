namespace FeedMeClient.Forms
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.MenuIndicatorPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.UserViewPanel = new System.Windows.Forms.Panel();
            this.viewRefunds1 = new FeedMeClient.UserControls.Admin_.ViewRefunds();
            this.viewOrder1 = new FeedMeVendorUI.UserControls.Menu.ViewOrder();
            this.viewOrders1 = new FeedMeClient.UserControls.Order.ViewOrders();
            this.enterCredentials1 = new FeedMeClient.UserControls.Order.EnterCredentials();
            this.reviewDesign1 = new FeedMeClient.UserControls.Designs.ReviewDesign();
            this.reviewOrderControl = new FeedMeClient.UserControls.Order.ReviewOrderControl();
            this.OrderControl = new FeedMeClient.UserControls.OrderControl();
            this.HomeControl = new FeedMeClient.UserControls.HomeControl();
            this.refund1 = new FeedMeClient.UserControls.Admin_.Refund();
            this.SideMenuPanel.SuspendLayout();
            this.UserViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(161)))), ((int)(((byte)(180)))));
            this.SideMenuPanel.Controls.Add(this.button1);
            this.SideMenuPanel.Controls.Add(this.MenuButton);
            this.SideMenuPanel.Controls.Add(this.MenuIndicatorPanel);
            this.SideMenuPanel.Controls.Add(this.SettingsButton);
            this.SideMenuPanel.Controls.Add(this.OrdersButton);
            this.SideMenuPanel.Controls.Add(this.SearchButton);
            this.SideMenuPanel.Controls.Add(this.HomeButton);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 32);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(139, 677);
            this.SideMenuPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::FeedMeClient.Properties.Resources.ProfileIcon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(14, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "    Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(19, 19);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(111, 35);
            this.MenuButton.TabIndex = 3;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // MenuIndicatorPanel
            // 
            this.MenuIndicatorPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.MenuIndicatorPanel.Location = new System.Drawing.Point(1, 60);
            this.MenuIndicatorPanel.Name = "MenuIndicatorPanel";
            this.MenuIndicatorPanel.Size = new System.Drawing.Size(12, 51);
            this.MenuIndicatorPanel.TabIndex = 2;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Image = global::FeedMeClient.Properties.Resources.SettingsIcon;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(0, 626);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(139, 51);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "       Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // OrdersButton
            // 
            this.OrdersButton.FlatAppearance.BorderSize = 0;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.ForeColor = System.Drawing.Color.White;
            this.OrdersButton.Image = global::FeedMeClient.Properties.Resources.ProfileIcon;
            this.OrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersButton.Location = new System.Drawing.Point(12, 162);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(123, 51);
            this.OrdersButton.TabIndex = 2;
            this.OrdersButton.Text = "     Orders";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Image = global::FeedMeClient.Properties.Resources.SearchIcon;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(12, 111);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(123, 51);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "     Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = global::FeedMeClient.Properties.Resources.HomeIcon;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(12, 60);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(123, 51);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "     Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // UserViewPanel
            // 
            this.UserViewPanel.BackColor = System.Drawing.SystemColors.Control;
            this.UserViewPanel.Controls.Add(this.refund1);
            this.UserViewPanel.Controls.Add(this.viewRefunds1);
            this.UserViewPanel.Controls.Add(this.viewOrder1);
            this.UserViewPanel.Controls.Add(this.viewOrders1);
            this.UserViewPanel.Controls.Add(this.enterCredentials1);
            this.UserViewPanel.Controls.Add(this.reviewDesign1);
            this.UserViewPanel.Controls.Add(this.reviewOrderControl);
            this.UserViewPanel.Controls.Add(this.OrderControl);
            this.UserViewPanel.Controls.Add(this.HomeControl);
            this.UserViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserViewPanel.Location = new System.Drawing.Point(139, 32);
            this.UserViewPanel.Name = "UserViewPanel";
            this.UserViewPanel.Size = new System.Drawing.Size(764, 677);
            this.UserViewPanel.TabIndex = 2;
            // 
            // viewRefunds1
            // 
            this.viewRefunds1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRefunds1.Location = new System.Drawing.Point(0, -5);
            this.viewRefunds1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewRefunds1.Name = "viewRefunds1";
            this.viewRefunds1.Size = new System.Drawing.Size(767, 677);
            this.viewRefunds1.TabIndex = 7;
            // 
            // viewOrder1
            // 
            this.viewOrder1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrder1.Location = new System.Drawing.Point(-1, -5);
            this.viewOrder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewOrder1.Name = "viewOrder1";
            this.viewOrder1.Size = new System.Drawing.Size(767, 677);
            this.viewOrder1.TabIndex = 6;
            // 
            // viewOrders1
            // 
            this.viewOrders1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.viewOrders1.Location = new System.Drawing.Point(-3, 0);
            this.viewOrders1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewOrders1.Name = "viewOrders1";
            this.viewOrders1.Size = new System.Drawing.Size(767, 677);
            this.viewOrders1.TabIndex = 5;
            // 
            // enterCredentials1
            // 
            this.enterCredentials1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCredentials1.Location = new System.Drawing.Point(-3, 0);
            this.enterCredentials1.Margin = new System.Windows.Forms.Padding(6);
            this.enterCredentials1.Name = "enterCredentials1";
            this.enterCredentials1.Size = new System.Drawing.Size(767, 677);
            this.enterCredentials1.TabIndex = 4;
            // 
            // reviewDesign1
            // 
            this.reviewDesign1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewDesign1.Location = new System.Drawing.Point(-3, -5);
            this.reviewDesign1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reviewDesign1.Name = "reviewDesign1";
            this.reviewDesign1.Size = new System.Drawing.Size(767, 677);
            this.reviewDesign1.TabIndex = 3;
            // 
            // reviewOrderControl
            // 
            this.reviewOrderControl.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.reviewOrderControl.Location = new System.Drawing.Point(0, 0);
            this.reviewOrderControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reviewOrderControl.Name = "reviewOrderControl";
            this.reviewOrderControl.Size = new System.Drawing.Size(764, 677);
            this.reviewOrderControl.TabIndex = 2;
            // 
            // OrderControl
            // 
            this.OrderControl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderControl.Location = new System.Drawing.Point(-3, 0);
            this.OrderControl.Margin = new System.Windows.Forms.Padding(6);
            this.OrderControl.Name = "OrderControl";
            this.OrderControl.Size = new System.Drawing.Size(767, 677);
            this.OrderControl.TabIndex = 1;
            // 
            // HomeControl
            // 
            this.HomeControl.AutoSize = true;
            this.HomeControl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeControl.Location = new System.Drawing.Point(0, 0);
            this.HomeControl.Margin = new System.Windows.Forms.Padding(6);
            this.HomeControl.Name = "HomeControl";
            this.HomeControl.Size = new System.Drawing.Size(771, 677);
            this.HomeControl.TabIndex = 0;
            // 
            // refund1
            // 
            this.refund1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.refund1.Location = new System.Drawing.Point(-1, 0);
            this.refund1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refund1.Name = "refund1";
            this.refund1.Size = new System.Drawing.Size(767, 677);
            this.refund1.TabIndex = 8;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 709);
            this.Controls.Add(this.UserViewPanel);
            this.Controls.Add(this.SideMenuPanel);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Controls.SetChildIndex(this.SideMenuPanel, 0);
            this.Controls.SetChildIndex(this.UserViewPanel, 0);
            this.SideMenuPanel.ResumeLayout(false);
            this.UserViewPanel.ResumeLayout(false);
            this.UserViewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Panel MenuIndicatorPanel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Panel UserViewPanel;
        private UserControls.HomeControl HomeControl;
        private UserControls.OrderControl OrderControl;
        private UserControls.Order.ReviewOrderControl reviewOrderControl;
        private UserControls.Designs.ReviewDesign reviewDesign1;
        private UserControls.Order.EnterCredentials enterCredentials1;
        private UserControls.Order.ViewOrders viewOrders1;
        private System.Windows.Forms.Button button1;
        private FeedMeVendorUI.UserControls.Menu.ViewOrder viewOrder1;
        private UserControls.Admin_.ViewRefunds viewRefunds1;
        private UserControls.Admin_.Refund refund1;
    }
}