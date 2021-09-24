
namespace FinalProject
{
    partial class ViewCart
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
            this.cartGrid = new System.Windows.Forms.DataGridView();
            this.homeButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.updateQuantityButton = new System.Windows.Forms.Button();
            this.quantityEntry = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.shippingLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.viewOrdersButton = new System.Windows.Forms.Button();
            this.orderMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cartGrid
            // 
            this.cartGrid.AllowUserToAddRows = false;
            this.cartGrid.AllowUserToDeleteRows = false;
            this.cartGrid.AllowUserToResizeColumns = false;
            this.cartGrid.AllowUserToResizeRows = false;
            this.cartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cartGrid.Location = new System.Drawing.Point(15, 78);
            this.cartGrid.MultiSelect = false;
            this.cartGrid.Name = "cartGrid";
            this.cartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartGrid.Size = new System.Drawing.Size(407, 236);
            this.cartGrid.TabIndex = 1;
            this.cartGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(15, 341);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Back";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(13, 13);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(30, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "asda";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(839, 12);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(127, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate Order";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(756, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(762, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(739, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Shipping:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grand Total:";
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(450, 199);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(111, 23);
            this.removeItemButton.TabIndex = 9;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // updateQuantityButton
            // 
            this.updateQuantityButton.Location = new System.Drawing.Point(456, 147);
            this.updateQuantityButton.Name = "updateQuantityButton";
            this.updateQuantityButton.Size = new System.Drawing.Size(100, 23);
            this.updateQuantityButton.TabIndex = 10;
            this.updateQuantityButton.Text = "Update Quantity";
            this.updateQuantityButton.UseVisualStyleBackColor = true;
            this.updateQuantityButton.Click += new System.EventHandler(this.updateQuantityButton_Click);
            // 
            // quantityEntry
            // 
            this.quantityEntry.Location = new System.Drawing.Point(456, 111);
            this.quantityEntry.Name = "quantityEntry";
            this.quantityEntry.Size = new System.Drawing.Size(100, 20);
            this.quantityEntry.TabIndex = 11;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(836, 60);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 13);
            this.totalLabel.TabIndex = 12;
            // 
            // shippingLabel
            // 
            this.shippingLabel.AutoSize = true;
            this.shippingLabel.Location = new System.Drawing.Point(836, 111);
            this.shippingLabel.Name = "shippingLabel";
            this.shippingLabel.Size = new System.Drawing.Size(0, 13);
            this.shippingLabel.TabIndex = 13;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(836, 157);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(0, 13);
            this.taxLabel.TabIndex = 14;
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.AutoSize = true;
            this.grandTotalLabel.Location = new System.Drawing.Point(836, 209);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.grandTotalLabel.TabIndex = 15;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(506, 78);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(0, 13);
            this.itemNameLabel.TabIndex = 16;
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Location = new System.Drawing.Point(845, 265);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(75, 23);
            this.placeOrderButton.TabIndex = 17;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // viewOrdersButton
            // 
            this.viewOrdersButton.Location = new System.Drawing.Point(49, 8);
            this.viewOrdersButton.Name = "viewOrdersButton";
            this.viewOrdersButton.Size = new System.Drawing.Size(127, 23);
            this.viewOrdersButton.TabIndex = 18;
            this.viewOrdersButton.Text = "View Orders";
            this.viewOrdersButton.UseVisualStyleBackColor = true;
            this.viewOrdersButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderMessage
            // 
            this.orderMessage.AutoSize = true;
            this.orderMessage.Location = new System.Drawing.Point(705, 17);
            this.orderMessage.Name = "orderMessage";
            this.orderMessage.Size = new System.Drawing.Size(0, 13);
            this.orderMessage.TabIndex = 19;
            // 
            // ViewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 408);
            this.Controls.Add(this.orderMessage);
            this.Controls.Add(this.viewOrdersButton);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.grandTotalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.shippingLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.quantityEntry);
            this.Controls.Add(this.updateQuantityButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.cartGrid);
            this.Name = "ViewCart";
            this.Text = "ViewCart";
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView cartGrid;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button updateQuantityButton;
        private System.Windows.Forms.TextBox quantityEntry;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label shippingLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Button viewOrdersButton;
        private System.Windows.Forms.Label orderMessage;
    }
}