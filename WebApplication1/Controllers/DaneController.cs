using Microsoft.AspNetCore.Mvc;
using Formularz.Models;

namespace Formularz.Controllers
{
    public class DaneController : Controller
    {
        [HttpPost]
        public IActionResult HandleForm(Dane model)
        {
            if (!ModelState.IsValid)
            {
                return View("Form", model);
            }
            return Content("Dane zostały przetworzone pomyślnie!");
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            else return View();

        }

        public IActionResult Wynik(Dane dane)
        {

            return View(dane);
        }

    }
}