using System;
using System.Collections.Generic;

namespace StoreManage.DTOs
{
    // Interface for Product-related operations
    public interface IProductOperations
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
        Product GetProductById(int productId);
    }

    // Product class
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string SubcategoryName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int InStock { get; set; } // Stock quantity
        public List<Color> Colors { get; set; }
        public List<Size> Sizes { get; set; }

        public Product()
        {
            Colors = new List<Color>();
            Sizes = new List<Size>();
        }
    }

    // Size class
    public class Size
    {
        public int SizeId { get; set; }
        public string SizeValue { get; set; } // e.g., "S", "M", "L"

        public Size(int sizeId, string sizeValue)
        {
            SizeId = sizeId;
            SizeValue = sizeValue;
        }
    }

    // Color class
    public class Color
    {
        public int ColorId { get; set; }
        public string HexaCode { get; set; }
        public string Name { get; set; }
        public List<ImageInfo> Images { get; set; }

        public Color()
        {
            Images = new List<ImageInfo>();
        }
    }

    // ImageInfo class
    public class ImageInfo
    {
        public int ImageId { get; set; }
        public string Url { get; set; }
        public string Alt { get; set; }
        public int ProductId { get; set; }
        public int ColorId { get; set; }
    }
}
