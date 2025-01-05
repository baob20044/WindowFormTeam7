using StoreManage.Controllers;
using StoreManage.DTOs.Inventory;
using StoreManage.DTOs.PColor;
using StoreManage.DTOs.PImage;
using StoreManage.DTOs.Size;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace StoreManage.Components.Add
{
    public partial class ColorAddProduct : UserControl
    {
        private readonly InventoryController _inventoryController;
        private readonly int _productId;
        public ColorAddProduct(int productId)
        {
            InitializeComponent();
            _inventoryController = new InventoryController(new ApiService());
            _productId = productId;
            LoadColors();
        }

        private Dictionary<int, Tuple<List<string>, List<(SizeDto size, int quantity)>>> colorData = new Dictionary<int, Tuple<List<string>, List<(SizeDto size, int quantity)>>>();

        private void SaveDataForColor(ColorDto color, List<string> imageUrls, List<(SizeDto size, int quantity)> data)
        {
            if (color == null)
            {
                MessageBox.Show("Color cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (colorData.ContainsKey(color.ColorId))
            {
                colorData[color.ColorId] = new Tuple<List<string>, List<(SizeDto size, int quantity)>>(imageUrls, data);
            }
            else
            {
                colorData.Add(color.ColorId, new Tuple<List<string>, List<(SizeDto size, int quantity)>>(imageUrls, data));
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
        private void DeleteColor(Panel panel, ColorDto color)
        {
            flowLayoutPanel1.Controls.Remove(panel);

            MessageBox.Show($"Xóa màu: {color.Name}");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var entry in colorData)
                {
                    int colorId = entry.Key; 
                    var sizeAndQuantities = entry.Value.Item2;

                    var imageUrls = entry.Value.Item1; 

                    foreach (var url in imageUrls)
                    {
                        var imageCreateDto = new ImageCreateDto
                        {
                            ProductId = _productId,
                            ColorId = colorId,
                            Url = url,
                            Alt = $"Image for product {_productId}, color {colorId}"
                        };

                        using (var client = new HttpClient())
                        {
                            client.BaseAddress = new Uri("http://localhost:5254");
                            client.DefaultRequestHeaders.Accept.Clear();
                            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                            var jsonContent = JsonSerializer.Serialize(imageCreateDto);
                            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                            var response = await client.PostAsync("/api/images", content);
                        }
                    }

                    foreach (var (size, quantity) in sizeAndQuantities)
                    {
                        int sizeId = size.SizeId;
                        if (sizeId == 0)
                        {
                            MessageBox.Show($"Size '{size}' không hợp lệ hoặc không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }

                        var inventoryCreateDto = new InventoryCreateDto
                        {
                            ProductId = _productId, 
                            ColorId = colorId,
                            SizeId = sizeId,
                            Quantity = quantity
                        };
                        var result = await _inventoryController.CreateAsync(inventoryCreateDto);
                    }
                }
                MessageBox.Show($"Thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var mainpage = this.FindForm() as AdminMainForm;
                mainpage.refreshProduct();
                this.Parent.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu Inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
