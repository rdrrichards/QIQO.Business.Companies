using System;
using System.ComponentModel.DataAnnotations;

namespace QIQO.Business.Companies.Data.Entities
{
    public class EntityType
    {
        [Key]
        public Guid EntityTypeId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "The max length of a entity type code is 20 characters")]
        public string EntityTypeCode { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "The max length of a entity type category is 30 characters")]
        public string EntityTypeCategory { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "The max length of a entity type name is 150 characters")]
        public string EntityTypeName { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "The max length of a entity type description is 255 characters")]
        public string EntityTypeDesc { get; set; }
    }
}
