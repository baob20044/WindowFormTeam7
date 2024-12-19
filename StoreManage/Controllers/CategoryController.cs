using StoreManage.DTOs.Category;
using StoreManage.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine($"Error: {ex.Message}");
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
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }


    }
}
