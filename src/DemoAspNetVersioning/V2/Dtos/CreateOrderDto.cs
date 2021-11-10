using System;
using Microsoft.AspNetCore.Mvc;

namespace DemoAspNetVersioning.V2.Dtos
{
    [ApiVersion("2.0")]
    public class CreateOrderDto
    {
        public decimal Total { get; set; }
        public DateTime IssueDate { get; set; }
        public int Sequence { get; set; }
        public decimal Taxes { get; set; }
    }
}