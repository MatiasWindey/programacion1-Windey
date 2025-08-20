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

        
    
        public List<Viaje> Listaviajes = new List<Viaje>();


        public Vehiculo(string placa, int kilometros)
        {
            
            this.Placa = placa;
            this.Kilometros = kilometros;
        }


    }   
}
