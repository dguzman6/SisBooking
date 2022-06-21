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
    public class FechasUtilizadosController : Controller
    {
        private readonly DataContext _context;

        public FechasUtilizadosController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Create(int IdA, DateTime fini, DateTime ffin)
        {
            if (User.Identity.IsAuthenticated)
            {
                for (DateTime i = fini; i <= ffin; i = i.AddDays(1.0))
                {
                    var F = new FechasUtilizado { Fecha = i, IdAlojamiento = IdA };
                    _context.Add(F);
                    _context.SaveChanges();
                }
                return RedirectToAction("Verificado", "Reservas");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            
        }


    }
}
