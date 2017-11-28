using QIQO.Business.Companies.Models;
using System;

namespace QIQO.Business.Companies.ViewModels
{
    public class EmployeeTypeViewModel
    {
        public EmployeeTypeViewModel() { }
        public EmployeeTypeViewModel(EmployeeType employeeType)
        {
            if (employeeType == null) throw new ArgumentNullException(nameof(employeeType));
            EmployeeTypeId = employeeType.EmployeeTypeId;
            EmployeeTypeCode = employeeType.EmployeeTypeCode;
            EmployeeTypeCategory = employeeType.EmployeeTypeCategory;
            EmployeeTypeName = employeeType.EmployeeTypeName;
            EmployeeTypeDesc = employeeType.EmployeeTypeDesc;
        }
        public Guid EmployeeTypeId { get; set; }
        public string EmployeeTypeCode { get; set; }
        public string EmployeeTypeCategory { get; set; }
        public string EmployeeTypeName { get; set; }
        public string EmployeeTypeDesc { get; set; }
    }
}
