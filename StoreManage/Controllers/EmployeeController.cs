using api.DTOs.Employee;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using StoreManage.DTOs.Employee;
using StoreManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public async Task<EmployeeDto> UpdateAsync(int id, EmployeeUpdateDto employeeUpdateDto, IFormFile file = null)
        {
            try
            {
                // Tạo multipart/form-data content
                var multipartData = new MultipartFormDataContent();

                // Gắn file nếu có
                if (file != null)
                {
                    var fileContent = new StreamContent(file.OpenReadStream());
                    var contentType = string.IsNullOrEmpty(file.ContentType) ? "application/octet-stream" : file.ContentType;
                    fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);

                    multipartData.Add(fileContent, "file", file.FileName);
                }

                // Gắn từng trường trong employeeUpdateDto
                multipartData.Add(new StringContent(employeeUpdateDto.Email ?? ""), "Email");
                multipartData.Add(new StringContent(employeeUpdateDto.PersonalInfo.FirstName ?? ""), "PersonalInfo.FirstName");
                multipartData.Add(new StringContent(employeeUpdateDto.PersonalInfo.LastName ?? ""), "PersonalInfo.LastName");
                multipartData.Add(new StringContent(employeeUpdateDto.PersonalInfo.Address ?? ""), "PersonalInfo.Address");
                multipartData.Add(new StringContent(employeeUpdateDto.PersonalInfo.DateOfBirth ?? ""), "PersonalInfo.DateOfBirth");
                multipartData.Add(new StringContent(employeeUpdateDto.PersonalInfo.PhoneNumber ?? ""), "PersonalInfo.PhoneNumber");
                multipartData.Add(new StringContent(employeeUpdateDto.PersonalInfo.Male.ToString()), "PersonalInfo.Male");

                // Sử dụng HttpClient để gửi yêu cầu PUT
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {TokenManager.GetToken()}"); // Thêm token vào header

                var response = await client.PutAsync($"http://localhost:5254/api/Employee/{id}", multipartData);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<EmployeeDto>(responseContent); // Trả về đối tượng EmployeeDto
                }
                else
                {
                    throw new Exception($"Update failed: {response.Content.ReadAsStringAsync().Result}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<List<EmployeeDto>> GetAllAsync()
        {
            try
            {
                var result = await _apiservice.GetAsync<List<EmployeeDto>>("Employee", TokenManager.GetToken());
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public async Task<EmployeeDto> GetByIdAsync(int employeeId)
        {
            try
            {
                var result = await _apiservice.GetAsync<EmployeeDto>($"Employee/{employeeId}", TokenManager.GetToken());
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
