using Newtonsoft.Json;
using RestSharp;
using StoreManage.Components;
using StoreManage.DTOs.Product;
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
        private List<ProductDto> products = new List<ProductDto>();
        private List<ShopItem> shopItems; // All items
        private List<ShopItem> filteredItems; // Filtered items based on search
        private int currentPage = 0;      // Current page index
        private int pageSize = 15;         // Number of items per page
        private int totalProduct = 50;

        public HomePage()
        {
            InitializeComponent();
            InitializeShopItems();
            filteredItems = new List<ShopItem>(shopItems); // Initially, no filtering
            LoadPage(0);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

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
                    Console.WriteLine("Hi" +item);
                    var shopItem = new ShopItem(item);
                    shopItem.OnShopItemClick += HandleShopItemClick; // Subscribe to the click event
                    shopItems.Add(shopItem); // Add to the list
                    flowLayoutPanel.Controls.Add(shopItem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

        public void HandleShopItemClick(int productId)
        {
            var mainForm = this.FindForm() as MainForm;
            DetailItem detail = new DetailItem(productId,mainForm);
            mainForm?.handleClickedShopItem(detail);
        }
    }
}
