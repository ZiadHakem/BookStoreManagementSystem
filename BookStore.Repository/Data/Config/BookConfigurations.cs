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
            builder.Property(book => book.Id)
                 .HasColumnName("ID");

            builder.Property(book => book.Name)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired(true);

            builder.Property(book => book.Price)
                .HasColumnType("money")
                .IsRequired(true);

            builder.Property(book => book.Statue)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired(true);

            builder.Property(book => book.Image)
                .HasColumnType("varchar")
                .IsRequired(true);

            builder.HasOne(b => b.Category)
            .WithMany(c => c.Books)
            .HasForeignKey(b => b.CategoryId);
        }
    }
}
