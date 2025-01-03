using StoreManage.Components;
using StoreManage.Components.Add;
using StoreManage.Components.Edit;
using StoreManage.Controllers;
using StoreManage.DTOs.Product;
using StoreManage.Services;
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

namespace StoreManage.AdminForms.Pages
{
    public partial class AdminProductPage : UserControl
    {
        private DataGridView dgvProducts;
        private int currentPage = 0;
        private int pageSize = 16;
        private bool isLastPage = false;
        private readonly ProductController productController;

        public AdminProductPage()
        {
            InitializeComponent();
            productController = new ProductController(new ApiService());
            LoadProducts();
        }

        private Guna.UI2.WinForms.Guna2Panel CreateHeaderPanel()
        {
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
                Location = new Point(174, 0) 
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
                Location = new Point(255, 0) 
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

            return headerPanel;
        }


        private async void LoadProducts()
        {
            string apiUrl = $"http://localhost:5254/api/products?Offset={currentPage * pageSize}&PageSize={pageSize}";

            var products = await GetAllProductsAsync(apiUrl);

            if (products.Any())
            {
                flowLayoutPanel.Controls.Clear();

                var headerPanel = CreateHeaderPanel();
                flowLayoutPanel.Controls.Add(headerPanel);

                for (int i = 0; i < products.Count; i++)
                {
                    var productRow = CreateProductRow(products[i], i);
                    flowLayoutPanel.Controls.Add(productRow);
                }

                bool isLastPage = products.Count < pageSize;
                UpdatePaginationButtons(isLastPage);

                UpdatePageLabel();
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào để hiển thị.");
                isLastPage = true; // Không có sản phẩm -> trang cuối
                UpdatePaginationButtons(isLastPage);
                UpdatePageLabel();
            }
        }
        private void UpdatePageLabel()
        {
            lbCountPage.Text = (currentPage + 1).ToString();
        }


        private void UpdatePaginationButtons(bool isLastPage)
        {
            btnLeft.Enabled = currentPage > 0;
            btnRight.Enabled = !isLastPage;
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
                Size = new Size(100, 50),
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(160, 10)
            };

            var priceLabel = new Label
            {
                Text = string.Format(new CultureInfo("vi-VN"), "{0:C}", product.Price),
                Font = new Font("Arial", 10, FontStyle.Regular),
                AutoSize = false,
                Size = new Size(80, 50),
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(270, 10)
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
                Image = Properties.Resources.ViewDetails,
                ImageSize = new Size(20, 20), 
                Size = new Size(40, 40), 
                BackColor = Color.Transparent, 
                BorderRadius = 5, 
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(450, 10)
            };
            btnDetails.Click += (s, e) =>
            {
                var productDetailForm = new ProductDetail(product.ProductId);

                this.Controls.Add(productDetailForm);

                productDetailForm.Dock = DockStyle.None;
                productDetailForm.BringToFront();
            };

            var btnAddColor = new Guna.UI2.WinForms.Guna2Button
            {
                Image = Properties.Resources.addColor,
                ImageSize = new Size(40, 40),
                Size = new Size(40, 40),
                BackColor = Color.Transparent,
                BorderRadius = 5,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(500, 10)
            };
            btnAddColor.Click += (s, e) =>
            {
                var addColorForm = new ColorAddProduct(product.ProductId);
                this.Controls.Add(addColorForm);

                addColorForm.Dock = DockStyle.None;
                addColorForm.Location = new Point(
                    (this.Width - addColorForm.Width) / 2,
                    (this.Height - addColorForm.Height) / 2
                );

                addColorForm.BringToFront();
            };

            var deleteIcon = new Guna.UI2.WinForms.Guna2Button
            {
                Image = Properties.Resources.Delete,
                ImageSize = new Size(25, 25),
                Size = new Size(40, 40),
                BackColor = Color.Transparent,
                BorderRadius = 5,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(550, 10)
            };
            deleteIcon.Click += async (s, e) =>
            {
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa sản phẩm này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo
                );

                if (confirmResult == DialogResult.Yes)
                {
                    await DeleteProduct(product.ProductId);
                    LoadProducts(); 
                }
            };

            var btnEdit = new Guna.UI2.WinForms.Guna2Button
            {
                Image = Properties.Resources.Edit1,
                ImageSize = new Size(25, 25),
                Size = new Size(40, 40),
                BackColor = Color.Transparent,
                BorderRadius = 5,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(600, 10)
            };
            btnEdit.Click += (s, e) =>
            {
                var addEditForm = new ProductEdit(product.ProductId);
                this.Controls.Add(addEditForm);

                addEditForm.Dock = DockStyle.None;
                addEditForm.Location = new Point(
                    (this.Width - addEditForm.Width) / 2,
                    (this.Height - addEditForm.Height) / 2
                );

                addEditForm.BringToFront();
            };

            rowPanel.Controls.Add(btnEdit);
            rowPanel.Controls.Add(deleteIcon);
            rowPanel.Controls.Add(btnDetails);
            rowPanel.Controls.Add(btnAddColor);
            rowPanel.Controls.Add(stockLabel);
            rowPanel.Controls.Add(priceLabel);
            rowPanel.Controls.Add(nameLabel);
            rowPanel.Controls.Add(pictureBox);
            rowPanel.Controls.Add(idLabel);

            return rowPanel;
        }
        private async Task DeleteProduct(int productId)
        {
            try
            {
                await productController.DeleteAsync(productId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi");
            }
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
            var existingCategoryAdd = this.Controls.OfType<ProductAdd>().FirstOrDefault();

            if (existingCategoryAdd == null)
            {
                var addCategory = new ProductAdd();

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

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadProducts();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (!isLastPage)
            {
                currentPage++;
                LoadProducts();
            }
        }
    }
}
