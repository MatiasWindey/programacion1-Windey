using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_viajes
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta(string placa, int kilometros) : base(placa, kilometros)
        {
            this.TipoVehiculo = "Motocicleta";
            this.Placa = placa;
            this.Kilometros = kilometros;
            
           

        }
    }
}
