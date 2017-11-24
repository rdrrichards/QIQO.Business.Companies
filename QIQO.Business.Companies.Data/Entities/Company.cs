using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QIQO.Business.Companies.Data.Entities
{
    public class Company
    {
        [Key]
        public int CompanyKey { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDesc { get; set; }
        public string AddedUserID { get; set; }
        public DateTime AddedDateTime { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateDateTime { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<ChartOfAccount> GLAccounts { get; set; } = new List<ChartOfAccount>();
        public ICollection<Ledger> Ledgers { get; set; } = new List<Ledger>();
        public ICollection<EntityAttribute> CompanyAttributes { get; set; } = new List<EntityAttribute>();
        public ICollection<Address> CompanyAddresses { get; set; } = new List<Address>();

    }
}
