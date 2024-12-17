using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StoreManage.DTOs.Customer
{
    public class CustomerUpdateDto
    {
        public CustomerPersonalInfo PersonalInfo { get; set; }

        [DefaultValue("")]
        [Required]
        public string Email { get; set; }
    }
}