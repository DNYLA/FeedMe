namespace FeedMeVendorUI.UserControls.Menu
{
    partial class StoreInfo
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RatingTbox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.PhoneTbox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.PostCodeTbox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTbox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.AddressTbox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.DescrTbox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.NameTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.UpdateButton);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.RatingTbox);
            this.panel5.Controls.Add(this.PhoneTbox);
            this.panel5.Controls.Add(this.PostCodeTbox);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.EmailTbox);
            this.panel5.Controls.Add(this.AddressTbox);
            this.panel5.Controls.Add(this.DescrTbox);
            this.panel5.Controls.Add(this.NameTBox);
            this.panel5.Location = new System.Drawing.Point(134, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(461, 389);
            this.panel5.TabIndex = 9;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateButton.Location = new System.Drawing.Point(170, 245);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(126, 27);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rating:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(125, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Postcode:";
            // 
            // RatingTbox
            // 
            this.RatingTbox.AutoResize = false;
            this.RatingTbox.BaseColor = System.Drawing.Color.Black;
            this.RatingTbox.BorderColor = System.Drawing.Color.Black;
            this.RatingTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RatingTbox.FocusColor = System.Drawing.Color.White;
            this.RatingTbox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.RatingTbox.ForeColor = System.Drawing.Color.Gray;
            this.RatingTbox.Location = new System.Drawing.Point(199, 192);
            this.RatingTbox.Name = "RatingTbox";
            this.RatingTbox.SingleLine = true;
            this.RatingTbox.Size = new System.Drawing.Size(97, 23);
            this.RatingTbox.TabIndex = 3;
            this.RatingTbox.Watermark = "";
            // 
            // PhoneTbox
            // 
            this.PhoneTbox.AutoResize = false;
            this.PhoneTbox.BaseColor = System.Drawing.Color.Black;
            this.PhoneTbox.BorderColor = System.Drawing.Color.Black;
            this.PhoneTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTbox.FocusColor = System.Drawing.Color.White;
            this.PhoneTbox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.PhoneTbox.ForeColor = System.Drawing.Color.Gray;
            this.PhoneTbox.Location = new System.Drawing.Point(199, 163);
            this.PhoneTbox.Name = "PhoneTbox";
            this.PhoneTbox.SingleLine = true;
            this.PhoneTbox.Size = new System.Drawing.Size(97, 23);
            this.PhoneTbox.TabIndex = 4;
            this.PhoneTbox.Watermark = "";
            // 
            // PostCodeTbox
            // 
            this.PostCodeTbox.AutoResize = false;
            this.PostCodeTbox.BaseColor = System.Drawing.Color.Black;
            this.PostCodeTbox.BorderColor = System.Drawing.Color.Black;
            this.PostCodeTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostCodeTbox.FocusColor = System.Drawing.Color.White;
            this.PostCodeTbox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.PostCodeTbox.ForeColor = System.Drawing.Color.Gray;
            this.PostCodeTbox.Location = new System.Drawing.Point(199, 134);
            this.PostCodeTbox.Name = "PostCodeTbox";
            this.PostCodeTbox.SingleLine = true;
            this.PostCodeTbox.Size = new System.Drawing.Size(97, 23);
            this.PostCodeTbox.TabIndex = 5;
            this.PostCodeTbox.Watermark = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // EmailTbox
            // 
            this.EmailTbox.AutoResize = false;
            this.EmailTbox.BaseColor = System.Drawing.Color.Black;
            this.EmailTbox.BorderColor = System.Drawing.Color.Black;
            this.EmailTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTbox.FocusColor = System.Drawing.Color.White;
            this.EmailTbox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.EmailTbox.ForeColor = System.Drawing.Color.Gray;
            this.EmailTbox.Location = new System.Drawing.Point(198, 105);
            this.EmailTbox.Name = "EmailTbox";
            this.EmailTbox.SingleLine = true;
            this.EmailTbox.Size = new System.Drawing.Size(97, 23);
            this.EmailTbox.TabIndex = 0;
            this.EmailTbox.Watermark = "";
            // 
            // AddressTbox
            // 
            this.AddressTbox.AutoResize = false;
            this.AddressTbox.BaseColor = System.Drawing.Color.Black;
            this.AddressTbox.BorderColor = System.Drawing.Color.Black;
            this.AddressTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressTbox.FocusColor = System.Drawing.Color.White;
            this.AddressTbox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.AddressTbox.ForeColor = System.Drawing.Color.Gray;
            this.AddressTbox.Location = new System.Drawing.Point(198, 76);
            this.AddressTbox.Name = "AddressTbox";
            this.AddressTbox.SingleLine = true;
            this.AddressTbox.Size = new System.Drawing.Size(97, 23);
            this.AddressTbox.TabIndex = 0;
            this.AddressTbox.Watermark = "";
            // 
            // DescrTbox
            // 
            this.DescrTbox.AutoResize = false;
            this.DescrTbox.BaseColor = System.Drawing.Color.Black;
            this.DescrTbox.BorderColor = System.Drawing.Color.Black;
            this.DescrTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescrTbox.FocusColor = System.Drawing.Color.White;
            this.DescrTbox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.DescrTbox.ForeColor = System.Drawing.Color.Gray;
            this.DescrTbox.Location = new System.Drawing.Point(198, 47);
            this.DescrTbox.Name = "DescrTbox";
            this.DescrTbox.SingleLine = true;
            this.DescrTbox.Size = new System.Drawing.Size(97, 23);
            this.DescrTbox.TabIndex = 0;
            this.DescrTbox.Watermark = "";
            // 
            // NameTBox
            // 
            this.NameTBox.AutoResize = false;
            this.NameTBox.BaseColor = System.Drawing.Color.Black;
            this.NameTBox.BorderColor = System.Drawing.Color.Black;
            this.NameTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTBox.FocusColor = System.Drawing.Color.White;
            this.NameTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.NameTBox.ForeColor = System.Drawing.Color.Gray;
            this.NameTBox.Location = new System.Drawing.Point(198, 18);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.SingleLine = true;
            this.NameTBox.Size = new System.Drawing.Size(97, 23);
            this.NameTBox.TabIndex = 0;
            this.NameTBox.Watermark = "";
            // 
            // StoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Name = "StoreInfo";
            this.Size = new System.Drawing.Size(776, 451);
            this.Load += new System.EventHandler(this.StoreInfo_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private FeedMeLogic.Controls.FeedMeTextBox EmailTbox;
        private FeedMeLogic.Controls.FeedMeTextBox AddressTbox;
        private FeedMeLogic.Controls.FeedMeTextBox DescrTbox;
        private FeedMeLogic.Controls.FeedMeTextBox NameTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FeedMeLogic.Controls.FeedMeTextBox RatingTbox;
        private FeedMeLogic.Controls.FeedMeTextBox PhoneTbox;
        private FeedMeLogic.Controls.FeedMeTextBox PostCodeTbox;
        private System.Windows.Forms.Button UpdateButton;
    }
}
