using Sistema_de_viajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            




            bool Consolaactiva = true;

            while (Consolaactiva)
            {

                Console.WriteLine("1.Agregar un vehiculo.\r\n2.Registrar un viaje para un vehiculo.\r\n3.Mostrar informacion del vehiculo\r\n4.Mostrar todos los vehiculos y estadisticas generales.\r\n5.Mostrar todas las patentes y tipos de vehiculos.\r\n\r\n6.Salir");
                if (int.TryParse(Console.ReadLine(), out int Opcionseleccionada))
                {

                    switch (Opcionseleccionada)
                    {

                        case 1:

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

            }
        }
    }
}
