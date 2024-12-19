using StoreManage.DTOs.Providerr;
using StoreManage.DTOs.Subcategory;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManage.Controllers
{
    public class ProviderController
    {
        private readonly ApiService _apiService;

        public ProviderController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<ProviderDto>> GetAllAsync()
        {
            try
            {
                var result = await _apiService.GetAsync<List<ProviderDto>>("providers");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public async Task<ProviderDto> GetByIdAsync(int id)
        {
            try
            {
                var result = await _apiService.GetAsync<ProviderDto>($"providers/{id}");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
}
