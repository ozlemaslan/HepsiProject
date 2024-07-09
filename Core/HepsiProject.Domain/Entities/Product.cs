using HepsiProject.Domain.Common;

namespace HepsiProject.Domain.Entities
{
    public class Product : EntityBase
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public Product()
        {
            
        }

        public Product(string productName, string productDescription, decimal price, decimal discount, int brandId)
        {
            ProductName = productName;
            ProductDescription = productDescription;
            Price = price;
            Discount = discount;
            BrandId = brandId;
        }
    }
}
