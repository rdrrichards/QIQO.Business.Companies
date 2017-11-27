using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QIQO.Business.Companies.Models
{
    public class Employee : IModel
    {
        public Employee(EmployeeData employeeData)
        {
            if (employeeData == null) throw new ArgumentNullException(nameof(employeeData));
            EmployeeId = employeeData.EmployeeId;
            CompanyId = employeeData.CompanyId;
            EmployeeCode = employeeData.EmployeeCode;
            EmployeeFirstName = employeeData.EmployeeFirstName;
            EmployeeMI = employeeData.EmployeeMI;
            EmployeeLastName = employeeData.EmployeeLastName;
            EmployeeDOB = employeeData.EmployeeDOB;
            ParentEmployeeId = employeeData.ParentEmployeeId;
            StartDate = employeeData.StartDate;
            EndDate = employeeData.EndDate;
            Comment = employeeData.Comment;
            CompanyRoleType = (QIQOEmployeeType)employeeData.CompanyRoleType;
            EmployeeType = new EmployeeType(employeeData.EmployeeType);

            if (employeeData.EmployeeAddresses != null)
                foreach (var address in employeeData.EmployeeAddresses) SetAddress(address);
            if (employeeData.EmployeeAttributes != null)
                foreach (var attribute in employeeData.EmployeeAttributes) SetEntityAttribute(attribute);
        }
        public Employee(Employee employee)
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
            EmployeeType = new EmployeeType(employee.EmployeeType);

            if (employee.EmployeeAddresses != null)
                foreach (var address in employee.EmployeeAddresses) SetAddress(address);
            if (employee.EmployeeAttributes != null)
                foreach (var attribute in employee.EmployeeAttributes) SetEntityAttribute(attribute);
        }
        public Guid EmployeeId { get; private set; }
        public Guid CompanyId { get; private set; }
        public string EmployeeCode { get; private set; }
        public string EmployeeFirstName { get; private set; }
        public string EmployeeMI { get; private set; }
        public string EmployeeLastName { get; private set; }
        public string EmployeeFullNameFL => $"{EmployeeFirstName} {EmployeeLastName}";
        public string EmployeeFullNameFML => $"{EmployeeFirstName} {EmployeeMI} {EmployeeLastName}";
        public string EmployeeFullNameLF => $"{EmployeeLastName} {EmployeeFirstName}";
        public string EmployeeFullNameLFM => $"{EmployeeLastName} {EmployeeMI} {EmployeeFirstName}";
        public DateTime? EmployeeDOB { get; private set; }
        public List<Address> EmployeeAddresses => new List<Address>();
        public List<EntityAttribute> EmployeeAttributes => new List<EntityAttribute>();
        public EmployeeType EmployeeType { get; private set; }
        public Guid ParentEmployeeId { get; private set; }
        public string EmployeeTitle { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Comment { get; private set; }
        public QIQOEmployeeType CompanyRoleType { get; private set; }
        public void SetAddress(AddressData addressData)
        {
            if (addressData == null) throw new ArgumentNullException(nameof(addressData));
            var existingAddress = EmployeeAddresses.FirstOrDefault(a => a.AddressType.AddressTypeCode == addressData.AddressType.AddressTypeCode);
            if (existingAddress != null)
                EmployeeAddresses.Remove(existingAddress);
            EmployeeAddresses.Add(new Address(addressData));
        }
        public void SetAddress(Address address)
        {
            if (address == null) throw new ArgumentNullException(nameof(address));
            var existingAddress = EmployeeAddresses.FirstOrDefault(a => a.AddressType.AddressTypeCode == address.AddressType.AddressTypeCode);
            if (existingAddress != null)
                EmployeeAddresses.Remove(existingAddress);
            EmployeeAddresses.Add(address);
        }
        public void SetEntityAttribute(EntityAttributeData entityAttributeData)
        {
            if (entityAttributeData == null) throw new ArgumentNullException(nameof(entityAttributeData));
            var existingAttribute = EmployeeAttributes.FirstOrDefault(a => a.AttributeType.AttributeTypeCode == entityAttributeData.AttributeType.AttributeTypeCode);
            if (existingAttribute != null)
                EmployeeAttributes.Remove(existingAttribute);
            EmployeeAttributes.Add(new EntityAttribute(entityAttributeData));
        }
        public void SetEntityAttribute(EntityAttribute entityAttribute)
        {
            if (entityAttribute == null) throw new ArgumentNullException(nameof(entityAttribute));
            var existingAttribute = EmployeeAttributes.FirstOrDefault(a => a.AttributeType.AttributeTypeCode == entityAttribute.AttributeType.AttributeTypeCode);
            if (existingAttribute != null)
                EmployeeAttributes.Remove(existingAttribute);
            EmployeeAttributes.Add(entityAttribute);
        }
    }
}
