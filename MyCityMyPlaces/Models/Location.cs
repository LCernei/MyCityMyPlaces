using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCityMyPlaces.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,6)")]
        public decimal Long { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,6)")]
        public decimal Lat { get; set; }

        public string Comment { get; set; }
        public string Name { get; set; }
        [Required]
        public bool Shared { get; set; } = false;

        [Required]
        public string UserEmail { get; set; }

        public Location()
        {
            this.Long = 0;
            this.Lat = 0;
            this.Shared = false;
        }
        
        public Location(decimal Long, decimal Lat, bool Shared, string UserEmail)
        {
            this.Long = Long;
            this.Lat = Lat;
            this.Shared = Shared;
            this.UserEmail = UserEmail;
        }
        
        public Location(decimal Long, decimal Lat, string Comment, string Name, bool Shared, string UserEmail)
        {
            this.Long = Long;
            this.Lat = Lat;
            this.Comment = Comment;
            this.Name = Name;
            this.Shared = Shared;
            this.UserEmail = UserEmail;
        }
        
        public Location(decimal Long, decimal Lat, string Name, bool Shared, string UserEmail)
        { 
            this.Long = Long;
            this.Lat = Lat;
            this.Name = Name;
            this.Shared = Shared;
            this.UserEmail = UserEmail;
        }
        
    }
}
