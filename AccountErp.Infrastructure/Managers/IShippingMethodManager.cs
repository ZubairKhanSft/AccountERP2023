using AccountErp.Dtos.Customer;
using AccountErp.Dtos;
using AccountErp.Models.Customer;
using AccountErp.Models.Payment;
using AccountErp.Models.ShippingAddress;
using AccountErp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AccountErp.Models.ShippingMethod;
using AccountErp.Dtos.ShippingMethod;

namespace AccountErp.Infrastructure.Managers
{
    public interface IShippingMethodManager
    {

        Task<int> AddAsync(AddShippingMethodModel model);
        
        Task EditAsync(AddShippingMethodModel model);

        Task<ShippingMethodDetailDto> GetDetailAsync(int id);

        Task<(List<ShippingMethodDetailDto>, int count)> GetAllAsync(int PageSize, int Page, string filterKey);

       
        Task DeleteAsync(int id);

       


    }
}
