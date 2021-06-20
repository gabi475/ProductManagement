using System;

namespace Common
{
    public class ProductDetailDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string CompanyName { get; set; }
    }
}
