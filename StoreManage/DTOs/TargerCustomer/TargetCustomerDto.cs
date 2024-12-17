
using StoreManage.DTOs.Category;
using System.Collections.Generic;

namespace StoreManage.DTOs.TargetCustomer
{
    public class TargetCustomerDto
    {
        public int TargetCustomerId { get; set; }
        public string TargetCustomerName { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Alt { get; set; } = string.Empty;
        public ICollection<CategoryDto> Categories { get; set; }
    }
}