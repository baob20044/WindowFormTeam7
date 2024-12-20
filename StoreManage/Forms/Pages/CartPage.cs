using StoreManage.Components;
using StoreManage.Controllers;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Forms.Pages
{
    public partial class CartPage : UserControl
    {
        private readonly OrderController orderController;
        public FlowLayoutPanel CartFlowLayout
        {
            get { return flowLayout; }
            set { flowLayout = value; }
        }
        public CartPage()
        {
            InitializeComponent();
            orderController = new OrderController(new ApiService());
        }
        public void UpdateCartTotals() /* Cart Page */
        {
            decimal totalMoney = 0;
            decimal transportFee = 30000;  // Static transport fee (VND)
            decimal discount = 0.20m;      // 20% discount

            // Calculate the total money based on the items in the cart
            foreach (Control control in flowLayout.Controls)
            {
                if (control is CartItem cartItem)
                {
                    // For each CartItem, calculate the price and quantity
                    decimal price = decimal.Parse(cartItem.ItemPrice.Replace(" VND", "").Replace(",", ""));
                    decimal quantity = cartItem.NumericValue;
                    totalMoney += price * quantity;
                }
            }

            // If the cart is empty, set the totals to zero or default values
            if (totalMoney == 0)
            {
                lbTotalMoney.Text = "0 VND";
                lbDiscount.Text = "0%";
                lbTransportFee.Text = $"0 VND";
                lbTotalOrder.Text = $"0 VND"; // Final total with only transport fee
            }
            else
            {
                // Apply discount and add transport fee
                decimal totalAfterDiscount = totalMoney * (1 - discount);
                decimal finalTotal = totalAfterDiscount + transportFee;

                // Update the labels on MainPage
                lbTotalMoney.Text = $"{totalMoney:N0} VND"; // Total before discount
                lbDiscount.Text = $"{discount * 100}%";     // Discount percentage
                lbTransportFee.Text = $"{transportFee:N0} VND"; // Transport fee
                lbTotalOrder.Text = $"{finalTotal:N0} VND"; // Final total after discount and transport fee
            }
        }
        public void RemoveCartItem(CartItem cartItem) /* Cart Page */
        {
            // Remove the item from the cart
            flowLayout.Controls.Remove(cartItem);

            // Update the cart totals after removing the item
            UpdateCartTotals();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var mainform = this.FindForm() as MainForm;
            var employeeId = mainform.employeeId;

            MessageBox.Show(employeeId.ToString());
        }
    }
}
