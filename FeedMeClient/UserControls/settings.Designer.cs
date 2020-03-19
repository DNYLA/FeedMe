namespace FeedMeClient.UserControls
{
    partial class settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTbox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.fNameTbox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.lNameTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.emailTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.pcodeTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.AddTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateButton.Location = new System.Drawing.Point(303, 433);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(197, 42);
            this.UpdateButton.TabIndex = 25;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 30);
            this.label7.TabIndex = 23;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(207, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 30);
            this.label8.TabIndex = 24;
            this.label8.Text = "Postcode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Username:";
            // 
            // nameTbox
            // 
            this.nameTbox.AutoResize = false;
            this.nameTbox.BaseColor = System.Drawing.Color.Black;
            this.nameTbox.BorderColor = System.Drawing.Color.Black;
            this.nameTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTbox.FocusColor = System.Drawing.Color.White;
            this.nameTbox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.nameTbox.ForeColor = System.Drawing.Color.Gray;
            this.nameTbox.Location = new System.Drawing.Point(321, 232);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.SingleLine = true;
            this.nameTbox.Size = new System.Drawing.Size(218, 23);
            this.nameTbox.TabIndex = 14;
            this.nameTbox.Watermark = "";
            // 
            // fNameTbox
            // 
            this.fNameTbox.AutoResize = false;
            this.fNameTbox.BaseColor = System.Drawing.Color.Black;
            this.fNameTbox.BorderColor = System.Drawing.Color.Black;
            this.fNameTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fNameTbox.FocusColor = System.Drawing.Color.White;
            this.fNameTbox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.fNameTbox.ForeColor = System.Drawing.Color.Gray;
            this.fNameTbox.Location = new System.Drawing.Point(321, 264);
            this.fNameTbox.Name = "fNameTbox";
            this.fNameTbox.SingleLine = true;
            this.fNameTbox.Size = new System.Drawing.Size(218, 23);
            this.fNameTbox.TabIndex = 14;
            this.fNameTbox.Watermark = "";
            // 
            // lNameTBox
            // 
            this.lNameTBox.AutoResize = false;
            this.lNameTBox.BaseColor = System.Drawing.Color.Black;
            this.lNameTBox.BorderColor = System.Drawing.Color.Black;
            this.lNameTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lNameTBox.FocusColor = System.Drawing.Color.White;
            this.lNameTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.lNameTBox.ForeColor = System.Drawing.Color.Gray;
            this.lNameTBox.Location = new System.Drawing.Point(320, 296);
            this.lNameTBox.Name = "lNameTBox";
            this.lNameTBox.SingleLine = true;
            this.lNameTBox.Size = new System.Drawing.Size(218, 23);
            this.lNameTBox.TabIndex = 14;
            this.lNameTBox.Watermark = "";
            // 
            // emailTBox
            // 
            this.emailTBox.AutoResize = false;
            this.emailTBox.BaseColor = System.Drawing.Color.Black;
            this.emailTBox.BorderColor = System.Drawing.Color.Black;
            this.emailTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTBox.FocusColor = System.Drawing.Color.White;
            this.emailTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.emailTBox.ForeColor = System.Drawing.Color.Gray;
            this.emailTBox.Location = new System.Drawing.Point(320, 328);
            this.emailTBox.Name = "emailTBox";
            this.emailTBox.SingleLine = true;
            this.emailTBox.Size = new System.Drawing.Size(218, 23);
            this.emailTBox.TabIndex = 14;
            this.emailTBox.Watermark = "";
            // 
            // pcodeTBox
            // 
            this.pcodeTBox.AutoResize = false;
            this.pcodeTBox.BaseColor = System.Drawing.Color.Black;
            this.pcodeTBox.BorderColor = System.Drawing.Color.Black;
            this.pcodeTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pcodeTBox.FocusColor = System.Drawing.Color.White;
            this.pcodeTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.pcodeTBox.ForeColor = System.Drawing.Color.Gray;
            this.pcodeTBox.Location = new System.Drawing.Point(321, 360);
            this.pcodeTBox.Name = "pcodeTBox";
            this.pcodeTBox.SingleLine = true;
            this.pcodeTBox.Size = new System.Drawing.Size(218, 23);
            this.pcodeTBox.TabIndex = 14;
            this.pcodeTBox.Watermark = "";
            // 
            // AddTBox
            // 
            this.AddTBox.AutoResize = false;
            this.AddTBox.BaseColor = System.Drawing.Color.Black;
            this.AddTBox.BorderColor = System.Drawing.Color.Black;
            this.AddTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddTBox.FocusColor = System.Drawing.Color.White;
            this.AddTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.AddTBox.ForeColor = System.Drawing.Color.Gray;
            this.AddTBox.Location = new System.Drawing.Point(321, 392);
            this.AddTBox.Name = "AddTBox";
            this.AddTBox.SingleLine = true;
            this.AddTBox.Size = new System.Drawing.Size(218, 23);
            this.AddTBox.TabIndex = 14;
            this.AddTBox.Watermark = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(363, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 110);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(230, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 30);
            this.label9.TabIndex = 22;
            this.label9.Text = "Picture:";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddTBox);
            this.Controls.Add(this.pcodeTBox);
            this.Controls.Add(this.emailTBox);
            this.Controls.Add(this.lNameTBox);
            this.Controls.Add(this.fNameTbox);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "settings";
            this.Size = new System.Drawing.Size(767, 677);
            this.Load += new System.EventHandler(this.settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private FeedMeLogic.Controls.FeedMeTextBox nameTbox;
        private FeedMeLogic.Controls.FeedMeTextBox fNameTbox;
        private FeedMeLogic.Controls.FeedMeTextBox lNameTBox;
        private FeedMeLogic.Controls.FeedMeTextBox emailTBox;
        private FeedMeLogic.Controls.FeedMeTextBox pcodeTBox;
        private FeedMeLogic.Controls.FeedMeTextBox AddTBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
    }
}
