using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class ChartOfAccount : IModel
    {
        public ChartOfAccount(ChartOfAccountData chartOfAccountData)
        {
            if (chartOfAccountData == null) throw new ArgumentNullException(nameof(chartOfAccountData));
            ChartOfAccountId = chartOfAccountData.ChartOfAccountId;
            CompanyId = chartOfAccountData.CompanyId;
            AccountNo = chartOfAccountData.AccountNo;
            AccountType = chartOfAccountData.AccountType;
            AccountName = chartOfAccountData.AccountName;
            BalanceType = chartOfAccountData.BalanceType;
            BankAccountFlag = chartOfAccountData.BankAccountFlag;
        }
        public ChartOfAccount(ChartOfAccount chartOfAccount)
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

        public ChartOfAccount(Guid chartOfAccountId, Guid companyId, string accountNo, string accountName,
            string accountType, string balanceType, bool bankAccountFlag)
        {
            ChartOfAccountId = chartOfAccountId;
            CompanyId = companyId;
            AccountNo = accountNo;
            AccountName = accountName;
            AccountType = accountType;
            BalanceType = balanceType;
            BankAccountFlag = bankAccountFlag;
        }

        public Guid ChartOfAccountId { get; private set; }
        public string AccountNo { get; private set; }
        public string AccountType { get; private set; }
        public string AccountName { get; private set; }
        public string BalanceType { get; private set; }
        public bool BankAccountFlag { get; private set; }
        public Guid CompanyId { get; private set; }
    }
}
