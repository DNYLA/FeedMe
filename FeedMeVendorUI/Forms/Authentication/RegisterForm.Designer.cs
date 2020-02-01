namespace FeedMeVendorUI.Forms.Authentication
{
    partial class RegisterForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.NoAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.vendorNameBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vendorDescBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.AddressBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.EmailBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.PhoneNumber = new FeedMeLogic.Controls.FeedMeTextBox();
            this.PasswordBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.ConfirmPasswordBox = new FeedMeLogic.Controls.FeedMeTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(62, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Confirm Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(62, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(60, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(60, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Vendor Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(59, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Vendor Name:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(30, 215);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // NoAccountLinkLabel
            // 
            this.NoAccountLinkLabel.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.NoAccountLinkLabel.AutoSize = true;
            this.NoAccountLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoAccountLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.NoAccountLinkLabel.Location = new System.Drawing.Point(132, 536);
            this.NoAccountLinkLabel.Name = "NoAccountLinkLabel";
            this.NoAccountLinkLabel.Size = new System.Drawing.Size(159, 17);
            this.NoAccountLinkLabel.TabIndex = 29;
            this.NoAccountLinkLabel.TabStop = true;
            this.NoAccountLinkLabel.Text = "Already Have an Account?";
            this.NoAccountLinkLabel.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.NoAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoAccountLinkLabel_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(185, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // RegisterButton
            // 
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RegisterButton.Location = new System.Drawing.Point(60, 557);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(308, 46);
            this.RegisterButton.TabIndex = 28;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // vendorNameBox
            // 
            this.vendorNameBox.AutoResize = false;
            this.vendorNameBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vendorNameBox.BaseColor = System.Drawing.Color.Black;
            this.vendorNameBox.BorderColor = System.Drawing.Color.Black;
            this.vendorNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendorNameBox.FocusColor = System.Drawing.Color.White;
            this.vendorNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.vendorNameBox.ForeColor = System.Drawing.Color.Gray;
            this.vendorNameBox.Location = new System.Drawing.Point(60, 216);
            this.vendorNameBox.Name = "vendorNameBox";
            this.vendorNameBox.SingleLine = false;
            this.vendorNameBox.Size = new System.Drawing.Size(308, 26);
            this.vendorNameBox.TabIndex = 38;
            this.vendorNameBox.Watermark = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(62, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Email:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(60, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Phone Number:";
            this.label8.Click += new System.EventHandler(this.label7_Click);
            // 
            // vendorDescBox
            // 
            this.vendorDescBox.AutoResize = false;
            this.vendorDescBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vendorDescBox.BaseColor = System.Drawing.Color.Black;
            this.vendorDescBox.BorderColor = System.Drawing.Color.Black;
            this.vendorDescBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendorDescBox.FocusColor = System.Drawing.Color.White;
            this.vendorDescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.vendorDescBox.ForeColor = System.Drawing.Color.Gray;
            this.vendorDescBox.Location = new System.Drawing.Point(60, 263);
            this.vendorDescBox.Name = "vendorDescBox";
            this.vendorDescBox.SingleLine = false;
            this.vendorDescBox.Size = new System.Drawing.Size(308, 26);
            this.vendorDescBox.TabIndex = 38;
            this.vendorDescBox.Watermark = "";
            // 
            // AddressBox
            // 
            this.AddressBox.AutoResize = false;
            this.AddressBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddressBox.BaseColor = System.Drawing.Color.Black;
            this.AddressBox.BorderColor = System.Drawing.Color.Black;
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressBox.FocusColor = System.Drawing.Color.White;
            this.AddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.AddressBox.ForeColor = System.Drawing.Color.Gray;
            this.AddressBox.Location = new System.Drawing.Point(60, 311);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.SingleLine = false;
            this.AddressBox.Size = new System.Drawing.Size(308, 26);
            this.AddressBox.TabIndex = 38;
            this.AddressBox.Watermark = "";
            // 
            // EmailBox
            // 
            this.EmailBox.AutoResize = false;
            this.EmailBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EmailBox.BaseColor = System.Drawing.Color.Black;
            this.EmailBox.BorderColor = System.Drawing.Color.Black;
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.FocusColor = System.Drawing.Color.White;
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.EmailBox.ForeColor = System.Drawing.Color.Gray;
            this.EmailBox.Location = new System.Drawing.Point(60, 359);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.SingleLine = false;
            this.EmailBox.Size = new System.Drawing.Size(308, 26);
            this.EmailBox.TabIndex = 38;
            this.EmailBox.Watermark = "";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoResize = false;
            this.PhoneNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PhoneNumber.BaseColor = System.Drawing.Color.Black;
            this.PhoneNumber.BorderColor = System.Drawing.Color.Black;
            this.PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumber.FocusColor = System.Drawing.Color.White;
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.PhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.PhoneNumber.Location = new System.Drawing.Point(60, 408);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.SingleLine = false;
            this.PhoneNumber.Size = new System.Drawing.Size(308, 26);
            this.PhoneNumber.TabIndex = 38;
            this.PhoneNumber.Watermark = "";
            // 
            // PasswordBox
            // 
            this.PasswordBox.AutoResize = false;
            this.PasswordBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PasswordBox.BaseColor = System.Drawing.Color.Black;
            this.PasswordBox.BorderColor = System.Drawing.Color.Black;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.FocusColor = System.Drawing.Color.White;
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.PasswordBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordBox.Location = new System.Drawing.Point(60, 456);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.SingleLine = false;
            this.PasswordBox.Size = new System.Drawing.Size(308, 26);
            this.PasswordBox.TabIndex = 38;
            this.PasswordBox.Watermark = "";
            // 
            // ConfirmPasswordBox
            // 
            this.ConfirmPasswordBox.AutoResize = false;
            this.ConfirmPasswordBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ConfirmPasswordBox.BaseColor = System.Drawing.Color.Black;
            this.ConfirmPasswordBox.BorderColor = System.Drawing.Color.Black;
            this.ConfirmPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPasswordBox.FocusColor = System.Drawing.Color.White;
            this.ConfirmPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.ConfirmPasswordBox.ForeColor = System.Drawing.Color.Gray;
            this.ConfirmPasswordBox.Location = new System.Drawing.Point(60, 503);
            this.ConfirmPasswordBox.Name = "ConfirmPasswordBox";
            this.ConfirmPasswordBox.SingleLine = false;
            this.ConfirmPasswordBox.Size = new System.Drawing.Size(308, 26);
            this.ConfirmPasswordBox.TabIndex = 38;
            this.ConfirmPasswordBox.Watermark = "";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 695);
            this.Controls.Add(this.ConfirmPasswordBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.vendorDescBox);
            this.Controls.Add(this.vendorNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.NoAccountLinkLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.RegisterButton);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Controls.SetChildIndex(this.RegisterButton, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.NoAccountLinkLabel, 0);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.vendorNameBox, 0);
            this.Controls.SetChildIndex(this.vendorDescBox, 0);
            this.Controls.SetChildIndex(this.AddressBox, 0);
            this.Controls.SetChildIndex(this.EmailBox, 0);
            this.Controls.SetChildIndex(this.PhoneNumber, 0);
            this.Controls.SetChildIndex(this.PasswordBox, 0);
            this.Controls.SetChildIndex(this.ConfirmPasswordBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.LinkLabel NoAccountLinkLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button RegisterButton;
        private FeedMeLogic.Controls.FeedMeTextBox vendorNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FeedMeLogic.Controls.FeedMeTextBox vendorDescBox;
        private FeedMeLogic.Controls.FeedMeTextBox AddressBox;
        private FeedMeLogic.Controls.FeedMeTextBox EmailBox;
        private FeedMeLogic.Controls.FeedMeTextBox PhoneNumber;
        private FeedMeLogic.Controls.FeedMeTextBox PasswordBox;
        private FeedMeLogic.Controls.FeedMeTextBox ConfirmPasswordBox;
    }
}