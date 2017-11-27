using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Core.Contracts;
using System;
using System.Collections.Generic;

namespace QIQO.Business.Companies.Models
{
    public class Product : IModel
    {
        public Product(ProductData productData)
        {
            if (productData == null) throw new ArgumentNullException(nameof(productData));
            ProductId = productData.ProductId;
            CompanyId = productData.CompanyId;
            ProductCost = productData.ProductCost;
            ProductName = productData.ProductName;
            ProductDesc = productData.ProductDesc;
            ProductNameShort = productData.ProductNameShort;
            ProductNameLong = productData.ProductNameLong;
            ProductImagePath = productData.ProductImagePath;
            ProductBasePrice = productData.ProductBasePrice;
            ProductDefaultQuantity = productData.ProductDefaultQuantity;
            ProductIncomeAccount = productData.ProductIncomeAccount;
            ProductCost = productData.ProductCost;
            SetProductType(productData.ProductType);
        }
        public Product(Product product)
        {

            if (product == null) throw new ArgumentNullException(nameof(product));
            ProductId = product.ProductId;
            CompanyId = product.CompanyId;
            ProductCost = product.ProductCost;
            ProductName = product.ProductName;
            ProductDesc = product.ProductDesc;
            ProductNameShort = product.ProductNameShort;
            ProductNameLong = product.ProductNameLong;
            ProductImagePath = product.ProductImagePath;
            ProductBasePrice = product.ProductBasePrice;
            ProductDefaultQuantity = product.ProductDefaultQuantity;
            ProductIncomeAccount = product.ProductIncomeAccount;
            ProductCost = product.ProductCost;
            SetProductType(product.ProductType);
        }
        public Guid ProductId { get; private set; }
        public Guid CompanyId { get; private set; }
        public ProductType ProductType { get; private set; } = new ProductType(new ProductTypeData());
        public string ProductCode { get; private set; }
        public string ProductName { get; private set; }
        public string ProductDesc { get; private set; }
        public string ProductNameShort { get; private set; }
        public string ProductNameLong { get; private set; }
        public string ProductImagePath { get; private set; }
        public decimal ProductBasePrice { get; private set; }
        public decimal ProductCost { get; private set; }
        public int ProductDefaultQuantity { get; private set; }
        public string ProductIncomeAccount { get; private set; }

        private void SetProductType(ProductTypeData productTypeData)
        {
            if (productTypeData == null) throw new ArgumentNullException(nameof(productTypeData));
            ProductType = new ProductType(productTypeData);
        }

        private void SetProductType(ProductType productType)
        {
            if (productType == null) throw new ArgumentNullException(nameof(productType));
            ProductType = new ProductType(productType);
        }
    }
}
