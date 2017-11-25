using System;
using System.ComponentModel.DataAnnotations;

namespace QIQO.Business.Companies.Data.Entities
{
    public class AddressType
    {
        [Key]
        public Guid AddressTypeId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "The max length of a address type code is 20 characters")]
        public string AddressTypeCode { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "The max length of a address type category is 30 characters")]
        public string AddressTypeCategory { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "The max length of a address type name is 150 characters")]
        public string AddressTypeName { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "The max length of a address type description is 255 characters")]
        public string AddressTypeDesc { get; set; }
    }
}
