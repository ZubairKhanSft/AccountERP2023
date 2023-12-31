﻿using AccountErp.Dtos.Quotation;
using AccountErp.Entities;
using AccountErp.Models.Quotation;
using AccountErp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountErp.Infrastructure.Repositories
{
    public interface IQuotationRepository
    {
        Task AddAsync(Quotation entity);

        void Edit(Quotation entity);

        Task<Quotation> GetAsync(int id);

        Task<QuotationDetailDto> GetDetailAsync(int id);

        Task<QuotationDeatilForEditDto> GetForEditAsync(int id);

        Task<JqDataTableResponse<QuotationListItemDto>> GetPagedResultAsync(QuotationJqDataTableRequestModel model);
        Task<(List<QuotationDetailDto>, int count)> GetAllAsync(int PageSize,int Page, string FilterKey, DateTime? QuotationDate);
        Task<List<QuotationDetailDto>> QuotationReportAsync(int customerId,DateTime From,DateTime To);
        Task<(List<QuotationDetailDto>, int count)> GetAllAsync();
        Task<List<QuotationListItemDto>> GetRecentAsync();

        Task<QuotationSummary> GetSummaryAsunc(int id);

        Task UpdateStatusAsync(int id, Constants.InvoiceStatus status);

        Task DeleteAsync(int id);

        Task<int> getCount();
    }
}
