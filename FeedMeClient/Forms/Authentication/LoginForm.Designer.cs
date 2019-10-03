namespace FeedMeClient.Forms.Authentication
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
            this.UsernameTextBox = new FeedMeClient.CustomControls.FeedMeTextBox();
            this.PasswordTextBox = new FeedMeClient.CustomControls.FeedMeTextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.NoAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ServerTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.AutoResize = true;
            this.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(207)))));
            this.UsernameTextBox.BaseColor = System.Drawing.Color.Black;
            this.UsernameTextBox.BorderColor = System.Drawing.Color.DodgerBlue;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(123)))), ((int)(((byte)(75)))));
            this.UsernameTextBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.UsernameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.Location = new System.Drawing.Point(62, 197);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.SingleLine = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(288, 23);
            this.UsernameTextBox.TabIndex = 0;
            this.UsernameTextBox.Text = "Username";
            this.UsernameTextBox.Watermark = "Username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AutoResize = true;
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(207)))));
            this.PasswordTextBox.BaseColor = System.Drawing.Color.Black;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(123)))), ((int)(((byte)(75)))));
            this.PasswordTextBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.Location = new System.Drawing.Point(62, 239);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.SingleLine = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(288, 23);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.Watermark = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LoginButton.Location = new System.Drawing.Point(46, 308);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(286, 44);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // NoAccountLinkLabel
            // 
            this.NoAccountLinkLabel.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.NoAccountLinkLabel.AutoSize = true;
            this.NoAccountLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoAccountLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.NoAccountLinkLabel.Location = new System.Drawing.Point(118, 274);
            this.NoAccountLinkLabel.Name = "NoAccountLinkLabel";
            this.NoAccountLinkLabel.Size = new System.Drawing.Size(143, 17);
            this.NoAccountLinkLabel.TabIndex = 3;
            this.NoAccountLinkLabel.TabStop = true;
            this.NoAccountLinkLabel.Text = "Don\'t have an account?";
            this.NoAccountLinkLabel.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.NoAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoAccountLinkLabel_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(32, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FeedMeClient.Properties.Resources.PizzaLogo;
            this.pictureBox3.Location = new System.Drawing.Point(136, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FeedMeClient.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(31, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ServerTest
            // 
            this.ServerTest.Location = new System.Drawing.Point(82, 413);
            this.ServerTest.Name = "ServerTest";
            this.ServerTest.Size = new System.Drawing.Size(135, 53);
            this.ServerTest.TabIndex = 7;
            this.ServerTest.Text = "button1";
            this.ServerTest.UseVisualStyleBackColor = true;
            this.ServerTest.Click += new System.EventHandler(this.ServerTest_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 538);
            this.Controls.Add(this.ServerTest);
            this.Controls.Add(this.NoAccountLinkLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Controls.SetChildIndex(this.UsernameTextBox, 0);
            this.Controls.SetChildIndex(this.PasswordTextBox, 0);
            this.Controls.SetChildIndex(this.LoginButton, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.NoAccountLinkLabel, 0);
            this.Controls.SetChildIndex(this.ServerTest, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.FeedMeTextBox UsernameTextBox;
        private CustomControls.FeedMeTextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel NoAccountLinkLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ServerTest;
    }
}