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
    internal class BookAuthorConfigurations : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasKey(ba => new {ba.BookID, ba.AuthorID});

            builder.HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(b => b.BookID);

            builder.HasOne(ba => ba.Author)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(b => b.AuthorID);
        }
    }
}