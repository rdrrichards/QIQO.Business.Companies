using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class EntityAttribute
    {
        [Key]
        public Guid AttributeId { get; set; }
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        // [ForeignKey("AttributeType")]
        // public QIQOAttributeType AttributeTypeKey { get; set; }
        public AttributeType AttributeType { get; set; }
        public string AttributeValue { get; set; }
        [MaxLength(20, ErrorMessage = "The attribute data type name cannot be longer than 20 characters")]
        public string AttributeDataType { get; set; }
        [MaxLength(100, ErrorMessage = "The attribute display format name cannot be longer than 100 characters")]
        public string AttributeDisplayFormat { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(30, ErrorMessage = "The added user id cannot be longer than 30 characters")]
        public string AddedUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime AddedDateTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(30, ErrorMessage = "The updated user id cannot be longer than 30 characters")]
        public string UpdateUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDateTime { get; set; }

    }

}
