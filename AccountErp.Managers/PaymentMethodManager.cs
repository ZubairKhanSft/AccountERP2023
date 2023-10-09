using AccountErp.Dtos.PaymentMethod;
using AccountErp.Dtos.WareHouse;
using AccountErp.Factories;
using AccountErp.Infrastructure.DataLayer;
using AccountErp.Infrastructure.Managers;
using AccountErp.Infrastructure.Repositories;
using AccountErp.Models.PaymentMethod;
using AccountErp.Models.WareHouse;
using AccountErp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccountErp.Managers
{
    public class PaymentMethodManager : IPaymentMethodManager
    {
        private readonly IPaymentMethodRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public PaymentMethodManager(IPaymentMethodRepository repository,IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(AddPaymentMethodModel model)
        {
            await _repository.AddAsync(PaymentMethodFactory.Create(model));
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task EditAsync(AddPaymentMethodModel model)
        {
            var warehouse = await _repository.GetAsync(model.Id);
            PaymentMethodFactory.Create(model, warehouse);
            _repository.Edit(warehouse);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<PaymentMethodDetailDto> GetDetailAsync(int id)
        {
            return await _repository.GetDetailAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<PaymentMethodDetailDto>> GetAllAsync(int PageSize, int Page)
        {
            return await _repository.GetAllAsync(PageSize, Page);
        }
    }
}
