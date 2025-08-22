using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproachWithSaiReddy.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public virtual Products Products { get; set; }
        public virtual Category Category{ get; set; }
    }
}
