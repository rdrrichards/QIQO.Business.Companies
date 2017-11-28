using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class EmployeeType : IModel
    {
        public EmployeeType(EmployeeType employeeType)
        {
            if (employeeType == null) throw new ArgumentNullException(nameof(employeeType));
            EmployeeTypeId = employeeType.EmployeeTypeId;
            EmployeeTypeCode = employeeType.EmployeeTypeCode;
            EmployeeTypeCategory = employeeType.EmployeeTypeCategory;
            EmployeeTypeName = employeeType.EmployeeTypeName;
            EmployeeTypeDesc = employeeType.EmployeeTypeDesc;
        }
        public EmployeeType(EmployeeTypeData employeeTypeData)
        {
            if (employeeTypeData == null) throw new ArgumentNullException(nameof(employeeTypeData));
            EmployeeTypeId = employeeTypeData.EmployeeTypeId;
            EmployeeTypeCode = employeeTypeData.EmployeeTypeCode;
            EmployeeTypeCategory = employeeTypeData.EmployeeTypeCategory;
            EmployeeTypeName = employeeTypeData.EmployeeTypeName;
            EmployeeTypeDesc = employeeTypeData.EmployeeTypeDesc;
        }
        public EmployeeType(Guid employeeTypeId, string employeeTypeCode, string employeeTypeName, string employeeTypeDesc, string employeeTypeCategory)
        {
            EmployeeTypeId = employeeTypeId;
            EmployeeTypeCode = employeeTypeCode;
            EmployeeTypeCategory = employeeTypeCategory;
            EmployeeTypeName = employeeTypeName;
            EmployeeTypeDesc = employeeTypeDesc;
        }
        public Guid EmployeeTypeId { get; private set; }
        public string EmployeeTypeCode { get; private set; }
        public string EmployeeTypeCategory { get; private set; }
        public string EmployeeTypeName { get; private set; }
        public string EmployeeTypeDesc { get; private set; }
    }
}
