using System;
using System.ComponentModel.DataAnnotations;

namespace ProductAndCate.Models
{
    public class Products
    {
        
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int ProductId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "First Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "Price")]
        public string Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        }
    }
