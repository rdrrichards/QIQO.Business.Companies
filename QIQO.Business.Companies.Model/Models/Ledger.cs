﻿using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QIQO.Business.Companies.Models
{
    public class Ledger : IModel
    {
        public Ledger(LedgerData ledgerData)
        {
            if (ledgerData == null) throw new ArgumentNullException(nameof(ledgerData));
            LedgerId = ledgerData.LedgerId;
            CompanyId = ledgerData.CompanyId;
            LedgeCode = ledgerData.LedgeCode;
            LedgeName = ledgerData.LedgeName;
            LedgeDesc = ledgerData.LedgeDesc;

            if (ledgerData.LedgerTxns != null)
                foreach (var txn in ledgerData.LedgerTxns) SetLedgerTxn(txn);

        }
        public Ledger(Ledger ledger)
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
        public Ledger(Guid ledgerId, Guid companyId, string ledgeCode, string ledgeName, string ledgeDesc, List<LedgerTxn> transactions)
        {
            LedgerId = ledgerId;
            CompanyId = companyId;
            LedgeCode = ledgeCode;
            LedgeName = ledgeName;
            LedgeDesc = ledgeDesc;
            LedgerTxns = transactions;
        }
        public Guid LedgerId { get; private set; }
        public Guid CompanyId { get; private set; }
        public string LedgeCode { get; private set; }
        public string LedgeName { get; private set; }
        public string LedgeDesc { get; private set; }
        public List<LedgerTxn> LedgerTxns { get; private set; } = new List<LedgerTxn>();

        public void SetLedgerTxn(LedgerTxnData txnData)
        {
            if (txnData == null) throw new ArgumentNullException(nameof(txnData));
            var existingTx = LedgerTxns.FirstOrDefault(a => a.LedgerTxnNum == txnData.LedgerTxnNum);
            if (existingTx != null)
                LedgerTxns.Remove(existingTx);
            LedgerTxns.Add(new LedgerTxn(txnData));
        }
        public void SetLedgerTxn(LedgerTxn txn)
        {
            if (txn == null) throw new ArgumentNullException(nameof(txn));
            var existingTx = LedgerTxns.FirstOrDefault(a => a.LedgerTxnNum == txn.LedgerTxnNum);
            if (existingTx != null)
                LedgerTxns.Remove(existingTx);
            LedgerTxns.Add(txn);
        }
    }
}
