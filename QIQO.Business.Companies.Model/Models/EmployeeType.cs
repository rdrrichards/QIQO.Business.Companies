using System;

namespace QIQO.Business.Companies.Models
{
    public class EmployeeType
    {
        public Guid EmployeeTypeId { get; set; }
        public string EmployeeTypeCode { get; set; }
        public string EmployeeTypeCategory { get; set; }
        public string EmployeeTypeName { get; set; }
        public string EmployeeTypeDesc { get; set; }
    }
}
