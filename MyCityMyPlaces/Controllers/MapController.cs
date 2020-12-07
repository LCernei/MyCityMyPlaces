using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCityMyPlaces.Interfaces;
using MyCityMyPlaces.Models;

namespace MyCityMyPlaces.Controllers
{
    public class MapController : Controller

    {
        private readonly IUserRepository _userRepository;
        private readonly IFamilyRepository _familyRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly ILogger<FamilyController> _logger;

        public MapController(IUserRepository userRepository,
            IFamilyRepository familyRepository,
            ILocationRepository locationRepository,
            ILogger<FamilyController> logger)
        {
            _userRepository = userRepository;
            _familyRepository = familyRepository;
            _locationRepository = locationRepository;
            _logger = logger;
        }

        public IActionResult Map()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
