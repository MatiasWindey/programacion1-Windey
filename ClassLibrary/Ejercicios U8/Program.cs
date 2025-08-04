using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace Ejercicios_U8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese su nombre");
            string Nombre = Console.ReadLine();
            Console.WriteLine("ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el dni");
            long dni = long.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su estado de animo");
            string animo = Console.ReadLine();
            Console.WriteLine("Ingrese su puesto");
            string puesto = Console.ReadLine();




            Persona persona = new Persona(Nombre, edad, dni, animo);

            Empleado empleado = new Empleado(Nombre, edad, dni, animo, puesto);

            Console.WriteLine(persona.saludar());
            Console.WriteLine(persona.Obteneredad());
            Console.WriteLine(persona.Obtenerdocumento());
            Console.WriteLine(persona.Obteneranimo());
            Console.WriteLine(empleado.Obtenertrabajo());
            Console.ReadKey();


        }
    }
}
