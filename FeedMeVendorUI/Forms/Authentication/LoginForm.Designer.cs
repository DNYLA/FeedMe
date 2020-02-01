namespace FeedMeVendorUI.Forms.Authentication
{
    partial class LoginForm
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
            this.UsernameTextBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.PasswordTextBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.AutoResize = false;
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UsernameTextBox.BaseColor = System.Drawing.Color.Black;
            this.UsernameTextBox.BorderColor = System.Drawing.Color.DodgerBlue;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(123)))), ((int)(((byte)(75)))));
            this.UsernameTextBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.UsernameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.Location = new System.Drawing.Point(48, 193);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.SingleLine = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(288, 25);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.Text = "username";
            this.UsernameTextBox.Watermark = "username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AutoResize = false;
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PasswordTextBox.BaseColor = System.Drawing.Color.Black;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(123)))), ((int)(((byte)(75)))));
            this.PasswordTextBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.Location = new System.Drawing.Point(49, 226);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.SingleLine = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(288, 25);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "password";
            this.PasswordTextBox.Watermark = "password";
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LoginButton.Location = new System.Drawing.Point(51, 290);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(286, 44);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
            // 
            // RegisterLinkLabel
            // 
            this.RegisterLinkLabel.AutoSize = true;
            this.RegisterLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.RegisterLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.RegisterLinkLabel.Location = new System.Drawing.Point(120, 259);
            this.RegisterLinkLabel.Name = "RegisterLinkLabel";
            this.RegisterLinkLabel.Size = new System.Drawing.Size(143, 17);
            this.RegisterLinkLabel.TabIndex = 5;
            this.RegisterLinkLabel.TabStop = true;
            this.RegisterLinkLabel.Text = "Dont Have an Account?";
            this.RegisterLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLinkLabel_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(128, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 538);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.RegisterLinkLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load_1);
            this.Controls.SetChildIndex(this.UsernameTextBox, 0);
            this.Controls.SetChildIndex(this.PasswordTextBox, 0);
            this.Controls.SetChildIndex(this.LoginButton, 0);
            this.Controls.SetChildIndex(this.RegisterLinkLabel, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FeedMeLogic.Controls.FeedMeTextBox UsernameTextBox;
        private FeedMeLogic.Controls.FeedMeTextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel RegisterLinkLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}