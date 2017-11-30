using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Companies.Model.Interfaces;
using QIQO.Business.Companies.Models;

namespace QIQO.Business.Companies.Model.Services
{
    public class AttributeTypeEntityService : IAttributeTypeEntityService
    {
        public AttributeType Map(AttributeTypeData ent)
        {
            return new AttributeType(ent);
        }

        public AttributeTypeData Map(AttributeType ent)
        {
            return new AttributeTypeData
            {
                AttributeTypeId = ent.AttributeTypeId,
                AttributeTypeCode = ent.AttributeTypeCode,
                AttributeTypeName = ent.AttributeTypeName,
                AttributeTypeDesc = ent.AttributeTypeDesc,
                AttributeTypeCategory = ent.AttributeTypeCategory
            };
        }
    }
}
