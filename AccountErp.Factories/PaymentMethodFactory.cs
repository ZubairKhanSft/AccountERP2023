using AccountErp.Entities;
using AccountErp.Models.Address;
using AccountErp.Models.Payment;
using AccountErp.Models.PaymentMethod;
using AccountErp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.Factories
{
    public class PaymentMethodFactory
    {
        public static PaymentMethod Create(AddPaymentMethodModel model)
        {
            var paymentMethod = new PaymentMethod()
            {
                Name = model.Name,
                Status = Constants.RecordStatus.Active,
                
            };

            return paymentMethod;
        }

        public static void Create(AddPaymentMethodModel model, PaymentMethod entity)
        {
            entity.Name = model.Name != null ? model.Name : entity.Name;
          
        }
    }
}
