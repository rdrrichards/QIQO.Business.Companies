using System;
using System.ComponentModel.DataAnnotations;

namespace QIQO.Business.Companies.Data.Entities
{
    public class ProductType
    {
        [Key]
        public Guid ProductTypeId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "The max length of a product type code is 20 characters")]
        public string ProductTypeCode { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "The max length of a product type category is 30 characters")]
        public string ProductTypeCategory { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "The max length of a product type name is 150 characters")]
        public string ProductTypeName { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "The max length of a product type description is 255 characters")]
        public string ProductTypeDesc { get; set; }

    }

}
