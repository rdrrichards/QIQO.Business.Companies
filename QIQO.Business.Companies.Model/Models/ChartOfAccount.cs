using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class ChartOfAccount : IModel
    {
        public Guid ChartOfAccountId { get; set; }
        public string AccountNo { get; set; }
        public string AccountType { get; set; }
        public string AccountName { get; set; }
        public string BalanceType { get; set; }
        public bool BankAccountFlag { get; set; }
        public Guid CompanyId { get; set; }
    }
}
