using Entities;
using System;
using System.Collections.Generic;

namespace Business
{
    public interface IOrderService
    {
        Order Create(Order order);
        IEnumerable<Order> GetAll();
        void Delete(Guid id);
    }
}
