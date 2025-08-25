using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_viajes
{
    public class Furgoneta : Vehiculo
    {       

        public Furgoneta(string placa, int kilometros, int Capacidadcarga) : base(placa, kilometros)
        {
            this.TipoVehiculo = "Furgoneta";
            this.Placa = placa;
            this.Kilometros = kilometros;
            this.Capacidadcarga = Capacidadcarga;

        }
    }
}
