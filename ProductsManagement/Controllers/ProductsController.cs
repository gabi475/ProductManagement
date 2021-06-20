using Business;
using Common;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProductsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;


        // quick constructor - tastezi 'ctor' si apesi TAB de 2 ori
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<ProductDetailDTO> GetAll()
        {
            return _productService.GetAll();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            var result =  _productService.Create(product);
            return Ok(result);
        }
    }
}
