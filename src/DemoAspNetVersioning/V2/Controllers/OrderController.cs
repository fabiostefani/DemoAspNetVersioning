using System;
using System.Threading.Tasks;
using DemoAspNetVersioning.Controllers;
using DemoAspNetVersioning.Model;
using DemoAspNetVersioning.Repository;
using DemoAspNetVersioning.V2.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DemoAspNetVersioning.V2.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
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

        [HttpPost]        
        public async Task<IActionResult> Post([FromBody] CreateOrderDto orderDto)
        {
            var order = new Order(orderDto.Total, orderDto.Taxes, orderDto.IssueDate, orderDto.Sequence);
            await _orderRepository.Save(order);
            return Created(nameof(GetById), order.Id);
        }
    }
}