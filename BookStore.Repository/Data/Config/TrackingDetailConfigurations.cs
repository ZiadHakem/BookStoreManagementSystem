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
    internal class TrackingDetailConfigurations : IEntityTypeConfiguration<TrackingDetail>
    {
        public void Configure(EntityTypeBuilder<TrackingDetail> builder)
        {
            builder.Property(T => T.Id)
                .HasColumnName("ID");

            builder.Property(T => T.Status)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired(true);
        }
    }
}
