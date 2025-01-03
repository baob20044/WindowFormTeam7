﻿using StoreManage.DTOs.Account;
using StoreManage.DTOs.Token;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public async Task<string> ForgotAsync(ForgotPasswordDto forgotPassword)
        {
            try
            {
                return await _apiService.PostAsync<string>("EmailSender/send", forgotPassword);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Forgot failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<string> changePassWordAsync(NewPasswordDto changePasswordDto)
        {
            try
            {
                return await _apiService.PostAsync<string>("Account/change-password", changePasswordDto, TokenManager.GetToken());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed: {ex.Message}","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<TokenDto> refreshTokenAsync()
        {
            try
            {
                return await _apiService.PostAsync<TokenDto>("Token/refresh", null,TokenManager.GetToken());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"refresh token failed : {ex.Message}");
                return null;
            }
        }
    }
}
