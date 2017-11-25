
namespace QIQO.Business.Companies.Models
{
    public class AttributeType
    {
        public int AttributeTypeKey { get; set; }
        public QIQOAttributeDataType AttributeDataTypeKey { get; set; }
        public string AttributeDefaultFormat { get; set; }
        public string AttributeTypeCode { get; set; }
        public string AttributeTypeCategory { get; set; }
        public string AttributeTypeName { get; set; }
        public string AttributeTypeDesc { get; set; }
    }

}
