using System;
using System.ComponentModel.DataAnnotations;

namespace QIQO.Business.Companies.Data.Entities
{
    public class AddressType
    {
        [Key]
        public int AddressTypeKey { get; set; }
        public string AddressTypeCode { get; set; }
        public string AddressTypeName { get; set; }
        public string AddressTypeDesc { get; set; }
        public string AddedUserID { get; set; }
        public DateTime AddedDateTime { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateDateTime { get; set; }


    }

}
