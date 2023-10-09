using AccountErp.Dtos.ShippingMethod;
using AccountErp.Dtos.Vendor;
using AccountErp.Dtos.WareHouse;
using AccountErp.Entities;
using AccountErp.Infrastructure.DataLayer;
using AccountErp.Models.ShippingMethod;
using AccountErp.Models.WareHouse;
using AccountErp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccountErp.Infrastructure.Repositories
{
    public interface IShippingMethodRepository
    {

        Task AddAsync(ShippingMethod entity);

        void Edit(ShippingMethod entity);

        Task<ShippingMethod> GetAsync(int id);

        Task<ShippingMethodDetailDto> GetDetailAsync(int id);

        Task DeleteAsync(int id);
        Task<(List<ShippingMethodDetailDto>, int count)> GetAllAsync(int PageSize, int Page, string filterKey);


       // Task<List<ShippingMethodDetailDto>> GetAllAsync(int PageSize, int Page,string Filter);
    }
}
