using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class ProductType : IModel
    {
        public ProductType(ProductTypeData productTypeData)
        {
            if (productTypeData == null) throw new ArgumentNullException(nameof(productTypeData));
            ProductTypeId = productTypeData.ProductTypeId;
            ProductTypeCode = productTypeData.ProductTypeCode;
            ProductTypeCategory = productTypeData.ProductTypeCategory;
            ProductTypeName = productTypeData.ProductTypeName;
            ProductTypeDesc = productTypeData.ProductTypeDesc;
        }
        public ProductType(ProductType productType)
        {
            if (productType == null) throw new ArgumentNullException(nameof(productType));
            ProductTypeId = productType.ProductTypeId;
            ProductTypeCode = productType.ProductTypeCode;
            ProductTypeCategory = productType.ProductTypeCategory;
            ProductTypeName = productType.ProductTypeName;
            ProductTypeDesc = productType.ProductTypeDesc;
        }
        public Guid ProductTypeId { get; private set; }
        public string ProductTypeCode { get; private set; }
        public string ProductTypeCategory { get; private set; }
        public string ProductTypeName { get; private set; }
        public string ProductTypeDesc { get; private set; }
    }
}
