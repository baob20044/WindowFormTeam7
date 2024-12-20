using StoreManage.DTOs.Size;
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
    public class SizeController
    {
        private readonly ApiService _apiService;

        public SizeController(ApiService apiService) 
        { 
            _apiService = apiService;
        }

        public async Task<List<SizeDto>> GetAllAsync()
        {
            try
            {
                var result = await _apiService.GetAsync<List<SizeDto>>("sizes");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public async Task<SizeDto> GetByIdAsync(int id)
        {
            try
            {
                var result = await _apiService.GetAsync<SizeDto>($"sizes/{id}");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public async Task<SizeCreateDto> CreateAsync(SizeCreateDto sizeCreateDto)
        {
            try
            {
                var result = await _apiService.PostAsync<SizeCreateDto>("sizes", sizeCreateDto, TokenManager.GetToken());
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public async Task<SizeUpdateDto> UpdateAsync(int sizeId, SizeUpdateDto sizeUpdateDto)
        {
            try
            {
                var result = await _apiService.PutAsync<SizeUpdateDto>($"sizes/{sizeId}", sizeUpdateDto, TokenManager.GetToken());
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
