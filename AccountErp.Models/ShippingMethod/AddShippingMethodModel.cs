using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.Models.ShippingMethod
{
    public class AddShippingMethodModel
    {
        public int Id { get; set; }
        public string ShippingMethodName { get; set; }
        public string ShippingMethodTerm { get; set; }
       
    }
}
