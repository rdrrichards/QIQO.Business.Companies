using QIQO.Business.Companies.Models;
using System;

namespace QIQO.Business.Companies.ViewModels
{
    public class ChartOfAccountViewModel
    {
        public ChartOfAccountViewModel() { }
        public ChartOfAccountViewModel(ChartOfAccount chartOfAccount)
        {
            if (chartOfAccount == null) throw new ArgumentNullException(nameof(chartOfAccount));
            ChartOfAccountId = chartOfAccount.ChartOfAccountId;
            CompanyId = chartOfAccount.CompanyId;
            AccountNo = chartOfAccount.AccountNo;
            AccountType = chartOfAccount.AccountType;
            AccountName = chartOfAccount.AccountName;
            BalanceType = chartOfAccount.BalanceType;
            BankAccountFlag = chartOfAccount.BankAccountFlag;
        }
        public Guid ChartOfAccountId { get; set; }
        public string AccountNo { get; set; }
        public string AccountType { get; set; }
        public string AccountName { get; set; }
        public string BalanceType { get; set; }
        public bool BankAccountFlag { get; set; }
        public Guid CompanyId { get; set; }
    }
}
