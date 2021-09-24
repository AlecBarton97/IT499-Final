
namespace FinalProject
{
    partial class ViewOrders
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
            this.backButton = new System.Windows.Forms.Button();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.orderButtonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 9);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(30, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "asda";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(15, 415);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // orderGridView
            // 
            this.orderGridView.AllowUserToAddRows = false;
            this.orderGridView.AllowUserToDeleteRows = false;
            this.orderGridView.AllowUserToResizeColumns = false;
            this.orderGridView.AllowUserToResizeRows = false;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.orderGridView.Location = new System.Drawing.Point(24, 57);
            this.orderGridView.MultiSelect = false;
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.ReadOnly = true;
            this.orderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderGridView.Size = new System.Drawing.Size(413, 250);
            this.orderGridView.TabIndex = 6;
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.Location = new System.Drawing.Point(443, 283);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(85, 23);
            this.cancelOrderButton.TabIndex = 7;
            this.cancelOrderButton.Text = "Cancel Order";
            this.cancelOrderButton.UseVisualStyleBackColor = true;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // orderButtonLabel
            // 
            this.orderButtonLabel.AutoSize = true;
            this.orderButtonLabel.Location = new System.Drawing.Point(534, 288);
            this.orderButtonLabel.Name = "orderButtonLabel";
            this.orderButtonLabel.Size = new System.Drawing.Size(0, 13);
            this.orderButtonLabel.TabIndex = 8;
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderButtonLabel);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.emailLabel);
            this.Name = "ViewOrders";
            this.Text = "ViewOrders";
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Label orderButtonLabel;
    }
}