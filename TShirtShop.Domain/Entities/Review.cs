using System;
using System.Collections.Generic;
using System.Text;

namespace TShirtShop.Domain.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string Value { get; set; }
        public short Rating { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
