using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Companies.Models;
using QIQO.Business.Core.Contracts;

namespace QIQO.Business.Companies.Model.Interfaces
{
    public interface ICompanyEntityService : IEntityService<Company, CompanyData> { }
    public interface IAddressEntityService : IEntityService<Address, AddressData> { }
    public interface IAddressTypeEntityService : IEntityService<AddressType, AddressTypeData> { }
    public interface IEntityTypeEntityService : IEntityService<EntityType, EntityTypeData> { }
    public interface IAttributeTypeEntityService : IEntityService<AttributeType, AttributeTypeData> { }
    public interface IChartOfAccountEntityService : IEntityService<ChartOfAccount, ChartOfAccountData> { }
    public interface IEmployeeEntityService : IEntityService<Employee, EmployeeData> { }
    public interface IEmployeeTypeEntityService : IEntityService<EmployeeType, EmployeeTypeData> { }
    public interface IEntityAttributeEntityService : IEntityService<EntityAttribute, EntityAttributeData> { }
    public interface IFeeScheduleEntityService : IEntityService<FeeSchedule, FeeScheduleData> { }
    public interface ILedgerEntityService : IEntityService<Ledger, LedgerData> { }
    public interface ILedgerTxnEntityService : IEntityService<LedgerTxn, LedgerTxnData> { }
    public interface IProductEntityService : IEntityService<Product, ProductData> { }
    public interface IProductTypeEntityService : IEntityService<ProductType, ProductTypeData> { }
}
