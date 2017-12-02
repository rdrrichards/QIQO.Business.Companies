using QIQO.Business.Companies.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QIQO.Business.Companies.ViewModels
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel() { }
        public EmployeeViewModel(Employee employee)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));
            EmployeeId = employee.EmployeeId;
            CompanyId = employee.CompanyId;
            EmployeeCode = employee.EmployeeCode;
            EmployeeFirstName = employee.EmployeeFirstName;
            EmployeeMI = employee.EmployeeMI;
            EmployeeLastName = employee.EmployeeLastName;
            EmployeeDOB = employee.EmployeeDOB;
            ParentEmployeeId = employee.ParentEmployeeId;
            StartDate = employee.StartDate;
            EndDate = employee.EndDate;
            Comment = employee.Comment;
            CompanyRoleType = employee.CompanyRoleType;
            EmployeeType = new EmployeeTypeViewModel(employee.EmployeeType);

            if (employee.EmployeeAddresses != null)
                foreach (var address in employee.EmployeeAddresses) SetAddress(address);
            if (employee.EmployeeAttributes != null)
                foreach (var attribute in employee.EmployeeAttributes) SetEntityAttribute(attribute);
        }
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
        public List<AddressViewModel> EmployeeAddresses { get; set; } = new List<AddressViewModel>();
        public List<EntityAttributeViewModel> EmployeeAttributes { get; set; } = new List<EntityAttributeViewModel>();
        public EmployeeTypeViewModel EmployeeType { get; set; }
        public Guid ParentEmployeeId { get; set; }
        public string EmployeeTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
        public QIQOEmployeeType CompanyRoleType { get; set; }
        public void SetAddress(Address address)
        {
            if (address == null) throw new ArgumentNullException(nameof(address));
            var existingAddress = EmployeeAddresses.FirstOrDefault(a => a.AddressType.AddressTypeCode == address.AddressType.AddressTypeCode);
            if (existingAddress != null)
                EmployeeAddresses.Remove(existingAddress);
            EmployeeAddresses.Add(new AddressViewModel(address));
        }
        public void SetEntityAttribute(EntityAttribute entityAttribute)
        {
            if (entityAttribute == null) throw new ArgumentNullException(nameof(entityAttribute));
            var existingAttribute = EmployeeAttributes.FirstOrDefault(a => a.AttributeType.AttributeTypeCode == entityAttribute.AttributeType.AttributeTypeCode);
            if (existingAttribute != null)
                EmployeeAttributes.Remove(existingAttribute);
            EmployeeAttributes.Add(new EntityAttributeViewModel(entityAttribute));
        }
    }
}
