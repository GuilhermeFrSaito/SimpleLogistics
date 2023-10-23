namespace SimpleLogistics.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Brand { get; set; }

        public string? Model { get; set; }

        public string? Description { get; set; }

        public ICollection<Supplier>? Suppliers { get; set; } = new List<Supplier>();
        public int SupplierId { get; set; }

        public ICollection<Storage> Storages { get; set; } = new List<Storage>();
        public int StorageId { get; set; }
    }
}
