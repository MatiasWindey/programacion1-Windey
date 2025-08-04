using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Empleado : Persona
    {
        string Puesto {  get; set; }




       public Empleado (string Nombre, int edad, long dni, string animo, string Puesto) : base(Nombre,edad,dni,animo)
        {

            this.Puesto = Puesto;


        }

        public string Obtenertrabajo()
        {

            return "mi puesto es " + this.Puesto;

        }


    }
}
