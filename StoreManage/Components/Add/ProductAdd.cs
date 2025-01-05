using StoreManage.DTOs.TargetCustomer;
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
using Guna.UI2.WinForms;
using StoreManage.DTOs.Category;
using StoreManage.DTOs.Providerr;
using System.Net.Http.Headers;
using StoreManage.Services;
using StoreManage.Controllers;
using StoreManage.DTOs.PColor;
using StoreManage.DTOs.Product;
using StoreManage.DTOs.Inventory;
using StoreManage.DTOs.PSize;
using StoreManage.DTOs.PImage;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using StoreManage.DTOs.Size;
using StoreManage.DTOs.Subcategory;

namespace StoreManage.Components.Add
{
    public partial class ProductAdd : UserControl
    {
        private readonly ProviderController _providerController;
        private readonly ProductController _productController;
        private readonly CategoryController _categoryController;
        private readonly SubcategoryController _subcategoryController;

        List<ProviderDto> providers;
        public ProductAdd()
        {
            InitializeComponent();
            _providerController = new ProviderController(new ApiService());
            _productController = new ProductController(new ApiService());
            _categoryController = new CategoryController(new ApiService());
            _subcategoryController = new SubcategoryController(new ApiService());
            LoadTargetCustomers();
            LoadProviders();
        }

        private async void LoadProviders()
        {
            try
            {
                providers = await _providerController.GetAllAsync();
                if (providers != null && providers.Count > 0)
                {
                    cbProdivder.DataSource = providers;
                    cbProdivder.DisplayMember = "ProviderCompanyName";
                    cbProdivder.ValueMember = "ProviderId";
                }
                else
                {
                    MessageBox.Show("Không có nhà cung cấp nào được tải.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách provider: {ex.Message}");
            }
        }

        private async void LoadTargetCustomers()
        {
            try
            {
                string apiUrl = "http://localhost:5254/api/targetCustomers";

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();

                    var targetCustomers = JsonSerializer.Deserialize<List<TargetCustomerDto>>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });


                    cBTargetCustomer.DataSource = targetCustomers;
                    cBTargetCustomer.DisplayMember = "TargetCustomerName";
                    cBTargetCustomer.ValueMember = "TargetCustomerId";

                    if (targetCustomers != null && targetCustomers.Count > 0)
                    {
                        int firstTargetCustomerId = targetCustomers[0].TargetCustomerId;
                        await LoadCategories(firstTargetCustomerId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách targetCustomers: {ex.Message}");
            }
        }

        private async Task LoadCategories(int targetCustomerId)
        {
            try
            {
                string apiUrl = $"http://localhost:5254/api/targetCustomers/{targetCustomerId}";

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();

                    var targetCustomer = JsonSerializer.Deserialize<TargetCustomerDto>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (targetCustomer != null && targetCustomer.Categories != null)
                    {
                        cbCategory.DataSource = targetCustomer.Categories.ToList();
                        cbCategory.DisplayMember = "Name";
                        cbCategory.ValueMember = "CategoryId";

                        if (targetCustomer.Categories.Count > 0)
                        {
                            int firstCategoryId = targetCustomer.Categories.First().CategoryId;
                            await LoadSubCategories(firstCategoryId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách danh mục: {ex.Message}");
            }
        }

        private async Task LoadSubCategories(int categoryId)
        {
            try
            {
                string apiUrl = $"http://localhost:5254/api/categories/{categoryId}";

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();

                    var category = JsonSerializer.Deserialize<CategoryDto>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (category != null && category.Subcategories != null)
                    {
                        cbSubCategory.DataSource = category.Subcategories.ToList();
                        cbSubCategory.DisplayMember = "SubcategoryName";
                        cbSubCategory.ValueMember = "SubcategoryId";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách danh mục con: {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private async void cBTargetCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBTargetCustomer.SelectedValue is int selectedTargetCustomerId)
            {
                await LoadCategories(selectedTargetCustomerId);
            }
        }

        private async void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedValue is int selectedCategoryId)
            {
                await LoadSubCategories(selectedCategoryId);
            }
        }

        private async Task<int> GetSizeIdFromNameAsync(string sizeName)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5254/api/sizes");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.GetAsync("");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var sizes = JsonSerializer.Deserialize<List<SizeDto>>(jsonString);

                        var size = sizes.FirstOrDefault(s => s.SizeValue.ToLower() == sizeName.ToLower());
                        if (size == null)
                        {
                            MessageBox.Show($"Error: Size '{sizeName}' not found in API data.");
                            return 0;
                        }

                        return size.SizeId;
                    }
                    else
                    {
                        MessageBox.Show($"Error: Failed to retrieve sizes from API. Status: {response.StatusCode}");
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while fetching size ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtCost.Text) ||
                    nudDiscount.Value == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                var defaultInventory = new List<ProductInventoryCreateDto>
                {
                    new ProductInventoryCreateDto
                    {
                        ColorId = 0,
                        Sizes = new List<SizeOfColorDto>
                        {
                            new SizeOfColorDto
                            {
                                SizeId = 0,
                                Quantity = 0
                            }
                        }
                    }
                };

                var productDto = new ProductCreateDto
                {
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Description = txtDescription.Text,
                    Cost = decimal.Parse(txtCost.Text),
                    DiscountPercentage = decimal.Parse(nudDiscount.Text),
                    Unit = "string",
                    CategoryId = (int)cbCategory.SelectedValue,
                    SubcategoryId = (int)cbSubCategory.SelectedValue,
                    TargetCustomerId = (int)cBTargetCustomer.SelectedValue,
                    NewCategory = "",
                    NewSubcategory = "",
                    ProviderId = (int)cbProdivder.SelectedValue,
                    Inventory = new List<ProductInventoryCreateDto>()
                };

                await _productController.CreateAsync(productDto);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu sản phẩm: {ex.Message}");
            }
            this.Parent.Controls.Remove(this);
        }

        private async void txtNewCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                string newCategoryName = txtNewCategory.Text.Trim();

                if (string.IsNullOrWhiteSpace(newCategoryName))
                {
                    MessageBox.Show("Vui lòng nhập tên danh mục trước khi nhấn Enter.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cBTargetCustomer.Items.Count == 0 || cBTargetCustomer.SelectedValue == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng mục tiêu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int targetCustomerId = (int)cBTargetCustomer.SelectedValue;

                try
                {
                    var newCategory = new CategoryCreateDto
                    {
                        Name = newCategoryName,
                        TargetCustomerId = targetCustomerId
                    };

                    await _categoryController.CreateAsync(newCategory);

                    MessageBox.Show("Danh mục mới đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNewCategory.Text = string.Empty;

                    await LoadCategories(targetCustomerId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm danh mục mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true;
                e.SuppressKeyPress = true; 
            }
        }

        private async void txtNewSubCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newSubCategoryName = txtNewSubCategory.Text.Trim();

                if (string.IsNullOrWhiteSpace(newSubCategoryName))
                {
                    MessageBox.Show("Vui lòng nhập tên danh mục con trước khi nhấn Enter.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cBTargetCustomer.Items.Count == 0 || cBTargetCustomer.SelectedValue == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng mục tiêu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int categoryId = (int)cbCategory.SelectedValue;

                try
                {
                    var newSubCategory = new SubcategoryCreateDto
                    {
                        SubcategoryName = newSubCategoryName,
                        Description = "stringstri",
                        CategoryId = categoryId
                    };

                    await _subcategoryController.CreateAsync(newSubCategory);

                    MessageBox.Show("Danh mục con mới đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNewSubCategory.Text = string.Empty;

                    await LoadSubCategories(categoryId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm danh mục con mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
