using StoreManage.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Forms.Pages
{
    public partial class CategoryPage : UserControl
    {
        private List<ShopItem> shopItems; // All items
        private List<ShopItem> filteredItems; // Filtered items based on search
        private int totalProduct = 50;
        public CategoryPage()
        {
            InitializeComponent();
            InitializeShopItems();
            filteredItems = new List<ShopItem>(shopItems); // Initially, no filtering
            LoadPage();
        }

        private void CategoryPage_Load(object sender, EventArgs e)
        {

        }
        private void InitializeShopItems()
        {
            shopItems = new List<ShopItem>();
            for (int i = 1; i <= totalProduct; i++) // Inclusive range to handle all products
            {
                var shopItem = new ShopItem(i);
                shopItem.OnShopItemClick += HandleShopItemClick; // Subscribe to the click event
                shopItems.Add(shopItem); // Add to the list
                flowLayout.Controls.Add(shopItem);
            }
        }
        private void LoadPage()
        {
            flowLayout.Controls.Clear(); 
            for (int i = 1; i < totalProduct; i++)
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
    }
}
