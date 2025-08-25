using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_viajes
{
    public class Viaje
    {
        public int Distancia { get; set; }

        public DateTime fecha { get; set; }

        public string Destino { get; set; }

        public string Placa { get; set; }

        public string Cargatransportada { get; set; }



        public Viaje()
        {

        }
        public Viaje(string Placa, string Destino, DateTime Fecha, string Cargatransportada) 
        {
           
            this.Placa = Placa;
            this.Destino = Destino;
            this.fecha = Fecha;
            this.Cargatransportada = Cargatransportada;
        }




    }
}
