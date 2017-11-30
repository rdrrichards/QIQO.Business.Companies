using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class EntityAttribute : IModel
    {
        public EntityAttribute(EntityAttributeData entityAttributeData)
        {
            if (entityAttributeData == null) throw new ArgumentNullException(nameof(entityAttributeData));
            AttributeId = entityAttributeData.AttributeId;
            EntityId = entityAttributeData.AttributeEntityId;
            AttributeValue = entityAttributeData.AttributeValue;
            AttributeDataType = entityAttributeData.AttributeDataType;
            AttributeDisplayFormat = entityAttributeData.AttributeDisplayFormat;
            EntityType = new EntityType(entityAttributeData.AttributeEntityType);
            AttributeType = new AttributeType(entityAttributeData.AttributeType);
        }
        public EntityAttribute(EntityAttribute entityAttribute)
        {
            if (entityAttribute == null) throw new ArgumentNullException(nameof(entityAttribute));
            AttributeId = entityAttribute.AttributeId;
            EntityId = entityAttribute.EntityId;
            AttributeValue = entityAttribute.AttributeValue;
            AttributeDataType = entityAttribute.AttributeDataType;
            AttributeDisplayFormat = entityAttribute.AttributeDisplayFormat;
            EntityType = new EntityType(entityAttribute.EntityType);
            AttributeType = new AttributeType(entityAttribute.AttributeType);
        }
        public EntityAttribute(Guid entityAttributeId, Guid entityId, string attributeValue, string attributeDataType, string attributeDisplayFormat,
            EntityType entityType, AttributeType attributeType)
        {
            AttributeId = entityAttributeId;
            EntityId = entityId;
            AttributeValue = attributeValue;
            AttributeDataType = attributeDataType;
            AttributeDisplayFormat = attributeDisplayFormat;
            EntityType = new EntityType(entityType);
            AttributeType = new AttributeType(attributeType);
        }
        public Guid AttributeId { get; private set; }
        public Guid EntityId { get; private set; }
        public EntityType EntityType { get; private set; } = new EntityType(new EntityTypeData());
        public AttributeType AttributeType { get; private set; } = new AttributeType(new AttributeTypeData());
        public string AttributeValue { get; private set; }
        public string AttributeDataType { get; private set; }
        public string AttributeDisplayFormat { get; private set; }
    }
}
