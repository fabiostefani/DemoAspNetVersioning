using System;
using Microsoft.AspNetCore.Mvc;

namespace DemoAspNetVersioning.V1.Dtos
{
    [ApiVersion("1.0", Deprecated = true)]
    public class CreateOrderDto
    {
        public decimal Total { get; set; }
        public DateTime IssueDate { get; set; }
        public int Sequence { get; set; }      
    }
}