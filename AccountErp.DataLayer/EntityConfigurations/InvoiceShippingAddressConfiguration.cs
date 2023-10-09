using AccountErp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.DataLayer.EntityConfigurations
{
    public class InvoiceShippingAddressConfiguration : IEntityTypeConfiguration<InvoiceShippingAddress>
    {

        public void Configure(EntityTypeBuilder<InvoiceShippingAddress> builder)
        {
            builder.ToTable("InvoiceShippingAddress");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            //   builder.Property(x => x.Name).IsRequired().HasMaxLength(250);
            //   builder.Property(x => x.SellingPrice).IsRequired().HasColumnType("NUMERIC(12,2)");
            //    builder.Property(x => x.BuyingPrice).IsRequired().HasColumnType("NUMERIC(12,2)");
            //   builder.Property(x => x.Description).IsRequired(false).HasMaxLength(1000);
            builder.Property(x => x.InvoiceId).IsRequired();
            builder.Property(x => x.Address).IsRequired(false);
            builder.Property(x => x.City).IsRequired(false);
            builder.Property(x => x.Country).IsRequired(false);
            builder.Property(x => x.State).IsRequired(false);
            builder.Property(x => x.PostalCode).IsRequired(false);
            builder.Property(x => x.CompanyName).IsRequired(false);
            builder.Property(x => x.RecipientName).IsRequired(false);

            builder.Property(x => x.CreatedOn).IsRequired();

            //builder.HasOne(x => x.Warehouse).WithMany().HasForeignKey(x => x.WareHouseId);

        }

    }
}
