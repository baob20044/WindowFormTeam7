using StoreManage.Components.Add;
using StoreManage.Controllers;
using StoreManage.DTOs.Inventory;
using StoreManage.DTOs.PColor;
using StoreManage.DTOs.Product;
using StoreManage.DTOs.Size;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private readonly ProviderController _providerController;
        private readonly SubcategoryController _subcategoryController;
        public ProductDetail(int productId)
        {
            InitializeComponent();
            _productId = productId;
            _providerController = new ProviderController(new Services.ApiService());
            _subcategoryController = new SubcategoryController(new Services.ApiService());
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
                        var providerName = await _providerController.GetByIdAsync(product.ProviderId);
                        var subCateName = await _subcategoryController.GetByIdAsync(product.SubcategoryId);

                        txtName.Text = product.Name;
                        txtPrice.Text = string.Format(new CultureInfo("vi-VN"), "{0:C0}", product.Price);
                        txtCost.Text = string.Format(new CultureInfo("vi-VN"), "{0:C0}", product.Cost);
                        txtProviderName.Text = providerName.ProviderCompanyName.ToString();
                        txtDescription.Text = product.Description;
                        txtDiscount.Text = $"{product.DiscountPercentage}";
                        txtSubCate.Text = subCateName.SubcategoryName.ToString();
                        txtInStock.Text = product.InStock.ToString();

                        flowLayoutPanel1.Controls.Clear(); 

                        foreach (var color in product.Colors)
                        {
                            foreach (var image in color.Images)
                            {
                                var pictureBox = new PictureBox
                                {
                                    Width = 100,
                                    Height = 140,
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    ImageLocation = image.Url
                                };

                                flowLayoutPanel1.Controls.Add(pictureBox);
                            }
                        }
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
                                //_pictureBox.ImageLocation = imageUrl;

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

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            var addAddAmountForm = new AmountAdd(Convert.ToInt32(cbColor.SelectedValue), Convert.ToInt32(cbSize.SelectedValue), _productId);
            this.Controls.Add(addAddAmountForm);

            addAddAmountForm.Dock = DockStyle.None;
            addAddAmountForm.Location = new Point(
                (this.Width - addAddAmountForm.Width) / 2,
                (this.Height - addAddAmountForm.Height) / 2
            );

            addAddAmountForm.BringToFront();
        }
    }

}
