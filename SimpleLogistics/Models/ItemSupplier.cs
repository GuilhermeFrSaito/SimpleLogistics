using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleLogistics.Models
{
    public class ItemSupplier
    {
        public ICollection<Item>? Items { get; set; }
        public int ItemId { get; set; }

        public ICollection<Supplier>? Suppliers { get; set; }
        public int SupplierId { get; set;}
    }
}
