namespace FeedMeClient.UserControls.Order
{
    partial class ReviewOrderControl
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
            this.OrderButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.VendorLabel = new System.Windows.Forms.Label();
            this.ItemPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.Gold;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderButton.Location = new System.Drawing.Point(154, 599);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(487, 55);
            this.OrderButton.TabIndex = 20;
            this.OrderButton.Text = "Continue";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(128, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(481, 32);
            this.label11.TabIndex = 18;
            this.label11.Text = "Please Review your order before continiung";
            // 
            // VendorLabel
            // 
            this.VendorLabel.AutoSize = true;
            this.VendorLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorLabel.Location = new System.Drawing.Point(261, 22);
            this.VendorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VendorLabel.Name = "VendorLabel";
            this.VendorLabel.Size = new System.Drawing.Size(168, 32);
            this.VendorLabel.TabIndex = 19;
            this.VendorLabel.Text = "Order from {0}";
            this.VendorLabel.TextChanged += new System.EventHandler(this.VendorLabel_TextChanged);
            // 
            // ItemPanel
            // 
            this.ItemPanel.Location = new System.Drawing.Point(87, 129);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(590, 451);
            this.ItemPanel.TabIndex = 3;
            // 
            // ReviewOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemPanel);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.VendorLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReviewOrderControl";
            this.Size = new System.Drawing.Size(767, 677);
            this.Load += new System.EventHandler(this.ReviewOrderControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label VendorLabel;
        private System.Windows.Forms.Panel ItemPanel;
    }
}
