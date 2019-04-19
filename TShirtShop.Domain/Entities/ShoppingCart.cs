using System;

namespace TShirtShop.Domain.Entities
{
    public class ShoppingCart
    {
        public int ItemId { get; set; }
        public string CardId { get; set; }
        public int ProductId { get; set; }
        public string Attributes { get; set; }
        public int Quantity { get; set; }
        public bool BuyNow { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
