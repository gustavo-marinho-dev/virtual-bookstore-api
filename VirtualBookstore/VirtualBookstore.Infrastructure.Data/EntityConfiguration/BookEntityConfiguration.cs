using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Domain.Entities;
using VirtualBookstore.Domain.Enums;

namespace VirtualBookstore.Infrastructure.Data.EntityConfiguration
{
    public class BookEntityConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> b)
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uniqueidentifier");

            b.Property<Backing>("Backing")
                .HasColumnType("varchar(50)");

            b.Property<string>("Categorie")
                .IsRequired()
                .HasColumnType("varchar(50)");

            b.Property<DateTimeOffset>("CreatedAt")
                .HasColumnType("datetimeoffset");

            b.Property<DateTimeOffset?>("DeletedAt")
                .HasColumnType("datetimeoffset");

            b.Property<string>("Dimensions")
                .IsRequired()
                .HasColumnType("varchar(50)");

            b.Property<string>("ISBN")
                .IsRequired()
                .HasColumnType("varchar(255)");

            b.Property<int>("Pages")
                .HasColumnType("int");

            b.Property<double>("Price")
                .HasColumnType("float");

            b.Property<DateTime>("PublicationYear")
                .HasColumnType("datetime2");

            b.Property<string>("Publisher")
                .IsRequired()
                .HasColumnType("varchar(255)");

            b.Property<double>("Rating")
                .HasColumnType("float");

            b.Property<Subject>("Subject")
                .HasColumnType("varchar(50)");

            b.Property<string>("Synopsis")
                .IsRequired()
                .HasColumnType("varchar(50)");

            b.Property<string>("Title")
                .IsRequired()
                .HasColumnType("varchar(255)");

            b.Property<DateTimeOffset?>("UpdatedAt")
                .HasColumnType("datetimeoffset");

            b.HasKey("Id");

            b.ToTable("Book");

            b.HasMany(e => e.Authors)
                .WithMany(e => e.Books)
        .        UsingEntity<BookAuthor>();
        }
    }
}
