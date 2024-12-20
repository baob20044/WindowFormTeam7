using StoreManage.DTOs.Order;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManage.Controllers
{
    public class OrderController
    {
        private readonly ApiService _apiService;

        public OrderController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<OrderDto>> GetAllAsync()
        {
            try
            {
                var result = await _apiService.GetAsync<List<OrderDto>>("Order");

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<OrderCreateDto> CreateAsync(OrderCreateDto orderCreateDto)
        {
            try
            {
                var result = await _apiService.PostAsync<OrderCreateDto>("Order", orderCreateDto, TokenManager.GetToken());
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public async Task<OrderDto> GetByIdAsync(int orderId)
        {
            try
            {
                var result = await _apiService.GetAsync<OrderDto>($"Order/{orderId}");
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
