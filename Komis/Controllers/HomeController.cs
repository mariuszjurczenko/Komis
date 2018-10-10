using Komis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Komis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISamochodRepository _samochodRepository;

        public HomeController(ISamochodRepository samochodRepository)
        {
            _samochodRepository = samochodRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {    
            return View();
        }
    }
}
