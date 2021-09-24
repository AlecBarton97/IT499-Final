
namespace FinalProject
{
    partial class Login
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
            this.emailEntry = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.updateAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailEntry
            // 
            this.emailEntry.Location = new System.Drawing.Point(95, 24);
            this.emailEntry.Name = "emailEntry";
            this.emailEntry.Size = new System.Drawing.Size(100, 20);
            this.emailEntry.TabIndex = 0;
            this.emailEntry.Text = "1111";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(95, 96);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 23);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(54, 27);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(33, 59);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordEntry
            // 
            this.passwordEntry.Location = new System.Drawing.Point(95, 59);
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.PasswordChar = '*';
            this.passwordEntry.Size = new System.Drawing.Size(100, 20);
            this.passwordEntry.TabIndex = 4;
            this.passwordEntry.Text = "1111";
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(95, 135);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(100, 23);
            this.createAccountButton.TabIndex = 7;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(195, 101);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 8;
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Location = new System.Drawing.Point(95, 355);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(100, 23);
            this.deleteAccountButton.TabIndex = 9;
            this.deleteAccountButton.Text = "Delete Account";
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // updateAccountButton
            // 
            this.updateAccountButton.Location = new System.Drawing.Point(95, 177);
            this.updateAccountButton.Name = "updateAccountButton";
            this.updateAccountButton.Size = new System.Drawing.Size(100, 23);
            this.updateAccountButton.TabIndex = 10;
            this.updateAccountButton.Text = "Update Info";
            this.updateAccountButton.UseVisualStyleBackColor = true;
            this.updateAccountButton.Click += new System.EventHandler(this.updateAccountButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateAccountButton);
            this.Controls.Add(this.deleteAccountButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.passwordEntry);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.emailEntry);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailEntry;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.Button updateAccountButton;
    }
}

