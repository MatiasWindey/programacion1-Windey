using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bibliovehiculos.Modelo;

namespace Bibliovehiculos.Data1
{
    public class ApplicationDbContext : DbContext

    {

        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;Database=GestionVehiculo;Trusted_Connection=True;TrustServerCertificate=True"
                );
        }


    }
}
