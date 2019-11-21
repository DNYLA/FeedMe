namespace FeedMeVendorUI.UserControls.Menu
{
    partial class MenuInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CatLBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ItemLBox = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.EditCatButton = new System.Windows.Forms.Button();
            this.AddCatButton = new System.Windows.Forms.Button();
            this.RemoveCatButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.EditItemButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.DescTbox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.CategoryTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.NameTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.CatNameTbox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.CatLBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(213, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 271);
            this.panel1.TabIndex = 0;
            // 
            // CatLBox
            // 
            this.CatLBox.BackColor = System.Drawing.SystemColors.Control;
            this.CatLBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatLBox.FormattingEnabled = true;
            this.CatLBox.ItemHeight = 21;
            this.CatLBox.Items.AddRange(new object[] {
            "Burgers",
            "Wraps",
            "Drinks",
            "Deserts"});
            this.CatLBox.Location = new System.Drawing.Point(0, 21);
            this.CatLBox.Name = "CatLBox";
            this.CatLBox.Size = new System.Drawing.Size(200, 250);
            this.CatLBox.TabIndex = 1;
            this.CatLBox.SelectedIndexChanged += new System.EventHandler(this.CatLBox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 21);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.ItemLBox);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(419, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 271);
            this.panel2.TabIndex = 1;
            // 
            // ItemLBox
            // 
            this.ItemLBox.BackColor = System.Drawing.SystemColors.Control;
            this.ItemLBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemLBox.FormattingEnabled = true;
            this.ItemLBox.ItemHeight = 21;
            this.ItemLBox.Items.AddRange(new object[] {
            "Burger 1",
            "Burger 2",
            "Burger 3",
            "Burger 4"});
            this.ItemLBox.Location = new System.Drawing.Point(0, 21);
            this.ItemLBox.Name = "ItemLBox";
            this.ItemLBox.Size = new System.Drawing.Size(200, 250);
            this.ItemLBox.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 21);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Items";
            // 
            // EditCatButton
            // 
            this.EditCatButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditCatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCatButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCatButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EditCatButton.Location = new System.Drawing.Point(81, 70);
            this.EditCatButton.Name = "EditCatButton";
            this.EditCatButton.Size = new System.Drawing.Size(126, 27);
            this.EditCatButton.TabIndex = 2;
            this.EditCatButton.Text = "Edit";
            this.EditCatButton.UseVisualStyleBackColor = false;
            this.EditCatButton.Click += new System.EventHandler(this.EditCatButton_Click);
            // 
            // AddCatButton
            // 
            this.AddCatButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddCatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCatButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCatButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddCatButton.Location = new System.Drawing.Point(81, 37);
            this.AddCatButton.Name = "AddCatButton";
            this.AddCatButton.Size = new System.Drawing.Size(126, 27);
            this.AddCatButton.TabIndex = 3;
            this.AddCatButton.Text = "Add";
            this.AddCatButton.UseVisualStyleBackColor = false;
            this.AddCatButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveCatButton
            // 
            this.RemoveCatButton.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveCatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCatButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCatButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RemoveCatButton.Location = new System.Drawing.Point(81, 103);
            this.RemoveCatButton.Name = "RemoveCatButton";
            this.RemoveCatButton.Size = new System.Drawing.Size(126, 27);
            this.RemoveCatButton.TabIndex = 4;
            this.RemoveCatButton.Text = "Remove";
            this.RemoveCatButton.UseVisualStyleBackColor = false;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveItemButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItemButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RemoveItemButton.Location = new System.Drawing.Point(625, 103);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(126, 27);
            this.RemoveItemButton.TabIndex = 7;
            this.RemoveItemButton.Text = "Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = false;
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddItemButton.Location = new System.Drawing.Point(625, 37);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(126, 27);
            this.AddItemButton.TabIndex = 6;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = false;
            // 
            // EditItemButton
            // 
            this.EditItemButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditItemButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditItemButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EditItemButton.Location = new System.Drawing.Point(625, 70);
            this.EditItemButton.Name = "EditItemButton";
            this.EditItemButton.Size = new System.Drawing.Size(126, 27);
            this.EditItemButton.TabIndex = 5;
            this.EditItemButton.Text = "Edit";
            this.EditItemButton.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.PriceTBox);
            this.panel5.Controls.Add(this.DescTbox);
            this.panel5.Controls.Add(this.CategoryTBox);
            this.panel5.Controls.Add(this.NameTBox);
            this.panel5.Location = new System.Drawing.Point(425, 293);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 141);
            this.panel5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
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
            this.PriceTBox.Location = new System.Drawing.Point(84, 103);
            this.PriceTBox.Name = "PriceTBox";
            this.PriceTBox.SingleLine = true;
            this.PriceTBox.Size = new System.Drawing.Size(97, 23);
            this.PriceTBox.TabIndex = 0;
            this.PriceTBox.Watermark = "";
            // 
            // DescTbox
            // 
            this.DescTbox.AutoResize = false;
            this.DescTbox.BaseColor = System.Drawing.Color.Black;
            this.DescTbox.BorderColor = System.Drawing.Color.Black;
            this.DescTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescTbox.FocusColor = System.Drawing.Color.White;
            this.DescTbox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.DescTbox.ForeColor = System.Drawing.Color.Gray;
            this.DescTbox.Location = new System.Drawing.Point(84, 74);
            this.DescTbox.Name = "DescTbox";
            this.DescTbox.SingleLine = true;
            this.DescTbox.Size = new System.Drawing.Size(97, 23);
            this.DescTbox.TabIndex = 0;
            this.DescTbox.Watermark = "";
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
            this.CategoryTBox.Location = new System.Drawing.Point(84, 45);
            this.CategoryTBox.Name = "CategoryTBox";
            this.CategoryTBox.SingleLine = true;
            this.CategoryTBox.Size = new System.Drawing.Size(97, 23);
            this.CategoryTBox.TabIndex = 0;
            this.CategoryTBox.Watermark = "";
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
            this.NameTBox.Location = new System.Drawing.Point(84, 16);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.SingleLine = true;
            this.NameTBox.Size = new System.Drawing.Size(97, 23);
            this.NameTBox.TabIndex = 0;
            this.NameTBox.Watermark = "";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.CatNameTbox);
            this.panel6.Location = new System.Drawing.Point(213, 293);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 141);
            this.panel6.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name:";
            // 
            // CatNameTbox
            // 
            this.CatNameTbox.AutoResize = false;
            this.CatNameTbox.BaseColor = System.Drawing.Color.Black;
            this.CatNameTbox.BorderColor = System.Drawing.Color.Black;
            this.CatNameTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatNameTbox.FocusColor = System.Drawing.Color.White;
            this.CatNameTbox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.CatNameTbox.ForeColor = System.Drawing.Color.Gray;
            this.CatNameTbox.Location = new System.Drawing.Point(85, 16);
            this.CatNameTbox.Name = "CatNameTbox";
            this.CatNameTbox.SingleLine = true;
            this.CatNameTbox.Size = new System.Drawing.Size(97, 23);
            this.CatNameTbox.TabIndex = 0;
            this.CatNameTbox.Watermark = "";
            // 
            // MenuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.EditItemButton);
            this.Controls.Add(this.RemoveCatButton);
            this.Controls.Add(this.AddCatButton);
            this.Controls.Add(this.EditCatButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuInfo";
            this.Size = new System.Drawing.Size(776, 451);
            this.Load += new System.EventHandler(this.MenuInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox CatLBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EditCatButton;
        private System.Windows.Forms.Button AddCatButton;
        private System.Windows.Forms.Button RemoveCatButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button EditItemButton;
        private System.Windows.Forms.ListBox ItemLBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private FeedMeLogic.Controls.FeedMeTextBox PriceTBox;
        private FeedMeLogic.Controls.FeedMeTextBox DescTbox;
        private FeedMeLogic.Controls.FeedMeTextBox CategoryTBox;
        private FeedMeLogic.Controls.FeedMeTextBox NameTBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private FeedMeLogic.Controls.FeedMeTextBox CatNameTbox;
    }
}
