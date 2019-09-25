namespace FeedMeClient.UserControls
{
    partial class HomeControl
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
            this.VendorsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.VendorAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VendorsFlowPanel
            // 
            this.VendorsFlowPanel.AutoScroll = true;
            this.VendorsFlowPanel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorsFlowPanel.Location = new System.Drawing.Point(8, 71);
            this.VendorsFlowPanel.Margin = new System.Windows.Forms.Padding(12, 92, 12, 13);
            this.VendorsFlowPanel.Name = "VendorsFlowPanel";
            this.VendorsFlowPanel.Size = new System.Drawing.Size(751, 591);
            this.VendorsFlowPanel.TabIndex = 1;
            // 
            // VendorAmountLabel
            // 
            this.VendorAmountLabel.AutoSize = true;
            this.VendorAmountLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorAmountLabel.Location = new System.Drawing.Point(93, 28);
            this.VendorAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VendorAmountLabel.Name = "VendorAmountLabel";
            this.VendorAmountLabel.Size = new System.Drawing.Size(596, 32);
            this.VendorAmountLabel.TabIndex = 7;
            this.VendorAmountLabel.Text = "There are currently {0} restraunts/food places near you";
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VendorAmountLabel);
            this.Controls.Add(this.VendorsFlowPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(767, 677);
            this.Load += new System.EventHandler(this.HomeControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel VendorsFlowPanel;
        private System.Windows.Forms.Label VendorAmountLabel;
    }
}
