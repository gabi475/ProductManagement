using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsManagement.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class OrderController : ControllerBase
        {
        private IOrderService _orderService;


        // quick constructor - tastezi 'ctor' si apesi TAB de 2 ori
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IEnumerable<Order> GetAll()
        {
            return _orderService.GetAll();

        }

        [HttpPost]
        public IActionResult Create([FromBody] Order order)
        {
            var x = 50;
            var y = 20;
            var result = _orderService.Create(order);
            return Ok(result);
        }
    }
}
