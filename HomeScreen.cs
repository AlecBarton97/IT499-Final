using FinalProject.Controllers;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class HomeScreen : Form
    {
        ItemController ic = new ItemController();
        CartController cartC = new CartController();
        Account currAcc;
        public HomeScreen(Account account)
        {
            InitializeComponent();
            currAcc = account;
            emailLabel.Text = account.Email;
            itemNameLabel.Text = "Apple";
            ic.CreateDefaultItems();
            PopulateDataGrid();
        }
        private void PopulateDataGrid()
        {
            itemsGridView.ScrollBars = ScrollBars.Vertical;
            itemsGridView.ColumnCount = 4;
            itemsGridView.Columns[0].Name = "Item Name";
            itemsGridView.Columns[1].Name = "Item Description";
            itemsGridView.Columns[2].Name = "Item Price";

            var items = ic.GetDataTableItems();
            var itemCount = items.Count();
            for (int i = 1; i <= itemCount; i++)
            {
                string[] row = { items[i - 1].Name, items[i - 1].Description, items[i - 1].Price.ToString()};
                itemsGridView.Rows.Add(row);
            }
        }

        private void itemsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                itemNameLabel.Text = itemsGridView.CurrentRow.Cells[0].Value.ToString(); 
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(quantityEntry.Text))
            {
                var item = ic.GetItem(itemNameLabel.Text);
                var quantity = Int32.Parse(quantityEntry.Text);
                cartC.CreateCartItem(currAcc.ID, item.ID, quantity);
            }
            else
            {
                quantityEntry.Text = "1";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ViewCart viewCart = new ViewCart(currAcc);
            viewCart.Tag = this;
            viewCart.Show();
            Hide();
        }

        private void itemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
