using Microsoft.Office.Interop.Word;
using Newtonsoft.Json;
using RestSharp;
using StoreManage.Components;
using StoreManage.Controllers;
using StoreManage.DTOs.Category;
using StoreManage.DTOs.Product;
using StoreManage.DTOs.Subcategory;
using StoreManage.DTOs.TargetCustomer;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using System;
using System.Linq;

using iText.Kernel.Geom;
using Microsoft.Office.Interop.Word;
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
        private int currentPage = 0; // Current page index
        private int pageSize = 15; // Number of items per page
        private bool isLastPage = false; // Flag to track if this is the last page
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
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Lỗi khi tải danh sách targetCustomers: {ex.Message}");
            }
        }

        private async void LoadCategories(int targetCustomerId)
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

                        // Select the first category and trigger loading subcategories
                        if (targetCustomer.Categories.Count > 0)
                        {
                            cbCategory.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Lỗi khi tải danh sách danh mục: {ex.Message}");
            }
        }

        private async void LoadSubCategories(int categoryId)
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

                        // Select the first subcategory if available
                        if (category.Subcategories.Count > 0)
                        {
                            cbSubCategory.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Lỗi khi tải danh sách danh mục con: {ex.Message}");
            }
        }
        private async void InitializeShopItems(string subcategoryId= "")
        {
            shopItems = new List<ShopItem>(); // Ensure it's initialized
            filteredItems = new List<ShopItem>(); // Initialize filteredItems
            flowLayout.Controls.Clear(); // Clear the flow layout before loading new items

            try
            {
                // Apply filters
                ApplyCategoryFilters();

                // Build the API URL with the filters
                string apiUrl = $"http://localhost:5254/api/products?Offset={currentPage * pageSize}&PageSize={pageSize}&SubcategoryId={subcategoryId}";

                var filters = new List<string>();

                // Filter logic as you've already implemented...
                // Add filters for target, category, subcategory, colors, sizes, price, etc.

                if (filters.Any())
                {
                    apiUrl += "&" + string.Join("&", filters);
                }

                // Call the API and parse the response
                var client = new RestClient(apiUrl);
                var request = new RestRequest();
                request.AddHeader("accept", "*/*");

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    products = JsonConvert.DeserializeObject<List<ProductDto>>(response.Content);
                    if (products != null && products.Any())
                    {
                        foreach (var item in products)
                        {
                            var shopItem = new ShopItem(item);
                            shopItem.OnShopItemClick += HandleShopItemClick; // Subscribe to the click event
                            shopItems.Add(shopItem); // Add to the list
                            flowLayout.Controls.Add(shopItem); // Add to the UI
                        }

                        isLastPage = products.Count < pageSize;
                        UpdatePaginationButtons();
                        UpdatePageLabel();
                    }
                    else
                    {
                        MessageBox.Show("No products available to display.");
                        isLastPage = true;
                        UpdatePaginationButtons();
                        UpdatePageLabel();
                    }
                }
                else
                {
                    //MessageBox.Show($"Error loading products: {response.Content}");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private List<string> GetSelectedColors()
        {
            var selectedColors = new List<string>();

            if (cbRed.Checked) selectedColors.Add("Red");
            if (cbBlack.Checked) selectedColors.Add("Black");
            if (cbYellow.Checked) selectedColors.Add("Yellow");
            if (cbOrange.Checked) selectedColors.Add("Orange");
            if (cbGray.Checked) selectedColors.Add("Gray");
            if (cbPink.Checked) selectedColors.Add("LightPink");
            if (cbPurple.Checked) selectedColors.Add("Purple");
            if (cbBrown.Checked) selectedColors.Add("Brown");
            if (cbWhite.Checked) selectedColors.Add("White");

            return selectedColors;
        }

        private List<string> GetSelectedSizes()
        {
            var selectedSizes = new List<string>();

            if (cbSizeS.Checked) selectedSizes.Add("S");
            if (cbSizeM.Checked) selectedSizes.Add("M");
            if (cbSizeL.Checked) selectedSizes.Add("L");
            if (cbSizeXl.Checked) selectedSizes.Add("XL");

            return selectedSizes;
        }
        private string GetSelectedPriceRange()
        {
            if (cbBelow350.Checked)
            {
                return "0-349999";
            }
            if (cbMiddle.Checked)
            {
                return "350000-749999";
            }
            if (cbAbove750.Checked)
            {
                return "750000-9999999"; // Adjust the upper limit based on your requirement
            }

            return string.Empty; // No price range selected
        }


        private void UpdatePaginationButtons()
        {
            btnLeft.Enabled = currentPage > 0;
            btnRight.Enabled = !isLastPage;
        }
        private void UpdatePageLabel()
        {
            lbCountPage.Text = $"{currentPage + 1}";
        }
        private async void btnNext_Click(object sender, EventArgs e)
        {
            flowLayout.Controls.Clear();
            if (!isLastPage)
            {
                currentPage++;
                InitializeShopItems(); // Re-load products for the next page
            }
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            flowLayout.Controls.Clear();
            if (currentPage > 0)
            {
                currentPage--;
                InitializeShopItems(); // Re-load products for the previous page
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
                    Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold), // Big text
                    ForeColor = Color.OrangeRed, // Warning color
                    AutoSize = false, // Allows custom size and alignment
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Size = new Size(flowLayout.Width, 50), // Width matches the flow layout
                    Margin = new Padding(0) // Remove additional margins
                };

                // Manually center the label in the flow layout
                noProductLabel.Location = new System.Drawing.Point(
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
                LoadCategories(selectedTargetCustomerId);
            }
            else
            {
                //MessageBox.Show("Invalid Target Customer selected.");
            }

        }

        private async void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedValue is int selectedCategoryId)
            {
                LoadSubCategories(selectedCategoryId);
            }
        }

        private void cbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Ensure a subcategory is selected
            InitializeShopItems(cbSubCategory.SelectedValue.ToString());
        }
    }
}