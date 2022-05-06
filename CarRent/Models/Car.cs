using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRent.Models
{
    public class Car : BaseEntity
    {
        [Required]
        [MaxLength(50, ErrorMessage ="this field should be less than 50 characters")]
        public string Make { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "this field should be less than 100 characters")]
        public string Model { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "this field should be less than 10 characters")]
        public string RegisterationNumber { get; set; }

        public ICollection<Rentals> Rentals { get; set; }

        
    }
}
