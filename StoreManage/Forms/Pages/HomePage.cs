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
    public partial class HomePage : UserControl
    {
        private List<ShopItem> shopItems; // All items
        private List<ShopItem> filteredItems; // Filtered items based on search
        private int currentPage = 0;      // Current page index
        private int pageSize = 15;         // Number of items per page
        private int totalProduct = 50;
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            InitializeShopItems();
            filteredItems = new List<ShopItem>(shopItems); // Initially, no filtering
            LoadPage(0);
        }
        private void InitializeShopItems()
        {
            shopItems = new List<ShopItem>();
            for (int i = 1; i <= totalProduct; i++) // Inclusive range to handle all products
            {
                var shopItem = new ShopItem(i);
                //shopItem.OnShopItemClick += HandleShopItemClick; // Subscribe to the click event
                shopItems.Add(shopItem); // Add to the list
                flowLayoutPanel.Controls.Add(shopItem);
            }
        }
        private void LoadPage(int pageIndex) /* Home Page */
        {
            flowLayoutPanel.Controls.Clear(); // Clear existing controlsy
            // Calculate the range of items to display
            int startIndex = pageIndex * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, filteredItems.Count);

            // Reuse preloaded controls from filtered list
            for (int i = startIndex; i < endIndex; i++)
            {
                flowLayoutPanel.Controls.Add(filteredItems[i]);
            }
            // Update navigation buttons
            btnPrevious.Enabled = pageIndex > 0;
            btnNext.Enabled = endIndex < filteredItems.Count;

            int totalPage = (filteredItems.Count % pageSize) == 0 ? filteredItems.Count / pageSize : (filteredItems.Count / pageSize) + 1;
            lbPageNumber.Text = $"{currentPage + 1}/{totalPage}";
        }
        private void btnNext_Click(object sender, EventArgs e) /* Home Page */
        {
            if ((currentPage + 1) * pageSize < filteredItems.Count)
            {
                currentPage++;
                LoadPage(currentPage);
            }
        }

        // Trang trước 
        private void btnPrevious_Click(object sender, EventArgs e) /* Home Page */
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadPage(currentPage);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            // Filter the items based on the search text
            filteredItems = shopItems
                .Where(item => item.ItemLabel.ToLower().Contains(searchText)) // Assuming ItemLabel is a property of ShopItem
                .ToList();

            // Reset current page and reload the page
            currentPage = 0;
            LoadPage(currentPage);
        }
    }
}
