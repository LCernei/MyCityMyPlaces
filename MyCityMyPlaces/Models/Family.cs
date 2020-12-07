using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCityMyPlaces.Models
{
    [Table("Family")]
    public class Family
    {
        [Key]
        public int IdFamily { get; set; }
        
        [ForeignKey("User")]
        public int IdUser { get; set; }
        [ForeignKey("User")]
        public int IdRelatedMember{ get; set; }
        public User User { get; set; }
        
        
        
        
    }
}
