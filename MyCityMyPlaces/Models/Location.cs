using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCityMyPlaces.Models
{
    public class Location
    {
        [Key]
        public int IdLocation { get; set; }
        [Required]
        [Column(TypeName = "decimal(8,6)")]
        public decimal CoordinateX { get; set; }
        [Required]  
        [Column(TypeName = "decimal(8,6)")]
        public decimal CoordinateY { get; set; }
        
        public string Comment { get; set; }
        
        public string LocationName { get; set; }
        [Required] 
        public bool Visible { get; set; } = false;
        
        [ForeignKey("User")]
        public int IdUser { get; set; }
        public User User { get; set; }

    }
}
