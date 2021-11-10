using System;

namespace DemoAspNetVersioning.Model
{
    public class Order
    {
        protected Order()
        {

        }
        public Order(decimal total, decimal taxes, DateTime issueDate, int sequence)
        {
            Id = Guid.NewGuid();
            this.Total = total;
            this.Taxes = taxes;
            this.IssueDate = issueDate;
            this.Sequence = sequence;
        }
        public Guid Id { get; }
        public decimal Total { get; }
        public decimal Taxes { get; }
        public DateTime IssueDate { get; }
        public int Sequence { get; }
    }
}