using Newtonsoft.Json;
using RestSharp;
using StoreManage.Components;
using StoreManage.Controllers;
using StoreManage.DTOs.Category;
using StoreManage.DTOs.Product;
using StoreManage.DTOs.Subcategory;
using StoreManage.DTOs.TargetCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Forms.Pages
{
    public partial class CategoryPage : UserControl
    {
        private List<ProductDto> products = new List<ProductDto>();
        private List<ShopItem> shopItems; // All items
        private List<ShopItem> filteredItems; // Filtered items based on search
        private int totalProduct = 50;
        private readonly TargetCustomerController targetCustomerController;
        private readonly CategoryController categoryController;
        private readonly SubcategoryController subcategoryController;
        private Dictionary<string, TargetCustomerDto> targetMap;
        private Dictionary<string, CategoryDto> categoryMap;
        private Dictionary<string, SubcategoryDto> subcategoryMap;
        public CategoryPage()
        {
            InitializeComponent();
            targetCustomerController = new TargetCustomerController(new Services.ApiService());
            categoryController = new CategoryController(new Services.ApiService());
            subcategoryController = new SubcategoryController(new Services.ApiService());

            InitializeShopItems();
            filteredItems = new List<ShopItem>(shopItems); // Initially, no filtering
                                                           //LoadPage();
            LoadTargetCustomers();
        }

        private void CategoryPage_Load(object sender, EventArgs e)
        {

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

                    var targetCustomers = System.Text.Json.JsonSerializer.Deserialize<List<TargetCustomerDto>>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });


                    cbTarget.DataSource = targetCustomers;
                    cbTarget.DisplayMember = "TargetCustomerName";
                    cbTarget.ValueMember = "TargetCustomerId";

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

                    var targetCustomer = System.Text.Json.JsonSerializer.Deserialize<TargetCustomerDto>(json, new JsonSerializerOptions
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

                    var category = System.Text.Json.JsonSerializer.Deserialize<CategoryDto>(json, new JsonSerializerOptions
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
        private async void InitializeShopItems()
        {
            shopItems = new List<ShopItem>();
            try
            {
                var client = new RestClient("http://localhost:5254");
                var request = new RestRequest($"/api/products/", Method.Get);
                request.AddHeader("accept", "*/*");

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    products = JsonConvert.DeserializeObject<List<ProductDto>>(response.Content);
                }
                else Console.WriteLine("Wrong");

                foreach (var item in products)
                {
                    Console.WriteLine("Hi" + item);
                    var shopItem = new ShopItem(item);
                    shopItem.OnShopItemClick += HandleShopItemClick; // Subscribe to the click event
                    shopItems.Add(shopItem); // Add to the list
                    flowLayout.Controls.Add(shopItem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void LoadPage()
        {
            flowLayout.Controls.Clear(); 
            for (int i = 0; i < totalProduct; i++)
            {
                flowLayout.Controls.Add(filteredItems[i]);
            }
        }
        public void HandleShopItemClick(int productId)
        {
            var mainForm = this.FindForm() as MainForm;
            DetailItem detail = new DetailItem(productId, mainForm);
            mainForm?.handleClickedShopItem(detail);
        }
        private void ApplyCategoryFilters()
        {
            var selectedColors = new List<string>();
            var selectedSizes = new List<string>();
            decimal minPrice = 0, maxPrice = decimal.MaxValue;

            // Collect selected colors
            if (cbRed.Checked) selectedColors.Add("Red");
            if (cbBlack.Checked) selectedColors.Add("Black");
            if (cbYellow.Checked) selectedColors.Add("Yellow");
            if (cbOrange.Checked) selectedColors.Add("Orange");
            if (cbGray.Checked) selectedColors.Add("Gray");
            if (cbPink.Checked) selectedColors.Add("LightPink");
            if (cbPurple.Checked) selectedColors.Add("Purple");
            if (cbBrown.Checked) selectedColors.Add("Brown");
            if (cbWhite.Checked) selectedColors.Add("White");

            // Collect selected sizes
            if (cbSizeS.Checked) selectedSizes.Add("S");
            if (cbSizeM.Checked) selectedSizes.Add("M");
            if (cbSizeL.Checked) selectedSizes.Add("L");
            if (cbSizeXl.Checked) selectedSizes.Add("XL");

            // Determine price range
            if (cbBelow350.Checked)
            {
                minPrice = 0;
                maxPrice = 349999;
            }
            if (cbMiddle.Checked)
            {
                minPrice = 350000;
                maxPrice = 749999;
            }
            if (cbAbove750.Checked)
            {
                minPrice = 750000;
                maxPrice = decimal.MaxValue;
            }
            if (cbBelow350.Checked && cbMiddle.Checked || cbAbove750.Checked && cbMiddle.Checked || cbBelow350.Checked && cbAbove750.Checked)
            {
                minPrice = decimal.MaxValue;
                maxPrice = decimal.MaxValue;
            }
            // Apply filters to the product list (shopItemsCategory)
            filteredItems = shopItems
            .Where(shopItem =>
                shopItem.LoadedProduct != null && // Ensure the product is loaded
                (selectedColors.Count == 0 ||
                 selectedColors.All(color => shopItem.LoadedProduct.Colors.Any(c => c.Name == color))) && // Ensure the product contains all selected colors
                (selectedSizes.Count == 0 ||
                 selectedSizes.All(size => shopItem.LoadedProduct.Sizes.Any(s => s.SizeValue == size))) && // Ensure the product contains all selected sizes
                shopItem.LoadedProduct.Price >= minPrice &&
                shopItem.LoadedProduct.Price <= maxPrice)
            .ToList();
        }
        private void LoadFilteredItems()
        {
            flowLayout.Controls.Clear(); // Clear previous controls

            if (filteredItems.Count == 0) // If no items match the filter
            {
                Label noProductLabel = new Label
                {
                    Text = "No product found",
                    Font = new Font("Arial", 16, FontStyle.Bold), // Big text
                    ForeColor = Color.OrangeRed, // Warning color
                    AutoSize = false, // Allows custom size and alignment
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Size = new Size(flowLayout.Width, 50), // Width matches the flow layout
                    Margin = new Padding(0) // Remove additional margins
                };

                // Manually center the label in the flow layout
                noProductLabel.Location = new Point(
                    (flowLayout.Width - noProductLabel.Width) / 2,
                    (flowLayout.Height - noProductLabel.Height) / 2
                );

                flowLayout.Controls.Add(noProductLabel);
            }
            else
            {
                // Add filtered items to the flow layout
                foreach (var item in filteredItems)
                {
                    flowLayout.Controls.Add(item);
                }
            }
        }


        private void cbBlack_CheckedChanged(object sender, EventArgs e)
        {
            ApplyCategoryFilters();  // Apply the filter logic
            LoadFilteredItems();     // Update the UI with filtered items
        }

        private async void cbTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTarget.SelectedValue is int selectedTargetCustomerId)
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

        private void cbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Ensure a subcategory is selected
            if (cbSubCategory.SelectedValue is int selectedSubcategoryId)
            {
                // Filter items based on the selected subcategory
                filteredItems = shopItems
                    .Where(shopItem =>
                        shopItem.LoadedProduct != null && // Ensure product is loaded
                        shopItem.LoadedProduct.SubcategoryId == selectedSubcategoryId)
                    .ToList();

                // Update the UI with filtered items
                LoadFilteredItems();
            }
            else
            {
                MessageBox.Show("Please select a valid subcategory.", "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

        }
    }
}
