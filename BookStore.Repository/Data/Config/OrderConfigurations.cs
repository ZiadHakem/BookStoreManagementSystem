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
        }
    }
}
