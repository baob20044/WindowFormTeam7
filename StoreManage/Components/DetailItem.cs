using Newtonsoft.Json;
using RestSharp;
using StoreManage.DTOs.PColor;
using StoreManage.DTOs.Product;
using StoreManage.DTOs.Size;
using StoreManage.Forms.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Components
{
    public partial class DetailItem : UserControl
    {
        private Dictionary<string, ColorDto> colorMap; // Map color names to Color objects
        private int productId;  // Store productId for CartItem
        private MainForm _mainForm;
        public DetailItem(int productId,MainForm mainForm )
        {
            InitializeComponent();
            this.productId = productId;

            _mainForm = mainForm;
        }
        private void DetailItem_Load(object sender, EventArgs e)
        {
            LoadProductDetails(productId);
            DropdownColor.SelectedIndexChanged += DropdownColor_SelectedIndexChanged; // Attach event handler
        }
        public class ProductService
        {
            private readonly RestClient _client;

            public ProductService(string baseUrl)
            {
                _client = new RestClient(baseUrl);
            }

            public async Task<ProductDto> GetProductByIdAsync(int productId)
            {
                var request = new RestRequest($"/api/products/{productId}", Method.Get);
                request.AddHeader("accept", "*/*");
                var response = await _client.ExecuteAsync(request);
                return response.IsSuccessful
                    ? JsonConvert.DeserializeObject<ProductDto>(response.Content)
                    : null;
            }
        }
        private async void LoadProductDetails(int productId)
        {
            try
            {
                var productService = new ProductService("http://localhost:5254");
                var product = await productService.GetProductByIdAsync(productId);

                if (product != null)
                {
                    UpdateUIWithProduct(product);
                    await LoadProductImage(product.Colors?.FirstOrDefault());
                }
                else
                {
                    ShowFallbackImage();
                }
            }
            catch
            {
                ShowFallbackImage();
            }
        }
        private void UpdateUIWithProduct(ProductDto product)
        {
            lbName.Text = product.Name;
            lbPrice.Text = $"{product.Price:N0} VND";
            lbDescription.Text = product.Description ?? "No description available";
            lbCost.Text = $"Cost: {product.Price + product.Price * 10 / 100:N0} VND";
            lbInStock.Text = $"Còn {product.InStock} sản phẩm trong kho";

            // Populate colors
            colorMap = new Dictionary<string, ColorDto>();
            DropdownColor.Items.Clear();
            foreach (var color in (product.Colors ?? new HashSet<ColorDto>()).ToList())
            {
                DropdownColor.Items.Add(color.Name);
                colorMap[color.Name] = color;
            }
            if (DropdownColor.Items.Count > 0)
            {
                DropdownColor.SelectedIndex = 0;
            }

            // Populate sizes
            DropdownSize.Items.Clear();
            foreach (var size in (product.Sizes ?? new HashSet<SizeDto>()).ToList())
            {
                DropdownSize.Items.Add(size.SizeValue); // Add size values like "S", "M", etc.
            }
            if (DropdownSize.Items.Count > 0)
            {
                DropdownSize.SelectedIndex = 0; // Default to the first size
            }
        }

        // Load ảnh sản phẩm theo màu chọn
        private async Task LoadProductImage(ColorDto color)
        {
            var imageUrl = color?.Images?.FirstOrDefault()?.Url;

            if (!string.IsNullOrEmpty(imageUrl))
            {
                try
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        var imageBytes = await httpClient.GetByteArrayAsync(imageUrl);

                        if (imageBytes.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pBProduct.Image = new Bitmap(ms); // Create the Bitmap from the MemoryStream
                            }
                        }
                        else
                        {
                            ShowFallbackImage();
                        }
                    }
                }
                catch
                {
                    ShowFallbackImage();
                }
            }
            else
            {
                ShowFallbackImage();
            }
        }

        private void ShowFallbackImage()
        {
            pBProduct.Image = global::StoreManage.Properties.Resources.cart; // Placeholder fallback image
        }

        // Khi thay đổi dropdowncolor thì đổi cả label và đổi ảnh 
        private async void DropdownColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropdownColor.SelectedIndex >= 0)
            {
                string selectedColorName = DropdownColor.SelectedItem.ToString();

                if (colorMap.TryGetValue(selectedColorName, out var selectedColor))
                {
                    // Update color label
                    lbColor.Text = $"Color: {selectedColor.Name}";

                    // Load the first image of the selected color
                    await LoadProductImage(selectedColor);
                }
            }
        }
        public void HandleCartItemClick(int productId)
        {
            DetailItem detail = new DetailItem(productId,_mainForm);
            _mainForm.handleClickedShopItem(detail);
        }
        private void AddToCart()
        {
            // Ensure MainForm is available
            if (_mainForm == null || _mainForm.cartInterface == null)
            {
                MessageBox.Show("Cart interface not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedColorName = DropdownColor.SelectedItem?.ToString();
            string selectedSize = DropdownSize.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedColorName) || string.IsNullOrEmpty(selectedSize))
            {
                MessageBox.Show("Please select a color and size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cartPage = _mainForm.cartInterface;
            bool productExistsInCart = false;

            foreach (Control control in cartPage.CartFlowLayout.Controls)
            {
                if (control is CartItem existingItem &&
                    existingItem.ProductId == productId &&
                    existingItem.SelectedColorName == selectedColorName &&
                    existingItem.SelectedSize == selectedSize)
                {
                    existingItem.NumericValue += NumericUpDown1.Value;
                    productExistsInCart = true;
                    break;
                }
            }

            if (!productExistsInCart)
            {
                var newCartItem = new CartItem(productId, selectedColorName, selectedSize, _mainForm)
                {
                    ItemLabel = lbName.Text,
                    ItemPrice = lbPrice.Text,
                    ProductImage = pBProduct.Image,
                    NumericValue = NumericUpDown1.Value
                };
                newCartItem.OnCartItemClick += HandleCartItemClick; // Subscribe to the click event
                cartPage.CartFlowLayout.Controls.Add(newCartItem);
            }

            cartPage.UpdateCartTotals();
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            AddToCart();
            _mainForm.ChangeToCart();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart();
            MessageBox.Show("Product added to cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
