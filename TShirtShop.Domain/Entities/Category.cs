using System;
using System.Collections.Generic;
using System.Text;

namespace TShirtShop.Domain.Entities
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int CategoryId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Department Department { get; set; }
        public ICollection<Product> Products { get; private set; }
    }
}
