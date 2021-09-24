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
    public partial class ViewCart : Form
    {
        ItemController ic = new ItemController();
        CartController cc = new CartController();
        OrderController oc = new OrderController();
        Account currAcc;
        double metaTotal;
        public ViewCart(Account account)
        {
            InitializeComponent();
            currAcc = account;
            emailLabel.Text = account.Email;
            GridViewPopulate();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen(currAcc);
            homeScreen.Tag = this;
            homeScreen.Show();
            Hide();
        }
        private void GridViewPopulate()
        {
            cartGrid.ScrollBars = ScrollBars.Vertical;
            cartGrid.ColumnCount = 4;
            cartGrid.Columns[0].Name = "Item Name";
            cartGrid.Columns[1].Name = "Item Price";
            cartGrid.Columns[2].Name = "Item Quantity";
            cartGrid.Columns[3].Name = "Total Price";
            var cart = cc.ReadCart(currAcc.ID);

            foreach (var item in cart)
            {
                var i = ic.GetItem(item.ItemID);

                string[] row = { i.Name, i.Price.ToString(), item.Quantity.ToString(), (i.Price * item.Quantity).ToString() };

                cartGrid.Rows.Add(row);
            }
        }
        private void CalculateTotals()
        {
            var cart = cc.ReadCart(currAcc.ID);
            double totalCost = 0.0;
            foreach (var item in cart)
            {
                var i = ic.GetItem(item.ItemID);
                totalCost += item.Quantity * i.Price;
            }
            totalCost = Math.Round(totalCost, 2);
            var tax = Math.Round(totalCost * 0.05,2);
            double shipping = 10.0;
            double grandTotal = Math.Round(totalCost + tax + shipping,2);
            metaTotal = grandTotal;

            totalLabel.Text = "$" + totalCost.ToString();
            taxLabel.Text = "$" + tax.ToString();
            shippingLabel.Text = "$" + shipping.ToString();
            grandTotalLabel.Text = "$" + grandTotal.ToString();
        }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                itemNameLabel.Text = cartGrid.CurrentRow.Cells[0].Value.ToString();
                quantityEntry.Text = cartGrid.CurrentRow.Cells[2].Value.ToString();
            }
        }
        private void updateQuantityButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(quantityEntry.Text))
            {
                var itemStr = cartGrid.CurrentRow.Cells[0].Value.ToString();
                var cart = cc.ReadCart(currAcc.ID);
                Cart selectedCartRowItem;
                foreach (var item in cart)
                {
                    if (ic.GetItem(item.ItemID).Name == itemStr)
                    {
                        selectedCartRowItem = item;
                        selectedCartRowItem.Quantity = Int32.Parse(quantityEntry.Text);
                        cc.UpdateCart(selectedCartRowItem);
                    }
                }
                ViewCart viewCart2 = new ViewCart(currAcc);
                viewCart2.Tag = this;
                viewCart2.Show();
                Hide();
            }
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(quantityEntry.Text))
            {
                var itemStr = cartGrid.CurrentRow.Cells[0].Value.ToString();
                var cart = cc.ReadCart(currAcc.ID);
                Cart selectedCartRowItem;
                foreach (var item in cart)
                {
                    if (ic.GetItem(item.ItemID).Name == itemStr)
                    {
                        selectedCartRowItem = item;
                        selectedCartRowItem.Quantity = Int32.Parse(quantityEntry.Text);
                        cc.DeleteCart(selectedCartRowItem);
                    }
                }

                ViewCart viewCart2 = new ViewCart(currAcc);
                viewCart2.Tag = this;
                viewCart2.Show();
                Hide();
            }

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            if (metaTotal > 0.0)
            {
                Order order = new Order() { AccountID = currAcc.ID, OrderStatus = "Not Shipped", OrderDate = DateTime.Now, CartID = cc.GetCurrentCartID(currAcc), OrderPrice = metaTotal };
                oc.CreateOrder(order);
                var currentCart = cc.ReadCart(currAcc.ID);
                foreach (var item in currentCart)
                {
                    var c = item;
                    c.Active = false;
                    cc.UpdateCart(c);
                }


                ViewOrders viewOrders = new ViewOrders(currAcc);
                viewOrders.Tag = this;
                viewOrders.Show();
                Hide();
            }
            else
            {
                orderMessage.Text = "Calculate Totals First!";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // view orders
            ViewOrders viewOrders = new ViewOrders(currAcc);
            viewOrders.Tag = this;
            viewOrders.Show();
            Hide();
        }
    }
}
