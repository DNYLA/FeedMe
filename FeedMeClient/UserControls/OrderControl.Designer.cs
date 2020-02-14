namespace FeedMeClient.UserControls
{
    partial class OrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VendorTitleLabel = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.ItemsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // VendorTitleLabel
            // 
            this.VendorTitleLabel.AutoSize = true;
            this.VendorTitleLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorTitleLabel.Location = new System.Drawing.Point(265, 7);
            this.VendorTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.VendorTitleLabel.Name = "VendorTitleLabel";
            this.VendorTitleLabel.Size = new System.Drawing.Size(205, 45);
            this.VendorTitleLabel.TabIndex = 13;
            this.VendorTitleLabel.Text = "Pizza Express";
            this.VendorTitleLabel.TextChanged += new System.EventHandler(this.VendorTitleLabel_TextChanged);
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.Gold;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderButton.Location = new System.Drawing.Point(142, 609);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(487, 55);
            this.OrderButton.TabIndex = 15;
            this.OrderButton.Text = "Place Order";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // ItemsFlowPanel
            // 
            this.ItemsFlowPanel.AutoScroll = true;
            this.ItemsFlowPanel.Location = new System.Drawing.Point(27, 151);
            this.ItemsFlowPanel.Name = "ItemsFlowPanel";
            this.ItemsFlowPanel.Size = new System.Drawing.Size(720, 442);
            this.ItemsFlowPanel.TabIndex = 16;
            // 
            // ButtonsFlowPanel
            // 
            this.ButtonsFlowPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonsFlowPanel.Location = new System.Drawing.Point(3, 55);
            this.ButtonsFlowPanel.Name = "ButtonsFlowPanel";
            this.ButtonsFlowPanel.Size = new System.Drawing.Size(761, 75);
            this.ButtonsFlowPanel.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FeedMeClient.Properties.Resources.Pizza_Express;
            this.pictureBox2.Location = new System.Drawing.Point(196, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ButtonsFlowPanel);
            this.Controls.Add(this.ItemsFlowPanel);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.VendorTitleLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(767, 677);
            this.Load += new System.EventHandler(this.OrderControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label VendorTitleLabel;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.FlowLayoutPanel ItemsFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel ButtonsFlowPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
