using AccountErp.DataLayer.Repositories;
using AccountErp.Dtos.Customer;
using AccountErp.Dtos.ShippingMethod;
using AccountErp.Factories;
using AccountErp.Infrastructure.DataLayer;
using AccountErp.Infrastructure.Managers;
using AccountErp.Infrastructure.Repositories;
using AccountErp.Models.Customer;
using AccountErp.Models.ShippingMethod;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccountErp.Managers
{
    public class ShippingMethodManager : IShippingMethodManager
    { 
        private readonly IShippingMethodRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public ShippingMethodManager(IShippingMethodRepository repository,IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<int> AddAsync(AddShippingMethodModel model)
        {
            var customer = ShippingMethodFactory.Create(model);
            await _repository.AddAsync(customer);
            await _unitOfWork.SaveChangesAsync();
            return customer.Id;
        }

        public async Task EditAsync(AddShippingMethodModel model)
        {
            var shippingMethod = await _repository.GetAsync(model.Id);
            ShippingMethodFactory.Update(model, shippingMethod);
            _repository.Edit(shippingMethod);
            await _unitOfWork.SaveChangesAsync();

            
        }

        public async Task<ShippingMethodDetailDto> GetDetailAsync(int id)
        {
            return await _repository.GetDetailAsync(id);
        }

        public async Task<(List<ShippingMethodDetailDto>, int count)> GetAllAsync(int PageSize, int Page, string filterKey)
        {
            return await _repository.GetAllAsync(PageSize, Page, filterKey);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

    }
}
