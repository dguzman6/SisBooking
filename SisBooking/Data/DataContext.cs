using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SisBooking.Models;

namespace SisBooking.Data
{

    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Alojamiento>()
        //        .HasOptional(j => j.JournalEntries)
        //        .WithMany()
        //        .WillCascadeOnDelete(true);
        //}


        public DbSet<Sede> Sedes { get; set; }
        public DbSet<Alojamiento> Alojamientos { get; set; }
        public DbSet<FechaEspecial> FechaEspeciales { get; set; }
        public DbSet<FechasUtilizado> FechasUtilizados { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}

