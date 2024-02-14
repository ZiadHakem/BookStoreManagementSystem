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
    public class BookPublisherCongfigurations : IEntityTypeConfiguration<BookPublisher>
    {
        public void Configure(EntityTypeBuilder<BookPublisher> builder)
        {

            builder.HasKey(bp => new { bp.BookID, bp.PublisherID });

            builder.HasOne(bp => bp.Book)
                .WithMany(b => b.BookPublishers)
                .HasForeignKey(bp => bp.BookID);

            builder.HasOne(bp => bp.Publisher)
                .WithMany(b => b.BookPublishers)
                .HasForeignKey(bp => bp.PublisherID);
        }
    }
}
