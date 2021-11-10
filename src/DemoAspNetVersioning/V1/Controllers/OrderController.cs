using System;
using System.Threading.Tasks;
using DemoAspNetVersioning.Controllers;
using DemoAspNetVersioning.Model;
using DemoAspNetVersioning.Repository;
using DemoAspNetVersioning.V1.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DemoAspNetVersioning.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class OrderController : MainController
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]        
        public async Task<IActionResult> Get()
        {
            return Ok(await _orderRepository.GetAll());
        }

        [HttpGet]
        [Route("Get/{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _orderRepository.GetById(id));
        }
        [Obsolete("Deprecated")]
        [HttpPost]        
        public async Task<IActionResult> Post([FromBody] CreateOrderDto orderDto)
        {
            var order = new Order(orderDto.Total, 0, orderDto.IssueDate, orderDto.Sequence);
            await _orderRepository.Save(order);
            return Created(nameof(GetById), order.Id);
        }
    }
}