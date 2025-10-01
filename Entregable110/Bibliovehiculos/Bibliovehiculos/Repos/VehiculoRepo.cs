using Bibliovehiculos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliovehiculos.Repos
{
    public class VehiculoRepo
    {

        public Vehiculo AgregarVehiculo(string Marca, string Modelo, int Anio)
        {
            using(var context = new Data1.ApplicationDbContext())
            {


                var vehiculo = new Vehiculo(Marca, Modelo, Anio);
                context.Vehiculos.Add(vehiculo);
                context.SaveChanges();
                
                return vehiculo;


            }





           
        }

    }
}
