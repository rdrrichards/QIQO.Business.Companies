using QIQO.Business.Companies.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QIQO.Business.Companies.ViewModels
{
    public class LedgerViewModel
    {
        public LedgerViewModel() { }
        public LedgerViewModel(Ledger ledger)
        {
            if (ledger == null) throw new ArgumentNullException(nameof(ledger));
            LedgerId = ledger.LedgerId;
            CompanyId = ledger.CompanyId;
            LedgeCode = ledger.LedgeCode;
            LedgeName = ledger.LedgeName;
            LedgeDesc = ledger.LedgeDesc;

            if (ledger.LedgerTxns != null)
                foreach (var txn in ledger.LedgerTxns) SetLedgerTxn(txn);
        }
        public Guid LedgerId { get; set; }
        public Guid CompanyId { get; set; }
        public string LedgeCode { get; set; }
        public string LedgeName { get; set; }
        public string LedgeDesc { get; set; }
        public List<LedgerTxnViewModel> LedgerTxns { get; set; } = new List<LedgerTxnViewModel>();
        public void SetLedgerTxn(LedgerTxn txn)
        {
            if (txn == null) throw new ArgumentNullException(nameof(txn));
            var existingTx = LedgerTxns.FirstOrDefault(a => a.LedgerTxnNum == txn.LedgerTxnNum);
            if (existingTx != null)
                LedgerTxns.Remove(existingTx);
            LedgerTxns.Add(new LedgerTxnViewModel(txn));
        }
    }
}
