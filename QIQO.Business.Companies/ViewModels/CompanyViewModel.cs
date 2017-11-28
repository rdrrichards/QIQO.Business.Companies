using QIQO.Business.Companies.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QIQO.Business.Companies.ViewModels
{
    public class CompanyViewModel
    {
        public CompanyViewModel() { }
        public CompanyViewModel(Company company)
        {
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
        public Guid CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDesc { get; set; }
        public List<EmployeeViewModel> Employees { get; set; } = new List<EmployeeViewModel>();
        public List<ChartOfAccountViewModel> GLAccounts { get; set; } = new List<ChartOfAccountViewModel>();
        public List<FeeScheduleViewModel> FeeSchedules { get; set; } = new List<FeeScheduleViewModel>();
        public List<LedgerViewModel> Ledgers { get; set; } = new List<LedgerViewModel>();
        public List<EntityAttributeViewModel> CompanyAttributes { get; set; } = new List<EntityAttributeViewModel>();
        public List<AddressViewModel> CompanyAddresses { get; set; } = new List<AddressViewModel>();
        public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();

        public Company GetCompany()
        {
            var addresses = Map(CompanyAddresses);
            var attributes = Map(CompanyAttributes);
            var employees = Map(Employees);
            var accounts = Map(GLAccounts);
            var schedules = Map(FeeSchedules);
            var ledgers = Map(Ledgers);
            var products = Map(Products);
            
            return new Company(CompanyId, CompanyCode, CompanyName, CompanyDesc,
                addresses, attributes, employees, accounts,
                schedules, ledgers, products);
        }
        private void SetAddress(AddressViewModel addressData)
        {
            if (addressData == null) throw new ArgumentNullException(nameof(addressData));
            var existingAddress = CompanyAddresses.FirstOrDefault(a => a.AddressType.AddressTypeCode == addressData.AddressType.AddressTypeCode);
            if (existingAddress != null)
                CompanyAddresses.Remove(existingAddress);
            CompanyAddresses.Add(addressData);
        }
        private void SetAddress(Address address)
        {
            if (address == null) throw new ArgumentNullException(nameof(address));
            var existingAddress = CompanyAddresses.FirstOrDefault(a => a.AddressType.AddressTypeCode == address.AddressType.AddressTypeCode);
            if (existingAddress != null)
                CompanyAddresses.Remove(existingAddress);
            CompanyAddresses.Add(new AddressViewModel(address));
        }
        private void SetEmployee(EmployeeViewModel employeeData)
        {
            if (employeeData == null) throw new ArgumentNullException(nameof(employeeData));
            var existingEmployee = Employees.FirstOrDefault(a => a.EmployeeCode == employeeData.EmployeeCode);
            if (existingEmployee != null)
                Employees.Remove(existingEmployee);
            Employees.Add(employeeData);
        }
        private void SetEmployee(Employee employee)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));
            var existingEmployee = Employees.FirstOrDefault(a => a.EmployeeCode == employee.EmployeeCode);
            if (existingEmployee != null)
                Employees.Remove(existingEmployee);
            Employees.Add(new EmployeeViewModel(employee));
        }
        private void SetChartOfAccount(ChartOfAccountViewModel chartOfAccountData)
        {
            if (chartOfAccountData == null) throw new ArgumentNullException(nameof(chartOfAccountData));
            var existingAccount = GLAccounts.FirstOrDefault(a => a.AccountNo == chartOfAccountData.AccountNo);
            if (existingAccount != null)
                GLAccounts.Remove(existingAccount);
            GLAccounts.Add(chartOfAccountData);
        }
        private void SetChartOfAccount(ChartOfAccount chartOfAccount)
        {
            if (chartOfAccount == null) throw new ArgumentNullException(nameof(chartOfAccount));
            var existingAccount = GLAccounts.FirstOrDefault(a => a.AccountNo == chartOfAccount.AccountNo);
            if (existingAccount != null)
                GLAccounts.Remove(existingAccount);
            GLAccounts.Add(new ChartOfAccountViewModel(chartOfAccount));
        }
        private void SetFeeSchedule(FeeScheduleViewModel feeScheduleData)
        {
            if (feeScheduleData == null) throw new ArgumentNullException(nameof(feeScheduleData));
            var existingSchedule = FeeSchedules.FirstOrDefault(a => a.Product.ProductCode == feeScheduleData.Product.ProductCode);
            if (existingSchedule != null)
                FeeSchedules.Remove(existingSchedule);
            FeeSchedules.Add(feeScheduleData);
        }
        private void SetFeeSchedule(FeeSchedule feeSchedule)
        {
            if (feeSchedule == null) throw new ArgumentNullException(nameof(feeSchedule));
            var existingSchedule = FeeSchedules.FirstOrDefault(a => a.Product.ProductCode == feeSchedule.Product.ProductCode);
            if (existingSchedule != null)
                FeeSchedules.Remove(existingSchedule);
            FeeSchedules.Add(new FeeScheduleViewModel(feeSchedule));
        }
        private void SetLedger(LedgerViewModel ledgerData)
        {
            if (ledgerData == null) throw new ArgumentNullException(nameof(ledgerData));
            var existingLedger = Ledgers.FirstOrDefault(a => a.LedgeCode == ledgerData.LedgeCode);
            if (existingLedger != null)
                Ledgers.Remove(existingLedger);
            Ledgers.Add(ledgerData);
        }
        private void SetLedger(Ledger ledger)
        {
            if (ledger == null) throw new ArgumentNullException(nameof(ledger));
            var existingLedger = Ledgers.FirstOrDefault(a => a.LedgeCode == ledger.LedgeCode);
            if (existingLedger != null)
                Ledgers.Remove(existingLedger);
            Ledgers.Add(new LedgerViewModel(ledger));
        }
        private void SetEntityAttribute(EntityAttributeViewModel entityAttributeData)
        {
            if (entityAttributeData == null) throw new ArgumentNullException(nameof(entityAttributeData));
            var existingAttribute = CompanyAttributes.FirstOrDefault(a => a.AttributeType.AttributeTypeCode == entityAttributeData.AttributeType.AttributeTypeCode);
            if (existingAttribute != null)
                CompanyAttributes.Remove(existingAttribute);
            CompanyAttributes.Add(entityAttributeData);
        }
        private void SetEntityAttribute(EntityAttribute entityAttribute)
        {
            if (entityAttribute == null) throw new ArgumentNullException(nameof(entityAttribute));
            var existingAttribute = CompanyAttributes.FirstOrDefault(a => a.AttributeType.AttributeTypeCode == entityAttribute.AttributeType.AttributeTypeCode);
            if (existingAttribute != null)
                CompanyAttributes.Remove(existingAttribute);
            CompanyAttributes.Add(new EntityAttributeViewModel(entityAttribute));
        }
        private void SetProduct(ProductViewModel productData)
        {
            if (productData == null) throw new ArgumentNullException(nameof(productData));
            var existingProduct = Products.FirstOrDefault(a => a.ProductCode == productData.ProductCode);
            if (existingProduct != null)
                Products.Remove(existingProduct);
            Products.Add(productData);
        }
        private void SetProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            var existingProduct = Products.FirstOrDefault(a => a.ProductCode == product.ProductCode);
            if (existingProduct != null)
                Products.Remove(existingProduct);
            Products.Add(new ProductViewModel(product));
        }

        private List<Address> Map(List<AddressViewModel> list)
        {
            var addresses = new List<Address>();
            if (list != null)
            {
                foreach (var address in list)
                {
                    var addressType = new AddressType(address.AddressType.AddressTypeId, address.AddressType.AddressTypeCode,
                        address.AddressType.AddressTypeName, address.AddressType.AddressTypeDesc, address.AddressType.AddressTypeCategory);
                    var entityType = new EntityType(address.EntityType.EntityTypeId, address.EntityType.EntityTypeCode,
                        address.EntityType.EntityTypeName, address.EntityType.EntityTypeDesc, address.EntityType.EntityTypeCategory);
                    addresses.Add(new Address(address.AddressId, address.AddressLine1, address.AddressLine2, address.AddressLine3, address.AddressLine4,
                        address.AddressCity, address.AddressState, address.AddressPostalCode, address.AddressCounty, address.AddressCountry,
                        address.AddressActiveFlag, address.AddressDefaultFlag, address.AddressNotes, address.EntityId,
                        addressType, entityType));
                }
            }
            return addresses;
        }
        private List<EntityAttribute> Map(List<EntityAttributeViewModel> list)
        {
            var attributes = new List<EntityAttribute>();
            if (list != null)
            {

                foreach (var attribute in list)
                {
                    var attributeType = new AttributeType(attribute.AttributeType.AttributeTypeId, attribute.AttributeType.AttributeDataTypeKey,
                        attribute.AttributeType.AttributeDefaultFormat, attribute.AttributeType.AttributeTypeCode, attribute.AttributeType.AttributeTypeName,
                        attribute.AttributeType.AttributeTypeDesc, attribute.AttributeType.AttributeTypeCategory);
                    var entityType = new EntityType(attribute.EntityType.EntityTypeId, attribute.EntityType.EntityTypeCode,
                        attribute.EntityType.EntityTypeName, attribute.EntityType.EntityTypeDesc, attribute.EntityType.EntityTypeCategory);
                    attributes.Add(new EntityAttribute(attribute.AttributeId, attribute.EntityId, attribute.AttributeValue, attribute.AttributeDataType,
                        attribute.AttributeDisplayFormat, entityType, attributeType));
                }
            }
            return attributes;
        }
        private List<Employee> Map(List<EmployeeViewModel> list)
        {
            var employees = new List<Employee>();
            if (list != null)
            {
                foreach (var employee in list)
                {
                    var employeeAddresses = new List<Address>();
                    var employeeAttributes = new List<EntityAttribute>();
                    if (employee.EmployeeAddresses != null)
                    {
                        foreach (var address in employee.EmployeeAddresses)
                        {
                            var addressType = new AddressType(address.AddressType.AddressTypeId, address.AddressType.AddressTypeCode,
                                address.AddressType.AddressTypeName, address.AddressType.AddressTypeDesc, address.AddressType.AddressTypeCategory);
                            var entityType = new EntityType(address.EntityType.EntityTypeId, address.EntityType.EntityTypeCode,
                                address.EntityType.EntityTypeName, address.EntityType.EntityTypeDesc, address.EntityType.EntityTypeCategory);
                            employeeAddresses.Add(new Address(address.AddressId, address.AddressLine1, address.AddressLine2, address.AddressLine3, address.AddressLine4,
                                address.AddressCity, address.AddressState, address.AddressPostalCode, address.AddressCounty, address.AddressCountry,
                                address.AddressActiveFlag, address.AddressDefaultFlag, address.AddressNotes, address.EntityId,
                                addressType, entityType));
                        }
                    }

                    if (employee.EmployeeAttributes != null)
                    {

                        foreach (var attribute in employee.EmployeeAttributes)
                        {
                            var attributeType = new AttributeType(attribute.AttributeType.AttributeTypeId, attribute.AttributeType.AttributeDataTypeKey,
                                attribute.AttributeType.AttributeDefaultFormat, attribute.AttributeType.AttributeTypeCode, attribute.AttributeType.AttributeTypeName,
                                attribute.AttributeType.AttributeTypeDesc, attribute.AttributeType.AttributeTypeCategory);
                            var entityType = new EntityType(attribute.EntityType.EntityTypeId, attribute.EntityType.EntityTypeCode,
                                attribute.EntityType.EntityTypeName, attribute.EntityType.EntityTypeDesc, attribute.EntityType.EntityTypeCategory);
                            employeeAttributes.Add(new EntityAttribute(attribute.AttributeId, attribute.EntityId, attribute.AttributeValue, attribute.AttributeDataType,
                                attribute.AttributeDisplayFormat, entityType, attributeType));
                        }
                    }
                    var employeeType = new EmployeeType(employee.EmployeeType.EmployeeTypeId, employee.EmployeeType.EmployeeTypeCode,
                        employee.EmployeeType.EmployeeTypeName, employee.EmployeeType.EmployeeTypeDesc, employee.EmployeeType.EmployeeTypeCategory);
                    employees.Add(new Employee(employee.EmployeeId, employee.CompanyId, employee.CompanyRoleType, employee.EmployeeCode,
                        employee.EmployeeFirstName, employee.EmployeeLastName, employee.EmployeeMI, employee.EmployeeDOB, employee.EmployeeTitle,
                        employee.StartDate, employee.EndDate, employee.ParentEmployeeId, employeeType,
                        employeeAddresses, employeeAttributes, employee.Comment));
                }
            }
            return employees;
        }
        private List<ChartOfAccount> Map(List<ChartOfAccountViewModel> list)
        {
            var accounts = new List<ChartOfAccount>();
            if (list != null)
            {
                foreach (var account in list)
                {
                    accounts.Add(new ChartOfAccount(account.ChartOfAccountId, account.CompanyId, account.AccountNo, account.AccountName,
                        account.AccountType, account.BalanceType, account.BankAccountFlag));
                }
            }
            return accounts;
        }
        private List<FeeSchedule> Map(List<FeeScheduleViewModel> list)
        {
            var schedules = new List<FeeSchedule>();
            if (list != null)
            {
                foreach (var schedule in list)
                {
                    var productType = new ProductType(schedule.Product.ProductType.ProductTypeId, schedule.Product.ProductType.ProductTypeCode, schedule.Product.ProductType.ProductTypeName,
                        schedule.Product.ProductType.ProductTypeDesc, schedule.Product.ProductType.ProductTypeCategory);
                    var product = new Product(schedule.Product.ProductId, schedule.Product.CompanyId, schedule.Product.ProductCode, schedule.Product.ProductName,
                        schedule.Product.ProductNameShort, schedule.Product.ProductNameLong, schedule.Product.ProductDesc, schedule.Product.ProductImagePath,
                        schedule.Product.ProductBasePrice, schedule.Product.ProductCost, schedule.Product.ProductDefaultQuantity, schedule.Product.ProductIncomeAccount,
                        productType);
                    schedules.Add(new FeeSchedule(schedule.FeeScheduleId, schedule.CompanyId, schedule.FeeScheduleTypeCode, schedule.FeeScheduleValue,
                        schedule.FeeScheduleStartDate, schedule.FeeScheduleEndDate, product, schedule.ProductDesc));
                }
            }
            return schedules;
        }
        private List<Ledger> Map(List<LedgerViewModel> list)
        {
            var ledgers = new List<Ledger>();
            if (list != null)
            {
                foreach (var ledger in list)
                {
                    var ledgerTxns = new List<LedgerTxn>();
                    if (ledger.LedgerTxns != null)
                    {
                        foreach (var txn in ledger.LedgerTxns)
                        {
                            ledgerTxns.Add(new LedgerTxn(txn.LedgerTxnId, txn.LedgerId, txn.Comment, txn.AccountFrom, txn.AccountTo,
                                txn.EntryDate, txn.PostDate, txn.Credit, txn.Debit, txn.LedgerTxnNum));
                        }
                    }
                    ledgers.Add(new Ledger(ledger.LedgerId, ledger.CompanyId, ledger.LedgeCode, ledger.LedgeName, ledger.LedgeDesc, ledgerTxns));
                }
            }
            return ledgers;
        }
        private List<Product> Map(List<ProductViewModel> list)
        {
            var products = new List<Product>();
            if (list != null)
            {
                foreach (var product in list)
                {
                    var productType = new ProductType(product.ProductType.ProductTypeId, product.ProductType.ProductTypeCode, product.ProductType.ProductTypeName,
                        product.ProductType.ProductTypeDesc, product.ProductType.ProductTypeCategory);
                    products.Add(new Product(product.ProductId, product.CompanyId, product.ProductCode, product.ProductName,
                        product.ProductNameShort, product.ProductNameLong, product.ProductDesc, product.ProductImagePath,
                        product.ProductBasePrice, product.ProductCost, product.ProductDefaultQuantity, product.ProductIncomeAccount,
                        productType));
                }
            }
            return products;
        }
    }
}
