namespace FeedMeClient.UserControls.Order
{
    partial class EnterCredentials
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
            this.CardNoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressTbox = new System.Windows.Forms.TextBox();
            this.SecCode = new System.Windows.Forms.TextBox();
            this.VendorLabel = new System.Windows.Forms.Label();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.MonthExpiry = new System.Windows.Forms.ComboBox();
            this.YearExpiry = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ExtraTbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CardNoBox
            // 
            this.CardNoBox.Location = new System.Drawing.Point(93, 223);
            this.CardNoBox.Name = "CardNoBox";
            this.CardNoBox.Size = new System.Drawing.Size(540, 33);
            this.CardNoBox.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Card Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "Expire Date (MM):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 73;
            this.label3.Text = "Expire Date (YY(YY)):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 77;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 74;
            this.label4.Text = "Security Code:";
            // 
            // AddressTbox
            // 
            this.AddressTbox.Location = new System.Drawing.Point(335, 343);
            this.AddressTbox.Name = "AddressTbox";
            this.AddressTbox.Size = new System.Drawing.Size(298, 33);
            this.AddressTbox.TabIndex = 76;
            // 
            // SecCode
            // 
            this.SecCode.Location = new System.Drawing.Point(93, 343);
            this.SecCode.Name = "SecCode";
            this.SecCode.PasswordChar = '*';
            this.SecCode.Size = new System.Drawing.Size(227, 33);
            this.SecCode.TabIndex = 75;
            // 
            // VendorLabel
            // 
            this.VendorLabel.AutoSize = true;
            this.VendorLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorLabel.Location = new System.Drawing.Point(247, 96);
            this.VendorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VendorLabel.Name = "VendorLabel";
            this.VendorLabel.Size = new System.Drawing.Size(168, 32);
            this.VendorLabel.TabIndex = 78;
            this.VendorLabel.Text = "Order from {0}";
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.BackColor = System.Drawing.Color.Gold;
            this.PurchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PurchaseButton.Location = new System.Drawing.Point(109, 448);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(487, 55);
            this.PurchaseButton.TabIndex = 79;
            this.PurchaseButton.Text = "Purchase";
            this.PurchaseButton.UseVisualStyleBackColor = false;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // MonthExpiry
            // 
            this.MonthExpiry.FormattingEnabled = true;
            this.MonthExpiry.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.MonthExpiry.Location = new System.Drawing.Point(93, 284);
            this.MonthExpiry.Name = "MonthExpiry";
            this.MonthExpiry.Size = new System.Drawing.Size(227, 33);
            this.MonthExpiry.TabIndex = 80;
            // 
            // YearExpiry
            // 
            this.YearExpiry.FormattingEnabled = true;
            this.YearExpiry.Items.AddRange(new object[] {
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.YearExpiry.Location = new System.Drawing.Point(335, 282);
            this.YearExpiry.Name = "YearExpiry";
            this.YearExpiry.Size = new System.Drawing.Size(298, 33);
            this.YearExpiry.TabIndex = 80;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 406);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(540, 33);
            this.textBox1.TabIndex = 75;
            // 
            // ExtraTbox
            // 
            this.ExtraTbox.AutoSize = true;
            this.ExtraTbox.Location = new System.Drawing.Point(93, 380);
            this.ExtraTbox.Name = "ExtraTbox";
            this.ExtraTbox.Size = new System.Drawing.Size(112, 25);
            this.ExtraTbox.TabIndex = 74;
            this.ExtraTbox.Text = "Extra Notes:";
            // 
            // EnterCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.YearExpiry);
            this.Controls.Add(this.MonthExpiry);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.VendorLabel);
            this.Controls.Add(this.CardNoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExtraTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddressTbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SecCode);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EnterCredentials";
            this.Size = new System.Drawing.Size(767, 677);
            this.Load += new System.EventHandler(this.EnterCredentials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CardNoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddressTbox;
        private System.Windows.Forms.TextBox SecCode;
        private System.Windows.Forms.Label VendorLabel;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.ComboBox MonthExpiry;
        private System.Windows.Forms.ComboBox YearExpiry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ExtraTbox;
    }
}
