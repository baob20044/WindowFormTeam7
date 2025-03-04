using System.ComponentModel.DataAnnotations;

namespace StoreManage.DTOs.Providerr
{
    public class ProviderUpdateDto
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string ProviderEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Provider phone number is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string ProviderPhone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Provider company name is required.")]
        [MinLength(3, ErrorMessage = "Provider company name must be at least 3 characters long.")]
        public string ProviderCompanyName { get; set; } = string.Empty;
    }
}