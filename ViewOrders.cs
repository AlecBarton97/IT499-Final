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
    public partial class ViewOrders : Form
    {
        Account currAcc;
        OrderController oc = new OrderController();
        public ViewOrders(Account acc)
        {
            currAcc = acc;
            InitializeComponent();
            CreateGrid();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ViewCart viewCart2 = new ViewCart(currAcc);
            viewCart2.Tag = this;
            viewCart2.Show();
            Hide();
        }
        private void CreateGrid()
        {
            orderGridView.ScrollBars = ScrollBars.Vertical;
            orderGridView.ColumnCount = 4;
            orderGridView.Columns[0].Name = "Order Number";
            orderGridView.Columns[1].Name = "Order Price";
            orderGridView.Columns[2].Name = "Order Date";
            orderGridView.Columns[3].Name = "Order Status";

            var orders = oc.ReadAccountOrder(currAcc);

            foreach (var item in orders)
            {
                string[] row = { item.ID.ToString(), item.OrderPrice.ToString(), item.OrderDate.ToString(), item.OrderStatus};

                orderGridView.Rows.Add(row);
            }

        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            if (orderGridView.SelectedRows.Count > 0)
            {
                var selectedOrder = orderGridView.CurrentRow.Cells[0].Value.ToString();

                var orderID = Int32.Parse(selectedOrder);

                var selectedOrderStatus = orderGridView.CurrentRow.Cells[3].Value.ToString();
                if (selectedOrderStatus != "Shipped")
                {
                    orderButtonLabel.Text = "Order Canceled";
                    var orderToDelete = oc.GetOrder(orderID);
                    oc.DeleteOrder(orderToDelete);

                    ViewOrders viewOrders = new ViewOrders(currAcc);
                    viewOrders.Tag = this;
                    viewOrders.Show();
                    Hide();

                }
            }

        }
    }
}
