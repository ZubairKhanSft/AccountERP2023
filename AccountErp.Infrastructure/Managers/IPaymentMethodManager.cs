using AccountErp.Dtos.PaymentMethod;
using AccountErp.Dtos.WareHouse;
using AccountErp.Models.PaymentMethod;
using AccountErp.Models.WareHouse;
using AccountErp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccountErp.Infrastructure.Managers
{
    public interface IPaymentMethodManager
    {
        Task AddAsync(AddPaymentMethodModel model);

        Task EditAsync(AddPaymentMethodModel model);


        Task<PaymentMethodDetailDto> GetDetailAsync(int id);

        Task DeleteAsync(int id);

      
      //  Task<IEnumerable<WareHouseDetailsDto>> GetAllAsync(Constants.RecordStatus? status = null);
        Task<List<PaymentMethodDetailDto>> GetAllAsync(int PageSize, int Page);
    }
}
