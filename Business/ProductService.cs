using Common;
using Entities;
using Entities.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class ProductService : IProductService
    {
        private ProductContext _context;
        public ProductService(ProductContext context)
        {
            _context = context;
        }
        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void Delete(Guid id)
        {
            // stergere pe baza id-ului
        }

        public IEnumerable<ProductDetailDTO> GetAll()
        {
            return _context.Products.Select(item => new ProductDetailDTO
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CompanyName = item.Company.Name
            });
        }
    }
}