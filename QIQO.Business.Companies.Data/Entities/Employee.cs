using System;
using System.Collections.Generic;

namespace QIQO.Business.Companies.Data.Entities
{
    public class Employee
    {
        public int EmployeeKey { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeMI { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeFullNameFL => $"{EmployeeFirstName} {EmployeeLastName}";
        public string EmployeeFullNameFML => $"{EmployeeFirstName} {EmployeeMI} {EmployeeLastName}";
        public string EmployeeFullNameLF => $"{EmployeeLastName} {EmployeeFirstName}";
        public string EmployeeFullNameLFM => $"{EmployeeLastName} {EmployeeMI} {EmployeeFirstName}";
        public DateTime? EmployeeDOB { get; set; }
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
        public ICollection<EntityAttribute> EmployeeAttributes { get; set; } = new List<EntityAttribute>();

        //public QIQOPersonType Type  { get; set; }
        public EmployeeType EmployeeTypeData { get; set; } = new EmployeeType();
        public string AddedUserID { get; set; }
        public DateTime AddedDateTime { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateDateTime { get; set; }

        public int ParentEmployeeKey { get; set; }
        // public List<Company> Companies { get; set; } = new List<Company>();
        public string EmployeeTitle { get; set; }
        public int EntityEmployeeKey { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
        public QIQOEmployeeType CompanyRoleType { get; set; } = QIQOEmployeeType.EmployeeHourly;
    }
}
