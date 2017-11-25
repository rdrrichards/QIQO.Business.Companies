using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class Ledger
    {
        [Key]
        public Guid LedgerId { get; set; }
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        [MaxLength(20, ErrorMessage = "The ledger code cannot be longer than 20 characters")]
        public string LedgeCode { get; set; }
        [MaxLength(100, ErrorMessage = "The ledger name cannot be longer than 100 characters")]
        public string LedgeName { get; set; }
        [MaxLength(255, ErrorMessage = "The ledger description cannot be longer than 255 characters")]
        public string LedgeDesc { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(30, ErrorMessage = "The added user id cannot be longer than 30 characters")]
        [Required]
        public string AddedUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime AddedDateTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(30, ErrorMessage = "The updated user id cannot be longer than 30 characters")]
        [Required]
        public string UpdateUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDateTime { get; set; }
        public ICollection<LedgerTxn> LedgerTxns { get; set; }

    }

}
