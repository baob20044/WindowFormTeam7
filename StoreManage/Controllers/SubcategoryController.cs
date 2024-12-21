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
    public class SubcategoryController
    {
        private readonly ApiService _apiService;

        public SubcategoryController(ApiService apiService)
        {
            _apiService = apiService;
        }   

        public async Task<List<SubcategoryDto>> GetAllAsync()
        {
            try
            {
                var result = await _apiService.GetAsync<List<SubcategoryDto>>("subcategories");
                return result;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public async Task<SubcategoryDto> GetByIdAsync(int id)
        {
            try
            {
                var result = await _apiService.GetAsync<SubcategoryDto>($"subcategories/{id}");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public async Task<SubcategoryCreateDto> CreateAsync(SubcategoryCreateDto subcategoryCreateDto)
        {
            try
            {
                var result = await _apiService.PostAsync<SubcategoryCreateDto>("subcategories", subcategoryCreateDto, TokenManager.GetToken());
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public async Task<SubcategoryUpdateDto> UpdateAsync(int subcategoryId, SubcategoryUpdateDto subcategoryUpdateDto)
        {
            try
            {
                var result = await _apiService.PutAsync<SubcategoryUpdateDto>($"subcategories/{subcategoryId}", subcategoryUpdateDto, TokenManager.GetToken());
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
