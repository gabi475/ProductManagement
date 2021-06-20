using Common;
using Entities;
using System;
using System.Collections.Generic;

namespace Business
{
    public interface IProductService
    {
        Product Create(Product product);
        IEnumerable<ProductDetailDTO> GetAll();
        void Delete(Guid id);
    }
}
