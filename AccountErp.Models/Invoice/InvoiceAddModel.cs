using AccountErp.Models.InvoiceServiceTag;
using AccountErp.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountErp.Models.Invoice
{
    public class InvoiceAddModel
    {
        [Required]
        public int CustomerId { get; set; }

        public decimal? Tax { get; set; }

        public decimal? Discount { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        public string Remark { get; set; }

        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal? PoSoNumber { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? LineAmountSubTotal { get; set; }

        public Constants.InvoiceType InvoiceType { get; set; }
        [Required]
        public List<InvoiceServiceModel> Items { get; set; }

        public List<InvoiceAttachmentAddModel> Attachments { get; set; }
        public int UserId { get; set; }
        public int CurrencyId { get; set; }
        public decimal VatAmount { get; set; }
        public string SalesOrderNumber { get; set; }
        public double ConversionRate { get; set; }
        public double TotalAmountAfterConversion { get; set; }


        public string ShippingAddress { get; set; }
        public string ShippingMethod { get; set; }
        public string ShippingTerm { get; set; }
        public string PaymentTerm { get; set; }


       
        public string RecipientName { get; set; }
        public string ShippingCompanyName { get; set; }
        public string ShippingCountry { get; set; }

        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingTRN { get; set; }
        public Constants.InvoiceValue InvoiceValue { get; set; }
       // public List<AddInvoiceServiceTagModel> InvoiceServiceTag { get; set; }
    }
}
