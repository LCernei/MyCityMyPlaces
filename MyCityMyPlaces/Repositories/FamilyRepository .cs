using MyCityMyPlaces.Data;
using MyCityMyPlaces.Interfaces;
using MyCityMyPlaces.Models;

namespace MyCityMyPlaces.Repositories
{
    public class FamilyRepository : GenericRepository<Family>, IFamilyRepository
    {
        public FamilyRepository(ApplicationDbContext context): base(context)
        { 
        }
    }
}
