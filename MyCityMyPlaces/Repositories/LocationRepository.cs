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

        public Location getLocation(decimal Long, decimal Lat, string email)
        {
            return _context.Locations.FirstOrDefault(l => l.Long == Long && l.Lat == Lat && l.User.Email == email.Trim().ToLower());
        }

        public bool addLocation(decimal Long, decimal Lat, string Name, bool Shared, string email)
        {
            User current = _context.Users.FirstOrDefault(u => u.Email == email.Trim().ToLower());
            _context.Locations.Add(new Location(Long, Lat, Name, Shared, current));
            _context.SaveChanges();
            return true;
        }
        
        public bool addLocation(decimal Long, decimal Lat,string Comment, string Name, bool Shared, string email)
        {
            User current = _context.Users.FirstOrDefault(u => u.Email == email.Trim().ToLower());
            _context.Locations.Add(new Location(Long, Lat, Comment, Name, Shared, current));
            _context.SaveChanges();
            return true;
        }
        

        public bool removeLocation(decimal Long, decimal Lat, string email)
        {
            User current = _context.Users.FirstOrDefault(u => u.Email == email.Trim().ToLower());
            _context.Locations.Remove(getLocation(Long, Lat, email));
            _context.SaveChanges();
            return true;
        }
    }
}
