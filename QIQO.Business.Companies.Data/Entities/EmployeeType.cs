using QIQO.Business.Core.Contracts;
using System;
using System.ComponentModel.DataAnnotations;

namespace QIQO.Business.Companies.Data.Entities
{
    public class EmployeeTypeData : IEntity
    {
        [Key]
        public Guid EmployeeTypeId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "The max length of a employee type code is 20 characters")]
        public string EmployeeTypeCode { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "The max length of a employee type category is 30 characters")]
        public string EmployeeTypeCategory { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "The max length of a employee type name is 150 characters")]
        public string EmployeeTypeName { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "The max length of a employee type description is 255 characters")]
        public string EmployeeTypeDesc { get; set; }
    }
}
