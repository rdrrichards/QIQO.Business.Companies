﻿using System;

namespace QIQO.Business.Companies.Models
{
    public class EntityAttribute
    {
        public Guid AttributeId { get; set; }
        public Guid CompanyId { get; set; }
        public AttributeType AttributeType { get; set; }
        public string AttributeValue { get; set; }
        public string AttributeDataType { get; set; }
        public string AttributeDisplayFormat { get; set; }
    }
}
