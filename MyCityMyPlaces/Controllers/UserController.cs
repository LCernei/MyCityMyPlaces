using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCityMyPlaces.Data;
using MyCityMyPlaces.Interfaces;

namespace MyCityMyPlaces.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IFamilyRepository _familyRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly ILogger<FamilyController> _logger;

        public UserController(IUserRepository userRepository,
            IFamilyRepository familyRepository,
            ILocationRepository locationRepository,
            ILogger<FamilyController> logger)
        {
            _userRepository = userRepository;
            _familyRepository = familyRepository;
            _locationRepository = locationRepository;
            _logger = logger;
        }
    }
}
