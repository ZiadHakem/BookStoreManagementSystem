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
    internal class AdminConfigurations : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(p => p.UserName)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(p => p.Password)
                   .IsRequired()
                   .HasMaxLength(10);
        }
    }
}
