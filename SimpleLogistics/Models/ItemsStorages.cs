using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleLogistics.Models
{
    public class ItemsStorages
    {
        public ICollection<Item>? Items { get; set; }
        public int ItemId { get; set; }

        public ICollection<Storage>? Storages { get; set; }
        public int StorageId { get; set;}
    }
}
