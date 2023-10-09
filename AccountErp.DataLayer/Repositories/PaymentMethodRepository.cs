using AccountErp.Dtos;
using AccountErp.Dtos.PaymentMethod;
using AccountErp.Dtos.WareHouse;
using AccountErp.Entities;
using AccountErp.Infrastructure.Repositories;
using AccountErp.Models.WareHouse;
using AccountErp.Utilities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountErp.DataLayer.Repositories
{
    public class PaymentMethodRepository : IPaymentMethodRepository
    {
        private readonly DataContext _dataContext;

        public PaymentMethodRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task AddAsync(PaymentMethod entity)
        {
            await _dataContext.PaymentMethods.AddAsync(entity);
        }

        public async Task<bool> IsExistsAsync(string name)
        {
            return await _dataContext.PaymentMethods.AnyAsync(
                x => x.Name.Equals(name) && x.Status != Constants.RecordStatus.Deleted);
        }

        public async Task<bool> HasItemsAsync()
        {
            return await _dataContext.PaymentMethods.AnyAsync();
        }

        public async Task<IEnumerable<SelectListItemDto>> GetSelectListItemsAsync()
        {
            return await _dataContext.PaymentMethods
                .Where(x => x.Status != Constants.RecordStatus.Deleted)
                .Select(x => new SelectListItemDto
                {
                    KeyInt = x.Id,
                    Value = x.Name
                })
                .ToListAsync();
        }





        public void Edit(PaymentMethod entity)
        {
            _dataContext.Update(entity);
        }
        public async Task<PaymentMethod> GetAsync(int id)
        {
            return await _dataContext.PaymentMethods.FindAsync(id);
        }

        public async Task<PaymentMethodDetailDto> GetDetailAsync(int id)
        {
            return await (from s in _dataContext.PaymentMethods
                          where s.Id == id
                          select new PaymentMethodDetailDto
                          {
                              Id = s.Id,
                              Name = s.Name,
                              Status = s.Status,
                             

                          })
                          .AsNoTracking()
                          .SingleOrDefaultAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var warehouse = await _dataContext.PaymentMethods.FindAsync(id);
            warehouse.Status = Constants.RecordStatus.Deleted;
            _dataContext.PaymentMethods.Update(warehouse);

        }
       

       

        public async Task<List<PaymentMethodDetailDto>> GetAllAsync(int PageSize, int Page)
        {
            if (PageSize != 0 && Page != 0)
            {
                return await (from s in _dataContext.PaymentMethods
                              where s.Status != Constants.RecordStatus.Deleted
                              select new PaymentMethodDetailDto
                              {
                                  Id = s.Id,
                                  Name = s.Name,
                                  Status = s.Status,
                                  
                              })
                             .AsNoTracking()
                             .OrderByDescending(s => s.Id)
                             .Skip((Page - 1) * PageSize)
                             .Take(PageSize)
                             .ToListAsync();
            }
            else
            {
                return await (from s in _dataContext.PaymentMethods
                              where s.Status != Constants.RecordStatus.Deleted
                              select new PaymentMethodDetailDto 
                              { Id = s.Id, Name = s.Name, Status = s.Status })
                            .AsNoTracking()
                            .OrderByDescending(s => s.Id)
                            .ToListAsync();
            }
        }

    }
}
