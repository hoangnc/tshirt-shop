using System;
using System.Collections.Generic;
using System.Text;

namespace TShirtShop.Domain.Entities
{
    public class Shipping
    {
        public int ShippingId { get; set; }
        public string Type { get; set; }
        public string Cost { get; set; }
        public int ShippingRegionId { get; set; }

        public ShippingRegion Region { get; set; }
    }
}
