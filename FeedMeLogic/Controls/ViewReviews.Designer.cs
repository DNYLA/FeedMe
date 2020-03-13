namespace FeedMeLogic.Controls
{
    partial class ViewReviews
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
            this.reviewFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.vendorIDLabel = new System.Windows.Forms.Label();
            this.TotalRatingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reviewFlowPanel
            // 
            this.reviewFlowPanel.Location = new System.Drawing.Point(51, 55);
            this.reviewFlowPanel.Name = "reviewFlowPanel";
            this.reviewFlowPanel.Size = new System.Drawing.Size(643, 587);
            this.reviewFlowPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(330, 11);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(106, 32);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Reviews";
            // 
            // vendorIDLabel
            // 
            this.vendorIDLabel.AutoSize = true;
            this.vendorIDLabel.Location = new System.Drawing.Point(84, 20);
            this.vendorIDLabel.Name = "vendorIDLabel";
            this.vendorIDLabel.Size = new System.Drawing.Size(52, 21);
            this.vendorIDLabel.TabIndex = 2;
            this.vendorIDLabel.Text = "label1";
            this.vendorIDLabel.TextChanged += new System.EventHandler(this.orderIDLabel_TextChanged);
            // 
            // TotalRatingLabel
            // 
            this.TotalRatingLabel.AutoSize = true;
            this.TotalRatingLabel.Location = new System.Drawing.Point(562, 20);
            this.TotalRatingLabel.Name = "TotalRatingLabel";
            this.TotalRatingLabel.Size = new System.Drawing.Size(62, 21);
            this.TotalRatingLabel.TabIndex = 3;
            this.TotalRatingLabel.Text = "Rating: ";
            // 
            // ViewReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TotalRatingLabel);
            this.Controls.Add(this.vendorIDLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.reviewFlowPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewReviews";
            this.Size = new System.Drawing.Size(767, 677);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel reviewFlowPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label vendorIDLabel;
        private System.Windows.Forms.Label TotalRatingLabel;
    }
}
