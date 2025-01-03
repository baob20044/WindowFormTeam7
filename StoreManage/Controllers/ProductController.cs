using Newtonsoft.Json;
using RestSharp;
using StoreManage.DTOs.Category;
using StoreManage.DTOs.Product;
using StoreManage.DTOs.Providerr;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Controllers
{
    public class ProductController
    {
        private readonly ApiService _apiService;

        public ProductController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ProductDto> GetByIdAsync(int productId)
        {
            try
            {
                var result = await _apiService.GetAsync<ProductDto>($"products/{productId}");
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<List<ProductDto>> GetAllAsyncs()
        {
            try
            {
                var result = await _apiService.GetAsync<List<ProductDto>>("products");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Load product failed : " + ex.Message);
                return null;
            }
        }

        public async Task<string> CreateAsync(ProductCreateDto productCreateDto)
        {
            try
            {
                var result = await _apiService.PostAsync<string>("products", productCreateDto, TokenManager.GetToken());
                MessageBox.Show($"Success: {result}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error create product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<ProductUpdateDto> UpdateAsync(int productId, ProductUpdateDto productUpdateDto)
        {
            try
            {
                var result = await _apiService.PutAsync<ProductUpdateDto>($"products/{productId}", productUpdateDto, TokenManager.GetToken());
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error update product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public async Task<bool> DeleteAsync(int productId)
        {
            try
            {
                var result = await _apiService.DeleteAsync($"products/{productId}", TokenManager.GetToken());
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error delete product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
