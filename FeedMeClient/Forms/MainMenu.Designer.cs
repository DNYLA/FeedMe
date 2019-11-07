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
            this.MenuButton = new System.Windows.Forms.Button();
            this.MenuIndicatorPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.UserViewPanel = new System.Windows.Forms.Panel();
            this.homeDesign1 = new FeedMeClient.UserControls.Designs.HomeDesign();
            this.SideMenuPanel.SuspendLayout();
            this.UserViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(161)))), ((int)(((byte)(180)))));
            this.SideMenuPanel.Controls.Add(this.MenuButton);
            this.SideMenuPanel.Controls.Add(this.MenuIndicatorPanel);
            this.SideMenuPanel.Controls.Add(this.SettingsButton);
            this.SideMenuPanel.Controls.Add(this.ProfileButton);
            this.SideMenuPanel.Controls.Add(this.SearchButton);
            this.SideMenuPanel.Controls.Add(this.HomeButton);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 32);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(139, 677);
            this.SideMenuPanel.TabIndex = 1;
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
            // ProfileButton
            // 
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.ForeColor = System.Drawing.Color.White;
            this.ProfileButton.Image = global::FeedMeClient.Properties.Resources.ProfileIcon;
            this.ProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileButton.Location = new System.Drawing.Point(12, 162);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(123, 51);
            this.ProfileButton.TabIndex = 2;
            this.ProfileButton.Text = "     Profile";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
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
            this.UserViewPanel.Controls.Add(this.homeDesign1);
            this.UserViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserViewPanel.Location = new System.Drawing.Point(139, 32);
            this.UserViewPanel.Name = "UserViewPanel";
            this.UserViewPanel.Size = new System.Drawing.Size(764, 677);
            this.UserViewPanel.TabIndex = 2;
            // 
            // homeDesign1
            // 
            this.homeDesign1.AutoSize = true;
            this.homeDesign1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeDesign1.Location = new System.Drawing.Point(-7, 0);
            this.homeDesign1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeDesign1.Name = "homeDesign1";
            this.homeDesign1.Size = new System.Drawing.Size(767, 774);
            this.homeDesign1.TabIndex = 0;
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
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Panel UserViewPanel;
        private UserControls.Designs.HomeDesign homeDesign1;
    }
}