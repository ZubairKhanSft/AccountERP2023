using AccountErp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.DataLayer.EntityConfigurations
{
    public class InvoiceServiceTagConfiguration : IEntityTypeConfiguration<InvoiceServiceTag>
    {
        public void Configure(EntityTypeBuilder<InvoiceServiceTag> builder)
        {
            builder.ToTable("InvoiceServiceTag");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedNever();


            builder.Property(x => x.InvoiceId).IsRequired();
            builder.Property(x => x.ProductId).IsRequired(false);
            builder.Property(x => x.Model).IsRequired();
            builder.Property(x => x.ServiceTag).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();

           
        }
    }
}
