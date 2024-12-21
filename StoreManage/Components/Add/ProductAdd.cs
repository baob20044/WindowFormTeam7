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
                    MessageBox.Show("hieu");
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
                        // Gán dữ liệu vào combobox
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
                Text = "Chỉnh sửa",
                AutoSize = true,
                Margin = new Padding(10, 5, 10, 5),
                Tag = color.ColorId 
            };
            editButton.Click += (sender, e) => EditColor(color);

            var deleteButton = new Button
            {
                Text = "Xóa",
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
            }
            else
            {
                existingCategoryAdd.BringToFront();
            }
        }

        private void DeleteColor(Panel panel, ColorDto color)
        {
            flowLayoutPanel1.Controls.Remove(panel);

            MessageBox.Show($"Xóa màu: {color.Name}");
        }
    }
}
