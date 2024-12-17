using System.ComponentModel.DataAnnotations;
using StoreManage.DTOs.Employee;

namespace StoreManage.DTOs.Account
{
    public class EmployeeRegisterDto
    {
        [Required]
        public  EmployeeCreateDto EmployeeInfo { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;
    }
}