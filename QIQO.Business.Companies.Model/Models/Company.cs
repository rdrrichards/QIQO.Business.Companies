using QIQO.Business.Core.Contracts;
using System;
using System.Collections.Generic;

namespace QIQO.Business.Companies.Models
{
    public class Company : IModel
    {
        public Guid CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDesc { get; set; }
        public List<Employee> Employees => new List<Employee>();
        public List<ChartOfAccount> GLAccounts => new List<ChartOfAccount>();
        public List<FeeSchedule> FeeSchedules => new List<FeeSchedule>();
        public List<Ledger> Ledgers => new List<Ledger>();
        public List<EntityAttribute> CompanyAttributes => new List<EntityAttribute>();
        public List<Address> CompanyAddresses => new List<Address>();
        public List<Product> Products => new List<Product>();
    }
}
