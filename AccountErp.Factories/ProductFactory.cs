using AccountErp.Entities;
using AccountErp.Models.Product;
using AccountErp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountErp.Factories
{
    public class ProductFactory
    {
        public static Product Create(ProductAddModel model, string userId)
        {
            var prod = new Product
            {
               
                ProductCategoryId = model.ProductCategoryId,
                Model = model.Model,
                Specification = model.Specification,
                Brands = model.Brands,
                Units = model.Units,
                RateAED = model.RateAED,
                RateUSD = model.RateUSD,
                PartNumber = model.PartNumber,
                UPC = model.UAN,
                SupplierCode = model.SupplierCode,
                Status = Constants.RecordStatus.Active,
                CreatedBy = userId ?? "0",
                CreatedOn = Utility.GetDateTime(),
            
             AttachmentName = model.FileUrl,
            };
            return prod;
        }

        public static void Create(ProductEditModel model, Product entity, string userId)
        {
            entity.ProductCategoryId = model.ProductCategoryId;
            entity.Model = model.Model != null ? model.Model : entity.Model;
            entity.Specification = model.Specification != null ? model.Specification : entity.Specification;
            entity.Brands = model.Brands != null ? model.Brands : entity.Brands;
            entity.Units = model.Units != 0 ? model.Units : entity.Units;
            entity.RateUSD = model.RateUSD != 0 ? model.RateUSD : entity.RateUSD;
            entity.RateAED = model.RateAED != 0 ? model.RateAED : entity.RateAED;
            entity.PartNumber = model.PartNumber != null  ? model.PartNumber : entity.PartNumber;
            entity.UPC = model.UAN != null ? model.UAN : entity.UPC;
            entity.SupplierCode = model.SupplierCode != null ? model.SupplierCode : entity.SupplierCode;


           

            entity.UpdatedBy = userId ?? "0";
            entity.UpdatedOn = Utility.GetDateTime();
            entity.AttachmentName = model.FileUrl != null ? model.FileUrl : entity.AttachmentName;

        }
    }
    
}
