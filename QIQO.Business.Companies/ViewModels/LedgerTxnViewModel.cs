using QIQO.Business.Companies.Models;
using System;

namespace QIQO.Business.Companies.ViewModels
{
    public class LedgerTxnViewModel
    {
        public LedgerTxnViewModel() { }
        public LedgerTxnViewModel(LedgerTxn ledgerTxn)
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
        public Guid LedgerTxnId { get; set; }
        public Guid LedgerId { get; set; }
        public string Comment { get; set; }
        public string AccountFrom { get; set; }
        public string AccountTo { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime PostDate { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public int LedgerTxnNum { get; set; }
    }
}
