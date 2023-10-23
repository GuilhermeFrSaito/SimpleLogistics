using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleLogistics.Models
{
    public class Sector
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public Storage? Storage { get; set; }
        public int StorageId { get; set; }
    }
}
