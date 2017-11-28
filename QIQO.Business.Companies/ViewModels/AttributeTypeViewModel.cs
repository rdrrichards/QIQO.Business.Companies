using QIQO.Business.Companies.Models;
using System;

namespace QIQO.Business.Companies.ViewModels
{
    public class AttributeTypeViewModel
    {
        public AttributeTypeViewModel() { }
        public AttributeTypeViewModel(AttributeType attributeType)
        {
            if (attributeType == null) throw new System.ArgumentNullException(nameof(attributeType));
            AttributeTypeId = attributeType.AttributeTypeId;
            AttributeDataTypeKey = attributeType.AttributeDataTypeKey;
            AttributeDefaultFormat = attributeType.AttributeDefaultFormat;
            AttributeTypeCode = attributeType.AttributeTypeCode;
            AttributeTypeCategory = attributeType.AttributeTypeCategory;
            AttributeTypeName = attributeType.AttributeTypeName;
            AttributeTypeDesc = attributeType.AttributeTypeDesc;
        }

        public Guid AttributeTypeId { get; set; }
        public QIQOAttributeDataType AttributeDataTypeKey { get; set; }
        public string AttributeDefaultFormat { get; set; }
        public string AttributeTypeCode { get; set; }
        public string AttributeTypeCategory { get; set; }
        public string AttributeTypeName { get; set; }
        public string AttributeTypeDesc { get; set; }
    }
}
