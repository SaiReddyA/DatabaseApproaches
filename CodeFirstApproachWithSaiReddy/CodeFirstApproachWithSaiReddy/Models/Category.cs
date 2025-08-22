using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproachWithSaiReddy.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
