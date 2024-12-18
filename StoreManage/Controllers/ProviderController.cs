using StoreManage.DTOs.Providerr;
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

        public async Task<ProviderDto> CreateProviderAsync(ProviderCreateDto providerCreateDto, string accessToken)
        {
            try
            {
                var result = await _apiService.PostAsync<ProviderDto>("providers", providerCreateDto, accessToken);
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
