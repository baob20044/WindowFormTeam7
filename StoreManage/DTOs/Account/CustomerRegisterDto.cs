using System.ComponentModel.DataAnnotations;
using StoreManage.DTOs.Customer;

namespace StoreManage.DTOs.Account
{
    public class CustomerRegisterDto
    {
        public  CustomerCreateDto CustomerInfo { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = string.Empty;
    }
}
