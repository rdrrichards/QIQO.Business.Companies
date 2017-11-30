﻿using QIQO.Business.Core.Contracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class EntityAttributeData : IEntity
    {
        [Key]
        public Guid AttributeId { get; set; }
        public Guid AttributeEntityId { get; set; }
        [Required]
        [ForeignKey("AttributeEntityTypeId")]
        public EntityTypeData AttributeEntityType { get; set; }
        [Required]
        public AttributeTypeData AttributeType { get; set; }
        public string AttributeValue { get; set; }
        [MaxLength(20, ErrorMessage = "The attribute data type name cannot be longer than 20 characters")]
        public string AttributeDataType { get; set; }
        [MaxLength(100, ErrorMessage = "The attribute display format name cannot be longer than 100 characters")]
        public string AttributeDisplayFormat { get; set; }
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
    }
}
