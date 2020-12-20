using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCityMyPlaces.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,6)")]
        public decimal Lon { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,6)")]
        public decimal Lat { get; set; }

        public string Comment { get; set; }
        public string Name { get; set; }
        [Required]
        public bool Shared { get; set; } = false;

        [Required]
        public virtual User User { get; set; }

        public Location(decimal lon, decimal lat, string comment, string name, bool shared)
        {
            Lon = lon;
            Lat = lat;
            Comment = comment;
            Name = name;
            Shared = shared;
        }

        public Location(decimal lon, decimal lat, string name, bool shared)
        { 
            Lon = lon;
            Lat = lat;
            Name = name;
            Shared = shared;
        }
    }
}
