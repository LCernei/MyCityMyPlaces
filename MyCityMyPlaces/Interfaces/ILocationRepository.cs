using System.Collections;
using System.Collections.Generic;
using MyCityMyPlaces.Models;

namespace MyCityMyPlaces.Interfaces
{
    public interface ILocationRepository : IGenericRepository<Location>
    {
        public bool AddLocation(decimal lon, decimal lat, string name, bool shared);
        public bool AddLocation(decimal lon, decimal lat, string comment, string name, bool shared);
        public bool RemoveLocation(decimal lon, decimal lat, string email);
        public Location GetLocation(decimal lon, decimal lat, string email);
    }
}
