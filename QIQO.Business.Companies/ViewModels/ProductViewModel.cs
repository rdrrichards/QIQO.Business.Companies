using QIQO.Business.Companies.Models;
using System;

namespace QIQO.Business.Companies.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel() { }
        public ProductViewModel(Product product)
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
        public Guid ProductId { get; set; }
        public Guid CompanyId { get; set; }
        public ProductTypeViewModel ProductType { get; set; } = new ProductTypeViewModel();
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

        void SetProductType(ProductType productType)
        {
            if (productType == null) throw new ArgumentNullException(nameof(productType));
            ProductType = new ProductTypeViewModel(productType);
        }
    }
}
