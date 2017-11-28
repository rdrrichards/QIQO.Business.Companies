
using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class AttributeType : IModel
    {
        public AttributeType(AttributeTypeData attributeTypeData)
        {
            if (attributeTypeData == null) throw new System.ArgumentNullException(nameof(attributeTypeData));
            AttributeTypeId = attributeTypeData.AttributeTypeId;
            AttributeDataTypeKey = (QIQOAttributeDataType)attributeTypeData.AttributeDataTypeKey;
            AttributeDefaultFormat = attributeTypeData.AttributeDefaultFormat;
            AttributeTypeCode = attributeTypeData.AttributeTypeCode;
            AttributeTypeCategory = attributeTypeData.AttributeTypeCategory;
            AttributeTypeName = attributeTypeData.AttributeTypeName;
            AttributeTypeDesc = attributeTypeData.AttributeTypeDesc;
        }
        public AttributeType(AttributeType attributeType)
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
        public AttributeType(Guid attributeTypeId, QIQOAttributeDataType attributeDataTypeKey, string attributeDefaultFormat, 
            string attributeTypeCode, string attributeTypeName, string attributeTypeDesc, string attributeTypeCategory)
        {
            AttributeTypeId = attributeTypeId;
            AttributeDataTypeKey =  attributeDataTypeKey;
            AttributeDefaultFormat = attributeDefaultFormat;
            AttributeTypeCode = attributeTypeCode;
            AttributeTypeCategory = attributeTypeCategory;
            AttributeTypeName = attributeTypeName;
            AttributeTypeDesc = attributeTypeDesc;
        }

        public Guid AttributeTypeId { get; private set; }
        public QIQOAttributeDataType AttributeDataTypeKey { get; private set; }
        public string AttributeDefaultFormat { get; private set; }
        public string AttributeTypeCode { get; private set; }
        public string AttributeTypeCategory { get; private set; }
        public string AttributeTypeName { get; private set; }
        public string AttributeTypeDesc { get; private set; }
    }

}
