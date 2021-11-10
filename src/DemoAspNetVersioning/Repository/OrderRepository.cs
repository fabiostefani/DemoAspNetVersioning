using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoAspNetVersioning.Context;
using DemoAspNetVersioning.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoAspNetVersioning.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DemoContext _context;
        public OrderRepository(DemoContext context)
        {
            _context = context;

        }
        public async Task Save(Order obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetById(Guid id)
        {
            return await _context.Orders.FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}