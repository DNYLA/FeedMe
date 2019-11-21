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
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.AutoResize = false;
            this.UsernameTextBox.BaseColor = System.Drawing.Color.Black;
            this.UsernameTextBox.BorderColor = System.Drawing.Color.Black;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.FocusColor = System.Drawing.Color.White;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.UsernameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.Location = new System.Drawing.Point(70, 82);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.SingleLine = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(246, 23);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.Text = "username";
            this.UsernameTextBox.Watermark = "username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AutoResize = false;
            this.PasswordTextBox.BaseColor = System.Drawing.Color.Black;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.Black;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.FocusColor = System.Drawing.Color.White;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.Location = new System.Drawing.Point(70, 134);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.SingleLine = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(246, 23);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "password";
            this.PasswordTextBox.Watermark = "password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(118, 212);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(131, 53);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
            // 
            // RegisterLinkLabel
            // 
            this.RegisterLinkLabel.AutoSize = true;
            this.RegisterLinkLabel.Location = new System.Drawing.Point(95, 174);
            this.RegisterLinkLabel.Name = "RegisterLinkLabel";
            this.RegisterLinkLabel.Size = new System.Drawing.Size(171, 21);
            this.RegisterLinkLabel.TabIndex = 5;
            this.RegisterLinkLabel.TabStop = true;
            this.RegisterLinkLabel.Text = "Dont Have an Account?";
            this.RegisterLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLinkLabel_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 628);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FeedMeLogic.Controls.FeedMeTextBox UsernameTextBox;
        private FeedMeLogic.Controls.FeedMeTextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel RegisterLinkLabel;
    }
}