using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManage.DTOs.Product
{
    public class ProductInfoDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string FirstPicture { get; set; } = string.Empty;
        public string Alt { get; set; } = string.Empty;
    }
}
