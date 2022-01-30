﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW6.Data.Entities;

namespace Module4HW6.Data.EntityConfigurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre").HasKey(g => g.Id);
            builder.Property(g => g.Id).HasColumnName("GenreId").ValueGeneratedOnAdd();
            builder.HasAlternateKey(g => g.Title);
            builder.Property(g => g.Title).IsRequired().HasMaxLength(50);
        }
    }
}
