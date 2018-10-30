using Komis.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;

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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Samochod samochod)
        {
            if (ModelState.IsValid)
            {
                _samochodRepository.DodajSamochod(samochod);
                return RedirectToAction(nameof(Index));
            }
            return View(samochod);
        }

        public IActionResult Edit(int Id)
        {
            var samochod = _samochodRepository.PobierzSamochodOId(Id);

            if (samochod == null)
                return NotFound();

            return View(samochod);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Samochod samochod) 
        {
            if (ModelState.IsValid)
            {
                _samochodRepository.EdytujSamochod(samochod);
                return RedirectToAction(nameof(Index));
            }
            return View(samochod);
        }

        public IActionResult Delete(int Id)
        {
            var samochod = _samochodRepository.PobierzSamochodOId(Id);

            if (samochod == null)
                return NotFound();

            return View(samochod);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var samochod = _samochodRepository.PobierzSamochodOId(id);
            _samochodRepository.UsunSamochod(samochod);

            return RedirectToAction(nameof(Index));
        }
    }
}
