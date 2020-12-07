using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCityMyPlaces.Models
{
    [Table("User")]
    public class User
    {
        public User()
        {
            Locations=new List<Location>();
        }

        [Key] 
        public int IdUser { get; set; }
        
        public string Name { get; set; }
        [Required]  
        public string Mail { get; set; }
        
        public IList<Location> Locations{ get; set; }
        public IList<Family> Families{ get; set; }
    }
}
