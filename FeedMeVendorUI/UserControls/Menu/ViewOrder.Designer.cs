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
            this.CookingButton = new System.Windows.Forms.Button();
            this.DeliveringButton = new System.Windows.Forms.Button();
            this.CompletedButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewOrderLabel
            // 
            this.ViewOrderLabel.AutoSize = true;
            this.ViewOrderLabel.Location = new System.Drawing.Point(318, 18);
            this.ViewOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewOrderLabel.Name = "ViewOrderLabel";
            this.ViewOrderLabel.Size = new System.Drawing.Size(89, 21);
            this.ViewOrderLabel.TabIndex = 0;
            this.ViewOrderLabel.Tag = "9";
            this.ViewOrderLabel.Text = "View Order";
            // 
            // ItemPanel
            // 
            this.ItemPanel.Location = new System.Drawing.Point(78, 68);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(600, 292);
            this.ItemPanel.TabIndex = 4;
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Location = new System.Drawing.Point(432, 18);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(73, 21);
            this.OrderIDLabel.TabIndex = 5;
            this.OrderIDLabel.Text = "OrderID: ";
            this.OrderIDLabel.TextChanged += new System.EventHandler(this.OrderIDLabel_TextChanged);
            // 
            // CookingButton
            // 
            this.CookingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CookingButton.BackColor = System.Drawing.Color.Transparent;
            this.CookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CookingButton.ForeColor = System.Drawing.Color.Black;
            this.CookingButton.Location = new System.Drawing.Point(89, 368);
            this.CookingButton.Name = "CookingButton";
            this.CookingButton.Size = new System.Drawing.Size(141, 67);
            this.CookingButton.TabIndex = 6;
            this.CookingButton.Text = "Cooking";
            this.CookingButton.UseVisualStyleBackColor = false;
            this.CookingButton.Click += new System.EventHandler(this.CookingButton_Click);
            // 
            // DeliveringButton
            // 
            this.DeliveringButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeliveringButton.BackColor = System.Drawing.Color.Transparent;
            this.DeliveringButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveringButton.ForeColor = System.Drawing.Color.Black;
            this.DeliveringButton.Location = new System.Drawing.Point(236, 368);
            this.DeliveringButton.Name = "DeliveringButton";
            this.DeliveringButton.Size = new System.Drawing.Size(141, 67);
            this.DeliveringButton.TabIndex = 6;
            this.DeliveringButton.Text = "Delivering";
            this.DeliveringButton.UseVisualStyleBackColor = false;
            this.DeliveringButton.Click += new System.EventHandler(this.DeliveringButton_Click);
            // 
            // CompletedButton
            // 
            this.CompletedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompletedButton.BackColor = System.Drawing.Color.Transparent;
            this.CompletedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompletedButton.ForeColor = System.Drawing.Color.Black;
            this.CompletedButton.Location = new System.Drawing.Point(383, 368);
            this.CompletedButton.Name = "CompletedButton";
            this.CompletedButton.Size = new System.Drawing.Size(141, 67);
            this.CompletedButton.TabIndex = 6;
            this.CompletedButton.Text = "Completed";
            this.CompletedButton.UseVisualStyleBackColor = false;
            this.CompletedButton.Click += new System.EventHandler(this.CompletedButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(530, 368);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(141, 67);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CompletedButton);
            this.Controls.Add(this.DeliveringButton);
            this.Controls.Add(this.CookingButton);
            this.Controls.Add(this.OrderIDLabel);
            this.Controls.Add(this.ItemPanel);
            this.Controls.Add(this.ViewOrderLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewOrder";
            this.Size = new System.Drawing.Size(776, 451);
            this.Load += new System.EventHandler(this.ViewOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ViewOrderLabel;
        private System.Windows.Forms.Panel ItemPanel;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.Button CookingButton;
        private System.Windows.Forms.Button DeliveringButton;
        private System.Windows.Forms.Button CompletedButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
