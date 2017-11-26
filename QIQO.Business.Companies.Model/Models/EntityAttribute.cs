using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class EntityAttribute : IModel
    {
        public Guid AttributeId { get; set; }
        public Guid EntityId { get; set; }
        public EntityType EntityType { get; set; }
        public AttributeType AttributeType { get; set; }
        public string AttributeValue { get; set; }
        public string AttributeDataType { get; set; }
        public string AttributeDisplayFormat { get; set; }
    }
}
