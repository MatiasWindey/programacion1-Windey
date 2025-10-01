using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesEjercicioPrueba.Data;
using ClasesEjercicioPrueba.Models;

namespace ClasesEjercicioPrueba.Repositories
{
    internal class VehiculoRepository
    {

        public static void GuardatVehiculo(Vehiculo vehiculo)
        {

            using var context = new AplicationDBContext();

            context.vehiculos.Add(vehiculo);


            context.SaveChanges();
        } 


    }
}
