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
    internal class BookConfigurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {

            builder.Property(b => b.Title)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(b => b.Price)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            builder.Property(b => b.Status)
                   .IsRequired();

            builder.HasMany(b => b.BookOrders)
                   .WithOne()
                   .HasForeignKey(bo => bo.BookId);

            builder.HasMany(b => b.BookCustomers)
                   .WithOne()
                   .HasForeignKey(bc => bc.BookId);

            builder.HasMany(b => b.BookAuthors)
                   .WithOne()
                   .HasForeignKey(ba => ba.BookId);

            builder.HasMany(b => b.BookPublishers)
                   .WithOne()
                   .HasForeignKey(ba => ba.BookId);
        }
    }
}
