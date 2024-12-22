using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using StoreManage.DTOs.Inventory;

namespace StoreManage.DTOs.Product
{
    public class ProductCreateDto
    {
        public string Name { get; set; } = "";

        public decimal Price { get; set; }

        public string Description { get; set; }

        public decimal Cost { get; set; }

        public decimal DiscountPercentage { get; set; }
        public string Unit { get; set; }

        public int SubcategoryId { get; set; }

        public int TargetCustomerId { get; set; }
        public int CategoryId { get; set; }
        [DefaultValue("")]
        public string NewCategory { get; set; } = string.Empty;
        [DefaultValue("")]
        public string NewSubcategory { get; set; } = string.Empty;
        public int ProviderId { get; set; }
        public ICollection<ProductInventoryCreateDto> Inventory { get; set; } = new List<ProductInventoryCreateDto>();
    }
}