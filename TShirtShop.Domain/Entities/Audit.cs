using System;
using System.Collections.Generic;
using System.Text;

namespace TShirtShop.Domain.Entities
{
    public class Audit
    {
        public int AuditId { get; set; }
        public int OrderId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }

        public Orders Orders { get; set; }
    }
}
