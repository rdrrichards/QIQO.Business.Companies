using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QIQO.Business.Companies.Data.Entities
{
    public class Company
    {
        [Key]
        public Guid CompanyKey { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDesc { get; set; }
        public string AddedUserID { get; set; }
        public DateTime AddedDateTime { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<ChartOfAccount> GLAccounts { get; set; }
        public ICollection<Ledger> Ledgers { get; set; }
        [ForeignKey("EntityId")]
        public ICollection<EntityAttribute> CompanyAttributes { get; set; }
        [ForeignKey("EntityId")]
        public ICollection<Address> CompanyAddresses { get; set; }

    }
}
