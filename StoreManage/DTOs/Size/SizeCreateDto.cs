using System.ComponentModel.DataAnnotations;

namespace StoreManage.DTOs.Size
{
    public class SizeCreateDto
    {
        [Required(ErrorMessage = "SizeValue is required.")]
        [RegularExpression("^(S|M|L|XL|XXL)$", ErrorMessage = "SizeValue must be one of the following: S, M, L, XL, XXL.")]
        public string SizeValue { get; set; } = string.Empty;
    }
}