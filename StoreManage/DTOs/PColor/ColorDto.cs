
using StoreManage.DTOs.PImage;
using System.Collections.Generic;

namespace StoreManage.DTOs.PColor
{
    public class ColorDto
    {
        public int ColorId { get; set; }
        public string HexaCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public ICollection<ImageDto> Images { get; set; }
    
        public override bool Equals(object o)
        {
            if (o == null) return false;
            if(o is ColorDto colorDto)
                return ColorId == colorDto.ColorId && Name == colorDto.Name;
            return false;
        }
        
        public override int GetHashCode()
        {
            return ColorId.GetHashCode();
        }

    }
}