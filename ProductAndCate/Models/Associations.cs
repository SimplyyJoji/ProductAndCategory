using System.ComponentModel.DataAnnotations;

namespace ProductAndCate.Models
{
    public class Association
    {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int AssociationId { get; set; }
        
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}