
namespace StoreManage.DTOs.Size
{
    public class SizeDto
    {
        public int SizeId { get; set; }
        public string SizeValue { get; set; } = string.Empty;

        //public override bool Equals(object o)
        //{
        //    if (o == null) return false;

        //    if(o is SizeDto sizeDto)
        //        return SizeId == sizeDto.SizeId && SizeValue == sizeDto.SizeValue;
        //    return false;
        //}
        
        //public override int GetHashCode()
        //{
        //    return SizeId.GetHashCode();
        //}
    }
}