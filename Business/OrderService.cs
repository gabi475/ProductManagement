using Common;
using Entities;
using Entities.Database;
using Business;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class OrderService : IOrderService
    {
        private ProductContext _context;

        public OrderService(ProductContext context)
        {
            _context = context;
        }
        public Order Create(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }

        public void Delete(Guid id)
        {
            // stergere pe baza id-ului
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.Include(o => o.Products);

        }
    }
}