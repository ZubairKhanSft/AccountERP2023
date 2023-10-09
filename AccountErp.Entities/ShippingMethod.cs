using AccountErp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.Entities
{
    public class ShippingMethod
    {
        public int Id { get; set; }
        public string ShippingMethodName { get; set; }
        public string ShippingMethodTerm { get; set; }
        public Constants.RecordStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set;  }
    }
}
