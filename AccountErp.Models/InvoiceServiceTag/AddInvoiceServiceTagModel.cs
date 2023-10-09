using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.Models.InvoiceServiceTag
{
    public class AddInvoiceServiceTagModel
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int? ProductId { get; set; }
        public string Model { get; set; }
        public string ServiceTag { get; set; }
    }
}
