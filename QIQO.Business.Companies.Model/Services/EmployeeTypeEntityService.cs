using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Companies.Model.Interfaces;
using QIQO.Business.Companies.Models;

namespace QIQO.Business.Companies.Model.Services
{
    public class EmployeeTypeEntityService : IEmployeeTypeEntityService
    {
        public EmployeeType Map(EmployeeTypeData ent)
        {
            return new EmployeeType(ent);
        }

        public EmployeeTypeData Map(EmployeeType ent)
        {
            return new EmployeeTypeData
            {
                EmployeeTypeId = ent.EmployeeTypeId,
                EmployeeTypeCode = ent.EmployeeTypeCode,
                EmployeeTypeName = ent.EmployeeTypeName,
                EmployeeTypeDesc = ent.EmployeeTypeDesc,
                EmployeeTypeCategory = ent.EmployeeTypeCategory
            };
        }
    }
}
