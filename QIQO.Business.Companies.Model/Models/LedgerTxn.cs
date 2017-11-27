using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class LedgerTxn : IModel
    {
        public LedgerTxn(LedgerTxnData ledgerTxnData)
        {
            if (ledgerTxnData == null) throw new ArgumentNullException(nameof(ledgerTxnData));
            LedgerTxnId = ledgerTxnData.LedgerTxnId;
            LedgerId = ledgerTxnData.LedgerId;
            Comment = ledgerTxnData.Comment;
            AccountFrom = ledgerTxnData.AccountFrom;
            AccountTo = ledgerTxnData.AccountTo;
            EntryDate = ledgerTxnData.EntryDate;
            PostDate = ledgerTxnData.PostDate;
            Credit = ledgerTxnData.Credit;
            Debit = ledgerTxnData.Debit;
            LedgerTxnNum = ledgerTxnData.LedgerTxnNum;
        }
        public LedgerTxn(LedgerTxn ledgerTxn)
        {
            if (ledgerTxn == null) throw new ArgumentNullException(nameof(ledgerTxn));
            LedgerTxnId = ledgerTxn.LedgerTxnId;
            LedgerId = ledgerTxn.LedgerId;
            Comment = ledgerTxn.Comment;
            AccountFrom = ledgerTxn.AccountFrom;
            AccountTo = ledgerTxn.AccountTo;
            EntryDate = ledgerTxn.EntryDate;
            PostDate = ledgerTxn.PostDate;
            Credit = ledgerTxn.Credit;
            Debit = ledgerTxn.Debit;
            LedgerTxnNum = ledgerTxn.LedgerTxnNum;
        }
        public Guid LedgerTxnId { get; private set; }
        public Guid LedgerId { get; private set; }
        public string Comment { get; private set; }
        public string AccountFrom { get; private set; }
        public string AccountTo { get; private set; }
        public DateTime EntryDate { get; private set; }
        public DateTime PostDate { get; private set; }
        public decimal Credit { get; private set; }
        public decimal Debit { get; private set; }
        public int LedgerTxnNum { get; private set; }
    }
}
