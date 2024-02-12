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
    internal class CartConfigurations : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.Property(cart => cart.Id)
                .HasColumnName("ID");

            builder.Property(cart => cart.Price)
              .HasColumnType("money")
              .IsRequired(true);

            builder.Property(cart => cart.NumberOfBooks)
                .HasColumnType("int")
                .IsRequired(true);
        }
    }
}
