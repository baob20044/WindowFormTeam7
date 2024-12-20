using api.DTOs.Employee;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManage.Controllers
{
    public class EmployeeController
    {
        private readonly ApiService _apiservice;
        public EmployeeController(ApiService apiService)
        {
            _apiservice = apiService;
        }

        public async Task<EmployeeDto> GetDetailsAsync()
        {
            try
            {
                var result = await _apiservice.GetAsync<EmployeeDto>("Employee/details", TokenManager.GetToken());
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
