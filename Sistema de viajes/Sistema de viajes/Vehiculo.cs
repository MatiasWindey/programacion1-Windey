using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_viajes
{
    public abstract class Vehiculo
    {
        public string Placa { get; set; }

        public int Kilometros { get; set; }

        public string TipoVehiculo { get; set; }

        public int Capacidadcarga { get; set; }



        public  Vehiculo(string placa, int kilometros)
        {
            
            this.Placa = placa;
            this.Kilometros = kilometros;
            this.Capacidadcarga = 0;

        }




    }   
}
