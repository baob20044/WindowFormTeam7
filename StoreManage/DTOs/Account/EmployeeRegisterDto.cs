using System.ComponentModel.DataAnnotations;
using StoreManage.DTOs.Employee;

namespace StoreManage.DTOs.Account
{
    public class EmployeeRegisterDto
    {
        public  EmployeeCreateDto EmployeeInfo { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}