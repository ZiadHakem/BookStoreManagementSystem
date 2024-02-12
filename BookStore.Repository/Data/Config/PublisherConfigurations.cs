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
    internal class PublisherConfigurations : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.Property(publisher => publisher.Id)
                .HasColumnName("ID");

            builder.Property(publisher => publisher.Name)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired(true);
        }
    }
}
