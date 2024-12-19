using StoreManage.DTOs.Account;
using StoreManage.DTOs.Token;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManage.Controllers
{
    public class AuthController
    {
        private readonly ApiService _apiService;

        public AuthController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<string> LoginAsync(string username, string password)
        {
            var loginDto = new LoginDto
            {
                Username = username,
                Password = password
            };

            try
            {
                // Gọi phương thức LoginAsync và trả về chuỗi accessToken
                return await _apiService.LoginAsync("Account/admin/login", loginDto);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ, thông báo lỗi cho người dùng
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> SignupAsync(EmployeeRegisterDto employeeRegisterDto)
        {
            try
            {
                return await _apiService.SignupAsync("Account/employee-register", employeeRegisterDto);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ, thông báo lỗi cho người dùng
                throw new Exception(ex.Message);
            }
        }


    }
}
