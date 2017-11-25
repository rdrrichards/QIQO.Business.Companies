using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }
        public Guid CompanyId { get; set; }
        [MaxLength(20, ErrorMessage = "The employee code cannot be longer than 20 characters")]
        [Required]
        public string EmployeeCode { get; set; }
        [MaxLength(30, ErrorMessage = "The employee first cannot be longer than 30 characters")]
        [Required]
        public string EmployeeFirstName { get; set; }
        [MaxLength(20, ErrorMessage = "The employee middle name cannot be longer than 20 characters")]
        public string EmployeeMI { get; set; }
        [MaxLength(30, ErrorMessage = "The employee last name cannot be longer than 30 characters")]
        [Required]
        public string EmployeeLastName { get; set; }
        public string EmployeeFullNameFL => $"{EmployeeFirstName} {EmployeeLastName}";
        public string EmployeeFullNameFML => $"{EmployeeFirstName} {EmployeeMI} {EmployeeLastName}";
        public string EmployeeFullNameLF => $"{EmployeeLastName} {EmployeeFirstName}";
        public string EmployeeFullNameLFM => $"{EmployeeLastName} {EmployeeMI} {EmployeeFirstName}";
        public DateTime? EmployeeDOB { get; set; }
        [ForeignKey("EntityId")]
        public ICollection<Address> EmployeeAddresses { get; set; }
        [ForeignKey("EntityId")]
        public ICollection<EntityAttribute> EmployeeAttributes { get; set; }        
        public EmployeeType EmployeeType { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(30, ErrorMessage = "The added user id cannot be longer than 30 characters")]
        [Required]
        public string AddedUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime AddedDateTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(30, ErrorMessage = "The updated user id cannot be longer than 30 characters")]
        [Required]
        public string UpdateUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDateTime { get; set; }
        public Guid ParentEmployeeId { get; set; }
        // public List<Company> Companies { get; set; } = new List<Company>();
        [MaxLength(30, ErrorMessage = "The employee title name cannot be longer than 30 characters")]
        [Required]
        public string EmployeeTitle { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [MaxLength(255, ErrorMessage = "The employee comment cannot be longer than 255 characters")]
        public string Comment { get; set; }
        public QIQOEmployeeType CompanyRoleType { get; set; }
    }
}
