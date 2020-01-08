namespace FeedMeVendorUI.Forms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.ReviewButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.SelectedPanel = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewOrder1 = new FeedMeVendorUI.UserControls.Menu.ViewOrder();
            this.orderControl1 = new FeedMeVendorUI.UserControls.Menu.OrderControl();
            this.storeInfo1 = new FeedMeVendorUI.UserControls.Menu.StoreInfo();
            this.menuInfo1 = new FeedMeVendorUI.UserControls.Menu.MenuInfo();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.InfoButton);
            this.panel1.Controls.Add(this.ReviewButton);
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Controls.Add(this.SelectedPanel);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Location = new System.Drawing.Point(18, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 47);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.DimGray;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(680, 3);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(90, 37);
            this.SettingsButton.TabIndex = 8;
            this.SettingsButton.Text = "     Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.FlatAppearance.BorderSize = 0;
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.ForeColor = System.Drawing.Color.DimGray;
            this.InfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoButton.Location = new System.Drawing.Point(270, 3);
            this.InfoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(90, 37);
            this.InfoButton.TabIndex = 7;
            this.InfoButton.Text = "     Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // ReviewButton
            // 
            this.ReviewButton.FlatAppearance.BorderSize = 0;
            this.ReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewButton.ForeColor = System.Drawing.Color.DimGray;
            this.ReviewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReviewButton.Location = new System.Drawing.Point(180, 3);
            this.ReviewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReviewButton.Name = "ReviewButton";
            this.ReviewButton.Size = new System.Drawing.Size(90, 37);
            this.ReviewButton.TabIndex = 6;
            this.ReviewButton.Text = "     Reviews";
            this.ReviewButton.UseVisualStyleBackColor = true;
            this.ReviewButton.Click += new System.EventHandler(this.ReviewButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.ForeColor = System.Drawing.Color.DimGray;
            this.MenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuButton.Location = new System.Drawing.Point(90, 3);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(90, 37);
            this.MenuButton.TabIndex = 5;
            this.MenuButton.Text = "     Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.Items_Click);
            // 
            // SelectedPanel
            // 
            this.SelectedPanel.BackColor = System.Drawing.Color.Yellow;
            this.SelectedPanel.Location = new System.Drawing.Point(4, 35);
            this.SelectedPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectedPanel.Name = "SelectedPanel";
            this.SelectedPanel.Size = new System.Drawing.Size(99, 4);
            this.SelectedPanel.TabIndex = 4;
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.DimGray;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 3);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(90, 37);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.Text = "     Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.viewOrder1);
            this.panel2.Controls.Add(this.orderControl1);
            this.panel2.Controls.Add(this.storeInfo1);
            this.panel2.Controls.Add(this.menuInfo1);
            this.panel2.Location = new System.Drawing.Point(18, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 451);
            this.panel2.TabIndex = 3;
            // 
            // viewOrder1
            // 
            this.viewOrder1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrder1.Location = new System.Drawing.Point(4, 5);
            this.viewOrder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewOrder1.Name = "viewOrder1";
            this.viewOrder1.Size = new System.Drawing.Size(772, 446);
            this.viewOrder1.TabIndex = 3;
            // 
            // orderControl1
            // 
            this.orderControl1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderControl1.Location = new System.Drawing.Point(-4, -5);
            this.orderControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderControl1.Name = "orderControl1";
            this.orderControl1.Size = new System.Drawing.Size(776, 451);
            this.orderControl1.TabIndex = 2;
            // 
            // storeInfo1
            // 
            this.storeInfo1.Location = new System.Drawing.Point(-4, 0);
            this.storeInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.storeInfo1.Name = "storeInfo1";
            this.storeInfo1.Size = new System.Drawing.Size(776, 451);
            this.storeInfo1.TabIndex = 1;
            // 
            // menuInfo1
            // 
            this.menuInfo1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuInfo1.Location = new System.Drawing.Point(-4, 0);
            this.menuInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuInfo1.Name = "menuInfo1";
            this.menuInfo1.Size = new System.Drawing.Size(776, 451);
            this.menuInfo1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SelectedPanel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button ReviewButton;
        private System.Windows.Forms.Panel panel2;
        private UserControls.Menu.MenuInfo menuInfo1;
        private UserControls.Menu.StoreInfo storeInfo1;
        private UserControls.Menu.OrderControl orderControl1;
        private UserControls.Menu.ViewOrder viewOrder1;
    }
}