using Newtonsoft.Json;
using RestSharp;
using StoreManage.DTOs.PColor;
using StoreManage.DTOs.Product;
using StoreManage.DTOs.Size;
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
        private FlowLayoutPanel flowLayoutCart; // Reference to the parent's FlowLayoutPanel
        public DetailItem(int productId, FlowLayoutPanel flowLayoutCart = null)
        {
            InitializeComponent();
            this.productId = productId;
            this.flowLayoutCart = flowLayoutCart;

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
    }
}
