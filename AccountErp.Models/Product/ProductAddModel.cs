﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AccountErp.Models.Product
{
    public class ProductAddModel
    {

        public string Model { get; set; }
        public string Specification { get; set; }
        public string Brands { get; set; }
        public int Units { get; set; }
        public double RateUSD { get; set; }
        public double RateAED { get; set; }
        public string PartNumber { get; set; }
        public string UAN { get; set; }
        public string SupplierCode { get; set; }
        public int? ProductCategoryId { get; set; }
        // public int? WarehouseId { get; set; }
        public string FileUrl { get; set; }

    }
}
