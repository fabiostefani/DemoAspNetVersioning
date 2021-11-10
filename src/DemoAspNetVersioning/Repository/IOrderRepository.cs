using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoAspNetVersioning.Model;

namespace DemoAspNetVersioning.Repository
{
    public interface IOrderRepository
    {
        Task Save(Order obj);
        Task<IEnumerable<Order>> GetAll();
        Task<Order> GetById(Guid id);
    }
}