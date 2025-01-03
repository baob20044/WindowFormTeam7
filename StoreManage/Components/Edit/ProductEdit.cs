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
using System.Text.Json;
using Guna.UI2.WinForms.Suite;
using StoreManage.Controllers;
using StoreManage.Services;


namespace StoreManage.Components.Edit
{
    public partial class ProductEdit : UserControl
    {
        private readonly int _productId;
        private readonly HttpClient _httpClient;
        private readonly ProductController productController;
        private ProductDto _originalProduct;
        public ProductEdit(int productId)
        {
            InitializeComponent();
            _productId = productId;
            productController = new ProductController(new ApiService());
            this.Load += ProductEdit_Load;
        }
        private async void ProductEdit_Load(object sender, EventArgs e)
        {
            await LoadProductDetails();

            txtName.TextChanged += (s, ev) => btnSave.Enabled = true;
            txtPrice.TextChanged += (s, ev) => btnSave.Enabled = true;
            txtCost.TextChanged += (s, ev) => btnSave.Enabled = true;
            nudDiscount.ValueChanged += (s, ev) => btnSave.Enabled = true;
            txtDescript.TextChanged += (s, ev) => btnSave.Enabled = true;
        }

        //private async Task LoadProductDetails()
        //{
        //    try
        //    {
        //        string apiUrl = $"http://localhost:5254/api/products/{_productId}";

        //        using (var client = new HttpClient())
        //        {
        //            var response = await client.GetAsync(apiUrl);
        //            response.EnsureSuccessStatusCode();

        //            var json = await response.Content.ReadAsStringAsync();

        //            var product = JsonSerializer.Deserialize<ProductDto>(json, new JsonSerializerOptions
        //            {
        //                PropertyNameCaseInsensitive = true
        //            });

        //            if (product != null)
        //            {
        //                txtName.Text = product.Name;
        //                txtPrice.Text = $"{product.Price:C}";
        //                txtPrice.Text = product.Price.ToString();
        //                txtCost.Text = product.Cost.ToString();
        //                nudDiscount.Value = product.DiscountPercentage;
        //                txtDescript.Text = product.Description;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi tải sản phẩm: {ex.Message}");
        //    }
        //}

        private async Task LoadProductDetails()
        {
            try
            {
                string apiUrl = $"http://localhost:5254/api/products/{_productId}";

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();

                    _originalProduct = JsonSerializer.Deserialize<ProductDto>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (_originalProduct != null)
                    {
                        // Gán giá trị ban đầu vào các TextBox và NumericUpDown
                        txtName.Text = _originalProduct.Name;
                        txtPrice.Text = _originalProduct.Price.ToString();
                        txtCost.Text = _originalProduct.Cost.ToString();
                        nudDiscount.Value = _originalProduct.DiscountPercentage;
                        txtDescript.Text = _originalProduct.Description;

                        // Vô hiệu hóa nút Save nếu không có thay đổi
                        btnSave.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải sản phẩm: {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!HasChanges())
            {
                MessageBox.Show("Không có thay đổi nào để lưu!");
                return;
            }

            var updatedProduct = new ProductUpdateDto
            {
                Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Cost = decimal.Parse(txtCost.Text),
                DiscountPercentage = decimal.Parse(nudDiscount.Text),
                Description = txtDescript.Text
            };

            try
            {
                await productController.UpdateAsync(_productId, updatedProduct);
                MessageBox.Show("Cập nhật sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật sản phẩm: {ex.Message}");
            }
        }
        private bool HasChanges()
        {
            return txtName.Text != _originalProduct.Name ||
                   txtPrice.Text != _originalProduct.Price.ToString("C") ||
                   txtCost.Text != _originalProduct.Cost.ToString() ||
                   nudDiscount.Value != _originalProduct.DiscountPercentage ||
                   txtDescript.Text != _originalProduct.Description;
        }
    }
}
