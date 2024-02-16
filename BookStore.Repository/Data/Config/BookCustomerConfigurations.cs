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
    internal class BookCustomerConfigurations : IEntityTypeConfiguration<BookCustomer>
    {
        public void Configure(EntityTypeBuilder<BookCustomer> builder)
        {
            builder.HasKey(bc => new { bc.BookId, bc.CustomerId });

            builder.Property(bc => bc.Quantity)
                   .IsRequired();
        }
    }
}
