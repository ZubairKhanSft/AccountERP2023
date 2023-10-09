using AccountErp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.DataLayer.EntityConfigurations
{
    public class ShippingMethodConfiguration : IEntityTypeConfiguration<ShippingMethod>
    {
        public void Configure(EntityTypeBuilder<ShippingMethod> builder)
        {
            builder.ToTable("ShippingMethod");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.ShippingMethodName).IsRequired();

            builder.Property(x => x.ShippingMethodTerm).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CreatedOn).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.UpdatedOn).IsRequired(false).HasMaxLength(100);
           // builder.Property(x => x.PostalCode).IsRequired(false).HasMaxLength(50);

           

        }
    }
}
