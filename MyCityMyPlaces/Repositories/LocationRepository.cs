using MyCityMyPlaces.Data;
using MyCityMyPlaces.Interfaces;
using MyCityMyPlaces.Models;

namespace MyCityMyPlaces.Repositories
{
    public class LocationRepository : GenericRepository<Location>, ILocationRepository
    {
        public LocationRepository(ApplicationDbContext context): base(context)
        { 
        }
    }
}
