using QIQO.Business.Companies.Models;
using System;
using System.Collections.Generic;

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
            Employees = company.Employees;
            GLAccounts = company.GLAccounts;
            FeeSchedules = company.FeeSchedules;
            Ledgers = company.Ledgers;
            CompanyAttributes = company.CompanyAttributes;
            CompanyAddresses = company.CompanyAddresses;
            Products = company.Products;
        }
        public Guid CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDesc { get; set; }
        public List<Employee> Employees { get; set; }
        public List<ChartOfAccount> GLAccounts { get; set; }
        public List<FeeSchedule> FeeSchedules { get; set; }
        public List<Ledger> Ledgers { get; set; }
        public List<EntityAttribute> CompanyAttributes { get; set; }
        public List<Address> CompanyAddresses { get; set; }
        public List<Product> Products { get; set; }
    }
}
