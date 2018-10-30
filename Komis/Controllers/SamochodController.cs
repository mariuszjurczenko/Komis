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

        public IActionResult Details(int id)
        {
            var samochod = _samochodRepository.PobierzSamochodOId(id);
            if (samochod == null)
                return NotFound();

            return View(samochod);
        }
    }
}
