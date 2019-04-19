
namespace TShirtShop.Domain.Entities
{
    public class Tax
    {
        public int TaxId { get; set; }
        public string Type { get; set; }
        public decimal Percentage { get; set; }

        public Orders Orders { get; set; }
    }
}
