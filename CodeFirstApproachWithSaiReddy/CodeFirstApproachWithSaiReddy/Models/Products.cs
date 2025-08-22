using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproachWithSaiReddy.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int categoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
