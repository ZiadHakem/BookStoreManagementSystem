using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Data.Config
{
    public class CustomerBookConfiguration : IEntityTypeConfiguration<CustomerBook>
    {
        public void Configure(EntityTypeBuilder<CustomerBook> builder)
        {
            builder.HasKey(cb => new { cb.CustomerId, cb.BookId });

            builder.HasOne(cb => cb.Customer)
                .WithMany(c => c.CustomerBooks)
                .HasForeignKey(cb => cb.CustomerId);

            builder.HasOne(cb => cb.Book)
                .WithMany(b => b.CustomerBooks)
                .HasForeignKey(cb => cb.BookId);

            builder.Property(cb => cb.NumOfBooks)
                .HasColumnType("int")
                .IsRequired(true);
        }
    }

}
