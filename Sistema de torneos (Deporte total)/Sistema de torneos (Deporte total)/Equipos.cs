using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_torneos__Deporte_total_
{
    public class Equipos
    {
        public int Id { get; set; } 

        public string Nombre { get; set; }

        public string Ciudad { get; set; }

        public int Puntos { get; set; }

        public int Goles { get; set; }

        public List<Partidos> Historialp { get; set; }

        public int Contadorid = 0;


        public Equipos(string Nombre, string Ciudad, int Puntos, int Goles) 
        {
            this.Id = Contadorid++;
            this.Nombre = Nombre;
            this.Ciudad = Ciudad;
            this.Puntos = Puntos;
            this.Goles = Goles;
            this.Historialp = new List<Partidos>();

        }
    }    


}
