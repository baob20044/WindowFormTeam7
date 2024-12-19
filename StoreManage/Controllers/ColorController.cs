using StoreManage.DTOs.PColor;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Controllers
{
    public class ColorController
    {
        private readonly ApiService _apiservice;
        public ColorController(ApiService apiService) 
        {
            _apiservice = apiService;
        }

        public async Task<List<ColorDto>> GetAllAsync()
        {
            try
            {
                var result = await _apiservice.GetAsync <List<ColorDto>>("colors");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public async Task<ColorDto> GetByIdAsync(int id)
        {
            try
            {
                var result = await _apiservice.GetAsync<ColorDto>($"colors/{id}");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public async Task<ColorCreateDto> CreateAsync(ColorCreateDto colorCreateDto)
        {
            try
            {
                var result = await _apiservice.PostAsync<ColorCreateDto>("colors", colorCreateDto, TokenManager.GetToken());
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }

        }
        public async Task<ColorUpdateDto> UpdateAsync(int colorId, ColorUpdateDto colorUpdateDto)
        {
            try
            {
                var result = await _apiservice.PutAsync<ColorUpdateDto>($"colors/{colorId}", colorUpdateDto, TokenManager.GetToken());
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
