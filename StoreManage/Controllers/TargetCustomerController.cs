using StoreManage.DTOs.Category;
using StoreManage.DTOs.TargetCustomer;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManage.Controllers
{
    public class TargetCustomerController
    {
        private readonly ApiService _apiService;

        public TargetCustomerController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<TargetCustomerDto>> GetAllAsync()
        {
            try
            {
                var result = await _apiService.GetAsync<List<TargetCustomerDto>>("targetCustomers");

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public async Task<TargetCustomerCreateDto> CreateAsync(TargetCustomerCreateDto targetCustomerCreateDto)
        {
            try
            {
                var result = await _apiService.PostAsync<TargetCustomerCreateDto>("targetCustomers", targetCustomerCreateDto, TokenManager.GetToken());
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
