
using System.Collections.Generic;

namespace TShirtShop.Domain.Entities
{
    public class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal CreatedOn { get; set; }
        public decimal? ShippedOn { get; set; }
        public int Status { get; set; }
        public string Comments { get; set; }
        public int CustomerId { get; set; }
        public string AuthCode { get; set; }
        public string Reference { get; set; }
        public int? ShippingId { get; set; }
        public int? TaxId { get; set; }

        public Audit Audit { get; set; }
        public Customer Customer { get; set; }
        public Tax Tax { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; private set; }
    }
}
