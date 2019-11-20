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
            this.usernameTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.passwordTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // usernameTBox
            // 
            this.usernameTBox.AutoResize = false;
            this.usernameTBox.BaseColor = System.Drawing.Color.Black;
            this.usernameTBox.BorderColor = System.Drawing.Color.Black;
            this.usernameTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTBox.FocusColor = System.Drawing.Color.White;
            this.usernameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.usernameTBox.ForeColor = System.Drawing.Color.Gray;
            this.usernameTBox.Location = new System.Drawing.Point(70, 82);
            this.usernameTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTBox.Name = "usernameTBox";
            this.usernameTBox.SingleLine = true;
            this.usernameTBox.Size = new System.Drawing.Size(246, 23);
            this.usernameTBox.TabIndex = 2;
            this.usernameTBox.Text = "username";
            this.usernameTBox.Watermark = "username";
            // 
            // passwordTBox
            // 
            this.passwordTBox.AutoResize = false;
            this.passwordTBox.BaseColor = System.Drawing.Color.Black;
            this.passwordTBox.BorderColor = System.Drawing.Color.Black;
            this.passwordTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTBox.FocusColor = System.Drawing.Color.White;
            this.passwordTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.passwordTBox.ForeColor = System.Drawing.Color.Gray;
            this.passwordTBox.Location = new System.Drawing.Point(70, 134);
            this.passwordTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.SingleLine = true;
            this.passwordTBox.Size = new System.Drawing.Size(246, 23);
            this.passwordTBox.TabIndex = 3;
            this.passwordTBox.Text = "password";
            this.passwordTBox.Watermark = "password";
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
            this.Controls.Add(this.passwordTBox);
            this.Controls.Add(this.usernameTBox);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Controls.SetChildIndex(this.usernameTBox, 0);
            this.Controls.SetChildIndex(this.passwordTBox, 0);
            this.Controls.SetChildIndex(this.LoginButton, 0);
            this.Controls.SetChildIndex(this.RegisterLinkLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FeedMeLogic.Controls.FeedMeTextBox usernameTBox;
        private FeedMeLogic.Controls.FeedMeTextBox passwordTBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel RegisterLinkLabel;
    }
}