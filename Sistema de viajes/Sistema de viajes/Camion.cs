using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_viajes
{
    public class Camion : Vehiculo 
    {        
        public int Cargaadicional { get; set; }
       
        public Camion(string placa, int kilometros,int Capacidadcarga, int Cargaadicional) : base(placa, kilometros)
        {     
        
            this.TipoVehiculo = "Camion";
            this.Placa = placa;
            this.Kilometros = kilometros;
            this.Capacidadcarga =  Capacidadcarga;
            this.Cargaadicional = Cargaadicional;
           

        }
    }
}
