namespace FeedMeClient.Forms
{
    partial class FeedMeMainForm
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
            this.TopPanelCloseButton = new System.Windows.Forms.Button();
            this.TopPanelMaximizeButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.TopBarPanel.Controls.Add(this.TopPanelMinimizeButton);
            this.TopBarPanel.Controls.Add(this.TopPanelCloseButton);
            this.TopBarPanel.Controls.Add(this.TopPanelMaximizeButton);
            this.TopBarPanel.Controls.Add(this.TitleLabel);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Margin = new System.Windows.Forms.Padding(6);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(791, 32);
            this.TopBarPanel.TabIndex = 0;
            this.TopBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseDown);
            // 
            // TopPanelMinimizeButton
            // 
            this.TopPanelMinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanelMinimizeButton.FlatAppearance.BorderSize = 0;
            this.TopPanelMinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.TopPanelMinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.TopPanelMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopPanelMinimizeButton.Font = new System.Drawing.Font("Marlett", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TopPanelMinimizeButton.ForeColor = System.Drawing.Color.White;
            this.TopPanelMinimizeButton.Location = new System.Drawing.Point(680, 0);
            this.TopPanelMinimizeButton.Margin = new System.Windows.Forms.Padding(6);
            this.TopPanelMinimizeButton.Name = "TopPanelMinimizeButton";
            this.TopPanelMinimizeButton.Size = new System.Drawing.Size(37, 32);
            this.TopPanelMinimizeButton.TabIndex = 0;
            this.TopPanelMinimizeButton.TabStop = false;
            this.TopPanelMinimizeButton.Text = "0";
            this.TopPanelMinimizeButton.UseVisualStyleBackColor = true;
            this.TopPanelMinimizeButton.Click += new System.EventHandler(this.TopPanelMinimizeButton_Click);
            // 
            // TopPanelCloseButton
            // 
            this.TopPanelCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanelCloseButton.FlatAppearance.BorderSize = 0;
            this.TopPanelCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.TopPanelCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.TopPanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopPanelCloseButton.Font = new System.Drawing.Font("Marlett", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TopPanelCloseButton.ForeColor = System.Drawing.Color.White;
            this.TopPanelCloseButton.Location = new System.Drawing.Point(754, 0);
            this.TopPanelCloseButton.Margin = new System.Windows.Forms.Padding(6);
            this.TopPanelCloseButton.Name = "TopPanelCloseButton";
            this.TopPanelCloseButton.Size = new System.Drawing.Size(37, 32);
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
            this.TopPanelMaximizeButton.Font = new System.Drawing.Font("Marlett", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TopPanelMaximizeButton.ForeColor = System.Drawing.Color.White;
            this.TopPanelMaximizeButton.Location = new System.Drawing.Point(717, 0);
            this.TopPanelMaximizeButton.Margin = new System.Windows.Forms.Padding(6);
            this.TopPanelMaximizeButton.Name = "TopPanelMaximizeButton";
            this.TopPanelMaximizeButton.Size = new System.Drawing.Size(37, 32);
            this.TopPanelMaximizeButton.TabIndex = 0;
            this.TopPanelMaximizeButton.TabStop = false;
            this.TopPanelMaximizeButton.Text = "1";
            this.TopPanelMaximizeButton.UseVisualStyleBackColor = true;
            this.TopPanelMaximizeButton.Click += new System.EventHandler(this.TopPanelMaximizeButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(346, 3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(151, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "FeedMe - Login";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            // 
            // FeedMeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(791, 455);
            this.Controls.Add(this.TopBarPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FeedMeMainForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FeedMeMainForm_Load);
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Button TopPanelMaximizeButton;
        private System.Windows.Forms.Button TopPanelCloseButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button TopPanelMinimizeButton;
    }
}