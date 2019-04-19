using System;
using System.Collections.Generic;
using System.Text;

namespace TShirtShop.Domain.Entities
{
    public class AttributeValue
    {
        public int AttributeValueId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }
    }
}
