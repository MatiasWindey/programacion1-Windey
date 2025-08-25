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

        public string fecha { get; set; }

        public string Destino { get; set; }

        public string Placa { get; set; }

        public int Cargatransportada { get; set; }



        
        public Viaje(string Placa, string Destino,int distancia, string Fecha, int Cargatransportada) 
        {
           
            this.Placa = Placa;
            this.Destino = Destino;
            this.Distancia = distancia;
            this.fecha = Fecha;
            this.Cargatransportada = Cargatransportada;
        }




    }
}
