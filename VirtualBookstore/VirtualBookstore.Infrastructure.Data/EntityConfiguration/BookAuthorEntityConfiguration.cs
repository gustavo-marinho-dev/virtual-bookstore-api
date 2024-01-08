using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Domain.Entities;

namespace VirtualBookstore.Infrastructure.Data.EntityConfiguration
{
    public class BookAuthorEntityConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uniqueidentifier");

            builder.Property<Guid>("AuthorId")
                .HasColumnType("uniqueidentifier");

            builder.Property<Guid>("BookId")
                .HasColumnType("uniqueidentifier");

            builder.Property<DateTimeOffset>("CreatedAt")
                .HasColumnType("datetimeoffset");

            builder.Property<DateTimeOffset?>("DeletedAt")
                .HasColumnType("datetimeoffset");

            builder.Property<DateTimeOffset?>("UpdatedAt")
                .HasColumnType("datetimeoffset");

            builder.HasKey("Id");

            builder.HasIndex("AuthorId");

            builder.HasIndex("BookId");

            builder.ToTable("BookAuthor");
        }
    }
}
