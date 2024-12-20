using StoreManage.DTOs.Inventory;
using StoreManage.DTOs.Subcategory;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Controllers
{
    public class InventoryController
    {
        private readonly ApiService _apiService;

        public InventoryController(ApiService apiService) 
        {
            _apiService = apiService;
        }

        public async Task<InventoryCreateDto> CreateAsync(InventoryCreateDto inventoryCreateDto)
        {
            try
            {
                var result = await _apiService.PostAsync<InventoryCreateDto>("inventories", inventoryCreateDto, TokenManager.GetToken());
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }

        }

        public async Task<InventoryDto> GetByIdAsync(int productId, int sizeId, int colorId)
        {
            try
            {
                var result = await _apiService.GetAsync<InventoryDto>($"inventories?productId={productId}&colorId={colorId}&sizeId={sizeId}");
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }



    }
}
