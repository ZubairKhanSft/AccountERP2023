using AccountErp.Entities;
using AccountErp.Models.ShippingMethod;
using AccountErp.Models.WareHouse;
using AccountErp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.Factories
{
    public class ShippingMethodFactory
    {

        public static ShippingMethod Create(AddShippingMethodModel model)
        {
            var prod = new ShippingMethod
            {
                ShippingMethodName = model.ShippingMethodName,
                ShippingMethodTerm = model.ShippingMethodTerm,
                Status = Constants.RecordStatus.Active,
                CreatedOn = Utility.GetDateTime(),

            };
            return prod;
        }
        public static void Update(AddShippingMethodModel model, ShippingMethod entity)
        {
            entity.ShippingMethodName = model.ShippingMethodName != null ? model.ShippingMethodName : entity.ShippingMethodName;
            entity.ShippingMethodTerm = model.ShippingMethodTerm != null ? model.ShippingMethodTerm : entity.ShippingMethodTerm;
           
            entity.UpdatedOn = Utility.GetDateTime();

        }
    }
}
