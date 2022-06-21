using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SisBooking.Data;
using SisBooking.Models;
using System.Diagnostics;

namespace SisBooking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return _context.Sedes != null ?
                          View(await _context.Sedes.ToListAsync()) :
                          Problem("Entity set 'DataContext.Sedes'  is null.");
            }
            else
            {
                return RedirectToAction("Index", "Sedes");
            }

            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}