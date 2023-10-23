using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleLogistics.Models
{
    public class Storage
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public Sector? Sector { get; set; }
        public int SectorId { get; set; }

        public ICollection<Item>? Items { get; set; }
        public int ItemId { get; set; }
        public int ItemQuantity { get; set; }
    }
}