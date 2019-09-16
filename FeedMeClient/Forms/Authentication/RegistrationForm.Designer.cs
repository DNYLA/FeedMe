namespace FeedMeClient.Forms.Authentication
{
    partial class Register
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
            this.NoAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.FirstNameBox = new FeedMeClient.CustomControls.FeedMeTextBox();
            this.LastNameBox = new FeedMeClient.CustomControls.FeedMeTextBox();
            this.UsernameBox = new FeedMeClient.CustomControls.FeedMeTextBox();
            this.EmailBox = new FeedMeClient.CustomControls.FeedMeTextBox();
            this.PasswordBox = new FeedMeClient.CustomControls.FeedMeTextBox();
            this.ConfirmPasswordBox = new FeedMeClient.CustomControls.FeedMeTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // NoAccountLinkLabel
            // 
            this.NoAccountLinkLabel.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.NoAccountLinkLabel.AutoSize = true;
            this.NoAccountLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoAccountLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.NoAccountLinkLabel.Location = new System.Drawing.Point(112, 457);
            this.NoAccountLinkLabel.Name = "NoAccountLinkLabel";
            this.NoAccountLinkLabel.Size = new System.Drawing.Size(159, 17);
            this.NoAccountLinkLabel.TabIndex = 7;
            this.NoAccountLinkLabel.TabStop = true;
            this.NoAccountLinkLabel.Text = "Already Have an Account?";
            this.NoAccountLinkLabel.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.NoAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoAccountLinkLabel_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FeedMeClient.Properties.Resources.PizzaLogo;
            this.pictureBox3.Location = new System.Drawing.Point(130, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // RegisterButton
            // 
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RegisterButton.Location = new System.Drawing.Point(57, 491);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(286, 46);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(27, 225);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.AutoResize = false;
            this.FirstNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(207)))));
            this.FirstNameBox.BaseColor = System.Drawing.Color.Black;
            this.FirstNameBox.BorderColor = System.Drawing.Color.Black;
            this.FirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameBox.FocusColor = System.Drawing.Color.White;
            this.FirstNameBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.FirstNameBox.ForeColor = System.Drawing.Color.Gray;
            this.FirstNameBox.Location = new System.Drawing.Point(57, 225);
            this.FirstNameBox.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.SingleLine = false;
            this.FirstNameBox.Size = new System.Drawing.Size(134, 23);
            this.FirstNameBox.TabIndex = 0;
            this.FirstNameBox.Watermark = "";
            // 
            // LastNameBox
            // 
            this.LastNameBox.AutoResize = false;
            this.LastNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(207)))));
            this.LastNameBox.BaseColor = System.Drawing.Color.Black;
            this.LastNameBox.BorderColor = System.Drawing.Color.Black;
            this.LastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameBox.FocusColor = System.Drawing.Color.White;
            this.LastNameBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.LastNameBox.ForeColor = System.Drawing.Color.Gray;
            this.LastNameBox.Location = new System.Drawing.Point(211, 225);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.SingleLine = false;
            this.LastNameBox.Size = new System.Drawing.Size(134, 23);
            this.LastNameBox.TabIndex = 1;
            this.LastNameBox.Watermark = "";
            // 
            // UsernameBox
            // 
            this.UsernameBox.AutoResize = false;
            this.UsernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(207)))));
            this.UsernameBox.BaseColor = System.Drawing.Color.Black;
            this.UsernameBox.BorderColor = System.Drawing.Color.Black;
            this.UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameBox.FocusColor = System.Drawing.Color.White;
            this.UsernameBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.UsernameBox.ForeColor = System.Drawing.Color.Gray;
            this.UsernameBox.Location = new System.Drawing.Point(57, 275);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.SingleLine = false;
            this.UsernameBox.Size = new System.Drawing.Size(290, 23);
            this.UsernameBox.TabIndex = 2;
            this.UsernameBox.Watermark = "";
            // 
            // EmailBox
            // 
            this.EmailBox.AutoResize = false;
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(207)))));
            this.EmailBox.BaseColor = System.Drawing.Color.Black;
            this.EmailBox.BorderColor = System.Drawing.Color.Black;
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.FocusColor = System.Drawing.Color.White;
            this.EmailBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.EmailBox.ForeColor = System.Drawing.Color.Gray;
            this.EmailBox.Location = new System.Drawing.Point(57, 319);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.SingleLine = false;
            this.EmailBox.Size = new System.Drawing.Size(290, 23);
            this.EmailBox.TabIndex = 3;
            this.EmailBox.Watermark = "";
            // 
            // PasswordBox
            // 
            this.PasswordBox.AutoResize = false;
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(207)))));
            this.PasswordBox.BaseColor = System.Drawing.Color.Black;
            this.PasswordBox.BorderColor = System.Drawing.Color.Black;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.FocusColor = System.Drawing.Color.White;
            this.PasswordBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.PasswordBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordBox.Location = new System.Drawing.Point(57, 368);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.SingleLine = false;
            this.PasswordBox.Size = new System.Drawing.Size(290, 23);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.Watermark = "";
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_Enter);
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBox_Leave);
            // 
            // ConfirmPasswordBox
            // 
            this.ConfirmPasswordBox.AutoResize = false;
            this.ConfirmPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(207)))));
            this.ConfirmPasswordBox.BaseColor = System.Drawing.Color.Black;
            this.ConfirmPasswordBox.BorderColor = System.Drawing.Color.Black;
            this.ConfirmPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPasswordBox.FocusColor = System.Drawing.Color.White;
            this.ConfirmPasswordBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.ConfirmPasswordBox.ForeColor = System.Drawing.Color.Gray;
            this.ConfirmPasswordBox.Location = new System.Drawing.Point(57, 412);
            this.ConfirmPasswordBox.Name = "ConfirmPasswordBox";
            this.ConfirmPasswordBox.PasswordChar = '*';
            this.ConfirmPasswordBox.SingleLine = false;
            this.ConfirmPasswordBox.Size = new System.Drawing.Size(290, 23);
            this.ConfirmPasswordBox.TabIndex = 5;
            this.ConfirmPasswordBox.Watermark = "";
            this.ConfirmPasswordBox.TextChanged += new System.EventHandler(this.ConfirmPasswordBox_TextChanged);
            this.ConfirmPasswordBox.Enter += new System.EventHandler(this.ConfirmPasswordBox_Enter);
            this.ConfirmPasswordBox.Leave += new System.EventHandler(this.ConfirmPasswordBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(56, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(209, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(57, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(57, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(56, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(56, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Confirm Password:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 550);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.ConfirmPasswordBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.NoAccountLinkLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.RegisterButton);
            this.Name = "Register";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.Controls.SetChildIndex(this.RegisterButton, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.NoAccountLinkLabel, 0);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.FirstNameBox, 0);
            this.Controls.SetChildIndex(this.UsernameBox, 0);
            this.Controls.SetChildIndex(this.EmailBox, 0);
            this.Controls.SetChildIndex(this.PasswordBox, 0);
            this.Controls.SetChildIndex(this.ConfirmPasswordBox, 0);
            this.Controls.SetChildIndex(this.LastNameBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel NoAccountLinkLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CustomControls.FeedMeTextBox FirstNameBox;
        private CustomControls.FeedMeTextBox LastNameBox;
        private CustomControls.FeedMeTextBox UsernameBox;
        private CustomControls.FeedMeTextBox EmailBox;
        private CustomControls.FeedMeTextBox PasswordBox;
        private CustomControls.FeedMeTextBox ConfirmPasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}