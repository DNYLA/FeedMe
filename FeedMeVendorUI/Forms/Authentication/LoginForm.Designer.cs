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
            this.usernameTexbox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.PasswordTextbox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTexbox
            // 
            this.usernameTexbox.AutoResize = false;
            this.usernameTexbox.BaseColor = System.Drawing.Color.Black;
            this.usernameTexbox.BorderColor = System.Drawing.Color.Black;
            this.usernameTexbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTexbox.FocusColor = System.Drawing.Color.White;
            this.usernameTexbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.usernameTexbox.ForeColor = System.Drawing.Color.Gray;
            this.usernameTexbox.Location = new System.Drawing.Point(70, 82);
            this.usernameTexbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTexbox.Name = "usernameTexbox";
            this.usernameTexbox.SingleLine = true;
            this.usernameTexbox.Size = new System.Drawing.Size(246, 23);
            this.usernameTexbox.TabIndex = 2;
            this.usernameTexbox.Text = "username";
            this.usernameTexbox.Watermark = "username";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.AutoResize = false;
            this.PasswordTextbox.BaseColor = System.Drawing.Color.Black;
            this.PasswordTextbox.BorderColor = System.Drawing.Color.Black;
            this.PasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextbox.FocusColor = System.Drawing.Color.White;
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.PasswordTextbox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTextbox.Location = new System.Drawing.Point(70, 134);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.SingleLine = true;
            this.PasswordTextbox.Size = new System.Drawing.Size(246, 23);
            this.PasswordTextbox.TabIndex = 3;
            this.PasswordTextbox.Text = "password";
            this.PasswordTextbox.Watermark = "password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.usernameTexbox);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Controls.SetChildIndex(this.usernameTexbox, 0);
            this.Controls.SetChildIndex(this.PasswordTextbox, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private FeedMeLogic.Controls.FeedMeTextBox usernameTexbox;
        private FeedMeLogic.Controls.FeedMeTextBox PasswordTextbox;
        private System.Windows.Forms.Button button1;
    }
}