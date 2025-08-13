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
                            foreach (Equipos Equipo in Listaequipos)
                            {

                                Console.WriteLine(Equipo.Nombre);

                            }
                            break;

                        case 3:
                            Console.WriteLine("iniciaremos un partido \r\n Por favor, ingrese los equipos que participaran iniciando por el equipo local");

                        string EquipoIngresado = Console.ReadLine();


                            foreach (Equipos equipo in Listaequipos)
                            {
                                string EquipoL;


                                if (equipo.Nombre == EquipoIngresado)
                                {

                                    EquipoL = equipo.Nombre;

                                }

                            }

                            Console.WriteLine("Ingrese el equipo visitante");

                        Equipos EquipoV = Console.ReadLine();

                            Console.WriteLine("ingrese los goles del local");

                        int GolesL = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese los goles del Visitante");

                        int GolesV = int.Parse(Console.ReadLine());


                        Partidos Partidonuevo = new Partidos(EquipoL, EquipoV, GolesL, GolesV);
            

               

            
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
           


        }

    }





}

