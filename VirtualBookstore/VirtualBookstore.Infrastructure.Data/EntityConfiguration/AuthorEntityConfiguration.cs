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
    public class AuthorEntityConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uniqueidentifier");

            builder.Property<string>("Biography")
                .IsRequired()
                .HasColumnType("varchar(1000)"); 

            builder.Property<DateTimeOffset>("CreatedAt")
                .HasColumnType("datetimeoffset");

            builder.Property<DateTime>("DateOfBirth")
                .HasColumnType("datetime2");

            builder.Property<DateTimeOffset?>("DeletedAt")
                .HasColumnType("datetimeoffset");

            builder.Property<string>("FullName")
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property<string>("Nationality")
                .IsRequired()
                .HasColumnType("varchar(50)"); 

            builder.Property<DateTimeOffset?>("UpdatedAt")
                .HasColumnType("datetimeoffset");

            builder.HasKey("Id");

            builder.ToTable("Author");

            builder.HasMany(e => e.Books)
                .WithMany(e => e.Authors)
                .UsingEntity<BookAuthor>();
        }
    }
}
