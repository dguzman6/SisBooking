using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SisBooking.Data;
using SisBooking.Models;

namespace SisBooking.Controllers
{
    public class SedesController : Controller
    {
        private readonly DataContext _context;

        public SedesController(DataContext context)
        {
            _context = context;
        }

        // GET: Sedes
        public async Task<IActionResult> Index()
        {
              return _context.Sedes != null ? 
                          View(await _context.Sedes.ToListAsync()) :
                          Problem("Entity set 'DataContext.Sedes'  is null.");
        }

        public async Task<IActionResult> Agendar(int? id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null || _context.Alojamientos == null)
                {
                    return NotFound();
                }

                List<Alojamiento> alojamientos = await _context.Alojamientos
                    .Where(m => m.IdSede == id)
                    .ToListAsync();
                return alojamientos == null ? NotFound() : View(alojamientos);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

    }
}
