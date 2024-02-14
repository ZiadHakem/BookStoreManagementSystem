using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Data.Config
{
    internal class OrderConfigurations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(order => order.Id)
                .HasColumnName("Number");

            builder.Property(order => order.Amount)
                .HasColumnType("money")
                .IsRequired(true);

            builder.Property(order => order.Date)
                .HasColumnType("datetime")
                .IsRequired(true);

            builder.Property(order => order.Status)
                .IsRequired(true)
                .HasColumnType("int");

            builder.HasOne(order => order.Customer)
            .WithMany(customer => customer.Orders)
            .HasForeignKey(order => order.CustomerId)
            .IsRequired(false);

            builder.HasOne(o => o.Book)
           .WithMany(b => b.Orders)
           .HasForeignKey(o => o.BookId);

        }
    }
}
