using StoreManage.DTOs.PImage;
using System.Collections.Generic;

namespace StoreManage.DTOs.PColor
{ 
    public class ColorToProductDto
    {
        public int ColorId { get; set; }
        public ICollection<ImageCreateToProductDto> Images { get; set; }
    }
}