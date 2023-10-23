namespace SimpleLogistics.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? CPF_CNPJ { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? Description { get; set; }

        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
