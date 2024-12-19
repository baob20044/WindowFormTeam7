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
using StoreManage.DTOs.Product;

namespace StoreManage.Components
{
    public partial class ShopItem : UserControl
    {
        public ProductDto LoadedProduct { get; private set; } // Expose the product
        public ProductInfoDto ProductInfo { get; private set; }
        public int ProductId { get; } // Property to hold product ID
        public event Action<int> OnShopItemClick; // Event to notify when the item is clicked
        public ShopItem(ProductDto product)
        {
            InitializeComponent();
            ProductId = product.ProductId;
            LoadedProduct = product;
            LoadProductData(product);

            this.Click += (s, e) => OnShopItemClick?.Invoke(ProductId);
            foreach (Control control in this.Controls)
            {
                control.Click += (s, e) => OnShopItemClick?.Invoke(ProductId);
            }
        }
        
        

        private void ShopItem_Load(object sender, EventArgs e)
        {

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

        private async void LoadProductData(ProductDto product)
        {
                    if (product != null)
                    {
                        // Set product details
                        ItemLabel = product.Name;
                        ItemPrice = $"{product.Price:N0} VND";

                        // Load the product image based on the first available color
                        var imageUrl = product.Colors.FirstOrDefault()?.Images.FirstOrDefault().Url;
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
