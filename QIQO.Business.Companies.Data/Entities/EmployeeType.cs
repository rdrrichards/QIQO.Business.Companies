using System;
using System.ComponentModel.DataAnnotations;

namespace QIQO.Business.Companies.Data.Entities
{
    public class EmployeeType
    {
        [Key]
        public int EmployeeTypeKey { get; set; }
        public string EmployeeTypeCategory { get; set; }
        public string EmployeeTypeCode { get; set; }
        public string EmployeeTypeName { get; set; }
        public string EmployeeTypeDesc { get; set; }
        public string AddedUserID { get; set; }
        public DateTime AddedDateTime { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
