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
            this.ItemPanel.Location = new System.Drawing.Point(78, 70);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(600, 292);
            this.ItemPanel.TabIndex = 4;
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemPanel);
            this.Controls.Add(this.ViewOrderLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewOrder";
            this.Size = new System.Drawing.Size(776, 451);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ViewOrderLabel;
        private System.Windows.Forms.Panel ItemPanel;
    }
}
