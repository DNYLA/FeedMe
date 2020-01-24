namespace FeedMeClient.UserControls.Admin_
{
    partial class Refund
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
            this.button2 = new System.Windows.Forms.Button();
            this.DeclineRefund = new System.Windows.Forms.Button();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.ItemPanel = new System.Windows.Forms.Panel();
            this.ViewOrderLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(187)))), ((int)(((byte)(51)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(156, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 67);
            this.button2.TabIndex = 11;
            this.button2.Text = "Accept Refund";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeclineRefund
            // 
            this.DeclineRefund.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeclineRefund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.DeclineRefund.FlatAppearance.BorderSize = 0;
            this.DeclineRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeclineRefund.ForeColor = System.Drawing.Color.Black;
            this.DeclineRefund.Location = new System.Drawing.Point(381, 544);
            this.DeclineRefund.Name = "DeclineRefund";
            this.DeclineRefund.Size = new System.Drawing.Size(211, 67);
            this.DeclineRefund.TabIndex = 12;
            this.DeclineRefund.Text = "Decline Refund";
            this.DeclineRefund.UseVisualStyleBackColor = false;
            this.DeclineRefund.Click += new System.EventHandler(this.DeclineRefund_Click);
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(120, 66);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(80, 21);
            this.TotalCostLabel.TabIndex = 9;
            this.TotalCostLabel.Text = "Total Cost:";
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Location = new System.Drawing.Point(515, 66);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(73, 21);
            this.OrderIDLabel.TabIndex = 10;
            this.OrderIDLabel.Text = "OrderID: ";
            this.OrderIDLabel.TextChanged += new System.EventHandler(this.OrderIDLabel_TextChanged);
            // 
            // ItemPanel
            // 
            this.ItemPanel.Location = new System.Drawing.Point(83, 116);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(600, 422);
            this.ItemPanel.TabIndex = 8;
            // 
            // ViewOrderLabel
            // 
            this.ViewOrderLabel.AutoSize = true;
            this.ViewOrderLabel.Location = new System.Drawing.Point(331, 66);
            this.ViewOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewOrderLabel.Name = "ViewOrderLabel";
            this.ViewOrderLabel.Size = new System.Drawing.Size(89, 21);
            this.ViewOrderLabel.TabIndex = 7;
            this.ViewOrderLabel.Tag = "9";
            this.ViewOrderLabel.Text = "View Order";
            // 
            // NextButton
            // 
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.ForeColor = System.Drawing.Color.Coral;
            this.NextButton.Location = new System.Drawing.Point(692, 290);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(57, 44);
            this.NextButton.TabIndex = 13;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.FlatAppearance.BorderSize = 0;
            this.PrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevButton.ForeColor = System.Drawing.Color.Coral;
            this.PrevButton.Location = new System.Drawing.Point(20, 290);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(57, 44);
            this.PrevButton.TabIndex = 13;
            this.PrevButton.Text = "<";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // Refund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DeclineRefund);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.OrderIDLabel);
            this.Controls.Add(this.ItemPanel);
            this.Controls.Add(this.ViewOrderLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Refund";
            this.Size = new System.Drawing.Size(767, 677);
            this.Load += new System.EventHandler(this.Refund_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DeclineRefund;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.Panel ItemPanel;
        private System.Windows.Forms.Label ViewOrderLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
    }
}
