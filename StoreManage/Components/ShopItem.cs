using Newtonsoft.Json;
using RestSharp;
using StoreManage.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Components
{
    public partial class ShopItem : UserControl
    {
        public Product LoadedProduct { get; private set; } // Expose the product
        public int ProductId { get; } // Property to hold product ID
        public ShopItem(int productId)
        {
            InitializeComponent();
            ProductId = productId;
            LoadProductData(productId);
        }

        private void ShowFallbackImage()
        {
            pBImage.Image = global::StoreManage.Properties.Resources.cart; // Default fallback image
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
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pBImage.Image = new Bitmap(ms); // Set the image directly to the PictureBox
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
                    LoadedProduct = JsonConvert.DeserializeObject<Product>(response.Content);

                    if (LoadedProduct != null)
                    {
                        // Set product details
                        ItemLabel = LoadedProduct.Name;
                        ItemPrice = $"{LoadedProduct.Price:N0} VND";

                        // Load the product image based on the first available color
                        var imageUrl = LoadedProduct.Colors?.FirstOrDefault()?.Images?.FirstOrDefault()?.Url;
                        if (!string.IsNullOrEmpty(imageUrl))
                        {
                            await LoadProductImage(imageUrl);
                        }
                        else
                        {
                            ShowFallbackImage();
                        }
                    }
                    else
                    {
                        ShowFallbackImage();
                    }
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

        public string ItemLabel
        {
            get => lbName.Text;
            set => lbName.Text = value;
        }

        public string ItemPrice
        {
            get => lbPrice.Text;
            set => lbPrice.Text = value;
        }
    }
}
