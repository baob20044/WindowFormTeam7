

using StoreManage.DTOs.Subcategory;
using System.Collections.Generic;

namespace StoreManage.DTOs.Category
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int TargetCustomerId { get; set; }
        public ICollection<SubcategoryDto> Subcategories { get; set; }
    }
}