using System.ComponentModel.DataAnnotations;

namespace ProductAndCate.Models
{
    public class Associations
    {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int ProductId { get; set; }
        
    }
}