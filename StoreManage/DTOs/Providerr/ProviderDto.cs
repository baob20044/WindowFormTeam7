using StoreManage.DTOs.Product;
using System.Collections.Generic;

namespace StoreManage.DTOs.Providerr
{
    public class ProviderDto
    {
        public int ProviderId { get; set; }
        public string ProviderEmail { get; set; }
        public string ProviderPhone { get; set; } = string.Empty;
        public string ProviderCompanyName { get; set; } = string.Empty;
        public ICollection<ProductDto> Products { get; set; }
    }
}