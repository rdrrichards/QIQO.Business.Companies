using QIQO.Business.Companies.Models;
using System;

namespace QIQO.Business.Companies.ViewModels
{
    public class ProductTypeViewModel
    {
        public ProductTypeViewModel() { }
        public ProductTypeViewModel(ProductType productType)
        {
            if (productType == null) throw new ArgumentNullException(nameof(productType));
            ProductTypeId = productType.ProductTypeId;
            ProductTypeCode = productType.ProductTypeCode;
            ProductTypeCategory = productType.ProductTypeCategory;
            ProductTypeName = productType.ProductTypeName;
            ProductTypeDesc = productType.ProductTypeDesc;
        }
        public Guid ProductTypeId { get; set; }
        public string ProductTypeCode { get; set; }
        public string ProductTypeCategory { get; set; }
        public string ProductTypeName { get; set; }
        public string ProductTypeDesc { get; set; }
    }
}
