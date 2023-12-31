﻿using AccountErp.Dtos.Vendor;
using AccountErp.Utilities;
using System;
using System.Collections.Generic;

namespace AccountErp.Dtos.Bill
{
    public class BillDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal? Tax { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal? Discount { get; set; }
        public string Remark { get; set; }
        public Constants.BillStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string RefrenceNumber { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? PoSoNumber { get; set; }
        public string StrBillDate { get; set; }
        public string StrDueDate { get; set; }
        public string Notes { get; set; }
        public string BillNumber { get; set; }
        public decimal? SubTotal { get; set; }
        public string CreatedBy { get; set; }

        public VendorPersonallnfoDto Vendor { get; set; }
        public Constants.InvoiceType BillType { get; set; }
        public IEnumerable<BillServiceDto> Items { get; set; }
        public IEnumerable<BillAttachmentDto> Attachments { get; set; }
        public BillServiceDto Bill { get; set; }

        public int? CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public double ConversionRate { get; set; }
        public double TotalAmountAfterConversion { get; set; }
        public string PaymentMethod { get; set; }

    }
}
