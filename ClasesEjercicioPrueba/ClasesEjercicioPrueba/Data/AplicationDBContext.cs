using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesEjercicioPrueba.Models;
using Microsoft.EntityFrameworkCore;

namespace ClasesEjercicioPrueba.Data
{
    internal class AplicationDBContext : DbContext 
    {

        public DbSet<Vehiculo> vehiculos {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (
                "Server=localhost\\SQLEXPRESS;Database=PruebasPractica;Trusted_Connection=True;TrustServerCertificate=True"
                );
        }

    }
}
