using Newtonsoft.Json;
using RestSharp;
using StoreManage.DTOs.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Components
{
    public partial class CartItem : UserControl
    {
        public int ProductId { get; } // To hold the product ID
        public string SelectedColorName { get; set; } // Selected color
        public string SelectedSize { get; set; }      // Selected size

        public event Action<int> OnCartItemClick; // Event to notify when the item is clicked
        private MainForm _mainForm;
        public CartItem(int productId, string selectedColorName, string selectedSize,MainForm mainForm)
        {
            InitializeComponent();
            ProductId = productId;

            SelectedColorName = selectedColorName;
            SelectedSize = selectedSize;

            pBProduct.Click += (s, e) => OnCartItemClick?.Invoke(ProductId);
            lbName.Click += (s, e) => OnCartItemClick?.Invoke(ProductId);
            lbPrice.Click += (s, e) => OnCartItemClick?.Invoke(ProductId);

            _mainForm = mainForm;
        }

        private void CartItem_Load(object sender, EventArgs e)
        {
            LoadProductData(ProductId);
        }
        private async Task LoadProductImage(string imageUrl)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    var imageBytes = await httpClient.GetByteArrayAsync(imageUrl);
                    if (imageBytes.Length > 0)
                    {
                        using (var ms = new System.IO.MemoryStream(imageBytes))
                        {
                            pBProduct.Image = new Bitmap(ms);
                        }
                    }
                    else
                    {
                        pBProduct.Image = global::StoreManage.Properties.Resources.cart; // Fallback image
                    }
                }
            }
            catch
            {
                pBProduct.Image = global::StoreManage.Properties.Resources.cart; // Fallback image
            }
        }
        private async void LoadProductData(int productId)
        {
            try
            {
                var client = new RestClient("http://localhost:5254");
                var request = new RestRequest($"/api/products/{productId}", Method.Get);
                request.AddHeader("accept", "*/*");

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var product = JsonConvert.DeserializeObject<ProductDto>(response.Content);

                    if (product != null)
                    {
                        // Set product details
                        lbName.Text = product.Name;
                        lbPrice.Text = $"{product.Price:N0} VND";

                        // Populate color dropdown
                        if (product.Colors != null && product.Colors.Count > 0)
                        {
                            DropdownColor.Items.Clear();
                            foreach (var color in product.Colors)
                            {
                                DropdownColor.Items.Add(color.Name);
                            }

                            // Set selected color based on the selected color name
                            if (!string.IsNullOrEmpty(SelectedColorName) && DropdownColor.Items.Contains(SelectedColorName))
                            {
                                DropdownColor.SelectedItem = SelectedColorName;
                            }
                            else
                            {
                                DropdownColor.SelectedIndex = 0; // Default to the first color
                            }
                        }

                        // Populate size dropdown
                        if (product.Sizes != null && product.Sizes.Count > 0)
                        {
                            DropdownSize.Items.Clear();
                            foreach (var size in product.Sizes)
                            {
                                DropdownSize.Items.Add(size.SizeValue);
                            }

                            // Set selected size based on the selected size
                            if (!string.IsNullOrEmpty(SelectedSize) && DropdownSize.Items.Contains(SelectedSize))
                            {
                                DropdownSize.SelectedItem = SelectedSize;
                            }
                            else
                            {
                                DropdownSize.SelectedIndex = 0; // Default to the first size
                            }
                        }

                        // Handle product image based on selected color
                        string selectedColorName = DropdownColor.SelectedItem?.ToString();
                        var selectedColor = product.Colors?.FirstOrDefault(c => c.Name == selectedColorName);

                        if (selectedColor != null && selectedColor.Images != null && selectedColor.Images.Count > 0)
                        {
                            var imageUrl = selectedColor.Images.FirstOrDefault()?.Url;
                            if (!string.IsNullOrEmpty(imageUrl))
                            {
                                await LoadProductImage(imageUrl);
                            }
                            else
                            {
                                pBProduct.Image = global::StoreManage.Properties.Resources.cart; // Fallback image
                            }
                        }
                        else
                        {
                            pBProduct.Image = global::StoreManage.Properties.Resources.cart; // Fallback image
                        }
                    }
                }
            }
            catch
            {
                pBProduct.Image = global::StoreManage.Properties.Resources.cart; // Fallback image
            }
        }
        public string ItemLabel
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }  // Set product name
        }

        public string ItemPrice
        {
            get { return lbPrice.Text; }
            set { lbPrice.Text = value; }  // Set product price
        }

        public Image ProductImage
        {
            get { return pBProduct.Image; }
            set { pBProduct.Image = value; }  // Set product image
        }
        public decimal NumericValue
        {
            get
            {
                return NumericUpDown1.Value;  // Return the current value of NumericUpDown
            }
            set
            {
                NumericUpDown1.Value = value;  // Set the value of NumericUpDown
            }
        }
        private void pBDelete_Click(object sender, EventArgs e)
        {
            // Remove the CartItem from the parent container (flowLayoutCart)
            _mainForm.cartInterface.RemoveCartItem(this); // Ensure that the total money gets updated
        }
        // Updagte khi thay đổi số lượng 
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _mainForm.cartInterface.UpdateCartTotals();
        }
    }
}
