namespace FeedMeVendorUI.UserControls.Menu
{
    partial class OrderControl
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
            this.OrdersFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrdersFlowPanel
            // 
            this.OrdersFlowPanel.Location = new System.Drawing.Point(20, 61);
            this.OrdersFlowPanel.Name = "OrdersFlowPanel";
            this.OrdersFlowPanel.Size = new System.Drawing.Size(731, 235);
            this.OrdersFlowPanel.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(315, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 30);
            this.label17.TabIndex = 2;
            this.label17.Text = "New Orders";
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.OrdersFlowPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(776, 451);
            this.Load += new System.EventHandler(this.OrderControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel OrdersFlowPanel;
        private System.Windows.Forms.Label label17;
    }
}
