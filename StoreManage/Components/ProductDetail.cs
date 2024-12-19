using StoreManage.DTOs.Inventory;
using StoreManage.DTOs.PColor;
using StoreManage.DTOs.Product;
using StoreManage.DTOs.Size;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Components
{
    public partial class ProductDetail : UserControl
    {
        private int _productId;
        private PictureBox _pictureBox;
        public ProductDetail(int productId)
        {
            InitializeComponent();
            _productId = productId;

            LoadProductDetails();
            LoadColorsForProduct();
        }

        private async void LoadProductDetails()
        {
            try
            {
                string apiUrl = $"http://localhost:5254/api/products/{_productId}";

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();

                    var product = JsonSerializer.Deserialize<ProductDto>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (product != null)
                    {
                        txtName.Text = product.Name;
                        txtPrice.Text = $"{product.Price:C}";
                        if (_pictureBox == null)
                        {
                            _pictureBox = new PictureBox
                            {
                                Width = 100,
                                Height = 140,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Location = new Point(400, 100)
                            };
                            this.Controls.Add(_pictureBox); 
                        }

                        var firstColor = product.Colors.FirstOrDefault();
                        var firstImageUrl = firstColor?.Images.FirstOrDefault()?.Url ?? "default-image.png";

                        _pictureBox.ImageLocation = firstImageUrl;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết sản phẩm: {ex.Message}");
            }
        }

        private async void LoadColorsForProduct()
        {
            try
            {
                string apiUrl = $"http://localhost:5254/api/inventories/All?ProductId={_productId}";

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();

                    var inventories = JsonSerializer.Deserialize<List<InventoryAllDto>>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    var colorIds = inventories
                        .Select(i => i.ColorId)
                        .Distinct()
                        .ToList();

                    var colors = await LoadColorDetails(colorIds);

                    cbColor.DataSource = colors;
                    cbColor.DisplayMember = "Name"; 
                    cbColor.ValueMember = "ColorId";

                    if (colors.Any())
                    {
                        cbColor.SelectedIndex = 0; 
                        var firstColorId = colors.First().ColorId;
                        LoadSizesForColor(firstColorId); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách màu sắc: {ex.Message}");
            }
        }

        private async Task<List<ColorDto>> LoadColorDetails(List<int> colorIds)
        {
            var colors = new List<ColorDto>();

            foreach (var colorId in colorIds)
            {
                string apiUrl = $"http://localhost:5254/api/colors/{colorId}"; 

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var color = JsonSerializer.Deserialize<ColorDto>(json, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });
                        if (color != null)
                        {
                            colors.Add(color);
                        }
                    }
                }
            }

            return colors;
        }
        private async void LoadSizesForColor(int colorId)
        {
            try
            {
                string inventoryApiUrl = $"http://localhost:5254/api/inventories/All?ProductId={_productId}&ColorId={colorId}";

                using (var client = new HttpClient())
                {
                    var inventoryResponse = await client.GetAsync(inventoryApiUrl);
                    inventoryResponse.EnsureSuccessStatusCode();

                    var inventoryJson = await inventoryResponse.Content.ReadAsStringAsync();

                    var inventories = JsonSerializer.Deserialize<List<InventoryAllDto>>(inventoryJson, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    var sizeIds = inventories
                        .Select(i => i.SizeId)
                        .Distinct()
                        .ToList();

                    var sizeDtos = new List<SizeDto>();

                    foreach (var sizeId in sizeIds)
                    {
                        string sizeApiUrl = $"http://localhost:5254/api/sizes/{sizeId}";
                        var sizeResponse = await client.GetAsync(sizeApiUrl);
                        sizeResponse.EnsureSuccessStatusCode();

                        var sizeJson = await sizeResponse.Content.ReadAsStringAsync();

                        var size = JsonSerializer.Deserialize<SizeDto>(sizeJson, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                        if (size != null)
                        {
                            sizeDtos.Add(size); 
                        }
                    }

                    cbSize.DataSource = sizeDtos;
                    cbSize.DisplayMember = "SizeValue"; 
                    cbSize.ValueMember = "SizeId";

                    if (cbSize.Items.Count > 0)
                    {
                        var firstSizeId = sizeDtos.First().SizeId;

                        string quantityApiUrl = $"http://localhost:5254/api/inventories/All?ProductId={_productId}&SizeId={firstSizeId}&ColorId={colorId}";

                        var quantityResponse = await client.GetAsync(quantityApiUrl);
                        quantityResponse.EnsureSuccessStatusCode();

                        var quantityJson = await quantityResponse.Content.ReadAsStringAsync();

                        var inventoryForSize = JsonSerializer.Deserialize<List<InventoryAllDto>>(quantityJson, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                        if (inventoryForSize.Any())
                        {
                            txtQuantity.Text = inventoryForSize.First().Quantity.ToString();
                        }
                        else
                        {
                            txtQuantity.Text = "0";
                        }
                    }
                    else
                    {
                        txtQuantity.Text = "0"; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách size: {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private async void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbColor.SelectedValue is int selectedColorId)
            {
                try
                {
                    string apiUrl = $"http://localhost:5254/api/products/{_productId}";
                    using (var client = new HttpClient())
                    {
                        var response = await client.GetAsync(apiUrl);
                        response.EnsureSuccessStatusCode();

                        var json = await response.Content.ReadAsStringAsync();
                        var product = JsonSerializer.Deserialize<ProductDto>(json, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                        if (product != null)
                        {
                            var selectedColor = product.Colors.FirstOrDefault(c => c.ColorId == selectedColorId);
                            if (selectedColor != null)
                            {
                                var imageUrl = selectedColor.Images.FirstOrDefault()?.Url ?? "default-image.png";
                                MessageBox.Show(imageUrl);
                                _pictureBox.ImageLocation = imageUrl;

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải thông tin sản phẩm: {ex.Message}");
                }

                LoadSizesForColor(selectedColorId);
            }
        }

    }

}
