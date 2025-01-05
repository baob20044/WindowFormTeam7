using Newtonsoft.Json;
using RestSharp;
using StoreManage.Components;
using StoreManage.Controllers;
using StoreManage.DTOs.Product;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Forms.Pages
{
    public partial class HomePage : UserControl
    {
        private int currentPage = 0; // Current page index
        private int pageSize = 15; // Number of items per page
        private bool isLastPage = false; // Flag to track if this is the last page
        private readonly ProductController _productController;

        public HomePage()
        {
            InitializeComponent();
            _productController = new ProductController(new ApiService());
            LoadProducts();
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
                    return System.Text.Json.JsonSerializer.Deserialize<List<ProductDto>>(json, new JsonSerializerOptions
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
        private async void LoadProducts(string query="")
        {
            flowLayoutPanel.Controls.Clear(); // Clear existing items from the flow panel
            string apiUrl = $"http://localhost:5254/api/products?Offset={currentPage * pageSize}&PageSize={pageSize}&Name={query}";

            try
            {
                var products = await GetAllProductsAsync(apiUrl);

                if (products.Any())
                {
                    foreach (var product in products)
                    {
                        var shopItem = new ShopItem(product);
                        shopItem.OnShopItemClick += HandleShopItemClick; // Subscribe to the click event
                        flowLayoutPanel.Controls.Add(shopItem);
                    }

                    // Update pagination buttons
                    isLastPage = products.Count < pageSize;
                    UpdatePaginationButtons();
                    UpdatePageLabel();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm");
                    isLastPage = true; // Không có sản phẩm -> trang cuối
                    UpdatePaginationButtons(isLastPage);
                    UpdatePageLabel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }
        private void UpdatePaginationButtons(bool isLastPage)
        {
            btnNext.Enabled = currentPage > 0;
            btnPrevious.Enabled = !isLastPage;
        }
        private void UpdatePaginationButtons()
        {
            btnPrevious.Enabled = currentPage > 0;
            btnNext.Enabled = !isLastPage;
        }

        private void UpdatePageLabel()
        {
            lbPageNumber.Text = $"Page {currentPage + 1}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!isLastPage)
            {
                currentPage++;
                LoadProducts();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadProducts();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void HandleShopItemClick(int productId)
        {
            var mainForm = this.FindForm() as MainForm;
            if (mainForm != null)
            {
                var detailItem = new DetailItem(productId, mainForm);
                mainForm.handleClickedShopItem(detailItem);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string searchText = txtSearch.Text;
                currentPage = 0; // Reset current page when performing a search

                // Use a filtered API call or locally filter the list if data is preloaded
                // Update API URL if filtering server-side
                LoadProducts(searchText); // Reload products based on search criteria
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadProducts();
        }
    }
}
