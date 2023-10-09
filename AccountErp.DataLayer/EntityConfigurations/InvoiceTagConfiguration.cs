using AccountErp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.DataLayer.EntityConfigurations
{
    public class InvoiceTagConfiguration : IEntityTypeConfiguration<InvoiceTag>
    {
        public void Configure(EntityTypeBuilder<InvoiceTag> builder)
        {
            builder.ToTable("InvoiceTag");
            builder.HasKey(x => x.id);

            builder.Property(x => x.id).ValueGeneratedOnAdd();


            builder.Property(x => x.InvoiceId).IsRequired();
            builder.Property(x => x.ProductId).IsRequired(false);
            builder.Property(x => x.Model).IsRequired();
            builder.Property(x => x.ServiceTag).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();


        }
    }
}
