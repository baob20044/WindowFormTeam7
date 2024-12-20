using StoreManage.Components;
using StoreManage.Components.Add;
using StoreManage.DTOs.Product;
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

namespace StoreManage.AdminForms.Pages
{
    public partial class AdminProductPage : UserControl
    {
        private DataGridView dgvProducts;
        public AdminProductPage()
        {
            InitializeComponent();
            LoadProducts();
        }

        private async void LoadProducts()
        {
            string apiUrl = "http://localhost:5254/api/products";

            var products = await GetAllProductsAsync(apiUrl);

            if (products.Any())
            {
                flowLayoutPanel.Controls.Clear();

                var headerPanel = new Guna.UI2.WinForms.Guna2Panel
                {
                    Size = new Size(flowLayoutPanel.Width - 40, 40),
                    BorderRadius = 5,
                    ShadowDecoration = { Enabled = true },
                    BackColor = Color.FromArgb(0, 122, 204),
                    Margin = new Padding(5)
                };

                var idHeader = new Label
                {
                    Text = "ID",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.White,
                    AutoSize = false,
                    Size = new Size(50, 40),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(1, 0)
                };
                headerPanel.Controls.Add(idHeader);

                var imageHeader = new Label
                {
                    Text = "Image",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.White,
                    AutoSize = false,
                    Size = new Size(100, 40),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(40, 0)
                };
                headerPanel.Controls.Add(imageHeader);

                var nameHeader = new Label
                {
                    Text = "Name",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.White,
                    AutoSize = false,
                    Size = new Size(100, 40),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Location = new Point(188, 0)
                };
                headerPanel.Controls.Add(nameHeader);

                var priceHeader = new Label
                {
                    Text = "Price",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.White,
                    AutoSize = false,
                    Size = new Size(100, 40),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(260, 0)
                };
                headerPanel.Controls.Add(priceHeader);

                var stockHeader = new Label
                {
                    Text = "Quantity",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.White,
                    AutoSize = false,
                    Size = new Size(100, 40),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(350, 0)
                };
                headerPanel.Controls.Add(stockHeader);

                flowLayoutPanel.Controls.Add(headerPanel);


                for (int i = 0; i < products.Count; i++)
                {
                    var productRow = CreateProductRow(products[i], i);
                    flowLayoutPanel.Controls.Add(productRow);
                }
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào để hiển thị.");
            }
        }

        private Guna.UI2.WinForms.Guna2Panel CreateProductRow(ProductDto product, int index)
        {
            var rowPanel = new Guna.UI2.WinForms.Guna2Panel
            {
                Size = new Size(flowLayoutPanel.Width - 40, 160),
                BorderRadius = 5,
                ShadowDecoration = { Enabled = true },
                BackColor = (index % 2 == 0) ? Color.LightGray : Color.White,
                Margin = new Padding(5)
            };

            var idLabel = new Label
            {
                Text = product.ProductId.ToString(),
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(50, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left
            };

            var pictureBox = new PictureBox
            {
                Width = 100,
                Height = 140,
                ImageLocation = product.Colors.FirstOrDefault()?.Images.FirstOrDefault()?.Url ?? "default-image.png",
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(45, 10)
            };

            var nameLabel = new Label
            {
                Text = product.Name,
                Font = new Font("Arial", 10, FontStyle.Regular),
                AutoSize = false,
                Size = new Size(150, 50),
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(160, 10)
            };

            var priceLabel = new Label
            {
                Text = $"{product.Price:C}",
                Font = new Font("Arial", 10, FontStyle.Regular),
                AutoSize = false,
                Size = new Size(100, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(280, 10)
            };

            var stockLabel = new Label
            {
                Text = product.InStock > 0 ? $"{product.InStock}" : "Hết hàng",
                Font = new Font("Arial", 10, FontStyle.Italic),
                ForeColor = product.InStock > 0 ? Color.Green : Color.Red,
                AutoSize = false,
                Size = new Size(100, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(350, 10)
            };

            var btnDetails = new Guna.UI2.WinForms.Guna2Button
            {
                Text = "Chi tiết",
                Size = new Size(80, 30),
                Dock = DockStyle.Right
            };
            btnDetails.Click += (s, e) =>
            {
                var productDetailForm = new ProductDetail(product.ProductId);

                this.Controls.Add(productDetailForm);

                productDetailForm.Dock = DockStyle.None;
                productDetailForm.Location = new Point(
                    (this.Width - productDetailForm.Width) / 2,
                    (this.Height - productDetailForm.Height) / 2
                );

                productDetailForm.BringToFront();
            };


            rowPanel.Controls.Add(btnDetails);
            rowPanel.Controls.Add(stockLabel);
            rowPanel.Controls.Add(priceLabel);
            rowPanel.Controls.Add(nameLabel);
            rowPanel.Controls.Add(pictureBox);
            rowPanel.Controls.Add(idLabel);

            return rowPanel;
        }

        public async Task<List<ProductDto>> GetAllProductsAsync(string apiUrl)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<List<ProductDto>>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }) ?? new List<ProductDto>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi gọi API: {ex.Message}");
                    return new List<ProductDto>();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if the CategoryAdd UserControl already exists
            var existingCategoryAdd = this.Controls.OfType<ProductAdd>().FirstOrDefault();

            if (existingCategoryAdd == null)
            {
                // Create an instance of the CategoryAdd UserControl
                var addCategory = new ProductAdd();

                // Add the CategoryAdd UserControl to the same container
                this.Controls.Add(addCategory);
                addCategory.Dock = DockStyle.None;

                // Position the CategoryAdd UserControl in the center
                addCategory.Location = new Point(
                    (this.Width - addCategory.Width) / 2,
                    (this.Height - addCategory.Height) / 2
                );
                addCategory.BringToFront();
            }
            else
            {
                // If it already exists, just bring it to the front
                existingCategoryAdd.BringToFront();
            }
        }
    }
}
