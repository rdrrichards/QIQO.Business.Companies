using QIQO.Business.Companies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QIQO.Business.Companies.ViewModels
{
    public class EntityAttributeViewModel
    {
        public EntityAttributeViewModel() { }
        public EntityAttributeViewModel(EntityAttribute entityAttribute)
        {
            if (entityAttribute == null) throw new ArgumentNullException(nameof(entityAttribute));
            AttributeId = entityAttribute.AttributeId;
            EntityId = entityAttribute.EntityId;
            AttributeValue = entityAttribute.AttributeValue;
            AttributeDataType = entityAttribute.AttributeDataType;
            AttributeDisplayFormat = entityAttribute.AttributeDisplayFormat;
            EntityType = new EntityTypeViewModel(entityAttribute.EntityType);
            AttributeType = new AttributeTypeViewModel(entityAttribute.AttributeType);
        }
        public Guid AttributeId { get; set; }
        public Guid EntityId { get; set; }
        public EntityTypeViewModel EntityType { get; set; } = new EntityTypeViewModel();
        public AttributeTypeViewModel AttributeType { get; set; } = new AttributeTypeViewModel();
        public string AttributeValue { get; set; }
        public string AttributeDataType { get; set; }
        public string AttributeDisplayFormat { get; set; }
    }
}
