using AccountErp.Entities;
using AccountErp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AccountErp.Dtos.Vendor;
using AccountErp.Utilities;
using AccountErp.Dtos.ShippingMethod;

namespace AccountErp.DataLayer.Repositories
{
    public class ShippingMethodRepository : IShippingMethodRepository
    {
        private readonly DataContext _dataContext;
        public ShippingMethodRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task AddAsync(ShippingMethod entity)
        {
            await _dataContext.ShippingMethods.AddAsync(entity);
        }

        public void Edit(ShippingMethod entity)
        {
            _dataContext.ShippingMethods.Update(entity);
        }

        public async Task<ShippingMethod> GetAsync(int id)
        {
            return await _dataContext.ShippingMethods
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task<ShippingMethodDetailDto> GetDetailAsync(int id)
        {
            return await (from s in _dataContext.ShippingMethods
                          where s.Id == id && s.Status != Constants.RecordStatus.Deleted
                          select new ShippingMethodDetailDto
                          {
                              Id = s.Id,
                              ShippingMethodName = s.ShippingMethodName,
                              ShippingMethodTerm = s.ShippingMethodTerm,
                              Status = s.Status,
                              CreatedOn = s.CreatedOn,
                              UpdatedOn = s.UpdatedOn,
                          })
                         .AsNoTracking()
                         .SingleOrDefaultAsync();
        }


        public async Task<(List<ShippingMethodDetailDto>, int count)> GetAllAsync(int PageSize, int Page, string FilterKey)
        {
            int count = 0;
            var response = new List<ShippingMethodDetailDto>();
            count = await _dataContext.ShippingMethods.Where(s => s.Status != Constants.RecordStatus.Deleted).CountAsync();

            if (PageSize != 0 && Page != 0)
            {
                response = await (from s in _dataContext.ShippingMethods
                                  where s.Status != Constants.RecordStatus.Deleted
                                   && (FilterKey == null
                                     //   || EF.Functions.Like(s.Id.ToString(), "%" + FilterKey + "%")
                                     || EF.Functions.Like(s.ShippingMethodName.ToString(), "%" + FilterKey + "%")
                                      || EF.Functions.Like(s.ShippingMethodTerm.ToString(), "%" + FilterKey + "%"))
                                  select new ShippingMethodDetailDto
                                  {
                                      Id = s.Id,
                                      ShippingMethodName = s.ShippingMethodName,
                                      ShippingMethodTerm = s.ShippingMethodTerm,
                                      Status = s.Status,
                                      CreatedOn = s.CreatedOn,
                                      UpdatedOn = s.UpdatedOn,
                                  })
                              .AsNoTracking()
                              .OrderByDescending(s => s.Id)
                              .Skip((Page - 1) * PageSize)
                              .Take(PageSize)
                              .ToListAsync();
                return (response, count);
            }
            else
            {
                response = await (from s in _dataContext.ShippingMethods
                                  where s.Status != Constants.RecordStatus.Deleted
                                  && (FilterKey == null
                                     //      || EF.Functions.Like(s.Id.ToString(), "%" + FilterKey + "%")
                                     || EF.Functions.Like(s.ShippingMethodName.ToString(), "%" + FilterKey + "%")
                                      || EF.Functions.Like(s.ShippingMethodTerm.ToString(), "%" + FilterKey + "%"))
                                  select new ShippingMethodDetailDto
                                  {
                                      Id = s.Id,
                                      ShippingMethodName = s.ShippingMethodName,
                                      ShippingMethodTerm = s.ShippingMethodTerm,
                                      Status = s.Status,
                                      CreatedOn = s.CreatedOn,
                                      UpdatedOn = s.UpdatedOn,
                                  })
                              .AsNoTracking()
                              .ToListAsync();
                return (response, count);

            }
        }



        public async Task DeleteAsync(int id)
        {
            var vendor = await _dataContext.ShippingMethods.FindAsync(id);
            vendor.Status = Constants.RecordStatus.Deleted;
            _dataContext.ShippingMethods.Update(vendor);
        }
    }
}
