using QIQO.Business.Core.Contracts;
using System;
using QIQO.Business.Companies.Data.Entities;

namespace QIQO.Business.Companies.Models
{
    public class EntityType : IModel
    {
        public EntityType(EntityTypeData entityTypeData)
        {
            if (entityTypeData == null) throw new ArgumentNullException(nameof(entityTypeData));
            EntityTypeId = entityTypeData.EntityTypeId;
            EntityTypeCode = entityTypeData.EntityTypeCode;
            EntityTypeName = entityTypeData.EntityTypeName;
            EntityTypeDesc = entityTypeData.EntityTypeDesc;
            EntityTypeCategory = entityTypeData.EntityTypeCategory;
        }
        public EntityType(EntityType entityType)
        {
            if (entityType == null) throw new ArgumentNullException(nameof(entityType));
            EntityTypeId = entityType.EntityTypeId;
            EntityTypeCode = entityType.EntityTypeCode;
            EntityTypeName = entityType.EntityTypeName;
            EntityTypeDesc = entityType.EntityTypeDesc;
            EntityTypeCategory = entityType.EntityTypeCategory;
        }
        public EntityType(Guid entityTypeId, string entityTypeCode, string entityTypeName, string entityTypeDesc, string entityTypeCategory)
        {
            EntityTypeId = entityTypeId;
            EntityTypeCode = entityTypeCode;
            EntityTypeName = entityTypeName;
            EntityTypeDesc = entityTypeDesc;
            EntityTypeCategory = entityTypeCategory;
        }

        public Guid EntityTypeId { get; private set; }
        public string EntityTypeCode { get; private set; }
        public string EntityTypeCategory { get; private set; }
        public string EntityTypeName { get; private set; }
        public string EntityTypeDesc { get; private set; }
    }
}
