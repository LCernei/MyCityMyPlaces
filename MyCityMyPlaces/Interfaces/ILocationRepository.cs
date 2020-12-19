using System.Collections;
using System.Collections.Generic;
using MyCityMyPlaces.Models;

namespace MyCityMyPlaces.Interfaces
{
    public interface ILocationRepository : IGenericRepository<Location>
    {
        public bool addLocation(decimal Long, decimal Lat, string Name, bool Shared, string email);
        public bool addLocation(decimal Long, decimal Lat, string Comment, string Name, bool Shared, string email);
        public bool removeLocation(decimal Long, decimal Lat, string email);
        public Location getLocation(decimal Long, decimal Lat, string email);
    }
}
