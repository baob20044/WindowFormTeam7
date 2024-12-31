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

namespace StoreManage.Components.Add
{
    public partial class ProductAdd : UserControl
    {
        private readonly ProviderController _providerController;
        List<ProviderDto> providers;
        public ProductAdd()
        {
            InitializeComponent();
            _providerController = new ProviderController(new ApiService());
            LoadTargetCustomers();
            LoadProviders();
            LoadColors();
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

        private async void LoadColors()
        {
            try
            {
                string apiUrl = "http://localhost:5254/api/colors";

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();

                    var colors = JsonSerializer.Deserialize<List<ColorDto>>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (colors != null && colors.Count > 0)
                    {
                        cbColor.DataSource = colors;
                        cbColor.DisplayMember = "Name";
                        cbColor.ValueMember = "ColorId";
                    }
                    else
                    {
                        MessageBox.Show("Không có màu sắc nào được tải.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách màu sắc: {ex.Message}");
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

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbColor.SelectedItem is ColorDto selectedColor)
            {
                AddColorToFlowLayout(selectedColor);
            }
        }

        private void AddColorToFlowLayout(ColorDto color)
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Panel existingPanel && existingPanel.Tag != null && existingPanel.Tag.Equals(color.ColorId))
                {
                    return;
                }
            }

            var panel = new Panel
            {
                Tag = color.ColorId,
                Width = flowLayoutPanel1.Width - 10,
                Height = 40
            };

            var tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 1,
                AutoSize = true
            };

            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

            var label = new Label
            {
                Text = color.Name,
                AutoSize = true,
                Margin = new Padding(10, 10, 10, 10)
            };

            var editButton = new Button
            {
                Text = "Edit",
                AutoSize = true,
                Margin = new Padding(10, 5, 10, 5),
                Tag = color.ColorId
            };
            editButton.Click += (sender, e) => EditColor(color);

            var deleteButton = new Button
            {
                Text = "Remove",
                AutoSize = true,
                Margin = new Padding(10, 5, 10, 5),
                Tag = color.ColorId
            };
            deleteButton.Click += (sender, e) => DeleteColor(panel, color);

            tableLayoutPanel.Controls.Add(label, 0, 0);
            tableLayoutPanel.Controls.Add(editButton, 1, 0);
            tableLayoutPanel.Controls.Add(deleteButton, 2, 0);

            panel.Controls.Add(tableLayoutPanel);

            flowLayoutPanel1.Controls.Add(panel);
        }

        private void EditColor(ColorDto color)
        {
            var existingCategoryAdd = this.Controls.OfType<SizeAndQuantityAndImgAdd>().FirstOrDefault();
            var addColor = new SizeAndQuantityAndImgAdd();

            addColor.SetColor(color);

            addColor.OnSave += (selectedColor, imageUrls, sizesAndQuantities) =>
            {
                SaveDataForColor(selectedColor, imageUrls, sizesAndQuantities);
                MessageBox.Show($"Dữ liệu đã được lưu cho màu: {selectedColor.Name}");
            };

            if (existingCategoryAdd == null)
            {
                var addCategory = new SizeAndQuantityAndImgAdd();

                this.Controls.Add(addCategory);
                addCategory.Dock = DockStyle.None;

                addCategory.Location = new Point(
                    (this.Width - addCategory.Width) / 2,
                    (this.Height - addCategory.Height) / 2
                );
                addCategory.BringToFront();
                if (colorData.ContainsKey(color.ColorId))
                {
                    //addCategory.LoadData(colorData[color]);
                    var data = colorData[color.ColorId];
                    addCategory.LoadData(data.Item2, data.Item1);
                }
                addCategory.OnSave += (selectedColor, imageUrls, data) =>
                {
                    SaveDataForColor(color, imageUrls, data);
                    MessageBox.Show($"Dữ liệu đã được lưu cho màu: {color.Name} + {imageUrls}");
                };
            }
            else
            {
                existingCategoryAdd.BringToFront();
                if (colorData.ContainsKey(color.ColorId))
                {
                    var data = colorData[color.ColorId];
                    existingCategoryAdd.LoadData(data.Item2, data.Item1);
                }
            }
        }

        private Dictionary<int, Tuple<List<string>, List<(string size, int quantity)>>> colorData = new Dictionary<int, Tuple<List<string>, List<(string size, int quantity)>>>();

        private void SaveDataForColor(ColorDto color, List<string> imageUrls, List<(string size, int quantity)> data)
        {
            if (color == null)
            {
                MessageBox.Show("Color cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (colorData.ContainsKey(color.ColorId))
            {
                colorData[color.ColorId] = new Tuple<List<string>, List<(string size, int quantity)>>(imageUrls, data);
            }
            else
            {
                colorData.Add(color.ColorId, new Tuple<List<string>, List<(string size, int quantity)>>(imageUrls, data));
            }
        }

        private void DeleteColor(Panel panel, ColorDto color)
        {
            flowLayoutPanel1.Controls.Remove(panel);

            MessageBox.Show($"Xóa màu: {color.Name}");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng ProductCreateDto từ dữ liệu form
                var productDto = new ProductCreateDto
                {
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Description = txtDescription.Text,
                    Cost = decimal.Parse(txtCost.Text),
                    DiscountPercentage = decimal.Parse(nudDiscount.Text),
                    Unit = "Cái",
                    SubcategoryId = (int)cbSubCategory.SelectedValue,
                    TargetCustomerId = (int)cBTargetCustomer.SelectedValue,
                    ProviderId = (int)cbProdivder.SelectedValue,
                    Inventory = GetProductInventoryData(),
                    //NewCategory = txtNewCategory.Text,
                    //NewSubcategory = txtNewSubcategory.Text
                };

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5254/");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Gửi yêu cầu POST tạo sản phẩm
                    var response = await client.PostAsJsonAsync("api/products", productDto);
                    response.EnsureSuccessStatusCode();

                    // Lấy ProductId từ phản hồi
                    var createdProduct = await response.Content.ReadFromJsonAsync<ProductCreateDto>();
                    int productId = createdProduct.Id;

                    // Gửi yêu cầu POST để thêm ảnh
                    await AddImagesForProduct(productId);

                    MessageBox.Show("Sản phẩm và hình ảnh đã được thêm thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu sản phẩm: {ex.Message}");
            }
        }

        private async Task AddImagesForProduct(int productId)
        {
            try
            {
                foreach (var panel in flowLayoutPanel1.Controls.OfType<Panel>())
                {
                    if (panel.Tag is int colorId)
                    {
                        var imageDtos = await GetImagesForColorAsync(colorId);
                        foreach (var imageDto in imageDtos)
                        {
                            imageDto.ProductId = productId;

                            using (var client = new HttpClient())
                            {
                                client.BaseAddress = new Uri("http://localhost:5254/");
                                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                                var response = await client.PostAsJsonAsync("api/images", imageDto);
                                response.EnsureSuccessStatusCode();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm hình ảnh: {ex.Message}");
            }
        }

        private async Task<List<ImageCreateDto>> GetImagesForColorAsync(int colorId)
        {
            var imageDtos = new List<ImageCreateDto>();

            try
            {
                int latestProductId = await GetLatestProductIdAsync();

                foreach (var imageUrl in GetImageUrlsForColor(colorId))
                {
                    imageDtos.Add(new ImageCreateDto
                    {
                        ProductId = latestProductId,
                        ColorId = colorId,
                        Url = imageUrl,
                        Alt = "Ảnh sản phẩm",
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy ProductId lớn nhất: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return imageDtos;
        }

        private async Task<int> GetLatestProductIdAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5254/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/products");
                response.EnsureSuccessStatusCode();

                var products = await response.Content.ReadFromJsonAsync<List<ProductDto>>();
                if (products == null || products.Count == 0)
                {
                    throw new Exception("Không có sản phẩm nào trong danh sách.");
                }

                return products.Max(p => p.ProductId);
            }
        }

        private IEnumerable<string> GetImageUrlsForColor(int colorId)
        {
            if (colorData.ContainsKey(colorId))
            {
                return colorData[colorId].Item1; 
            }
            else
            {
                MessageBox.Show($"Không tìm thấy dữ liệu ảnh cho ColorId = {colorId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return Enumerable.Empty<string>();
            }
        }


        private ICollection<ProductInventoryCreateDto> GetProductInventoryData()
        {
            var inventoryList = new List<ProductInventoryCreateDto>();

            foreach (var panel in flowLayoutPanel1.Controls.OfType<Panel>())
            {
                if (panel.Tag is int colorId)
                {
                    var sizes = new List<SizeOfColorDto>();

                    foreach (var sizeControl in panel.Controls.OfType<Control>())
                    {
                        if (sizeControl.Tag is Tuple<int, int> sizeData) 
                        {
                            sizes.Add(new SizeOfColorDto
                            {
                                SizeId = sizeData.Item1, 
                                Quantity = sizeData.Item2 
                            });
                        }
                    }

                    inventoryList.Add(new ProductInventoryCreateDto
                    {
                        ColorId = colorId,
                        Sizes = sizes
                    });
                }
            }

            return inventoryList;
        }


    }
}
