using System.ComponentModel.DataAnnotations;

namespace MyCityMyPlaces.Models
{
    public class MapViewModel
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        [Required]
        public decimal Lon { get; set; }
        public decimal Lat { get; set; }
        public bool Shared { get; set; }
    }
}
