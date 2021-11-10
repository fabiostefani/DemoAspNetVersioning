using DemoAspNetVersioning.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAspNetVersioning.Context
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired();
            builder.Property(x => x.IssueDate)
                .IsRequired();
            builder.Property(x => x.Sequence)
                .IsRequired();
            builder.Property(x => x.Total)
                .IsRequired()
                .HasPrecision(9, 2);
            builder.Property(x=>x.Taxes)
                .IsRequired()
                .HasPrecision(9,2);
        }
    }
}