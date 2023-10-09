using AccountErp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.Entities
{
    public class InvoiceShippingAddress
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string RecipientName { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
