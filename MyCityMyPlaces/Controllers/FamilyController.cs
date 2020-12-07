using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCityMyPlaces.Data;
using MyCityMyPlaces.Interfaces;
using MyCityMyPlaces.Models;

namespace MyCityMyPlaces.Controllers

{
    public class FamilyController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IFamilyRepository _familyRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly ILogger<FamilyController> _logger;

        public FamilyController(IUserRepository userRepository,
            IFamilyRepository familyRepository,
            ILocationRepository locationRepository,
            ILogger<FamilyController> logger)
        {
            _userRepository = userRepository;
            _familyRepository = familyRepository;
            _locationRepository = locationRepository;
            _logger = logger;
        }

        public IActionResult AddFamilyMember()
        {
            //Example Insert
            // _userRepository.Add(new User(){IdUser = 1, Mail = "a@a.a", Name = "a"});
            //
            // _userRepository.Add(new User(){IdUser = 2, Mail = "b@b.b", Name = "b"});
            // List<User> asd = _userRepository.GetAll().ToList();
            // _familyRepository.Add(new Family(){IdFamily = 1, IdUser = 1,IdRelatedMember = 2});
            return Ok();
        }

        public IActionResult Family()
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
