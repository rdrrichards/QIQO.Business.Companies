using System;
using System.Collections.Generic;

namespace QIQO.Business.Companies.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
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
        public List<Address> Addresses { get; set; }
        public List<EntityAttribute> EmployeeAttributes { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public Guid ParentEmployeeId { get; set; }
        public string EmployeeTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
        public QIQOEmployeeType CompanyRoleType { get; set; }
    }
}
