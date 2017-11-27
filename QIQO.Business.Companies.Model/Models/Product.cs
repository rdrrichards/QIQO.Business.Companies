﻿using QIQO.Business.Core.Contracts;
using System;
using System.Collections.Generic;

namespace QIQO.Business.Companies.Models
{
    public class Product : IModel
    {
        public Guid ProductId { get; set; }
        public Guid CompanyId { get; set; }
        public ProductType ProductType => new ProductType();
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public string ProductNameShort { get; set; }
        public string ProductNameLong { get; set; }
        public string ProductImagePath { get; set; }
        public decimal ProductBasePrice { get; set; }
        public decimal ProductCost { get; set; }
        public int ProductDefaultQuantity { get; set; }
        public string ProductIncomeAccount { get; set; }
    }
}
