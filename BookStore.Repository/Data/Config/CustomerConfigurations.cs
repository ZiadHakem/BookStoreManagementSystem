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
    internal class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(cus => cus.Name)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(cus => cus.UserName)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(cus => cus.Password)
                   .IsRequired()
                   .HasMaxLength(10);

            builder.Property(cus => cus.Address)
                   .IsRequired();

            builder.Property(cus => cus.Email)
                   .IsRequired();

            builder.Property(cus => cus.Phone)
                   .IsRequired()
                   .HasMaxLength(11);

            builder.HasMany(cus => cus.Orders)
                   .WithOne()
                   .HasForeignKey(o => o.CustomerId);
        }
    }
}
