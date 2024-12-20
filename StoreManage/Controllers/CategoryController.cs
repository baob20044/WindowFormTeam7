using StoreManage.DTOs.Category;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Controllers
{
    public class CategoryController
    {
        private readonly ApiService _apiService;

        public CategoryController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<CategoryDto>> GetAllAsync()
        {
            try
            {
                var result = await _apiService.GetAsync<List<CategoryDto>>("categories");

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}" ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<CategoryCreateDto> CreateAsync(CategoryCreateDto categoryCreateDto)
        {
            try
            {
                var result = await _apiService.PostAsync<CategoryCreateDto>("categories", categoryCreateDto, TokenManager.GetToken());
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public async Task<CategoryDto> GetByIdAsync(int categoryId)
        {
            try
            {
                var result = await _apiService.GetAsync<CategoryDto>($"categories/{categoryId}");
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<CategoryUpdateDto> UpdateAsync(int categoryId, CategoryUpdateDto categoryUpdateDto)
        {
            try
            {
                var result = await _apiService.PutAsync<CategoryUpdateDto>($"categories/{categoryId}", categoryUpdateDto, TokenManager.GetToken());
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
