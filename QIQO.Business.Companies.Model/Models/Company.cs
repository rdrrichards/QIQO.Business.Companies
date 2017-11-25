using System;
using System.Collections.Generic;

namespace QIQO.Business.Companies.Models
{
    public class Company
    {
        public Guid CompanyKey { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDesc { get; set; }
        public List<Employee> Employees { get; set; }
        public List<ChartOfAccount> GLAccounts { get; set; }
        public List<FeeSchedule> FeeSchedules { get; set; }
        public List<Ledger> Ledgers { get; set; }
        public List<EntityAttribute> CompanyAttributes { get; set; }
        public List<Address> CompanyAddresses { get; set; }
    }
}
