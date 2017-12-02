using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Companies.Model.Interfaces;
using QIQO.Business.Companies.Models;
using System;

namespace QIQO.Business.Companies.Model.Services
{
    public class EntityAttributeEntityService : IEntityAttributeEntityService
    {
        public EntityAttribute Map(EntityAttributeData ent)
        {
            return new EntityAttribute(ent);
        }

        public EntityAttributeData Map(EntityAttribute ent)
        {
            return new EntityAttributeData
            {
                AttributeId = ent.AttributeId != default(Guid) ? ent.AttributeId : Guid.NewGuid(),
                AttributeEntityId = ent.EntityId,
                AttributeEntityTypeId = ent.EntityType.EntityTypeId,
                AttributeTypeId = ent.AttributeType.AttributeTypeId,
                AttributeValue = ent.AttributeValue,
                AttributeDataType = ent.AttributeDataType,
                AttributeDisplayFormat = ent.AttributeDisplayFormat
            };
        }
    }
}
