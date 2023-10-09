using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.Entities
{
    public class InvoiceTag
    {
        public int id { get; set; }
        public int InvoiceId { get; set; }
        public int? ProductId { get; set; }
        public string Model { get; set; }
        public string ServiceTag { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
