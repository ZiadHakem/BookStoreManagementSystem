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
            builder.Property(customer => customer.Id)
                .HasColumnName("CustomerID");

            builder.Property(customer => customer.Name)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired(true);

            builder.Property(customer => customer.Address)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired(true);

            builder.Property(customer => customer.Email)
               .HasMaxLength(100)
               .HasColumnType("varchar")
               .IsRequired(true);

            builder.Property(customer => customer.Phone)
                .HasColumnType("int")
                .IsRequired(true);

            builder.Property(customer => customer.User_Name)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired(true);

            builder.Property(customer => customer.Password)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired(true);
        }
    }
}
