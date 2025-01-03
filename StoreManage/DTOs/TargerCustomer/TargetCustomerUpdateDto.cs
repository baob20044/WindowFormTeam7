using System.ComponentModel.DataAnnotations;

namespace StoreManage.DTOs.TargetCustomer
{
    public class TargetCustomerUpdateDto
    {
        [Required(ErrorMessage = "TargetCustomerName is required.")]
        public string TargetCustomerName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Url is required.")]
        // [Url(ErrorMessage = "Please enter a valid URL.")]
        public string Url { get; set; } = string.Empty;

        [Required(ErrorMessage = "Alt is required.")]
        [StringLength(100, ErrorMessage = "Alt text cannot exceed 100 characters.")]
        public string Alt { get; set; } = string.Empty;
    }
}