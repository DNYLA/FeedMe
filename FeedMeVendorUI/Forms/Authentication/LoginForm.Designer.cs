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
            this.feedMeTextBox1 = new FeedMeLogic.Controls.FeedMeTextBox();
            this.feedMeTextBox2 = new FeedMeLogic.Controls.FeedMeTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feedMeTextBox1
            // 
            this.feedMeTextBox1.AutoResize = false;
            this.feedMeTextBox1.BaseColor = System.Drawing.Color.Black;
            this.feedMeTextBox1.BorderColor = System.Drawing.Color.Black;
            this.feedMeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedMeTextBox1.FocusColor = System.Drawing.Color.White;
            this.feedMeTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.feedMeTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.feedMeTextBox1.Location = new System.Drawing.Point(70, 82);
            this.feedMeTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedMeTextBox1.Name = "feedMeTextBox1";
            this.feedMeTextBox1.SingleLine = true;
            this.feedMeTextBox1.Size = new System.Drawing.Size(246, 26);
            this.feedMeTextBox1.TabIndex = 2;
            this.feedMeTextBox1.Text = "username";
            this.feedMeTextBox1.Watermark = "username";
            // 
            // feedMeTextBox2
            // 
            this.feedMeTextBox2.AutoResize = false;
            this.feedMeTextBox2.BaseColor = System.Drawing.Color.Black;
            this.feedMeTextBox2.BorderColor = System.Drawing.Color.Black;
            this.feedMeTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedMeTextBox2.FocusColor = System.Drawing.Color.White;
            this.feedMeTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.feedMeTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.feedMeTextBox2.Location = new System.Drawing.Point(70, 134);
            this.feedMeTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedMeTextBox2.Name = "feedMeTextBox2";
            this.feedMeTextBox2.SingleLine = true;
            this.feedMeTextBox2.Size = new System.Drawing.Size(246, 20);
            this.feedMeTextBox2.TabIndex = 3;
            this.feedMeTextBox2.Text = "password";
            this.feedMeTextBox2.Watermark = "password";
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
            this.Controls.Add(this.feedMeTextBox2);
            this.Controls.Add(this.feedMeTextBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Controls.SetChildIndex(this.feedMeTextBox1, 0);
            this.Controls.SetChildIndex(this.feedMeTextBox2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private FeedMeLogic.Controls.FeedMeTextBox feedMeTextBox1;
        private FeedMeLogic.Controls.FeedMeTextBox feedMeTextBox2;
        private System.Windows.Forms.Button button1;
    }
}