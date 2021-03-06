﻿using QIQO.Business.Core.Contracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class LedgerTxnData : IEntity
    {
        [Key]
        public Guid LedgerTxnId { get; set; }
        [ForeignKey("Ledger")]
        public Guid LedgerId { get; set; }
        [MaxLength(255, ErrorMessage = "The transaction comment cannot be longer than 255 characaters")]
        public string Comment { get; set; }
        [MaxLength(20, ErrorMessage = "The account number cannot be longer than 20 characaters")]
        public string AccountFrom { get; set; }
        [MaxLength(20, ErrorMessage = "The account number cannot be longer than 20 characaters")]
        public string AccountTo { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime PostDate { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public int LedgerTxnNum { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(30, ErrorMessage = "The added user id cannot be longer than 30 characters")]
        [Required]
        public string AddedUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime AddedDateTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(30, ErrorMessage = "The updated user id cannot be longer than 30 characters")]
        [Required]
        public string UpdateUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime UpdateDateTime { get; set; }

    }

}
