using QIQO.Business.Core.Contracts;
using System.ComponentModel.DataAnnotations;

namespace QIQO.Business.Companies.Data.Entities
{
    public class AttributeTypeData : IEntity
    {
        [Key]
        public int AttributeTypeKey { get; set; }
        public QIQOAttributeDataType AttributeDataTypeKey { get; set; }
        public string AttributeDefaultFormat { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "The max length of a attribute type code is 20 characters")]
        public string AttributeTypeCode { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "The max length of a attribute type category is 30 characters")]
        public string AttributeTypeCategory { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "The max length of a attribute type name is 150 characters")]
        public string AttributeTypeName { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "The max length of a attribute type description is 255 characters")]
        public string AttributeTypeDesc { get; set; }
    }

}
