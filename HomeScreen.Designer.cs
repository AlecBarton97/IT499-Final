
namespace FinalProject
{
    partial class HomeScreen
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.itemLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.quantityEntry = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(35, 9);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(30, 13);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "temp";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "View Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemsGridView
            // 
            this.itemsGridView.AllowUserToAddRows = false;
            this.itemsGridView.AllowUserToDeleteRows = false;
            this.itemsGridView.AllowUserToResizeColumns = false;
            this.itemsGridView.AllowUserToResizeRows = false;
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.itemsGridView.Location = new System.Drawing.Point(38, 113);
            this.itemsGridView.MultiSelect = false;
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsGridView.Size = new System.Drawing.Size(332, 325);
            this.itemsGridView.TabIndex = 3;
            this.itemsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGridView_CellClick);
            this.itemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGridView_CellContentClick);
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(445, 159);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(61, 13);
            this.itemLabel.TabIndex = 4;
            this.itemLabel.Text = "Item Name:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(454, 200);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity:";
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(536, 228);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(75, 23);
            this.addToCartButton.TabIndex = 6;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // quantityEntry
            // 
            this.quantityEntry.Location = new System.Drawing.Point(523, 193);
            this.quantityEntry.Name = "quantityEntry";
            this.quantityEntry.Size = new System.Drawing.Size(100, 20);
            this.quantityEntry.TabIndex = 7;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(533, 159);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(35, 13);
            this.itemNameLabel.TabIndex = 8;
            this.itemNameLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Shopping";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.quantityEntry);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.itemsGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailLabel);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView itemsGridView;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.TextBox quantityEntry;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label label1;
    }
}