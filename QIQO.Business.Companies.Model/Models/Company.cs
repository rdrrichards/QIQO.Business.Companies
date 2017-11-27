using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QIQO.Business.Companies.Models
{
    public class Company : IModel
    {
        public Company(CompanyData companyData)
        {
            if (companyData == null) throw new ArgumentNullException(nameof(companyData));
            CompanyId = companyData.CompanyId;
            CompanyCode = companyData.CompanyCode;
            CompanyName = companyData.CompanyName;
            CompanyDesc = companyData.CompanyDesc;

            if (companyData.CompanyAddresses != null)
                foreach (var address in companyData.CompanyAddresses) SetAddress(address);
            if (companyData.CompanyAttributes != null)
                foreach (var attribute in companyData.CompanyAttributes) SetEntityAttribute(attribute);
            if (companyData.Employees != null)
                foreach (var employee in companyData.Employees) SetEmployee(employee);
            if (companyData.GLAccounts != null)
                foreach (var account in companyData.GLAccounts) SetChartOfAccount(account);
            if (companyData.FeeSchedules != null)
                foreach (var schedule in companyData.FeeSchedules) SetFeeSchedule(schedule);
            if (companyData.Ledgers != null)
                foreach (var ledger in companyData.Ledgers) SetLedger(ledger);
            if (companyData.Products != null)
                foreach (var product in companyData.Products) SetProduct(product);
        }
        public Company(Company company)
        {
            if (company == null) throw new ArgumentNullException(nameof(company));
            CompanyId = company.CompanyId;
            CompanyCode = company.CompanyCode;
            CompanyName = company.CompanyName;
            CompanyDesc = company.CompanyDesc;

            if (company.CompanyAddresses != null)
                foreach (var address in company.CompanyAddresses) SetAddress(address);
            if (company.CompanyAttributes != null)
                foreach (var attribute in company.CompanyAttributes) SetEntityAttribute(attribute);
            if (company.Employees != null)
                foreach (var employee in company.Employees) SetEmployee(employee);
            if (company.GLAccounts != null)
                foreach (var account in company.GLAccounts) SetChartOfAccount(account);
            if (company.FeeSchedules != null)
                foreach (var schedule in company.FeeSchedules) SetFeeSchedule(schedule);
            if (company.Ledgers != null)
                foreach (var ledger in company.Ledgers) SetLedger(ledger);
            if (company.Products != null)
                foreach (var product in company.Products) SetProduct(product);
        }
        public Guid CompanyId { get; private set; }
        public string CompanyCode { get; private set; }
        public string CompanyName { get; private set; }
        public string CompanyDesc { get; private set; }
        public List<Employee> Employees { get; private set; } = new List<Employee>();
        public List<ChartOfAccount> GLAccounts { get; private set; } = new List<ChartOfAccount>();
        public List<FeeSchedule> FeeSchedules { get; private set; } = new List<FeeSchedule>();
        public List<Ledger> Ledgers { get; private set; } = new List<Ledger>();
        public List<EntityAttribute> CompanyAttributes { get; private set; } = new List<EntityAttribute>();
        public List<Address> CompanyAddresses { get; private set; } = new List<Address>();
        public List<Product> Products { get; private set; } = new List<Product>();

        public void SetAddress(AddressData addressData)
        {
            if (addressData == null) throw new ArgumentNullException(nameof(addressData));
            var existingAddress = CompanyAddresses.FirstOrDefault(a => a.AddressType.AddressTypeCode == addressData.AddressType.AddressTypeCode);
            if (existingAddress != null)
                CompanyAddresses.Remove(existingAddress);
            CompanyAddresses.Add(new Address(addressData));
        }
        public void SetAddress(Address address)
        {
            if (address == null) throw new ArgumentNullException(nameof(address));
            var existingAddress = CompanyAddresses.FirstOrDefault(a => a.AddressType.AddressTypeCode == address.AddressType.AddressTypeCode);
            if (existingAddress != null)
                CompanyAddresses.Remove(existingAddress);
            CompanyAddresses.Add(address);
        }
        public void SetEmployee(EmployeeData employeeData)
        {
            if (employeeData == null) throw new ArgumentNullException(nameof(employeeData));
            var existingEmployee = Employees.FirstOrDefault(a => a.EmployeeCode == employeeData.EmployeeCode);
            if (existingEmployee != null)
                Employees.Remove(existingEmployee);
            Employees.Add(new Employee(employeeData));
        }
        public void SetEmployee(Employee employee)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));
            var existingEmployee = Employees.FirstOrDefault(a => a.EmployeeCode == employee.EmployeeCode);
            if (existingEmployee != null)
                Employees.Remove(existingEmployee);
            Employees.Add(employee);
        }
        public void SetChartOfAccount(ChartOfAccountData chartOfAccountData)
        {
            if (chartOfAccountData == null) throw new ArgumentNullException(nameof(chartOfAccountData));
            var existingAccount = GLAccounts.FirstOrDefault(a => a.AccountNo == chartOfAccountData.AccountNo);
            if (existingAccount != null)
                GLAccounts.Remove(existingAccount);
            GLAccounts.Add(new ChartOfAccount(chartOfAccountData));
        }
        public void SetChartOfAccount(ChartOfAccount chartOfAccount)
        {
            if (chartOfAccount == null) throw new ArgumentNullException(nameof(chartOfAccount));
            var existingAccount = GLAccounts.FirstOrDefault(a => a.AccountNo == chartOfAccount.AccountNo);
            if (existingAccount != null)
                GLAccounts.Remove(existingAccount);
            GLAccounts.Add(chartOfAccount);
        }
        public void SetFeeSchedule(FeeScheduleData feeScheduleData)
        {
            if (feeScheduleData == null) throw new ArgumentNullException(nameof(feeScheduleData));
            var existingSchedule = FeeSchedules.FirstOrDefault(a => a.Product.ProductCode == feeScheduleData.Product.ProductCode);
            if (existingSchedule != null)
                FeeSchedules.Remove(existingSchedule);
            FeeSchedules.Add(new FeeSchedule(feeScheduleData));
        }
        public void SetFeeSchedule(FeeSchedule feeSchedule)
        {
            if (feeSchedule == null) throw new ArgumentNullException(nameof(feeSchedule));
            var existingSchedule = FeeSchedules.FirstOrDefault(a => a.Product.ProductCode == feeSchedule.Product.ProductCode);
            if (existingSchedule != null)
                FeeSchedules.Remove(existingSchedule);
            FeeSchedules.Add(feeSchedule);
        }
        public void SetLedger(LedgerData ledgerData)
        {
            if (ledgerData == null) throw new ArgumentNullException(nameof(ledgerData));
            var existingLedger = Ledgers.FirstOrDefault(a => a.LedgeCode == ledgerData.LedgeCode);
            if (existingLedger != null)
                Ledgers.Remove(existingLedger);
            Ledgers.Add(new Ledger(ledgerData));
        }
        public void SetLedger(Ledger ledger)
        {
            if (ledger == null) throw new ArgumentNullException(nameof(ledger));
            var existingLedger = Ledgers.FirstOrDefault(a => a.LedgeCode == ledger.LedgeCode);
            if (existingLedger != null)
                Ledgers.Remove(existingLedger);
            Ledgers.Add(ledger);
        }
        public void SetEntityAttribute(EntityAttributeData entityAttributeData)
        {
            if (entityAttributeData == null) throw new ArgumentNullException(nameof(entityAttributeData));
            var existingAttribute = CompanyAttributes.FirstOrDefault(a => a.AttributeType.AttributeTypeCode == entityAttributeData.AttributeType.AttributeTypeCode);
            if (existingAttribute != null)
                CompanyAttributes.Remove(existingAttribute);
            CompanyAttributes.Add(new EntityAttribute(entityAttributeData));
        }
        public void SetEntityAttribute(EntityAttribute entityAttribute)
        {
            if (entityAttribute == null) throw new ArgumentNullException(nameof(entityAttribute));
            var existingAttribute = CompanyAttributes.FirstOrDefault(a => a.AttributeType.AttributeTypeCode == entityAttribute.AttributeType.AttributeTypeCode);
            if (existingAttribute != null)
                CompanyAttributes.Remove(existingAttribute);
            CompanyAttributes.Add(entityAttribute);
        }
        public void SetProduct(ProductData productData)
        {
            if (productData == null) throw new ArgumentNullException(nameof(productData));
            var existingProduct = Products.FirstOrDefault(a => a.ProductCode == productData.ProductCode);
            if (existingProduct != null)
                Products.Remove(existingProduct);
            Products.Add(new Product(productData));
        }
        public void SetProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            var existingProduct = Products.FirstOrDefault(a => a.ProductCode == product.ProductCode);
            if (existingProduct != null)
                Products.Remove(existingProduct);
            Products.Add(product);
        }
    }
}
