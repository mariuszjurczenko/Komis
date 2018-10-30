using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Komis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Komis.Controllers
{
    public class SamochodController : Controller
    {
        private readonly ISamochodRepository _samochodRepository;

        public SamochodController(ISamochodRepository samochodRepository)
        {
            _samochodRepository = samochodRepository;
        }

        public IActionResult Index()
        {
            return View(_samochodRepository.PobierzWszystkieSamochody());
        }
    }
}
