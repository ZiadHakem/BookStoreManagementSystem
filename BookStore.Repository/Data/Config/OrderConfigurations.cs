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
            builder.Property(o => o.Amount)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            builder.Property(o => o.Date)
                   .IsRequired();

            builder.Property(o => o.Status)
                   .IsRequired();

            builder.HasMany(o => o.OrderBooks)
                   .WithOne()
                   .HasForeignKey(bo => bo.OrderId);

            
        }
    }
}
