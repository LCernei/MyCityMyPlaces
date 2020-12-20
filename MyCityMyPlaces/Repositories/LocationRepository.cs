using System.Collections;
using MyCityMyPlaces.Data;
using MyCityMyPlaces.Interfaces;
using MyCityMyPlaces.Models;
using System.Linq;

namespace MyCityMyPlaces.Repositories
{
    public class LocationRepository : GenericRepository<Location>, ILocationRepository
    {
        public LocationRepository(ApplicationDbContext context): base(context)
        { 
        }

        public Location GetLocation(decimal lon, decimal lat, string email)
        {
            return _context.Locations.FirstOrDefault(l => l.Lon == lon && l.Lat == lat && l.User.Email == email.Trim().ToLower());
        }

        public bool AddLocation(decimal lon, decimal lat, string name, bool shared)
        {
            // User current = _context.Users.FirstOrDefault(u => u.Email == email.Trim().ToLower());
            _context.Locations.Add(new Location(lon, lat, name, shared));
            _context.SaveChanges();
            return true;
        }
        
        public bool AddLocation(decimal lon, decimal lat,string comment, string name, bool shared)
        {
            // User current = _context.Users.FirstOrDefault(u => u.Email == email.Trim().ToLower());
            _context.Locations.Add(new Location(lon, lat, comment, name, shared));
            _context.SaveChanges();
            return true;
        }
        

        public bool RemoveLocation(decimal lon, decimal lat, string email)
        {
            _context.Locations.Remove(GetLocation(lon, lat, email));
            _context.SaveChanges();
            return true;
        }
    }
}
