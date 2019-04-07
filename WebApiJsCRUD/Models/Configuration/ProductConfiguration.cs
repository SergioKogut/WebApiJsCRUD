using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApiJsCRUD.Models.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("tblProduct");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Price).HasColumnName("Price").IsRequired();
        }

    }
}
