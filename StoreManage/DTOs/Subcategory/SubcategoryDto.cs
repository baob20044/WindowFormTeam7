
using StoreManage.DTOs.Product;
using System.Collections.Generic;

namespace StoreManage.DTOs.Subcategory
{
    public class SubcategoryDto
    {
        public int SubcategoryId { get; set; }
        public string SubcategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<ProductDto> Products { get; set; }
        public int CategoryId { get; set; }
    }
}