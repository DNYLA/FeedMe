namespace FeedMeVendorUI.Forms
{
    partial class FeedMeVendorTemplate
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
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.TopPanelMinimizeButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TopPanelCloseButton = new System.Windows.Forms.Button();
            this.TopPanelMaximizeButton = new System.Windows.Forms.Button();
            this.TopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TopBarPanel.Controls.Add(this.TopPanelMinimizeButton);
            this.TopBarPanel.Controls.Add(this.TitleLabel);
            this.TopBarPanel.Controls.Add(this.TopPanelCloseButton);
            this.TopBarPanel.Controls.Add(this.TopPanelMaximizeButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(800, 21);
            this.TopBarPanel.TabIndex = 1;
            this.TopBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseDown);
            // 
            // TopPanelMinimizeButton
            // 
            this.TopPanelMinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanelMinimizeButton.FlatAppearance.BorderSize = 0;
            this.TopPanelMinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.TopPanelMinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.TopPanelMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopPanelMinimizeButton.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TopPanelMinimizeButton.ForeColor = System.Drawing.Color.White;
            this.TopPanelMinimizeButton.Location = new System.Drawing.Point(740, 1);
            this.TopPanelMinimizeButton.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TopPanelMinimizeButton.Name = "TopPanelMinimizeButton";
            this.TopPanelMinimizeButton.Size = new System.Drawing.Size(20, 20);
            this.TopPanelMinimizeButton.TabIndex = 0;
            this.TopPanelMinimizeButton.TabStop = false;
            this.TopPanelMinimizeButton.Text = "0";
            this.TopPanelMinimizeButton.UseVisualStyleBackColor = true;
            this.TopPanelMinimizeButton.Click += new System.EventHandler(this.TopPanelMinimizeButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.TitleLabel.Location = new System.Drawing.Point(372, 2);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(104, 17);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "FeedMe - Login";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseDown);
            // 
            // TopPanelCloseButton
            // 
            this.TopPanelCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanelCloseButton.FlatAppearance.BorderSize = 0;
            this.TopPanelCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.TopPanelCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.TopPanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopPanelCloseButton.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TopPanelCloseButton.ForeColor = System.Drawing.Color.White;
            this.TopPanelCloseButton.Location = new System.Drawing.Point(780, 1);
            this.TopPanelCloseButton.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TopPanelCloseButton.Name = "TopPanelCloseButton";
            this.TopPanelCloseButton.Size = new System.Drawing.Size(20, 20);
            this.TopPanelCloseButton.TabIndex = 0;
            this.TopPanelCloseButton.TabStop = false;
            this.TopPanelCloseButton.Text = "r";
            this.TopPanelCloseButton.UseVisualStyleBackColor = true;
            this.TopPanelCloseButton.Click += new System.EventHandler(this.TopPanelCloseButton_Click);
            // 
            // TopPanelMaximizeButton
            // 
            this.TopPanelMaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanelMaximizeButton.FlatAppearance.BorderSize = 0;
            this.TopPanelMaximizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.TopPanelMaximizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.TopPanelMaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopPanelMaximizeButton.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TopPanelMaximizeButton.ForeColor = System.Drawing.Color.White;
            this.TopPanelMaximizeButton.Location = new System.Drawing.Point(760, 1);
            this.TopPanelMaximizeButton.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.TopPanelMaximizeButton.Name = "TopPanelMaximizeButton";
            this.TopPanelMaximizeButton.Size = new System.Drawing.Size(20, 20);
            this.TopPanelMaximizeButton.TabIndex = 0;
            this.TopPanelMaximizeButton.TabStop = false;
            this.TopPanelMaximizeButton.Text = "1";
            this.TopPanelMaximizeButton.UseVisualStyleBackColor = true;
            this.TopPanelMaximizeButton.Click += new System.EventHandler(this.TopPanelMaximizeButton_Click);
            // 
            // FeedMeVendorTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TopBarPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FeedMeVendorTemplate";
            this.Text = "FeedMeVendorTemplate";
            this.Load += new System.EventHandler(this.FeedMeVendorTemplate_Load);
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Button TopPanelMinimizeButton;
        private System.Windows.Forms.Button TopPanelCloseButton;
        private System.Windows.Forms.Button TopPanelMaximizeButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}