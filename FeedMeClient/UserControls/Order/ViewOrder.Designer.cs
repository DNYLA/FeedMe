namespace FeedMeVendorUI.UserControls.Menu
{
    partial class ViewOrder
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
            this.ViewOrderLabel = new System.Windows.Forms.Label();
            this.ItemPanel = new System.Windows.Forms.Panel();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewOrderLabel
            // 
            this.ViewOrderLabel.AutoSize = true;
            this.ViewOrderLabel.Location = new System.Drawing.Point(327, 81);
            this.ViewOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewOrderLabel.Name = "ViewOrderLabel";
            this.ViewOrderLabel.Size = new System.Drawing.Size(89, 21);
            this.ViewOrderLabel.TabIndex = 0;
            this.ViewOrderLabel.Tag = "9";
            this.ViewOrderLabel.Text = "View Order";
            // 
            // ItemPanel
            // 
            this.ItemPanel.Location = new System.Drawing.Point(79, 131);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(600, 422);
            this.ItemPanel.TabIndex = 4;
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Location = new System.Drawing.Point(511, 81);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(73, 21);
            this.OrderIDLabel.TabIndex = 5;
            this.OrderIDLabel.Text = "OrderID: ";
            this.OrderIDLabel.TextChanged += new System.EventHandler(this.OrderIDLabel_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(396, 559);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(211, 67);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Request Refund";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(166, 559);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 67);
            this.button2.TabIndex = 6;
            this.button2.Text = "Create Review";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(116, 81);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(80, 21);
            this.TotalCostLabel.TabIndex = 5;
            this.TotalCostLabel.Text = "Total Cost:";
            this.TotalCostLabel.TextChanged += new System.EventHandler(this.OrderIDLabel_TextChanged);
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.OrderIDLabel);
            this.Controls.Add(this.ItemPanel);
            this.Controls.Add(this.ViewOrderLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewOrder";
            this.Size = new System.Drawing.Size(767, 677);
            this.Load += new System.EventHandler(this.ViewOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ViewOrderLabel;
        private System.Windows.Forms.Panel ItemPanel;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TotalCostLabel;
    }
}
