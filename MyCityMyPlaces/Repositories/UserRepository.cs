using MyCityMyPlaces.Data;
using MyCityMyPlaces.Interfaces;
using MyCityMyPlaces.Models;

namespace MyCityMyPlaces.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context): base(context)
        { 
        }
    }
}
