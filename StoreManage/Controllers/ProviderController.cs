using StoreManage.DTOs.Providerr;
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
                var result = await _apiService.GetAsync<List<ProviderDto>>("providers",TokenManager.GetToken());
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
                var result = await _apiService.GetAsync<ProviderDto>($"providers/{id}", TokenManager.GetToken());
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public async Task<ProviderCreateDto> CreateAsync(ProviderCreateDto providerCreateDto)
        {
            try
            {
                var result = await _apiService.PostAsync<ProviderCreateDto>("providers", providerCreateDto, TokenManager.GetToken());
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<ProviderUpdateDto> UpdateAsync(int providerId, ProviderUpdateDto providerUpdateDto)
        {
            try
            {
                var result = await _apiService.PutAsync<ProviderUpdateDto>($"providers/{providerId}", providerUpdateDto, TokenManager.GetToken());
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
