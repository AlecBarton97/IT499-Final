using FinalProject.Controllers;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Login : Form
    {
        ControllerController cc = new ControllerController();
        AccountController ac = new AccountController();
        bool updateAccountFlag;
        Account updateAccount;
        public Login()
        {
            InitializeComponent();
            updateAccountFlag = false;
            if (cc.CheckTables() != true)
            {
                cc.CreateTables();
            }
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = ac.CreateAccount(emailEntry.Text, passwordEntry.Text);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (updateAccountFlag == true && passwordEntry.TextLength > 3)
            {
                updateAccount.Email = emailEntry.Text;
                updateAccount.Password = passwordEntry.Text;
                ac.UpdateAccount(updateAccount);
                updateAccountFlag = false;
                messageLabel.Text = "Account Updated";
            }else if (emailEntry.TextLength != 0 && passwordEntry.TextLength != 0)
            {
                var attempt = ac.ReadAccount(emailEntry.Text, passwordEntry.Text);
                if (attempt != null)
                {
                    HomeScreen homeScreen = new HomeScreen(attempt);
                    homeScreen.Tag = this;
                    homeScreen.Show();
                    Hide();
                }
                else
                {
                    messageLabel.Text = "Please try again";
                }
            }
            else
            {
                messageLabel.Text = "Enter Email and Password";
            }

        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            if (emailEntry.TextLength != 0 && passwordEntry.TextLength != 0)
            {
                var attempt = ac.ReadAccount(emailEntry.Text, passwordEntry.Text);
                if (attempt != null)
                {
                    ac.DeleteAccount(ac.ReadAccount(emailEntry.Text, passwordEntry.Text));
                    messageLabel.Text = "Account Deleted!";
                }
                else
                {
                    messageLabel.Text = "No Account Found";
                }
            }
            else
            {
                messageLabel.Text = "Enter Email and Password";
            }

        }
        private void updateAccountButton_Click(object sender, EventArgs e)
        {
            if (emailEntry.TextLength != 0 && passwordEntry.TextLength != 0)
            {
                var attempt = ac.ReadAccount(emailEntry.Text, passwordEntry.Text);
                if (attempt != null)
                {
                    updateAccount = ac.ReadAccount(emailEntry.Text, passwordEntry.Text);
                    messageLabel.Text = "Enter new info and click login!";
                    emailEntry.Text = "";
                    passwordEntry.Text = "";
                    updateAccountFlag = true;
                }
                else
                {
                    messageLabel.Text = "Please try again";
                }
            }
            else
            {
                messageLabel.Text = "Enter Email and Password";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
