using AccountErp.Dtos;
using AccountErp.Dtos.PaymentMethod;
using AccountErp.Dtos.WareHouse;
using AccountErp.Entities;
using AccountErp.Models.WareHouse;
using AccountErp.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountErp.Infrastructure.Repositories
{
    public interface IPaymentMethodRepository
    {
        Task AddAsync(PaymentMethod entity);

        Task<bool> IsExistsAsync(string name);

        Task<bool> HasItemsAsync();

        Task<IEnumerable<SelectListItemDto>> GetSelectListItemsAsync();


        //Task AddAsync(WareHouse entity);

        void Edit(PaymentMethod entity);

        Task<PaymentMethod> GetAsync(int id);

        Task<PaymentMethodDetailDto> GetDetailAsync(int id);

        Task DeleteAsync(int id);

       
        Task<List<PaymentMethodDetailDto>> GetAllAsync(int PageSize, int Page);
    }
}
