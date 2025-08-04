using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Persona
    {

        public int edad { get; set; }

        public string Nombre { get; set; }

        public long dni { get; set; }

        public string animo { get; set; }

       


        public Persona(string nombre, int edad, long dni, string animo)
        {
            this.edad = edad;
            this.Nombre = nombre;
            this.dni = dni;
            this.animo = animo;
            
        }   



        public string saludar()
        {

            return $"hola soy {Nombre}";

        }

        public string Obteneranimo()
        {

            return $"mi estado de animo es {animo}";
        }


        public string Obteneredad()
        {

            return $"mi edad es {edad}";
        }

        public string Obtenerdocumento()
        {

            return $"mi documento es {dni}";

        }




    }
}
