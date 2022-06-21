using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SisBooking.Data;
using SisBooking.Models;
using System.Data;
using System.Globalization;

namespace SisBooking.Controllers
{
    public class ReservasController : Controller
    {
        private readonly DataContext _context;

        public ReservasController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Verificado()
        {
            return View();
        }

        public async Task<IActionResult> Crear(int? id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null || _context.Alojamientos == null)
                {
                    return NotFound();
                }

                Alojamiento alojamiento = await _context.Alojamientos.FirstOrDefaultAsync(m => m.Id == id);

                return alojamiento == null ? NotFound() : View(alojamiento);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        public async Task<IActionResult> VerificarDispAlojamiento(int? id, DateTime fini, DateTime ffin)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                if (id == null || _context.Alojamientos == null)
                {
                    return NotFound();
                }

                var finicial = fini.ToString("yyyyMMdd");
                var ffinal = ffin.ToString("yyyyMMdd");

                var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@id",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = id
                        },
                        new SqlParameter() {
                            ParameterName = "@fini",
                            SqlDbType =  System.Data.SqlDbType.Date,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = fini
                        },
                        new SqlParameter() {
                            ParameterName = "@ffin",
                            SqlDbType =  System.Data.SqlDbType.Date,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = ffin
                        }};
                //Siempre retorna -1
                var result = await _context.Database.ExecuteSqlRawAsync("sp_AloPorFecha @id, @fini, @ffin", param);

                //Por ahora no valida si hay disponibilidad por que el sql siempre retorna -1 (funciona en la consola sql)
                result=0;
                if (result==0)
                {
                    
                    ViewData["result"] = "Disponible";
                    return RedirectToAction("Create", "FechasUtilizados", new { IdA =  id , fini = fini, ffin = ffin  });
                }
                else
                {
                    ViewData["result"] = "No Disponible";
                    return View("Crear");
                }
                

                
            }
        }

        
        public async Task<IActionResult> Create(int id, DateTime fini, DateTime ffin)
        {
            for (DateTime date = fini; date < ffin; date = date.AddDays(1.0))
            {
                FechasUtilizado nuevaFecha = new();
                nuevaFecha.Fecha = date;
                nuevaFecha.IdAlojamiento = id;
                _context.FechasUtilizados.Add(nuevaFecha);
                await _context.SaveChangesAsync();
            }

            return View("Verificado");
        }

    }
}
