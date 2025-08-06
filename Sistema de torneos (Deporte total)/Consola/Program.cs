using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_torneos__Deporte_total_;

namespace Consola
{

    internal class Program
    {


        static void Main(string[] args)
        {
            List<Equipos> Listaequipos = new List<Equipos>();
            List<Partidos> Listapartidos = new List<Partidos>();

            bool Consolaactiva = true;

            while (Consolaactiva)
            {

                Console.WriteLine("1. Registar nuevo equipo\r\n2. Ver equipos\r\n3. Jugar partido\r\n4. Ver tabla de posiciones\r\n5. Ver historial de partidos\r\n6.Salir\r\n");
                if (int.TryParse(Console.ReadLine(), out int Opcionseleccionada))
                {
                    switch(Opcionseleccionada)
                    {

                        case 1:
                            Console.WriteLine("ingrese el nombre del equipo");
                            string Equipoingresado = Console.ReadLine();
                            Console.WriteLine("ingrese el nombre de la ciudad");
                            string Ciudadingresada = Console.ReadLine();

                            Equipos Equiponuevo = new Equipos(Equipoingresado, Ciudadingresada, 0, 0);

                            Listaequipos.Add(Equiponuevo);


                            break;
                            
                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        case 5:
                            break;

                        case 6:
                            Consolaactiva = false;
                            break;



                    }
                   
                }
                else
                {
                    Console.WriteLine("ingrese un caracter valido gil\n");
                }
                




            }
            foreach(Equipos Equipo in Listaequipos)
            {

                Console.WriteLine(Equipo.Nombre);

            }


        }

    }





}

