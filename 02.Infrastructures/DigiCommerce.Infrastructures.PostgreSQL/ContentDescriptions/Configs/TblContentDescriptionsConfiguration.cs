﻿using DigiCommerce.Core.Domain.ContentDescriptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.ContentDescriptions.Configs
{
    public class TblContentDescriptionsConfiguration : IEntityTypeConfiguration<TblContentDescriptions>
    {
        public void Configure(EntityTypeBuilder<TblContentDescriptions> builder)
        {
            builder.ToTable("Tbl_ContentDescriptions");

            builder.Property(e => e.HtmlDescription).IsRequired();

            builder.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
