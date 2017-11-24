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
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeMI { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeFullNameFL => $"{EmployeeFirstName} {EmployeeLastName}";
        public string EmployeeFullNameFML => $"{EmployeeFirstName} {EmployeeMI} {EmployeeLastName}";
        public string EmployeeFullNameLF => $"{EmployeeLastName} {EmployeeFirstName}";
        public string EmployeeFullNameLFM => $"{EmployeeLastName} {EmployeeMI} {EmployeeFirstName}";
        public DateTime? EmployeeDOB { get; set; }
        [ForeignKey("EntityId")]
        public ICollection<Address> Addresses { get; set; }
        [ForeignKey("EntityId")]
        public ICollection<EntityAttribute> EmployeeAttributes { get; set; }

        //public QIQOPersonType Type  { get; set; }
        public EmployeeType EmployeeTypeData { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string AddedUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime AddedDateTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string UpdateUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDateTime { get; set; }

        public Guid ParentEmployeeId { get; set; }
        // public List<Company> Companies { get; set; } = new List<Company>();
        public string EmployeeTitle { get; set; }
        public Guid EntityEmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
        public QIQOEmployeeType CompanyRoleType { get; set; } = QIQOEmployeeType.EmployeeHourly;
    }
}
