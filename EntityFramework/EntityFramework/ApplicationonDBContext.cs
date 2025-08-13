using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class ApplicationonDBContext : DbContext 
    {
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<CuentaBancaria> CuentasBancarias { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (
                "Server=localhost\\SQLEXPRESS;Database=FinanzasBD;Trusted_Connection=True;TrustServerCertificate=True"
                );
        }

    }
}
