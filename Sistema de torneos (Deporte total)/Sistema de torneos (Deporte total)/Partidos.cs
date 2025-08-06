using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_torneos__Deporte_total_
{
    public class Partidos
    {

        public int Id { get; set; }

        public Equipos Equipolocal { get; set; }

        public Equipos Equipovisitante { get; set; }

        public int Goleslocal { get; set; }

        public int Golesvisitante {  get; set; }

        public int Contadorid = 0;

        public Partidos(Equipos Equipolocal, Equipos Equipovisitante, int Goleslocal, int Golesvisitante) 
        {

            this.Id = Contadorid++;
            this.Equipolocal = Equipolocal;
            this.Equipovisitante = Equipovisitante;
            this.Goleslocal = Goleslocal;
            this.Golesvisitante = Golesvisitante;

        }


    }
}
