using StoreManage.DTOs.PSize;
using System.Collections.Generic;

namespace StoreManage.DTOs.Inventory
{
    public class ProductInventoryCreateDto
    {
        public int ColorId { get; set; }
        public ICollection<SizeOfColorDto> Sizes { get; set; } = new List<SizeOfColorDto>();
    }
}
