using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntityFramework.Models;
using EntityFramework.Data;

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context db;
        public HomeController(Context db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {

            IQueryable<Car> model = db.Cars; // a to pobierze do pamieci sfiltrowanie dane najpierw sql potem dane Uzwyaj go na bazie dancyh
            var x = model.ToList();
            IEnumerable<Car> model2 = db.Cars.ToList(); // pobierze wszytskie do pamieci
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
