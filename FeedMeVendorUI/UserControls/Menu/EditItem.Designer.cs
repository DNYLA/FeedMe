namespace FeedMeVendorUI.UserControls.Menu
{
    partial class EditItem
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
            this.ItemName = new System.Windows.Forms.Label();
            this.EditItemPanel = new System.Windows.Forms.Panel();
            this.DescTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.PriceTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.CategoryTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateItemButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.avatarPBox = new System.Windows.Forms.PictureBox();
            this.EditCategoryPanel = new System.Windows.Forms.Panel();
            this.UpdateCategoryButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EditCategoryTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.EditItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPBox)).BeginInit();
            this.EditCategoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(270, 12);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(256, 32);
            this.ItemName.TabIndex = 1;
            this.ItemName.Text = "Category/Item Name";
            this.ItemName.TextChanged += new System.EventHandler(this.ItemName_TextChanged);
            // 
            // EditItemPanel
            // 
            this.EditItemPanel.Controls.Add(this.avatarPBox);
            this.EditItemPanel.Controls.Add(this.label5);
            this.EditItemPanel.Controls.Add(this.UpdateItemButton);
            this.EditItemPanel.Controls.Add(this.label6);
            this.EditItemPanel.Controls.Add(this.label4);
            this.EditItemPanel.Controls.Add(this.NameTBox);
            this.EditItemPanel.Controls.Add(this.label2);
            this.EditItemPanel.Controls.Add(this.CategoryTBox);
            this.EditItemPanel.Controls.Add(this.PriceTBox);
            this.EditItemPanel.Controls.Add(this.DescTBox);
            this.EditItemPanel.Location = new System.Drawing.Point(287, 58);
            this.EditItemPanel.Name = "EditItemPanel";
            this.EditItemPanel.Size = new System.Drawing.Size(263, 354);
            this.EditItemPanel.TabIndex = 29;
            // 
            // DescTBox
            // 
            this.DescTBox.AutoResize = false;
            this.DescTBox.BaseColor = System.Drawing.Color.Black;
            this.DescTBox.BorderColor = System.Drawing.Color.Black;
            this.DescTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescTBox.FocusColor = System.Drawing.Color.White;
            this.DescTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.DescTBox.ForeColor = System.Drawing.Color.Gray;
            this.DescTBox.Location = new System.Drawing.Point(92, 204);
            this.DescTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DescTBox.Name = "DescTBox";
            this.DescTBox.SingleLine = true;
            this.DescTBox.Size = new System.Drawing.Size(144, 22);
            this.DescTBox.TabIndex = 14;
            this.DescTBox.Watermark = "";
            // 
            // PriceTBox
            // 
            this.PriceTBox.AutoResize = false;
            this.PriceTBox.BaseColor = System.Drawing.Color.Black;
            this.PriceTBox.BorderColor = System.Drawing.Color.Black;
            this.PriceTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTBox.FocusColor = System.Drawing.Color.White;
            this.PriceTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.PriceTBox.ForeColor = System.Drawing.Color.Gray;
            this.PriceTBox.Location = new System.Drawing.Point(92, 236);
            this.PriceTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PriceTBox.Name = "PriceTBox";
            this.PriceTBox.SingleLine = true;
            this.PriceTBox.Size = new System.Drawing.Size(144, 22);
            this.PriceTBox.TabIndex = 15;
            this.PriceTBox.Watermark = "";
            // 
            // CategoryTBox
            // 
            this.CategoryTBox.AutoResize = false;
            this.CategoryTBox.BaseColor = System.Drawing.Color.Black;
            this.CategoryTBox.BorderColor = System.Drawing.Color.Black;
            this.CategoryTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryTBox.FocusColor = System.Drawing.Color.White;
            this.CategoryTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.CategoryTBox.ForeColor = System.Drawing.Color.Gray;
            this.CategoryTBox.Location = new System.Drawing.Point(92, 172);
            this.CategoryTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryTBox.Name = "CategoryTBox";
            this.CategoryTBox.SingleLine = true;
            this.CategoryTBox.Size = new System.Drawing.Size(144, 22);
            this.CategoryTBox.TabIndex = 13;
            this.CategoryTBox.Watermark = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name:";
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
            this.NameTBox.Location = new System.Drawing.Point(92, 140);
            this.NameTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.SingleLine = true;
            this.NameTBox.Size = new System.Drawing.Size(144, 22);
            this.NameTBox.TabIndex = 12;
            this.NameTBox.Watermark = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price:";
            // 
            // UpdateItemButton
            // 
            this.UpdateItemButton.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateItemButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateItemButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateItemButton.Location = new System.Drawing.Point(47, 294);
            this.UpdateItemButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateItemButton.Name = "UpdateItemButton";
            this.UpdateItemButton.Size = new System.Drawing.Size(189, 44);
            this.UpdateItemButton.TabIndex = 26;
            this.UpdateItemButton.Text = "Update";
            this.UpdateItemButton.UseVisualStyleBackColor = false;
            this.UpdateItemButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Description:";
            // 
            // avatarPBox
            // 
            this.avatarPBox.Location = new System.Drawing.Point(85, 17);
            this.avatarPBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avatarPBox.Name = "avatarPBox";
            this.avatarPBox.Size = new System.Drawing.Size(154, 113);
            this.avatarPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPBox.TabIndex = 27;
            this.avatarPBox.TabStop = false;
            // 
            // EditCategoryPanel
            // 
            this.EditCategoryPanel.Controls.Add(this.UpdateCategoryButton);
            this.EditCategoryPanel.Controls.Add(this.label7);
            this.EditCategoryPanel.Controls.Add(this.EditCategoryTBox);
            this.EditCategoryPanel.Location = new System.Drawing.Point(287, 55);
            this.EditCategoryPanel.Name = "EditCategoryPanel";
            this.EditCategoryPanel.Size = new System.Drawing.Size(263, 354);
            this.EditCategoryPanel.TabIndex = 30;
            // 
            // UpdateCategoryButton
            // 
            this.UpdateCategoryButton.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCategoryButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCategoryButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateCategoryButton.Location = new System.Drawing.Point(47, 170);
            this.UpdateCategoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateCategoryButton.Name = "UpdateCategoryButton";
            this.UpdateCategoryButton.Size = new System.Drawing.Size(189, 44);
            this.UpdateCategoryButton.TabIndex = 26;
            this.UpdateCategoryButton.Text = "Update";
            this.UpdateCategoryButton.UseVisualStyleBackColor = false;
            this.UpdateCategoryButton.Click += new System.EventHandler(this.UpdateCategory_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Category:";
            // 
            // EditCategoryTBox
            // 
            this.EditCategoryTBox.AutoResize = false;
            this.EditCategoryTBox.BaseColor = System.Drawing.Color.Black;
            this.EditCategoryTBox.BorderColor = System.Drawing.Color.Black;
            this.EditCategoryTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EditCategoryTBox.FocusColor = System.Drawing.Color.White;
            this.EditCategoryTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.EditCategoryTBox.ForeColor = System.Drawing.Color.Gray;
            this.EditCategoryTBox.Location = new System.Drawing.Point(92, 124);
            this.EditCategoryTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditCategoryTBox.Name = "EditCategoryTBox";
            this.EditCategoryTBox.SingleLine = true;
            this.EditCategoryTBox.Size = new System.Drawing.Size(144, 22);
            this.EditCategoryTBox.TabIndex = 13;
            this.EditCategoryTBox.Watermark = "";
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EditCategoryPanel);
            this.Controls.Add(this.EditItemPanel);
            this.Controls.Add(this.ItemName);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditItem";
            this.Size = new System.Drawing.Size(776, 451);
            this.Load += new System.EventHandler(this.EditItem_Load);
            this.EditItemPanel.ResumeLayout(false);
            this.EditItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPBox)).EndInit();
            this.EditCategoryPanel.ResumeLayout(false);
            this.EditCategoryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Panel EditItemPanel;
        private System.Windows.Forms.PictureBox avatarPBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateItemButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private FeedMeLogic.Controls.FeedMeTextBox NameTBox;
        private System.Windows.Forms.Label label2;
        private FeedMeLogic.Controls.FeedMeTextBox CategoryTBox;
        private FeedMeLogic.Controls.FeedMeTextBox PriceTBox;
        private FeedMeLogic.Controls.FeedMeTextBox DescTBox;
        private System.Windows.Forms.Panel EditCategoryPanel;
        private System.Windows.Forms.Button UpdateCategoryButton;
        private System.Windows.Forms.Label label7;
        private FeedMeLogic.Controls.FeedMeTextBox EditCategoryTBox;
    }
}
