namespace FeedMeClient.UserControls.Order
{
    partial class CreateReview
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
            this.MessageTBox = new FeedMeClient.CustomControls.FeedMeTextBox();
            this.RatingLbox = new System.Windows.Forms.ListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.orderIDT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageTBox
            // 
            this.MessageTBox.AutoResize = false;
            this.MessageTBox.BaseColor = System.Drawing.Color.Black;
            this.MessageTBox.BorderColor = System.Drawing.Color.Black;
            this.MessageTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageTBox.FocusColor = System.Drawing.Color.White;
            this.MessageTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.MessageTBox.ForeColor = System.Drawing.Color.Gray;
            this.MessageTBox.Location = new System.Drawing.Point(66, 60);
            this.MessageTBox.Multiline = true;
            this.MessageTBox.Name = "MessageTBox";
            this.MessageTBox.SingleLine = false;
            this.MessageTBox.Size = new System.Drawing.Size(617, 501);
            this.MessageTBox.TabIndex = 0;
            this.MessageTBox.Text = "Type Your Message Here...";
            this.MessageTBox.Watermark = "Type Your Message Here...";
            this.MessageTBox.WordWrap = false;
            // 
            // RatingLbox
            // 
            this.RatingLbox.FormattingEnabled = true;
            this.RatingLbox.ItemHeight = 25;
            this.RatingLbox.Items.AddRange(new object[] {
            "1/5",
            "2/5",
            "3/5",
            "4/5",
            "5/5"});
            this.RatingLbox.Location = new System.Drawing.Point(153, 567);
            this.RatingLbox.Name = "RatingLbox";
            this.RatingLbox.Size = new System.Drawing.Size(120, 29);
            this.RatingLbox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(264, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(175, 32);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Create Review";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rating:";
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.BackColor = System.Drawing.Color.Gold;
            this.PurchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PurchaseButton.Location = new System.Drawing.Point(270, 614);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(253, 45);
            this.PurchaseButton.TabIndex = 80;
            this.PurchaseButton.Text = "Submit";
            this.PurchaseButton.UseVisualStyleBackColor = false;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // orderIDT
            // 
            this.orderIDT.AutoSize = true;
            this.orderIDT.Location = new System.Drawing.Point(479, 23);
            this.orderIDT.Name = "orderIDT";
            this.orderIDT.Size = new System.Drawing.Size(88, 25);
            this.orderIDT.TabIndex = 81;
            this.orderIDT.Text = "OrderID: ";
            // 
            // CreateReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderIDT);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.RatingLbox);
            this.Controls.Add(this.MessageTBox);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateReview";
            this.Size = new System.Drawing.Size(767, 677);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.FeedMeTextBox MessageTBox;
        private System.Windows.Forms.ListBox RatingLbox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.Label orderIDT;
    }
}
