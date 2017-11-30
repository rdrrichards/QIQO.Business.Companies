using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Companies.Model.Interfaces;
using QIQO.Business.Companies.Models;

namespace QIQO.Business.Companies.Model.Services
{
    public class ProductTypeEntityService : IProductTypeEntityService
    {
        public ProductType Map(ProductTypeData ent)
        {
            return new ProductType(ent);
        }

        public ProductTypeData Map(ProductType ent)
        {
            return new ProductTypeData
            {
                ProductTypeId = ent.ProductTypeId,
                ProductTypeCode = ent.ProductTypeCode,
                ProductTypeName = ent.ProductTypeName,
                ProductTypeDesc = ent.ProductTypeDesc,
                ProductTypeCategory = ent.ProductTypeCategory
            };
        }
    }
}
