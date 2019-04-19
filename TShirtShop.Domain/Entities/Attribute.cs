using System;
using System.Collections.Generic;
using System.Text;

namespace TShirtShop.Domain.Entities
{
    public class Attribute
    {
        public int AttributeId { get; set; }
        public string Name { get; set; }
        public AttributeValue Value { get; set; }
    }
}
