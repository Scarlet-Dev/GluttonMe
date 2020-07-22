using GluttonMe.Api.Interfaces;
using GluttonMe.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Repository
{
    public class OrderRepository : IOrderRepository<Order>
    {
        public Order Create(Order model)
        {
            throw new NotImplementedException();
        }

        public List<Order> Get()
        {
            throw new NotImplementedException();
        }

        public List<Order> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Order model)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Order model)
        {
            throw new NotImplementedException();
        }
    }
}
