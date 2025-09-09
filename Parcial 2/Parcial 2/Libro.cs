using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    public class Libro
    {
        public int ISBN { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public int prestamoCont = 0;

        public string Disponibilidad { get; set; }





        public Libro(int ISBM, string Titulo, string Autor,string Disponibilidad)
        {
            prestamoCont++;
            this.ISBN = ISBM;
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Disponibilidad = Disponibilidad; 
            

        }
    }
}
